using System;
using System.Globalization;
using System.Linq;
using System.Numerics;
using Lunari.Tsuki.Editor.Extenders;
using Lunari.Tsuki.Editor.Windows;
using UnityEditor;
using UnityEditor.IMGUI.Controls;
using UnityEditor.PackageManager.UI;
using UnityEngine;
using Vector2 = UnityEngine.Vector2;
namespace Lunari.Tsuki.Editor {
    public class EditorContentVisualizer : EditorWindow {
        public class IconDropdown : AdvancedDropdown {
            public class IconItem : AdvancedDropdownItem {
                public IconItem(string name) : base(name) { }
                public Texture GetTexture() => EditorGUIUtility.IconContent(name).image;
            }
            private readonly string[] icons;
            public event Action<IconItem> onSelected;
            public IconDropdown(string[] icons) : base(new AdvancedDropdownState()) {
                this.icons = icons;
                this.minimumSize = new Vector2(0, 700);
            }
            protected override AdvancedDropdownItem BuildRoot() {
                var item = new IconItem(string.Empty);
                foreach (var icon in icons) {
                    var child = item.FindOrCreate(icon, s => new IconItem(s));
                    child.name = icon;
                    child.icon = EditorGUIUtility.IconContent(icon).image as Texture2D;
                }
                item.OrderByGroupFirst();
                return item;
            }
            protected override void ItemSelected(AdvancedDropdownItem item) {
                if (item is IconItem icon) {
                    onSelected?.Invoke(icon);
                }
            }
        }
        [MenuItem("Tools/Tsuki/View Editor Built In Content")]
        public static void Preview() {
            CreateWindow<EditorContentVisualizer>().Show();
        }
        private string search;
        private string texture;
        private string text = "The quick brown fox jumps over the lazy dog";
        private Vector2 textureSize;
        private Vector2 scroll;
        private Lazy<DropdownButton> icons;
        private Rect lastRect;
        private int numHorizontalBoxes = 3;
        private void OnEnable() {
            icons = new Lazy<DropdownButton>(() => {
                var icon = new IconDropdown(IconsGenerator.GetAllIcons().ToArray());
                icon.onSelected += item => {
                    texture = item.name;
                    var t = item.GetTexture();
                    textureSize = new Vector2(t.width, t.height);
                };
                return new DropdownButton(icon, new GUIContent("Select Icon"));
            });
        }
        private void OnGUI() {
            search = EditorGUILayout.TextField("Search", search, Styles.SearchTextField);
            text = EditorGUILayout.TextField("Preview Text", text);
            numHorizontalBoxes = EditorGUILayout.IntField("Num Horizontal Boxes", numHorizontalBoxes);
            using (new EditorGUILayout.VerticalScope(Styles.FrameBox)) {
                EditorGUILayout.LabelField("Current Texture:", texture);
                textureSize = EditorGUILayout.Vector2Field("Preview Size", textureSize);
                icons.Value.OnGUI();
                if (!texture.IsNullOrEmpty()) {
                    TsukiGUILayout.Texture(EditorGUIUtility.IconContent(texture).image, textureSize);
                }
            }
            var guiSkins = GUI.skin;
            int index = 0;
            using (var scope = new EditorGUILayout.ScrollViewScope(scroll)) {
                EditorGUILayout.BeginHorizontal();
                foreach (var o in guiSkins) {
                    var style = (GUIStyle)o;
                    var name = style.name;

                    if (!search.IsNullOrEmpty()) {
                        if (!(CultureInfo.CurrentCulture.CompareInfo.IndexOf(name, search, CompareOptions.IgnoreCase) >= 0)) {
                            continue;
                        }
                    }
                    DrawGUIStylePreview(style);
                    if (++index == numHorizontalBoxes) {
                        index = 0;
                        EditorGUILayout.EndHorizontal();
                        EditorGUILayout.BeginHorizontal();
                    }

                }
                scroll = scope.scrollPosition;
                EditorGUILayout.EndHorizontal();
            }
        }
        private void DrawGUIStylePreview(GUIStyle style) {
            using (new EditorGUILayout.VerticalScope(Styles.FrameBox)) {
                using (new EditorGUILayout.HorizontalScope()) {
                    EditorGUILayout.LabelField(style.name, Styles.BoldLabel, GUILayout.ExpandWidth(true));
                    if (GUILayout.Button("Inspect")) {
                        var inspector = CreateWindow<GUIStyleInspector>("Inspect " + style.name + " style.");
                        inspector.SetStyle(style);
                        inspector.ShowTab();
                    }
                }
                GUIContent content;
                if (!texture.IsNullOrEmpty()) {
                    content = new GUIContent(EditorGUIUtility.IconContent(texture)) {
                        text = text
                    };
                } else {
                    content = new GUIContent(text);
                }
                EditorGUILayout.LabelField(content, style);
            }
        }
    }
}