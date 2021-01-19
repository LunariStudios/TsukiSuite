using System.Linq;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor.Animations;
#endif
namespace Lunari.Tsuki.Runtime {
    public static class Animations {
#if UNITY_EDITOR
        public enum AnimatorParameterProblem {
            None,
            AlreadyInUse,
            NoController
        }
        [EditorOnly]
        public static void EnsureHasParameter(this Animator animator, string parameter, AnimatorControllerParameterType type, bool replaceIfInUse = false) {
            if (animator.EnsureHasParameter(parameter, type, out var problem)) {
                return;
            }
            if (!replaceIfInUse || problem != AnimatorParameterProblem.AlreadyInUse) {
                return;
            }
            var controller = (AnimatorController)animator.runtimeAnimatorController;
            controller.RemoveParameter(controller.parameters.First(controllerParameter => controller.name == parameter));
            animator.EnsureHasParameter(parameter, type);
        }
        [EditorOnly]
        public static bool EnsureHasParameter(this Animator animator, string parameter, AnimatorControllerParameterType type, out AnimatorParameterProblem problem) {
            if (animator.runtimeAnimatorController is AnimatorController controller) {
                var existing = controller.parameters.FirstOrDefault(p => p.name == parameter);
                if (existing == null) {
                    controller.AddParameter(parameter, type);
                    problem = AnimatorParameterProblem.None;
                    return true;
                }
                if (existing.type == type) {
                    problem = AnimatorParameterProblem.None;
                    return true;
                }
                problem = AnimatorParameterProblem.AlreadyInUse;
                return false;

            }
            problem = AnimatorParameterProblem.NoController;
            return false;
        }
#endif
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