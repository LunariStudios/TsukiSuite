using System;
using System.Collections.Generic;
using System.Linq;

namespace Lunari.Tsuki.Entities {
    public class Traits : ITraits {
        private readonly Dictionary<int, Trait> traits = new Dictionary<int, Trait>();

        public T GetTrait<T>(bool allowSubclass = false) where T : Trait {
            if (allowSubclass) {
                foreach (var trait in traits.Values) {
                    if (trait is T required) {
                        return required;
                    }
                }
            } else {
                if (traits.TryGetValue(typeof(T).GetHashCode(), out var found)) {
                    if (found is T cast) {
                        return cast;
                    }
                }
            }

            return null;
        }

        public IEnumerable<T> GetTraits<T>() where T : Trait {
            foreach (var keyValuePair in traits) {
                var trait = keyValuePair.Value;
                if (trait is T cast) {
                    yield return cast;
                }
            }
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