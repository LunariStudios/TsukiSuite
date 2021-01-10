using UnityEngine;
namespace Lunari.Tsuki.Entities {
    public abstract class Trait : MonoBehaviour {
        private Entity entity;

        public Entity Owner => entity;
        public TraitDependencies TryClaim(Entity requisitor, Trait[] traits, bool initialize = true) {
            if (initialize && entity != null) {
                return null;
            }

            var claims = new TraitDependencies(requisitor, this, initialize);
            foreach (var trait in traits) {
                claims.Include(trait);
            }
            Configure(claims);
            if (claims.Successful) {
                entity = requisitor;
            }
            return claims;
        }
        public bool TryClaim(Entity requisitor, Trait[] traits, out TraitDependencies dependencies, bool initialize = true) {
            var result = dependencies = TryClaim(requisitor, traits, initialize);
            return result != null && result.Successful;
        }
        public virtual void Configure(TraitDependencies dependencies) { }
    }
}