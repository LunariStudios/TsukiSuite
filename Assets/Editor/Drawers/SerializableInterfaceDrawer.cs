using System.Linq;
using Lunari.Tsuki.Editor.Utilities;
using Lunari.Tsuki.Misc;
using UnityEditor;
using UnityEngine;
namespace Lunari.Tsuki.Editor.Drawers {
    [CustomPropertyDrawer(typeof(SerializableInterface<>), true)]
    public class SerializableInterfaceDrawer : PropertyDrawer {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
            var value = property.FindInstanceWithin();
            var interf = (SerializableInterface) value;
            var type = value.GetType();
            var interfaceType = type.BaseType.GetGenericArguments().Single();
            interf.SetObject(EditorGUI.ObjectField(position, label, interf.GetObject(), interfaceType, property.serializedObject.targetObject));
        }
    }
}