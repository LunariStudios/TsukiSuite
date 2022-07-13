using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Lunari.Tsuki.Cheater {
    public delegate void CommandExecutor();

    public class CommandInvokation {
        private readonly Command command;

        public string UsedLabel { get; }

        public string[] GivenArgs { get; }

        public CommandInvokation(Command command, string usedLabel, string[] givenArgs) {
            this.command = command;
            UsedLabel = usedLabel;
            GivenArgs = givenArgs;
        }


        private CommandParser GetStringSource(CommandArgument argument) {
            var parser = new CommandParser(GivenArgs);
            var i = 0;
            CommandArgument arg;
            do {
                arg = command.Arguments[i];
                if (arg == argument) {
                    return parser;
                }

                arg.Consume(parser);
                i++;
            } while (arg != argument);

            return null;
        }

        private T Get<T>(CommandArgument<T> argument) {
            var parser = GetStringSource(argument);
            var err = string.Empty;
            
            if (argument.Parse(parser, out var v, ref err)) {
                return v;
            }

            return default;
        }

        public Tuple<T> Parse<T>(CommandArgument<T> argument) {
            return new Tuple<T>(Get(argument));
        }

        public Tuple<A, B> Parse<A, B>(
            CommandArgument<A> first,
            CommandArgument<B> second
        ) {
            return new Tuple<A, B>(Get(first), Get(second));
        }

        public Tuple<A, B, C> Parse<A, B, C>(
            CommandArgument<A> first,
            CommandArgument<B> second,
            CommandArgument<C> third
        ) {
            return new Tuple<A, B, C>(Get(first), Get(second), Get(third));
        }
    }

    public class CommandOutput {
        public CommandOutput(Command command) {
            Command = command;
        }

        internal StringBuilder Stdout { get; } = new StringBuilder();

        public Command Command { get; }

        public void PrintLn(StringBuilder builder) {
            PrintLn(builder.ToString());
        }

        public void PrintLn(string message) {
            Stdout.AppendLine(message);
        }
    }

    public abstract class Command {
        private CommandExecutor executor;
        private List<Command> children = new List<Command>();

        public List<CommandArgument> Arguments { get; } = new List<CommandArgument>();

        public string[] Aliases { get; }

        public string ShortDescription { get; protected set; }

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

        protected IntArgument AddIntArgument(string name, string description = null) {
            var arg = new IntArgument(name, description);
            AddArgument(arg);
            return arg;
        }

        public abstract void Invoke(CommandInvokation invokation, CommandOutput output);
    }
}