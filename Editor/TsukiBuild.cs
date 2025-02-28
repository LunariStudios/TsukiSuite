using System;
using System.IO;
using JetBrains.Annotations;
using Lunari.Tsuki.Logging;
using UnityEditor;
using UnityEditor.Build.Reporting;
using UnityEngine;

namespace Lunari.Tsuki.Editor {
    public static class TsukiBuild {
        private const string ScriptingBackendParameter = "-scriptingBackend";
        private const string BuildPathParameter = "-build";
        private const string BuildOptionsParameter = "-buildOptions";
        private const string BuildTargetParameter = "-buildTarget";
        private const string TargetGroupParameter = "-targetGroup";
        private const string ScenesPathParameter = "-scenesPath";

        [UsedImplicitly]
        public static void PerformTsukiBuild() {
            var logger = new UnityLogger("TsukiBuild");

            // Scripting Backend override (defaults to mono)
            var backend = GetCliParam(ScriptingBackendParameter);
            ScriptingImplementation implementation = backend switch {
                "mono" => ScriptingImplementation.Mono2x,
                "il2cpp" => ScriptingImplementation.IL2CPP,
                "dotnet" => ScriptingImplementation.WinRTDotNET,
                _ => ScriptingImplementation.Mono2x
            };
            logger.Log($"Using scripting backend: {backend ?? "default (mono)"}");

            // Build path must be specified via CLI.
            var buildPath = GetCliParam(BuildPathParameter);
            if (string.IsNullOrEmpty(buildPath)) {
                logger.LogError("Build path not specified. Use -build to specify the build output path.");
                return;
            }
            logger.Log($"Build output path: {buildPath}");

            // Build Options override (comma-separated list, e.g. "Development,AutoRunPlayer")
            BuildOptions buildOptions = BuildOptions.None;
            var buildOptionsParam = GetCliParam(BuildOptionsParameter);
            if (!string.IsNullOrEmpty(buildOptionsParam)) {
                var optionsArray = buildOptionsParam.Split(',');
                foreach (var option in optionsArray) {
                    if (Enum.TryParse(option.Trim(), true, out BuildOptions optionParsed)) {
                        buildOptions |= optionParsed;
                    } else {
                        logger.LogWarning($"Unknown BuildOption: {option}");
                    }
                }
            } else {
                // Default build options if not specified.
                buildOptions = BuildOptions.StrictMode | BuildOptions.BuildScriptsOnly;
            }
            logger.Log($"Build options: {buildOptions}");

            // Build Target override (e.g. "StandaloneWindows64")
            BuildTarget buildTarget = EditorUserBuildSettings.activeBuildTarget;
            var buildTargetParam = GetCliParam(BuildTargetParameter);
            if (!string.IsNullOrEmpty(buildTargetParam)) {
                if (!Enum.TryParse(buildTargetParam, true, out buildTarget)) {
                    logger.LogWarning($"Unknown BuildTarget: {buildTargetParam}, defaulting to {EditorUserBuildSettings.activeBuildTarget}");
                    buildTarget = EditorUserBuildSettings.activeBuildTarget;
                }
            }
            logger.Log($"Build target: {buildTarget}");

            // Target Group override (e.g. "Standalone")
            BuildTargetGroup targetGroup = EditorUserBuildSettings.selectedBuildTargetGroup;
            var targetGroupParam = GetCliParam(TargetGroupParameter);
            if (!string.IsNullOrEmpty(targetGroupParam)) {
                if (!Enum.TryParse(targetGroupParam, true, out targetGroup)) {
                    logger.LogWarning($"Unknown TargetGroup: {targetGroupParam}, defaulting to {EditorUserBuildSettings.selectedBuildTargetGroup}");
                    targetGroup = EditorUserBuildSettings.selectedBuildTargetGroup;
                }
            }
            logger.Log($"Target group: {targetGroup}");

            // Apply the selected scripting backend
            PlayerSettings.SetScriptingBackend(targetGroup, implementation);

            // Scenes directory override: defaults to the "Samples" folder inside Assets.
            string scenesDirectory = GetCliParam(ScenesPathParameter);
            if (string.IsNullOrEmpty(scenesDirectory)) {
                scenesDirectory = Path.Combine(Application.dataPath, "Samples");
            }
            if (!Directory.Exists(scenesDirectory)) {
                logger.LogError($"Scenes directory does not exist: {scenesDirectory}");
                return;
            }
            logger.Log($"Searching for scenes in: {scenesDirectory}");
            var scenes = Directory.GetFiles(scenesDirectory, "*.unity", SearchOption.AllDirectories);
            if (scenes.Length == 0) {
                logger.LogWarning("No scenes found to build.");
            } else {
                logger.Log($"Found {scenes.Length} scene(s):");
                foreach (var scene in scenes) {
                    logger.Log($" - {scene}");
                }
            }

            // Configure build player options.
            var buildPlayerOptions = new BuildPlayerOptions {
                scenes = scenes,
                locationPathName = buildPath,
                target = buildTarget,
                targetGroup = targetGroup,
                options = buildOptions
            };

            logger.Log("Starting build...");
            var report = BuildPipeline.BuildPlayer(buildPlayerOptions);
            if (report.summary.result == BuildResult.Succeeded) {
                logger.Log("Build succeeded.");
            } else {
                logger.LogError("Build failed.");
            }
        }

        private static string GetCliParam(string cliParam) {
            var args = Environment.GetCommandLineArgs();
            for (var i = 0; i < args.Length; i++) {
                if (!args[i].Contains(cliParam))
                    continue;
                if (i + 1 >= args.Length)
                    continue;
                return args[i + 1];
            }
            return null;
        }

        private static bool GetCliFlag(string cliFlag) {
            string[] args = Environment.GetCommandLineArgs();
            foreach (var arg in args) {
                if (arg.Equals($"-{cliFlag}", StringComparison.OrdinalIgnoreCase)) {
                    return true;
                }
            }
            return false;
        }
    }
}
