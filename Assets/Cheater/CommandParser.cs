namespace Lunari.Tsuki.Cheater {
    public class CommandParser {
        private string[] segments;
        private int current;

        public CommandParser(string[] segments) {
            this.segments = segments;
            current = 0;
        }

        public string Take() {
            if (current < segments.Length) {
                return segments[current++];
            }

            return null;
        }
    }
}