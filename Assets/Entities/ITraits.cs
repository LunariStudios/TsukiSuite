using System.Collections.Generic;
using UnityEngine;

namespace Lunari.Tsuki.Entities {
    public interface ITraits {
        T GetTrait<T>(bool allowSubclass = false) where T : ITrait;
        IEnumerable<T> GetTraits<T>() where T : ITrait;
    }

    public interface ITrait {

        public Entity Owner {
            get;
        }

        GameObject gameObject {
            get;
        }

        public TraitDescriptor TryClaim(Entity requisitor, ITrait[] traits, bool initialize = true);

        public void Describe(TraitDescriptor descriptor);
    }

    public static partial class TraitExtensions {
        /// <summary>
        /// This is just a helper method to ease implementation of ITrait.
        /// 
        /// Since default interface methods is only available in C# 8.0>=, this extension method is defined as an alternative.
        /// When implementing 
        /// </summary>
        /// <example>
        /// public TraitDescriptor TryClaim(Entity requisitor, ITrait[] traits, bool initialize = true) {
        ///     return this.ExecuteClaim(requisitor, traits, initialize, out owner); // Where owner is a field of type Entity.
        /// }
        /// </example>
        /// <param name="newOwner"></param>
        /// <returns></returns>
        public static TraitDescriptor ExecuteClaim(this ITrait self, Entity requisitor, ITrait[] traits, bool initialize, out Entity newOwner) {
            if (initialize && self.Owner != null) {
                newOwner = self.Owner;
                return null;
            }

            var claims = new TraitDescriptor(requisitor, self, initialize);
            foreach (var trait in traits) {
                claims.Include(trait);
            }
            self.Describe(claims);
            if (claims.Successful) {
                newOwner = requisitor;
            } else {
                newOwner = null;
            }
            return claims;
        }

        public static bool TryClaim(this ITrait trait, Entity requisitor, ITrait[] traits, out TraitDescriptor descriptor, bool initialize = true) {
            var result = descriptor = trait.TryClaim(requisitor, traits, initialize);
            return result != null && result.Successful;
        }
    }
}