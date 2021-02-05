using System;
namespace Lunari.Tsuki.Runtime.Stacking {
    [Serializable]
    public class BooleanStackable : Stackable<bool> {
        public Mode mode;
        public enum Mode {
            /// <summary>
            /// If any modifier allows it, return true
            /// </summary>
            Any,
            /// <summary>
            /// If any modifier disallow it, return false
            /// </summary>
            All,
            /// <summary>
            /// If any modifier allow it, return false
            /// </summary>
            None
        }
        public BooleanStackable(bool value, Mode mode) {
            this.mode = mode;
        }
        private BooleanStackable() : this(false, Mode.Any) { }

        public override bool Value {
            get {
                if (modifiers != null) {
                    return EvaluateModifiers();
                }
                return baseValue;
            }
        }

        private bool EvaluateModifiers() {
            switch (mode) {
                case Mode.Any:
                    foreach (var modifier in modifiers) {
                        if (modifier.value) {
                            return true;
                        }
                    }
                    break;
                case Mode.All:
                    foreach (var modifier in modifiers) {
                        if (!modifier.value) {
                            return false;
                        }
                    }
                    break;
                case Mode.None:
                    foreach (var modifier in modifiers) {
                        if (modifier.value) {
                            return false;
                        }
                    }
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            return baseValue;
        }

        public static implicit operator bool(BooleanStackable property) {
            return property.Value;
        }

        public static implicit operator BooleanStackable(bool value) {
            return new BooleanStackable {
                baseValue = value
            };
        }
    }
}