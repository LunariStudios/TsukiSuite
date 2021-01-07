using UnityEngine;
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
        }

        public string ParameterName {
            get;
        }
        public AnimatorControllerParameterType ParameterType {
            get;
        }
    }
}