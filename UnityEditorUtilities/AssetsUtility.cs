using UnityEditor;
using UnityEngine;

namespace UnityUtilities.Editor {
    public static class AssetsUtility {
        public static void AddToAssetFile<T>(this ScriptableObject obj, bool save = true) where T : ScriptableObject {
            var o = ScriptableObject.CreateInstance<T>();
            AssetDatabase.AddObjectToAsset(o, obj);
            if (save) {
                AssetDatabase.SaveAssets();
            }
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