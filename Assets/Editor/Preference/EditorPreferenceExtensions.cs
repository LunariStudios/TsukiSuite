using UnityEngine.UIElements;
namespace Lunari.Tsuki.Editor.Preference {
    public static class EditorPreferenceExtensions {
        public static void Bind<T>(this INotifyValueChanged<T> control, EditorPreference<T> preference) {
            control.value = preference.Value;
            control.RegisterValueChangedCallback(evt => preference.Value = evt.newValue);
        }
    }
}