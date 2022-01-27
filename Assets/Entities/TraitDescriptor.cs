using System;
using System.Collections.Generic;
using System.Linq;
using Lunari.Tsuki.Entities.Problems;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor.Animations;

#endif

namespace Lunari.Tsuki.Entities {
    public class TraitDescriptor : Traits {
        public Trait Of { get; }

        public List<Problem> Problems { get; } = new List<Problem>();

        public TraitDescriptor(Entity entity, Trait of, bool initialize) {
            Entity = entity;
            Of = of;
            Initialize = initialize;
        }

        public bool Successful => Initialize && Problems.IsEmpty();

        public bool Initialize { get; }

        public Entity Entity { get; }

        public string FailureReason {
            get { return string.Join(Environment.NewLine, Problems.Select(exception => exception.Description)); }
        }

        public T DependsOn<T>(bool allowSubclasses = false) where T : Trait {
            var found = GetTrait<T>(allowSubclasses);
            if (found == null) {
                Problems.Add(new MissingTrait(Entity, typeof(T), Of));
            }

            return found;
        }
        public T RequiresComponent<T>(CommonLocation commonLocation) where T : Component {
            return RequiresComponent<T>(TraitLocations.PathOf(commonLocation));
        }
        public T RequiresComponent<T>(string expectedLocation = null) where T : Component {
            foreach (var problem in Problems) {
                if (
                    problem is MissingComponent missing
                    && missing.DependencyType == typeof(T)
                    && problem.Entity == Entity
                    && problem.Requisitor == Of
                ) {
                    return null;
                }
            }
            if (!Entity.TryGetComponentInChildren(out T component)) {

                Problems.Add(new MissingComponent(Entity, typeof(T), Of, expectedLocation));
            }

            return component;
        }

        public void RequiresAnimatorParameter(string parameter, AnimatorControllerParameterType type) {
            var animator = RequiresComponent<Animator>();
            if (animator != null && animator.runtimeAnimatorController == null) {
                if (!Problems.Any(problem => problem is MissingAnimatorController)) {
                    Problems.Add(new MissingAnimatorController(Of, Entity, animator));
                }
            }
#if UNITY_EDITOR
            if (animator != null && animator.runtimeAnimatorController is AnimatorController controller) {
                if (controller.parameters.Any(controllerParameter =>
                        controllerParameter.name == parameter && controllerParameter.type == type)) {
                    return;
                }

                Problems.Add(new MissingAnimatorParameter(Entity, parameter, type, Of));
            }
#endif
        }
        public ProblemBuilder AddProblem(string message) {
            return new ProblemBuilder(this, message);
        }
    }
}