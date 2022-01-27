using Lunari.Tsuki.Editor;
using Lunari.Tsuki.Scopes;
using UnityEditor;
using UnityEngine;
namespace Lunari.Tsuki.Entities.Editor {
    [CustomEditor(typeof(Trait), true)]
    public class TraitEditor : UnityEditor.Editor {
        public override void OnInspectorGUI() {
            using (new EditorGUILayout.VerticalScope(Styles.box)) {
                if (target is Trait trait) {
                    var entity = trait.GetComponentInParent<Entity>();
                    if (entity == null) {
                        EditorGUILayout.HelpBox("This trait is not owned by any entity.", MessageType.Warning);
                    } else {
                        using (new GUIEnabledScope(false)) {
                            using (new EditorGUILayout.HorizontalScope()) {
                                EditorGUILayout.ObjectField("Entity", entity, typeof(Entity), true);
                                if (!TraitEditorUtils.IsCurrentlySelected(entity)) {
                                    using (new GUIEnabledScope(true)) {
                                        if (GUILayout.Button("Select")) {
                                            Selection.activeObject = entity;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            base.OnInspectorGUI();
        }
    }
}