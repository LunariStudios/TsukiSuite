using System;
namespace Lunari.Tsuki.Stacking {
    [Serializable]
    public class FloatStackable : Stackable<float> {
        public float masterMultiplier = 1;
        public override float Value => baseValue * Multiplier;

        public float Multiplier {
            get {
                var result = masterMultiplier;
                if (modifiers != null) {
                    foreach (var multiplierHandle in modifiers) {
                        result *= multiplierHandle.value;
                    }
                }

                return result;
            }
        }

        public static implicit operator float(FloatStackable property) {
            return property.Value;
        }

        public static implicit operator FloatStackable(float value) {
            return new FloatStackable {
                baseValue = value
            };
        }
    }
}