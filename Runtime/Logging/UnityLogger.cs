using UnityEngine;

namespace Lunari.Tsuki.Runtime.Logging {
    public class UnityLogger {
        public UnityLogger(string name) {
            this.Name = name;
        }

        public string Name {
            get;
            private set;
        }

        public void Log(string message) {
            Debug.Log(FormatMessage(message));
        }

        public void LogWarning(string warning) {
            Debug.LogWarning(FormatMessage(warning));
        }

        public void LogError(string error) {
            Debug.LogWarning(FormatMessage(error));
        }

        protected virtual string FormatMessage(string message) {
            return string.Format("[{0}] {1}", Name, message);
        }
    }
}