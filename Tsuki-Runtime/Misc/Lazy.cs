using System;

namespace Lunari.Tsuki.Misc {
    public class Lazy<T> {
        private T value;
        private readonly Func<T> creator;

        public Lazy(Func<T> creator) {
            this.creator = creator;
        }

        public T Value {
            get {
                if (value == null) {
                    value = creator();
                }

                return value;
            }
        }
        public static implicit operator Lazy<T>(Func<T> creator) {
            return new Lazy<T>(creator);
        }
    }
}