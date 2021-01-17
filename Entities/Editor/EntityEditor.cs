using System;
using System.Collections.Generic;
using System.Reflection;
using Lunari.Tsuki.Editor;
using Lunari.Tsuki.Editor.Extenders;
using Lunari.Tsuki.Entities.Problems;
using Lunari.Tsuki.Runtime;
using Lunari.Tsuki.Runtime.Scopes;
using UnityEditor;
using UnityEngine;
namespace Lunari.Tsuki.Entities.Editor {
    [CustomEditor(typeof(Entity))]
    public class EntityEditor : UnityEditor.Editor {
        private Entity entity;
        private TypeSelectorButton<Trait> button;
        private static readonly Lazy<GUIStyle> ProblemStyle = new Lazy<GUIStyle>(() => new GUIStyle(Styles.WordWrappedMiniLabel) {
            wordWrap = true,
        });
        private void OnEnable() {
            entity = (Entity)target;
            button = new TypeSelectorButton<Trait>(
                new GUIContent("Add Trait"),
                AddTrait,
                GroupSelector
            );

        }
        private static string GroupSelector(Type arg) {
            var a = CustomAttributeExtensions.GetCustomAttribute<TraitLocationAttribute>(arg);
            return a?.Path;
        }
        public override void OnInspectorGUI() {
            var found = entity.GetComponentsInChildren<Trait>();
            var problems = new List<Problem>();
            using (new EditorGUILayout.VerticalScope(EditorStyles.helpBox)) {
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
                foreach (var trait in found) {
                    trait.TryClaim(entity, found, out var dependencies, false);
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
                                Selection.activeObject = trait;
                            }
                        }
                        if (GUILayout.Button(Icons.treeeditor_trash, GUILayout.Height(22), GUILayout.Width(22))) {
                            Delete(trait);
                        }
                    }
                    problems.AddRange(dependencies.Problems);
                }
            }
            if (problems.IsEmpty()) {
                return;
            }
            using (new EditorGUILayout.VerticalScope(EditorStyles.helpBox)) {
                EditorGUILayout.LabelField("Problems: ", EditorStyles.boldLabel);
                foreach (var problem in problems) {
                    using (new EditorGUILayout.HorizontalScope(EditorStyles.helpBox)) {
                        GUILayout.Label(new GUIContent(problem.Description, Icons.console_erroricon), ProblemStyle.Value);
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
        private void Delete(Trait trait) {
            var go = trait.gameObject;
            DestroyImmediate(trait);
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
            toAddOn.gameObject.AddComponent(trait);
        }
    }
}