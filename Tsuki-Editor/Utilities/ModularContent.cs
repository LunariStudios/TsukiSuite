using System;

namespace Lunari.Tsuki.Editor.Utilities {
    public class ModularContent<T> {
        private readonly T staticContent;
        private readonly Func<T> dynamicContent;

        public ModularContent(T staticContent) {
            this.staticContent = staticContent;
            dynamicContent = null;
        }

        public ModularContent(Func<T> dynamicContent) {
            this.dynamicContent = dynamicContent;
            staticContent = default(T);
        }

        public T Content => dynamicContent != null ? dynamicContent() : staticContent;

        public static implicit operator ModularContent<T>(T value) {
            return new ModularContent<T>(value);
        }

        public static implicit operator ModularContent<T>(Func<T> creator) {
            return new ModularContent<T>(creator);
        }
    }
}