using System.Collections.Generic;
using System.Linq;
using Lunari.Tsuki.Singletons;
namespace Lunari.Tsuki.Cheater {
    public static class CommandManager {

        public static HashSet<Command> Commands {
            get;
        } = new HashSet<Command>();

        public static void Register(Command command) {
            Commands.Add(command);
        }
        public static void Register(params Command[] commands) {
            foreach (var command in commands) {
                Register(command);
            }
        }
        public static Command Get(string label) {
            return Commands.FirstOrDefault(command => CommandHelper.IsValidAlias(command, label));
        }
    }


}