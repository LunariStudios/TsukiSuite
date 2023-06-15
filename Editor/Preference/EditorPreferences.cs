using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;
namespace Lunari.Tsuki.Editor.Preference {
    public abstract class EditorPreference<T> {
        private readonly string _key;
        private readonly T _defaultValue;
        private bool _loaded = false;
        private T _cached;
        public UnityEvent Changed { get; } = new UnityEvent();
        protected EditorPreference(string key, T defaultValue) {
            _key = key;
            _defaultValue = defaultValue;
        }
        protected abstract void Write(string key, T value);
        protected abstract T Read(string key);
        public abstract void DrawField(GUIContent label);
        public void DrawField(string label) {
            DrawField(EditorGUIUtility.TrTempContent(label));
        }

        public T Value {
            get {
                if (!_loaded) {
                    _loaded = true;
                    _cached = EditorPrefs.HasKey(_key) ? Read(_key) : _defaultValue;
                }
                return _cached;
            }
            set {
                Write(_key, value);
                _loaded = false;
                Changed.Invoke();
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
        public BoolEditorPreference(string key, bool defaultValue) : base(key, defaultValue) { }
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
    public class IntEditorPreference : EditorPreference<int> {
        public IntEditorPreference(string key, int defaultValue) : base(key, defaultValue) { }
        protected override void Write(string key, int value) {
            EditorPrefs.SetInt(key, value);
        }
        protected override int Read(string key) {
            return EditorPrefs.GetInt(key);
        }
        public override void DrawField(GUIContent label) {
            Value = EditorGUILayout.IntField(label, Value);
        }
    }
    public class StringEditorPreference : EditorPreference<string> {
        public StringEditorPreference(string key, string defaultValue) : base(key, defaultValue) { }
        protected override void Write(string key, string value) {
            EditorPrefs.SetString(key, value);
        }
        protected override string Read(string key) {
            return EditorPrefs.GetString(key);
        }
        public override void DrawField(GUIContent label) {
            Value = EditorGUILayout.TextField(label, Value);
        }
    }
    public class EnumEditorPreference<T> : EditorPreference<T> where T : struct, Enum {

        public EnumEditorPreference(string key, T defaultValue) : base(key, defaultValue) { }
        protected override void Write(string key, T value) {
            EditorPrefs.SetString(key, Enum.Format(typeof(T), value, "G"));
        }
        protected override T Read(string key) {
            return Enum.TryParse(EditorPrefs.GetString(key), out T value) ? value : default;
        }
        public override void DrawField(GUIContent label) {
            Value = (T) EditorGUILayout.EnumPopup(label, Value);
        }
    }
}