using UnityEngine;
namespace Lunari.Tsuki.Entities {
    public abstract class Trait : MonoBehaviour {
        private Entity entity;

        public Entity Owner => entity;
        public TraitDescriptor TryClaim(Entity requisitor, Trait[] traits, bool initialize = true) {
            if (initialize && entity != null) {
                return null;
            }

            var claims = new TraitDescriptor(requisitor, this, initialize);
            foreach (var trait in traits) {
                claims.Include(trait);
            }
            Configure(claims);
            if (claims.Successful) {
                entity = requisitor;
            }
            return claims;
        }
        public bool TryClaim(Entity requisitor, Trait[] traits, out TraitDescriptor descriptor, bool initialize = true) {
            var result = descriptor = TryClaim(requisitor, traits, initialize);
            return result != null && result.Successful;
        }
        public virtual void Configure(TraitDescriptor descriptor) { }
        public override string ToString() {
            var ownerName = Owner == null ? "none" : Owner.name;
            return $"{GetType().GetLegibleName()} (Owned by {ownerName})";
        }
    }
}