namespace Lunari.Tsuki.Cheater {
    public abstract class CommandArgument {
        protected CommandArgument(string name, string description) {
            Name = name;
            Description = description;
        }

        public string Name { get; }

        public string Description { get; }

        public abstract string ArgumentType { get; }
        public string DescriptionOrDefault => Description.IsNullOrEmpty() ? "No description provided." : Description;
        public abstract void Consume(CommandParser parser);
    }

    public abstract class CommandArgument<T> : CommandArgument {
        protected CommandArgument(string name, string description) : base(name, description) { }

        public override void Consume(CommandParser parser) {
            var err = string.Empty;
            Parse(parser, out _, ref err);
        }

        public abstract bool Parse(CommandParser parser, out T value, ref string error);
    }

    public class StringArgument : CommandArgument<string> {
        public StringArgument(string name, string description) : base(name, description) { }

        public override string ArgumentType => "string";

        public override bool Parse(CommandParser parser, out string value, ref string error) {
            value = parser.Take();
            return true;
        }
    }

    public class IntArgument : CommandArgument<int> {
        public IntArgument(string name, string description) : base(name, description) { }

        public override string ArgumentType => "int";

        public override bool Parse(CommandParser parser, out int value, ref string error) {
            if (int.TryParse(parser.Take(), out value)) {
                return true;
            }

            return false;
        }
    }
}