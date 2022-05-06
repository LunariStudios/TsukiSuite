using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Lunari.Tsuki.Cheater {
    public class CommandHelper {
        public static bool IsValidAlias(Command command, string label) {
            return command.Aliases.Any(alias => alias.StartsWith(label, StringComparison.InvariantCultureIgnoreCase));
        }
        public static string GetCommandLabel(string current) {
            if (!current.IsNullOrEmpty()) {
                var firstSpaceIndex = current.IndexOf(' ');
                return firstSpaceIndex > 0 ? current.Substring(0, firstSpaceIndex ) : current;
            }
            return string.Empty;
        }
        public static string[] GetCommandArgs(string cmd) {
            return cmd.Split(' ').Skip(1).ToArray();
        }
        public static string[] SplitCommand(string str) {
            if (str.IsNullOrEmpty()) {
                return Array.Empty<string>();
            }
            var components = new List<string>();
            var flagReadingString = false;
            var builder = new StringBuilder();

            void Submit() {
                var current = builder.ToString();
                if (!current.IsNullOrEmpty()) {
                    components.Add(current);
                    builder = new StringBuilder();    
                }
            }

            for (var i = 0; i < str.Length; i++) {
                var c = str[i];
                var isQuotes = c == '"';
                if (isQuotes) {
                    if (flagReadingString) {
                        flagReadingString = false;
                        Submit();
                    } else {
                        flagReadingString = true;
                    }
                } else {
                    if (flagReadingString) {
                        builder.Append(c);
                    } else {
                        var isSpace = c == ' ';
                        if (isSpace) {
                            Submit();
                        } else {
                            builder.Append(c);
                        }
                    }
                }
            }
            var rest = builder.ToString();
            if (!rest.IsNullOrEmpty()) {
                components.Add(rest);
            }
            return components.ToArray();
        }
    }
}