using UnityEngine;
namespace Lunari.Tsuki.Entities {
    public interface ITrait {

        public Entity Owner {
            get;
        }

        GameObject gameObject {
            get;
        }

        protected void AssignOwner(Entity owner);
        public TraitDescriptor TryClaim(Entity requisitor, ITrait[] traits, bool initialize = true) {
            if (initialize && Owner != null) {
                return null;
            }

            var claims = new TraitDescriptor(requisitor, this, initialize);
            foreach (var trait in traits) {
                claims.Include(trait);
            }
            Configure(claims);
            if (claims.Successful) {
                AssignOwner(requisitor);
            }
            return claims;
        }

        public bool TryClaim(Entity requisitor, ITrait[] traits, out TraitDescriptor descriptor, bool initialize = true) {
            var result = descriptor = TryClaim(requisitor, traits, initialize);
            return result != null && result.Successful;
        }
        public virtual void Configure(TraitDescriptor descriptor) { }
    }

    public abstract class Trait : MonoBehaviour, ITrait {

        public Entity Owner {
            get;
            private set;
        }

        public virtual void Configure(TraitDescriptor descriptor) { }
        void ITrait.AssignOwner(Entity owner) {
            Owner = owner;
        }
        
        public override string ToString() {
            var ownerName = Owner == null ? "none" : Owner.name;
            return $"{GetType().GetLegibleName()} (Owned by {ownerName})";
        }
    }
}