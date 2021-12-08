using System;
using Lunari.Tsuki.Editor;
using UnityEngine;
namespace Lunari.Tsuki.Entities.Editor {
    public partial class EntityEditor {
        private static readonly Lazy<GUIStyle> TraitCategoryHeaderStyle = new Lazy<GUIStyle>(() => new GUIStyle(Styles.FoldoutHeader) {
            margin = new RectOffset(32, 32, 32, 32)
        });
    }
}