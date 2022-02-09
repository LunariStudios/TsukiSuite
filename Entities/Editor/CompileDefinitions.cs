using System.Collections.Generic;
using System.Linq;
using UnityEditor;
namespace Lunari.Tsuki.Entities.Editor {
    public static class CompileDefinitions {
        public const string EntitiesCompileDefinition = "TSUKI_ENTITIES";
        [InitializeOnLoadMethod]
        public static void EnsureHasDefinitions() {
            var group = EditorUserBuildSettings.selectedBuildTargetGroup;
            var definesString = PlayerSettings.GetScriptingDefineSymbolsForGroup(group);
            var definitions = new HashSet<string>(definesString.Split(';'));
            if (!definitions.Contains(EntitiesCompileDefinition)) {
                definitions.Add(EntitiesCompileDefinition);
            }
            PlayerSettings.SetScriptingDefineSymbolsForGroup(
                group,
                definitions.ToArray()
            );
        }
    }
}