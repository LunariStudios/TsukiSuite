using System;
using System.Collections.Generic;
using System.Reflection;
using Lunari.Tsuki.Algorithm;
using Lunari.Tsuki.Editor;
using Lunari.Tsuki.Editor.Extenders;
using Lunari.Tsuki.Entities.Problems;
using UnityEditor;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Lunari.Tsuki.Entities.Editor {
    [CustomEditor(typeof(Entity))]
    public partial class EntityEditor : UnityEditor.Editor {

        private Entity entity;

        private static readonly Lazy<GUIStyle> ProblemStyle = new Lazy<GUIStyle>(() =>
            new GUIStyle(Styles.WordWrappedMiniLabel) {
                wordWrap = true,
            }
        );
        private EntityMeta meta;
        private TypeSelectorButton<ITrait> addTraitButton;
        private Dictionary<string, TraitOptions> traitOptions;
        private Dictionary<string, GroupOptions> groupOptions;
        private void OnDestroy() { }
        private void OnEnable() {
            entity = (Entity) target;
            if (!EditorApplication.isPlaying) {
                ReloadMeta();
            }
            traitOptions = new Dictionary<string, TraitOptions>();
            groupOptions = new Dictionary<string, GroupOptions>();
            addTraitButton = new TypeSelectorButton<ITrait>(
                new GUIContent("Add Trait"),
                AddTrait,
                TraitExtensions.FindTraitLocation,
                type => entity.GetComponentInChildren(type) != null && !type.IsAbstract
            );
            addTraitButton.RectCalculated += (ref Rect rect) =>
            {
                rect.xMin -= rect.width / 2;
            };
        }
        private void ReloadMeta() {
            var oldMeta = meta;
            meta = new EntityMeta(entity);

        }
        private void OnValidate() {
            ReloadMeta();
        }
        public override void OnInspectorGUI() {
            var found = entity.GetComponentsInChildren<ITrait>();
            var problems = new List<Problem>();
            using (new EditorGUILayout.VerticalScope()) {
                using (new EditorGUILayout.HorizontalScope()) {
                    EditorGUILayout.LabelField($"Traits ({found.Length})", EditorStyles.boldLabel);
                    addTraitButton?.OnInspectorGUI();
                    if (GUILayout.Button("Refresh")) {
                        ReloadMeta();
                    }
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

                DrawTraits();
            }
            problems = new List<Problem>();
            var allTraits = meta.AllTraits;
            foreach (var trait in allTraits) {
                problems.AddRange(trait.PeekDescription(entity, allTraits).Problems);
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
                        var solutions = problem.Solutions;
                        using (new EditorGUILayout.VerticalScope()) {
                            foreach (var solution in solutions) {
                                DrawSolution(solution);
                            }
                        }
                    }

                }
            }
        }


        private bool IsTraitCategoryVisible(string category) {
            if (category.IsNullOrEmpty()) {
                return true;
            }

            return groupOptions.TryGetValue(category, out var options) && options.shown;
        }

        private void Delete(Trait trait) {
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
            ReloadMeta();
            EditorUtility.SetDirty(gameObject);
        }
    }
}