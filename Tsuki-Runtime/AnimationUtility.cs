using System.Linq;
using UnityEngine;

namespace Lunari.Tsuki {
    public static class AnimationUtility {
        public static bool HasParameter(this Animator animator, string parameter) {
            return animator.parameters.Any(p => p.name == parameter);
        }

        public static void AttemptSetFloat(this Animator animator, string key, float f) {
            if (!animator.HasParameter(key)) {
                return;
            }

            animator.SetFloat(key, f);
        }

        public static void AttemptSetBool(this Animator animator, string key, bool f) {
            if (!animator.HasParameter(key)) {
                return;
            }

            animator.SetBool(key, f);
        }

        public static void AttemptSetInt(this Animator animator, string key, int f) {
            if (!animator.HasParameter(key)) {
                return;
            }

            animator.SetInteger(key, f);
        }

        public static void AttemptSetTrigger(this Animator animator, string key) {
            if (!animator.HasParameter(key)) {
                return;
            }

            animator.SetTrigger(key);
        }
    }
}