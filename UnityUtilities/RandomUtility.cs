using UnityEngine;

namespace UnityUtilities {
    public static class RandomUtility {
        public static bool NextBool() {
            return Random.value > 0.5;
        }

        public static float NextFloat(float multiplier = 1F) {
            return Random.value * multiplier;
        }
    }
}