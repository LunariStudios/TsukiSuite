using UnityEngine;

namespace Lunari.Tsuki.Entities {
    public abstract class Trait : MonoBehaviour, ITrait {
        private Entity owner;

        public Entity Owner {
            get => owner;
            private set => owner = value;
        }

        public TraitDescriptor TryClaim(Entity requisitor, ITrait[] traits, bool initialize = true) {
            return this.ExecuteClaim(requisitor, traits, initialize, out owner);
        }
        public virtual void Describe(TraitDescriptor descriptor) { }

        public override string ToString() {
            var ownerName = Owner == null ? "none" : Owner.name;
            return $"{GetType().GetLegibleName()} (Owned by {ownerName})";
        }
    }
}