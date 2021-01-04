using System;
using System.Collections.Generic;
using System.Linq;
namespace Lunari.Tsuki.Entities {
    public class Traits : ITraits {
        private readonly Dictionary<int, Trait> traits = new Dictionary<int, Trait>();
        public T GetTrait<T>() where T : Trait {
            if (traits.TryGetValue(typeof(T).GetHashCode(), out var found)) {
                if (found is T cast) {
                    return cast;
                }
            }
            return null;
        }
        public bool HasTrait(Type type) {
            return traits.Any(pair => pair.Key == type.GetHashCode());
        }
        public void Include(Trait trait) {
            traits[trait.GetType().GetHashCode()] = trait;
        }
        public void Include(Traits traits) {
            foreach (var pair in traits.traits) {
                Include(pair.Value);
            }
        }
    }

}