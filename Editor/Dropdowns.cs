using System;
using System.Collections.Generic;
using System.Linq;
using Lunari.Tsuki.Runtime;
using UnityEditor.IMGUI.Controls;
namespace Lunari.Tsuki.Editor {
    public static class Dropdowns {
        public static AdvancedDropdownItem FindOrCreate(this AdvancedDropdownItem root, string path) {
            return FindOrCreate(root, path, n => new AdvancedDropdownItem(n));
        }
        public static T FindOrCreate<T>(this T root, string path, Func<string, T> creator) where T : AdvancedDropdownItem {
            var current = root;
            var toGet = new Stack<string>();
            foreach (var s in path.Split('/').Reverse()) {
                toGet.Push(s);
            }
            do {
                var next = toGet.Pop();
                var candidate = (T)current.children.FirstOrDefault(item => item.name == next);
                if (candidate == null) {
                    var newItem = creator(next);
                    current.AddChild(newItem);
                    current = newItem;
                } else {
                    current = candidate;
                }
            } while (!toGet.IsEmpty());
            return current;
        }
        public static void OrderByGroupFirst(this AdvancedDropdownItem root) {
            if (root.children is List<AdvancedDropdownItem> children) {
                children.Sort(CompareItems);
            }
            foreach (var advancedDropdownItem in root.children) {
                advancedDropdownItem.OrderByGroupFirst();
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

    }
}