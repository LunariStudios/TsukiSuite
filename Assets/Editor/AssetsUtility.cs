#if UNITY_EDITOR
using System;
using UnityEditor;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Lunari.Tsuki.Editor {
    public static class AssetsUtility {
        public static T AddToAssetFile<T>(this ScriptableObject obj, bool setDirty = true, bool save = true)
            where T : ScriptableObject {
            return (T) obj.AddToAssetFile(typeof(T), setDirty, save);
        }

        public static Object AddToAssetFile(this ScriptableObject obj, Type type, bool setDirty = true,
            bool save = true) {
            var o = ScriptableObject.CreateInstance(type);
            AssetDatabase.AddObjectToAsset(o, obj);
            if (setDirty) {
                EditorUtility.SetDirty(obj);
            }

            if (save) {
                AssetDatabase.SaveAssets();
            }

            return o;
        }

        public static void CreateAsset(string path, Object asset) {
            var assetPathAndName = AssetDatabase.GenerateUniqueAssetPath(path + "/New Cutscene.asset");
            AssetDatabase.CreateAsset(asset, assetPathAndName);
            AssetDatabase.SaveAssets();
            EditorUtility.FocusProjectWindow();
            Selection.activeObject = asset;
        }

        public static T CreateAsset<T>(string path) where T : ScriptableObject {
            var obj = ScriptableObject.CreateInstance<T>();
            CreateAsset(path, obj);
            return obj;
        }
    }
}
#endif