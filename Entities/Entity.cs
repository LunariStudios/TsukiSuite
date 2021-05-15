using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Lunari.Tsuki.Entities {
    public class Entity : MonoBehaviour, ITraits {
        private bool aware;
        private readonly Traits traits = new Traits();
        public UnityEvent onAwareChanged = new UnityEvent();
        public UnityEvent onDeleted = new UnityEvent();

        public bool Aware {
            get => aware;
            set {
                if (aware == value) {
                    return;
                }

                aware = value;
                onAwareChanged.Invoke();
            }
        }

        private void Awake() {
            Aware = true;
            var found = GetComponentsInChildren<Trait>();
            foreach (var trait in found) {
                if (traits.HasTrait(found.GetType())) {
                    Debug.LogWarning(
                        $"Entity '{this}' has multiple traits of type '{trait.GetType()}', please remove one of the traits before building for Release"
                    );
                    continue;
                }

                if (!trait.TryClaim(this, found, out var dependencies)) {
                    Debug.LogWarning(
                        $"Unable to claim trait {trait}: {dependencies.FailureReason}"
                    );
                    continue;
                }

                traits.Include(trait);
            }
        }

        public T GetTrait<T>(bool allowSubclasses = false) where T : Trait {
            return traits.GetTrait<T>(allowSubclasses);
        }

        public IEnumerable<T> GetTraits<T>() where T : Trait {
            return traits.GetTraits<T>();
        }

        public void Delete() {
            onDeleted.Invoke();
            Destroy(gameObject);
        }
    }
}