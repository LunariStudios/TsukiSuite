namespace Lunari.Tsuki.Cheater {
    public abstract class CommandArgument {
        protected CommandArgument(string name, string description) {
            this.Name = name;
            this.Description = description;
        }

        public string Name {
            get;
        }

        public string Description {
            get;
        }

        public string DescriptionOrDefault => Description.IsNullOrEmpty() ? "No description provided." : Description;
    }

    public abstract class CommandArgument<T> : CommandArgument {
        protected CommandArgument(string name, string description) : base(name, description) {
        }
        public abstract T Parse(string value);
    }
    public class StringArgument : CommandArgument<string> {
        public StringArgument(string name, string description) : base(name, description) {
        }
        public override string Parse(string value) {
            return value;
        }
    }
}