using Lunari.Tsuki;
using Lunari.Tsuki.Entities;
using Unity.Netcode;
namespace Lunari.Entities.Network {
    public abstract class NetworkTrait : NetworkBehaviour, ITrait {
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