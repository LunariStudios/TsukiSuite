using System;
using System.Collections.Generic;
using System.Linq;
using Lunari.Tsuki.Editor;
using Lunari.Tsuki.Misc;
using UnityEditor;
using UnityEditor.ShortcutManagement;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Lunari.Tsuki.Cheater {
    public class CommandWindow {
        private const string OpenCheaterShortcutId = "tsuki.cheater.toggle";
        private static CommandWindow window;

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
        private static void Init() {
            window ??= new CommandWindow();
        }

        public CommandWindow() {
            var (go, created) = GameObjects.CreateWith<OnGUIHook>();
            created.onGUI.AddListener(OnGUI);
            Object.DontDestroyOnLoad(go);
            var binding = ShortcutManager.instance.GetShortcutBinding(OpenCheaterShortcutId);
            if (binding.keyCombinationSequence.IsEmpty()) {
                binding = new ShortcutBinding(new KeyCombination(KeyCode.F1));
                ShortcutManager.instance.RebindShortcut(OpenCheaterShortcutId, binding);
            }
        }

        private void OpenWindow() {
            open = true;
        }

        private void CloseWindow() {
            open = false;
        }

        public void OnGUI() {
            Pool();
            if (open) {
                Draw();
            }
        }

        private bool open;
        private string command;
        private readonly CommandCompleter completer = new CommandCompleter();
        private readonly List<CommandOutput> outputs = new List<CommandOutput>();

        private void Pool() {
            var ev = Event.current;
            if (ev.type != EventType.KeyDown) {
                return;
            }

            if (ev.keyCode != KeyCode.S) {
                return;
            }

            var target = EventModifiers.Shift;
            if (Application.platform == RuntimePlatform.OSXEditor) {
                target |= EventModifiers.Command;
            }
            else {
                target |= EventModifiers.Control;
            }

            if ((ev.modifiers & target) != target) {
                return;
            }

            ToggleWindow();
        }

        [Shortcut(OpenCheaterShortcutId, KeyCode.F1)]
        private static void Toggle() {
            Debug.Log("Toggling");
            window?.ToggleWindow();
            if (window == null) {
                Debug.LogWarning("Window of null");
            }
        }

        private void ToggleWindow() {
            if (open) {
                CloseWindow();
            }
            else {
                OpenWindow();
            }
        }

        private void Draw() {
            var commandAreaRect = Screen.safeArea;
            commandAreaRect = commandAreaRect.Padding(32);
            GUILayout.BeginArea(commandAreaRect);
            using (new EditorGUILayout.VerticalScope(Styles.box)) {
                GUILayout.Label("Cheater");
                command = GUILayout.TextField(command, CheaterStyles.TextFieldInput);
                completer.Draw(ref command);
            }

            if (!outputs.IsEmpty()) {
                using (new EditorGUILayout.VerticalScope(Styles.box, GUILayout.ExpandHeight(true))) {
                    EditorGUILayout.LabelField("History", Styles.IN_BigTitle);
                    foreach (var commandOutput in outputs) {
                        using (new EditorGUILayout.VerticalScope(Styles.box)) {
                            EditorGUILayout.LabelField(commandOutput.Command.PrimaryAlias, Styles.IN_BigTitle);
                            var hasStdout = commandOutput.Stdout.Length > 0;
                            if (hasStdout) {
                                EditorGUILayout.LabelField(commandOutput.Stdout.ToString());
                            }
                        }
                    }
                }
            }

            GUILayout.EndArea();
            var isSubmit = Event.current.type == EventType.KeyDown && Event.current.character == '\n';
            if (isSubmit) {
                Submit();
            }
        }

        private void Submit() {
            var str = command;
            command = string.Empty;
            var label = CommandHelper.GetCommandLabel(str);
            var cmd = CommandManager.Commands.FirstOrDefault(cmd => CommandHelper.IsValidAlias(cmd, label));
            if (cmd == null) {
                return;
            }

            var segments = CommandHelper.SplitCommand(str);
            var invokation = new CommandInvokation(cmd, label, segments.Skip(1).ToArray());
            var output = new CommandOutput(cmd);
            cmd.Invoke(invokation, output);
            outputs.Add(output);
        }
    }
}