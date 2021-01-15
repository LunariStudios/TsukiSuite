using UnityEngine;
#if UNITY_EDITOR
using UnityEditor.Animations;
#endif
namespace Lunari.Tsuki.Entities.Problems {
    public class MissingAnimatorParameter : Problem {
        public MissingAnimatorParameter(
            Entity entity,
            string name,
            AnimatorControllerParameterType parameterType,
            Trait requisitor
        ) : base(requisitor, entity, $"Entity {entity.name}'s animator not have a parameter named {name} of type {parameterType} which is a dependency of {requisitor} ") {
            ParameterName = name;
            ParameterType = parameterType;
#if UNITY_EDITOR
            WithSolution($"Add {name} ({parameterType})",
                () => {
                    var animator = entity.GetComponentInChildren<Animator>();
                    if (animator.runtimeAnimatorController is AnimatorController controller) {
                        controller.AddParameter(name, parameterType);
                    }
                });
#endif
        }

        public string ParameterName {
            get;
        }

        public AnimatorControllerParameterType ParameterType {
            get;
        }
    }
}