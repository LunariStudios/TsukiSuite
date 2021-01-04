using System;
using UnityEngine;
using UnityEngine.Events;
namespace Lunari.Tsuki.Entities {
    public class Entity : MonoBehaviour {
        private bool aware;
        private Traits traits = new Traits();
        public UnityEvent onAwareChanged = new UnityEvent();

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
    }
}