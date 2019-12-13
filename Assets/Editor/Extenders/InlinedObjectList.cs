using System.Collections.Generic;
using Lunari.Tsuki.Runtime;
using Lunari.Tsuki.Runtime.Scopes;
using UnityEditor;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Lunari.Tsuki.Editor.Extenders {

    public class InlinedObjectList<T> where T : ScriptableObject {
        private static readonly Color DeleteColor = new Color(0.8f, 0.24f, 0.24f);
        private readonly List<UnityEditor.Editor> subEditors = new List<UnityEditor.Editor>();
        private readonly List<T> objects;

        public static readonly GUIContent NameContent = new GUIContent(
            "Name",
            "The name of this " + typeof(T).GetLegibleName());

        public InlinedObjectList(List<T> objects) {
            this.objects = objects;
            ReloadEditors();
        }

        private static void Swap(IList<T> list, int indexA, int indexB) {
            var tmp = list[indexA];
            list[indexA] = list[indexB];
            list[indexB] = tmp;
        }

        public void OnInspectorGUI() {
            var toRemove = new HashSet<int>();
            bool shouldReloadEditors = false;
            for (var i = 0; i < subEditors.Count; i++) {
                var editor = subEditors[i];
                var token = objects[i];
                using (new EditorGUILayout.HorizontalScope(GUIStyles.box)) {
                    using (new EditorGUILayout.VerticalScope(TsukiStyles.NoMargin)) {
                        var buttonProperties = new[] {
                            GUILayout.MaxWidth(50)
                        };
                        if (i > 0 && GUILayout.Button("Up", buttonProperties)) {
                            Swap(objects, i, i - 1);
                            shouldReloadEditors = true;
                        }

                        using (new GUIColorScope(DeleteColor)) {
                            if (GUILayout.Button("Delete", buttonProperties)) {
                                if (token != null && !EditorUtility.DisplayDialog(
                                        "You are about to delete " + token.name,
                                        "Are you sure about this?",
                                        "Yep", "Nope"
                                    )) {
                                    continue;
                                }

                                toRemove.Add(i);
                                Object.DestroyImmediate(token, true);
                                shouldReloadEditors = true;
                            }
                        }

                        if (i < subEditors.Count - 1 && GUILayout.Button("Down", buttonProperties)) {
                            shouldReloadEditors = true;
                            Swap(objects, i, i + 1);
                        }
                    }

                    using (new EditorGUILayout.VerticalScope()) {
                        if (token == null) {
                            EditorGUILayout.LabelField("Null object, please delete");
                        } else {
                            using (new EditorGUILayout.HorizontalScope()) {
                                EditorGUILayout.LabelField($"#{i} - {token.name}",
                                    EditorStyles.boldLabel);
                                var hidden = (token.hideFlags & HideFlags.HideInHierarchy) == HideFlags.HideInHierarchy;
                                var img = GUIIcons.GetIcon(hidden
                                    ? GUIIcons.animationvisibilitytoggleoff
                                    : GUIIcons.animationvisibilitytoggleon);
                                if (GUILayout.Button(img, GUIStyle.none,
                                    GUILayout.Width(EditorGUIUtility.singleLineHeight))) {
                                    token.hideFlags ^= HideFlags.HideInHierarchy;
                                    AssetDatabase.SaveAssets();
                                }
                            }

                            token.name = EditorGUILayout.TextField(NameContent, token.name);
                            editor.OnInspectorGUI();
                        }
                    }
                }
            }

            foreach (var i in toRemove) {
                objects.RemoveAt(i);
            }

            if (shouldReloadEditors) {
                ReloadEditors();
            }
        }

        private void ReloadEditors() {
            foreach (var subEditor in subEditors) {
                Object.Destroy(subEditor);
            }
            subEditors.Clear();
            foreach (var o in objects) {
                subEditors.Add(UnityEditor.Editor.CreateEditor(o));
            }
        }
    }
}