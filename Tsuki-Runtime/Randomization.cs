using UnityEngine;

namespace Lunari.Tsuki {
    public static class Randomization {
        public static bool NextBool() {
            return Random.value > 0.5;
        }

        public static float NextFloat(float multiplier = 1F) {
            return Random.value * multiplier;
        }
    }
}