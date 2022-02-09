using System.Collections;
using System.Reflection;
using UnityEditor;
using UnityEngine;

namespace Lunari.Tsuki.Editor.Utilities {
    public static class Serialization {
        /// <summary>
        /// Finds the instance of the serialized property inside the object that the <see cref="property"/> exists in.
        /// </summary>
        /// <param name="property">The property to find an instance for</param>
        /// <typeparam name="T">The type of the instance</typeparam>
        /// <returns>The found instance or null if it can't be cast to <see cref="T"/></returns>
        public static T FindInstanceWithin<T>(this SerializedProperty property) where T : class {
            return property.FindInstanceAt<T>(property.serializedObject.targetObject);
        }
        /// <summary>
        /// Finds the instance of the serialized property inside the object that the <see cref="property"/> exists in.
        /// </summary>
        /// <param name="property">The property to find an instance for</param>
        /// <typeparam name="T">The type of the instance</typeparam>
        /// <returns>The found instance or null if it can't be cast to <see cref="T"/></returns>
        public static object FindInstanceWithin(this SerializedProperty property) {
            return property.FindInstanceAt(property.serializedObject.targetObject);
        }

        /// <summary>
        /// Finds the instance of the serialized property inside the given object
        /// </summary>
        /// <param name="property">The property to find an instance for</param>
        /// <param name="obj">The object on which to search for the instance</param>
        /// <typeparam name="T">The type of the instance</typeparam>
        /// <returns>The found instance or null if it can't be cast to <see cref="T"/></returns>
        public static T FindInstanceAt<T>(this SerializedProperty property, Object obj) where T : class {
            return property.FindInstanceAt(obj) as T;
        }

        private static object ExtractFromField(string fieldName, object owner) {
            var field = owner.GetType().GetField(fieldName,
                BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
            return field == null ? null : field.GetValue(owner);
        }

        /// <summary>
        /// Finds the instance of the serialized property inside the given object
        /// </summary>
        /// <param name="property">The property to find an instance for</param>
        /// <param name="obj">The object on which to search for the instance</param>
        /// <returns>The found instance or null if it can't be found</returns>
        public static object FindInstanceAt(this SerializedProperty property, Object obj) {
            var path = property.propertyPath;
            var nodes = path.Split('.');
            var firstProperty = nodes[0];
            var current = ExtractFromField(firstProperty, obj);
            var child = property.serializedObject.FindProperty(firstProperty);
            for (var i = 1; i < nodes.Length; i++) {
                var fieldName = nodes[i];
                if (fieldName.Equals("Array")) {
                    continue;
                }

                object found;

                if (fieldName.StartsWith("data")) {
                    var indexS = fieldName.Replace("data[", string.Empty).Replace("]", string.Empty);
                    var index = int.Parse(indexS);
                    var list = (IList) current;
                    found = list[index];
                } else {
                    child = child.FindPropertyRelative(fieldName);
                    found = ExtractFromField(fieldName, current);
                }

                current = found;
            }

            return current;
        }
    }
}