using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Lunari.Tsuki.Misc;
using UnityEditor;
using UnityEditor.IMGUI.Controls;
using UnityEngine;

namespace Lunari.Tsuki.Editor.Extenders {
    public class TypeSelectorDropdown<T> : AdvancedDropdown {
        public delegate string PathSelector(Type type);

        public delegate void OnSelectedCallback(Type type);

        private class TypeSelectorItem : AdvancedDropdownItem {
            private readonly Type targetType;

            public TypeSelectorItem(Type targetType, string name) : base(name) {
                this.targetType = targetType;
            }

            public Type GetTargetType() {
                return targetType;
            }
        }

        private readonly PathSelector selector;
        private readonly OnSelectedCallback callback;
        private readonly Predicate<Type> typeFilter;

        public TypeSelectorDropdown(
            OnSelectedCallback callback,
            PathSelector selector = null,
            Predicate<Type> typeFilter = null
        ) : base(new AdvancedDropdownState()) {
            this.callback = callback;
            this.selector = selector ?? SelectPath;
            this.typeFilter = typeFilter;
        }

        protected override void ItemSelected(AdvancedDropdownItem item) {
            if (item is TypeSelectorItem tsItem) {
                callback(tsItem.GetTargetType());
            }
        }

        protected override AdvancedDropdownItem BuildRoot() {
            var root = new AdvancedDropdownItem(string.Empty);
            var all = TypeCache.GetTypesDerivedFrom<T>();
            foreach (var type in all) {
                if (typeFilter != null && typeFilter(type)) {
                    continue;
                }
                var path = selector(type);
                var parent = !path.IsNullOrEmpty() ? root.FindOrCreate(path) : root;
                var item = new TypeSelectorItem(type, type.Name) {
                    icon = type.FindUnityIcon() as Texture2D
                };
                parent.AddChild(item);
            }

            Reorder(root);
            return root;
        }

        private static void Reorder(AdvancedDropdownItem root) {
            if (root.children is List<AdvancedDropdownItem> children) {
                children.Sort(CompareItems);
            }

            foreach (var advancedDropdownItem in root.children) {
                Reorder(advancedDropdownItem);
            }
        }

        private static int CompareItems(AdvancedDropdownItem x, AdvancedDropdownItem y) {
            var isFirstGroup = x.children.IsEmpty();
            var isSecondGroup = y.children.IsEmpty();
            if (isFirstGroup == isSecondGroup) {
                return 0;
            }

            if (isFirstGroup) {
                return 1;
            }

            return -1;
        }

        private static string SelectPath(MemberInfo type) {
            var category = type.GetCustomAttribute<CategoryAttribute>();
            return category?.Category;
        }
    }
}