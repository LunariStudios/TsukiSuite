using System;
using System.Collections.Generic;
using System.Linq;
using Lunari.Tsuki.Entities.Problems;
using Lunari.Tsuki.Runtime;
using UnityEngine;

#if UNITY_EDITOR
using UnityEditor.Animations;
#endif

namespace Lunari.Tsuki.Entities {
    public class TraitDependencies : Traits {
        private readonly Trait of;

        public List<Problem> Problems {
            get;
        } = new List<Problem>();

        public TraitDependencies(Entity entity, Trait of, bool initialize) {
            Entity = entity;
            this.of = of;
            Initialize = initialize;
        }

        public bool Successful => Initialize && Problems.IsEmpty();

        public bool Initialize {
            get;
        }

        public Entity Entity {
            get;
        }

        public string FailureReason {
            get {
                return string.Join(Environment.NewLine, Problems.Select(exception => exception.Description));
            }
        }

        public T DependsOn<T>() where T : Trait {
            var found = GetTrait<T>();
            if (found == null) {
                Problems.Add(new MissingTrait(Entity, typeof(T), of));
            }
            return found;
        }
        public T RequiresComponent<T>(string expectedLocation = null) where T : Component {
            if (!Entity.TryGetComponentInChildren(out T component)) {
                Problems.Add(new MissingComponent(Entity, typeof(T), of, expectedLocation));
            }
            return component;
        }
 
        public void RequiresAnimatorParameter(string parameter, AnimatorControllerParameterType type) {
            var animator = RequiresComponent<Animator>();
            if (animator != null && animator.runtimeAnimatorController == null) {
                if (!Problems.Any(problem => problem is MissingAnimatorController)) {
                    Problems.Add(new MissingAnimatorController(of, Entity, animator));
                }
            }
#if UNITY_EDITOR
            if (animator != null && animator.runtimeAnimatorController is AnimatorController controller) {
                if (controller.parameters.Any(controllerParameter => controllerParameter.name == parameter && controllerParameter.type == type)) {
                    return;
                }
                Problems.Add(new MissingAnimatorParameter(Entity, parameter, type, of));
            }
#endif
        }
    }
}