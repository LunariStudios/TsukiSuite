using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
namespace Lunari.Tsuki.Cheater {
    public delegate void CommandExecutor();

    public class CommandInvokation {
        private readonly Command command;

        public string UsedLabel {
            get;
        }

        public string[] GivenArgs {
            get;
        }

        public CommandInvokation(Command command, string usedLabel, string[] givenArgs) {
            this.command = command;
            UsedLabel = usedLabel;
            GivenArgs = givenArgs;
        }
        public Tuple<T> Parse<T>(CommandArgument<T> argument) {
            var index = command.Arguments.IndexOf(argument);
            if (index < 0 || index >= GivenArgs.Length) {
                throw new Exception($"Argument {argument.Name} was out of bounds of used args {string.Join(", ", GivenArgs)}");
            }
            return new Tuple<T>(argument.Parse(GivenArgs[index]));
        }
    }
    public class CommandOutput {
        private readonly StringBuilder stdout = new StringBuilder();
        private readonly Command command;
        public CommandOutput(Command command) {
            this.command = command;
        }
        public void PrintLn(StringBuilder builder) {
            PrintLn(builder.ToString());
        }
        public void PrintLn(string message) {
            stdout.AppendLine(message);
        }
        public void Display() {
            Debug.Log($"Command {command.PrimaryAlias}: {Environment.NewLine}{stdout}");
        }
    }
    public abstract class Command {
        private CommandExecutor executor;
        private List<Command> children = new List<Command>();

        public List<CommandArgument> Arguments {
            get;
        } = new List<CommandArgument>();

        public string[] Aliases {
            get;
        }

        public string ShortDescription {
            get;
            protected set;
        }

        public string PrimaryAlias => Aliases[0];
        public string[] SecondaryAliases => Aliases.Skip(1).ToArray();

        public string ShortDescriptionOrDefault {
            get {
                if (ShortDescription.IsNullOrEmpty()) {
                    return "No description provided.";
                }
                return ShortDescription;
            }
        }

        public Command(params string[] aliases) {
            this.Aliases = aliases;
        }
        protected void AddArgument(CommandArgument argument) {
            Arguments.Add(argument);
        }

        protected StringArgument AddStringArgument(string name, string description = null) {
            var arg = new StringArgument(name, description);
            AddArgument(arg);
            return arg;
        }
        public abstract void Invoke(CommandInvokation invokation, CommandOutput output);
    }

}