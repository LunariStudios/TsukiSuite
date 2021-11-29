using System;
using System.Collections.Generic;
using System.Reflection;
using Lunari.Tsuki.Algorithm;
using Lunari.Tsuki.Editor;
using Lunari.Tsuki.Editor.Extenders;
using Lunari.Tsuki.Entities.Problems;
using UnityEditor;
using UnityEngine;

namespace Lunari.Tsuki.Entities.Editor {
    [CustomEditor(typeof(Entity))]
    public partial class EntityEditor : UnityEditor.Editor {
        private static readonly Lazy<GUIStyle> ProblemStyle = new Lazy<GUIStyle>(
            () => new GUIStyle(Styles.WordWrappedMiniLabel) {
                wordWrap = true,
            }
        );
        private Entity entity;
        private EntityMeta meta;
        private TypeSelectorButton<Trait> addTraitButton;
        private Dictionary<string, TraitOptions> traitOptions;
        private Dictionary<string, GroupOptions> groupOptions;

        private void OnEnable() {
            entity = (Entity) target;
            ReloadMeta();
            traitOptions = new Dictionary<string, TraitOptions>();
            groupOptions = new Dictionary<string, GroupOptions>();
            addTraitButton = new TypeSelectorButton<Trait>(
                new GUIContent("Add Trait"),
                AddTrait,
                TraitExtensions.FindTraitLocation,
                type => entity.GetComponentInChildren(type) != null && !type.IsAbstract
            );
        }
        private void ReloadMeta() {
            meta = new EntityMeta(entity);
        }

        public override void OnInspectorGUI() {
            var found = entity.GetComponentsInChildren<Trait>();
            var problems = new List<Problem>();
            using (new EditorGUILayout.VerticalScope()) {
                using (new EditorGUILayout.HorizontalScope()) {
                    EditorGUILayout.LabelField($"Traits ({found.Length})", EditorStyles.boldLabel);
                    addTraitButton.OnInspectorGUI();
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

            var gameObject = toAddOn.gameObject;
            gameObject.AddComponent(trait);
            EditorUtility.SetDirty(gameObject);
        }
    }
}