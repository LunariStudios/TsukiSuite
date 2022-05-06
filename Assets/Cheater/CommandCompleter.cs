using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lunari.Tsuki.Exceptions;
using UnityEngine;
namespace Lunari.Tsuki.Cheater {
    public class CommandCompleter {

        public int SelectedSuggestion {
            get;
            private set;
        } = -1;

        private void EnsureSelectionWithinBounds(int min, int max) {
            SelectedSuggestion = Mathf.Clamp(SelectedSuggestion, min, max);
        }
        private TextEditor textEditor;
        private void ConsumeEvents(Command[] possibleCommands, ref string current) {
            var ev = Event.current;
            if (ev.type != EventType.KeyDown) {
                return;
            }
            var lastPossibleIndex = possibleCommands.Length - 1;
            switch (ev.keyCode) {
                case KeyCode.Tab:
                    if (SelectedSuggestion >= 0 && SelectedSuggestion <= lastPossibleIndex) {
                        Complete(possibleCommands, ref current);
                        ev.Use();
                    }
                    return;
                case KeyCode.UpArrow:
                    EnsureSelectionWithinBounds(0, lastPossibleIndex);
                    SelectedSuggestion--;
                    ev.Use();
                    return;
                case KeyCode.DownArrow:
                    EnsureSelectionWithinBounds(-1, lastPossibleIndex);
                    if (SelectedSuggestion < lastPossibleIndex) {
                        SelectedSuggestion++;
                    }
                    ev.Use();
                    return;

            }
        }
        private void Complete(Command[] command, ref string current) {
            var cmd = CommandHelper.SplitCommand(current);
            var primaryAlias = command[SelectedSuggestion].PrimaryAlias;
            if (cmd.IsEmpty()) {
                current = primaryAlias;
            } else {
                cmd[0] = primaryAlias;
                current = string.Join(" ", cmd);
            }

            var newIndex = current.Length ;
            textEditor.text = current;
            textEditor.cursorIndex = newIndex;
            textEditor.selectIndex = newIndex;
        }
        public void Draw(Rect area, ref string current) {
            var segments = CommandHelper.SplitCommand(current);
            var numSeg = segments.Length;
            var label = CommandHelper.GetCommandLabel(current);
            textEditor = (TextEditor) GUIUtility.GetStateObject(typeof(TextEditor), GUIUtility.keyboardControl);
            if (textEditor == null) {
                return;
            }
            var cursorPos = textEditor.cursorIndex;
            var segmentIndex = FindSelectedSegmentIndex(segments, cursorPos);
            if (segmentIndex == 0) {
                SuggestCommands(area, ref current, label);
            } else {
                var cmd = CommandManager.Get(label);
                var argIndex = segmentIndex - 1;
                var suggestionRect = area.SetY(area.yMax).GetLine(0, 24F);
                if (argIndex >= cmd.Arguments.Count) {
                    GUI.Box(
                        suggestionRect,
                        $"No args left (Provided: {numSeg - 1}, Num Command Args: {cmd.Arguments.Count}, Current Index: {argIndex}, Cursor: {cursorPos})",
                        CheaterStyles.CommandSuggestionSelected
                    );
                    return;
                }
                var argument = cmd.Arguments[argIndex];
                GUI.Box(
                    suggestionRect,
                    $"<{argument.Name}>: {argument.DescriptionOrDefault}",
                    CheaterStyles.CommandSuggestionSelected
                );
            }
        }
        private static int FindSelectedSegmentIndex(string[] segments, int cursorPos) {
            if (segments.IsNullOrEmpty()) {
                return 0;
            }
            var segmentIndex = 0;
            var stringPos = 0;
            while (true) {
                var seg = segments[segmentIndex];
                var segmentEnd = stringPos + seg.Length + (segmentIndex); //segmentIndex is for spaces 
                if (cursorPos >= stringPos && cursorPos <= segmentEnd) {
                    return segmentIndex;
                }
                segmentIndex++;
                stringPos += seg.Length;
                if (segmentIndex == segments.Length) {
                    return segmentIndex;
                }
            }
        }
        private void SuggestCommands(Rect area, ref string current, string label) {

            Command[] possibleCommands;
            if (label.IsEmpty()) {
                possibleCommands = CommandManager.Commands.ToArray();
            } else {
                possibleCommands = CommandManager.Commands.Where(command => CommandHelper.IsValidAlias(command, label)).ToArray();
            }
            ConsumeEvents(possibleCommands, ref current);
            int i = 0;
            foreach (var command in possibleCommands) {
                // State
                var isSelected = i == SelectedSuggestion;

                // Visuals
                var suggestionRect = area.SetY(area.yMax).GetLine(i, 24F);


                var msg = new StringBuilder();
                msg.Append($"{command.PrimaryAlias}: {command.ShortDescriptionOrDefault} ({command.PrimaryAlias}");
                if (!command.Arguments.IsNullOrEmpty()) {
                    msg.Append(string.Join(" ", command.Arguments.Select(argument => $"<{argument.Name}>")));
                }
                msg.Append(")");
                GUI.Box(
                    suggestionRect,
                    msg.ToString(),
                    isSelected ? CheaterStyles.CommandSuggestionSelected : CheaterStyles.CommandSuggestion
                );
                i++;
            }
        }
    }
}