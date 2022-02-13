using UnityEditor;
using UnityEngine;
namespace Lunari.Tsuki.Editor.Preference {
    public abstract class EditorPreference<T> {
        private readonly string key;
        private readonly T defaultValue;
        private bool loaded = false;
        private T cached;
        protected EditorPreference(string key, T defaultValue) {
            this.key = key;
            this.defaultValue = defaultValue;
        }
        protected abstract void Write(string key, T value);
        protected abstract T Read(string key);
        public abstract void DrawField(GUIContent label);
        public void DrawField(string label) {
            DrawField(EditorGUIUtility.TrTempContent(label));
        }

        public T Value {
            get {
                if (!loaded) {
                    loaded = true;
                    cached = EditorPrefs.HasKey(key) ? Read(key) : defaultValue;
                }
                return cached;
            }
            set {
                Write(key, value);
                loaded = false;
            }
        }
    }
    public class FloatEditorPreference : EditorPreference<float> {

        protected override void Write(string key, float value) {
            EditorPrefs.SetFloat(key, value);
        }
        protected override float Read(string key) {
            return EditorPrefs.GetFloat(key);
        }
        public FloatEditorPreference(string key, float defaultValue) : base(key, defaultValue) { }
        public override void DrawField(GUIContent label) {
            Value = EditorGUILayout.FloatField(label, Value);
        }
    }
    public class BoolEditorPreference : EditorPreference<bool> {
        public BoolEditorPreference(string key, bool defaultValue) : base(key, defaultValue) {
        }
        protected override void Write(string key, bool value) {
            EditorPrefs.SetBool(key, value);
        }
        protected override bool Read(string key) {
            return EditorPrefs.GetBool(key);
        }
        public override void DrawField(GUIContent label) {
            Value = EditorGUILayout.Toggle(label, Value);
        }
    }
}