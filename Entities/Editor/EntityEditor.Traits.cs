using System;
using Lunari.Tsuki.Algorithm;
using Lunari.Tsuki.Editor;
using Lunari.Tsuki.Entities.Problems;
using Lunari.Tsuki.Scopes;
using UnityEditor;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Lunari.Tsuki.Entities.Editor {
    public partial class EntityEditor {
        [Serializable]
        public struct GroupOptions {
            public bool shown;
        }
        [Serializable]
        public struct TraitOptions { }
        private  void DrawSolution(Solution solution) {
            if (solution == null) {
                return;
            }

            if (GUILayout.Button(
                    solution.Description,
                    GUILayout.ExpandHeight(true)
                )) {
                solution.Action();
                ReloadMeta();
            }
        }

        private void DrawTraits() {
            bool BeginTraitGroup(string name, bool shown) {
                EditorGUILayout.BeginVertical(Styles.FrameBox);
                using (new EditorGUILayout.HorizontalScope()) {
                    const float TraitGroupHeaderSize = 20;
                    var rect = GUILayoutUtility.GetRect(
                        0,
                        float.MaxValue, 
                        TraitGroupHeaderSize, 
                        TraitGroupHeaderSize
                    ).AddXMin(14).SubXMax(4);
                    shown = EditorGUI.BeginFoldoutHeaderGroup(rect, shown, name, TraitCategoryHeaderStyle.Value);
                    EditorGUI.EndFoldoutHeaderGroup();
                    //shown = EditorGUILayout.Foldout(shown, TraitCategoryHeaderStyle.Value);
                    //EditorGUILayout.LabelField(name, Styles.BoldLabel);

                }

                return shown;
            }

            void EndTraitGroup() {
                EditorGUILayout.EndVertical();

            }

            var path = string.Empty;

            void OnEnter(string entry, Tree<string, TraitGroup>.Node node) {
                var group = node.Value;
                string groupId;
                if (entry != null) {
                    var suffix = entry + "/";
                    path += suffix;
                    groupId = path;
                } else {
                    groupId = "/";
                }
                var a = GetGroupOptions(groupId);
                var shown = a.shown = BeginTraitGroup(groupId, a.shown);
                groupOptions[groupId] = a;

                if (shown) {
                    foreach (var trait in @group) {
                        if (trait == null) {
                            continue;
                        }
                        DrawTrait(trait);
                    }
                }
            }

            void OnExit(string entry, Tree<string, TraitGroup>.Node node) {
                if (entry == null) { } else {
                    var suffix = entry + '/';
                    path = path.Remove(path.Length - suffix.Length, suffix.Length);
                }

                EndTraitGroup();
            }

            meta.TraitTree.Explore(
                OnEnter,
                OnExit,
                (s, node) => true);
        }
        private GroupOptions GetGroupOptions(string groupId) {
            if (!groupOptions.TryGetValue(groupId, out var found)) {
                found = new GroupOptions();
                groupOptions[groupId] = found;
            }
            return found;
        }

        private void DrawTrait(ITrait trait) {
            var dependencies = trait.PeekDescription(entity, meta.AllTraits);
            if (dependencies == null) {
                return;
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
                if (obj == (Object) trait) {
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
                    Delete((Trait) trait);
                }
            }
        }
    }
}