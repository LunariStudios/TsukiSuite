﻿using System;
using System.Linq;
using UnityEditor;
using UnityEngine;

namespace Lunari.Tsuki.Cheater {
    public class CommandWindow {
        private static CommandWindow window;
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
        private static void Init() {
            window ??= new CommandWindow();
        }
        public CommandWindow() {
            var (go, created) = GameObjects.CreateWith<CommandHook>();
            created.Setup(this);
            hook = created;
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
        private readonly CommandHook hook;

        private void Pool() {
            var ev = Event.current;
            if (ev.type != EventType.KeyDown) {
                return;
            }
            if (ev.keyCode != KeyCode.C) {
                return;
            }
            EventModifiers target = EventModifiers.Shift;
            if (Application.platform == RuntimePlatform.OSXEditor) {
                target |= EventModifiers.Command;
            } else {
                target |= EventModifiers.Control;
            }
            if ((ev.modifiers & target) != target) {
                return;
            }
            ToggleWindow();
        }

        private void ToggleWindow() {
            if (open) {
                CloseWindow();
            } else {
                OpenWindow();
            }
        }
        private void Draw() {
            var commandAreaRect = Screen.safeArea;
            commandAreaRect = commandAreaRect.SetHeight(128);
            GUI.Box(commandAreaRect, GUIContent.none);
            GUI.Label(commandAreaRect.GetLine(0), "Command input", CheaterStyles.CommandHeader);
            completer.Draw(commandAreaRect, ref command);
            command = GUI.TextField(commandAreaRect.SkipLines(1), command, CheaterStyles.TextFieldInput);
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
            output.Display();
        }
    }
}