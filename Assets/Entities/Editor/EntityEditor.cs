using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Lunari.Tsuki.Editor;
using Lunari.Tsuki.Editor.Extenders;
using Lunari.Tsuki.Entities.Problems;
using Lunari.Tsuki.Runtime;
using Lunari.Tsuki.Runtime.Algorithm;
using Lunari.Tsuki.Runtime.Scopes;
using UnityEditor;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Lunari.Tsuki.Entities.Editor {
    [CustomEditor(typeof(Entity))]
    public class EntityEditor : UnityEditor.Editor {
        private Entity entity;
        private TypeSelectorButton<ITrait> button;

        private static readonly Lazy<GUIStyle> ProblemStyle = new Lazy<GUIStyle>(() =>
            new GUIStyle(Styles.WordWrappedMiniLabel) {
                wordWrap = true,
            });

        private void OnEnable() {
            entity = (Entity) target;
            button = new TypeSelectorButton<ITrait>(
                new GUIContent("Add ITrait"),
                AddTrait,
                TraitExtensions.FindTraitLocation,
                type => entity.GetComponentInChildren(type) != null
            );
        }

        public override void OnInspectorGUI() {
            var found = entity.GetComponentsInChildren<ITrait>();
            var problems = new List<Problem>();
            using (new EditorGUILayout.VerticalScope()) {
                using (new EditorGUILayout.HorizontalScope()) {
                    EditorGUILayout.LabelField($"Traits ({found.Length})", EditorStyles.boldLabel);
                    button.OnInspectorGUI();
                }

                EditorGUILayout.Space();
                if (EditorApplication.isPlaying) {
                    GUILayout.Label(
                        new GUIContent {
                            image = Icons.console_infoicon,
                            text = "Please exit play mode to inspect entity"
                        },
                        Styles.CenteredLabel
                    );
                    return;
                }

                DrawTraitTree(found, problems);
            }

            if (problems.IsEmpty()) {
                return;
            }

            using (new EditorGUILayout.VerticalScope(EditorStyles.helpBox)) {
                EditorGUILayout.LabelField("Problems: ", EditorStyles.boldLabel);
                foreach (var problem in problems) {
                    using (new EditorGUILayout.HorizontalScope(EditorStyles.helpBox)) {
                        GUILayout.Label(new GUIContent(problem.Description, Icons.console_erroricon),
                            ProblemStyle.Value);
                        var solution = problem.Solution;
                        if (solution == null) {
                            continue;
                        }

                        if (GUILayout.Button(
                            solution.Description,
                            GUILayout.ExpandHeight(true)
                        )) {
                            solution.Action();
                        }
                    }
                }
            }
        }

        private Dictionary<string, bool> traitGroupVisibility = new Dictionary<string, bool>();

        private Dictionary<string, bool> shouldClose = new Dictionary<string, bool>();

        private bool IsTraitCategoryVisible(string category) {
            if (category.IsNullOrEmpty()) {
                return true;
            }

            return traitGroupVisibility.TryGetValue(category, out var shown) && shown;
        }

        private void DrawTraitTree(ITrait[] all, List<Problem> problems) {
            var tree = TraitEditorUtils.CalcTraitTreeOf(all);
            var stack = string.Empty;
            tree.Explore(delegate(string entry, Tree<string, List<ITrait>>.Node node) {
                    shouldClose[stack] = false;
                    foreach (var trait in node.Value) {
                        trait.TryClaim(entity, all, out var a, false);
                        problems.AddRange(a.Problems);
                    }

                    if (entry == null) {
                        Draw(node.Value, all);
                        return;
                    }

                    var parentVisible = IsTraitCategoryVisible(stack);
                    stack += entry + '/';
                    var shown = parentVisible && IsTraitCategoryVisible(stack);
                    if (parentVisible) {
                        shown = traitGroupVisibility[stack] = BeginTraitGroup(shown, stack);
                    }

                    if (shown) {
                        Draw(node.Value, all);
                    }
                },
                delegate(string entry, Tree<string, List<ITrait>>.Node node) {
                    if (entry == null) {
                        return;
                    }

                    var shownSelf = IsTraitCategoryVisible(stack);
                    var suffix = entry + '/';
                    stack = stack.Remove(stack.Length - suffix.Length, suffix.Length);
                    var parentVisible = IsTraitCategoryVisible(stack);

                    if (parentVisible) {
                        EndTraitGroup();
                    }
                });
        }

        void Draw(
            IEnumerable<ITrait> children,
            ITrait[] all
        ) {
            foreach (var trait in children) {
                trait.TryClaim(entity, all, out var dependencies, false);
                if (dependencies == null) {
                    continue;
                }

                using (new EditorGUILayout.HorizontalScope(Styles.box)) {
                    var content = new GUIContent(trait.GetType().Name);
                    if (!dependencies.Problems.IsEmpty()) {
                        TsukiGUILayout.Icon(Icons.console_erroricon, 16);
                    }

                    EditorGUILayout.PrefixLabel(content);
                    EditorGUILayout.Space(0, true);
                    var obj = Selection.activeObject;
                    var editable = true;
                    if (obj == trait) {
                        editable = false;
                    } else if (obj is GameObject go && go == trait.gameObject) {
                        editable = false;
                    }

                    using (new GUIEnabledScope(editable)) {
                        if (GUILayout.Button("Select", GUILayout.Height(22), GUILayout.Width(32F * 4))) {
                            Selection.activeObject = (Object) trait;
                        }
                    }

                    if (GUILayout.Button(Icons.treeeditor_trash, GUILayout.Height(22), GUILayout.Width(22))) {
                        Delete(trait);
                    }
                }
            }
        }

        private bool BeginTraitGroup(bool shown, string stack) {
            EditorGUILayout.BeginVertical(Styles.FrameBox);
            using (new EditorGUILayout.HorizontalScope()) {
                shown = EditorGUILayout.Toggle(shown, Styles.Foldout, GUILayout.Width(16F));
                EditorGUILayout.LabelField(stack, Styles.BoldLabel);
            }

            return shown;
        }

        private void EndTraitGroup() {
            EditorGUILayout.EndVertical();
        }

        private void Delete(ITrait trait) {
            var go = trait.gameObject;
            DestroyImmediate((Object) trait);
            if (go != entity.gameObject && go.transform.childCount == 0) {
                DestroyImmediate(go);
            }
        }

        private void AddTrait(Type trait) {
            var path = new Queue<string>();

            var loc = CustomAttributeExtensions.GetCustomAttribute<TraitLocationAttribute>(trait);
            if (loc != null) {
                foreach (var s in loc.Path.Split('/')) {
                    path.Enqueue(s);
                }
            }

            var toAddOn = entity.gameObject.transform;
            foreach (var s in path) {
                var found = toAddOn.transform.Find(s);
                if (found == null) {
                    found = new GameObject(s).transform;
                    found.SetParent(toAddOn);
                }

                toAddOn = found;
            }

            var gameObject = toAddOn.gameObject;
            gameObject.AddComponent(trait);
            EditorUtility.SetDirty(gameObject);
        }
    }
}