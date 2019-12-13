using System;

namespace Lunari.Tsuki.Editor.Utilities {
    /// <summary>
    /// Represent a value that may be static or dynamic in relation to a context.
    /// <br/>
    /// The most clear use of this is for easily creating GUIContent on editors.
    /// <example>
    /// See <see cref="Lunari.Tsuki.Editor.Extenders.TypeSelectorButton"/>.
    /// </example>
    /// </summary>
    /// <typeparam name="T"></typeparam>
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