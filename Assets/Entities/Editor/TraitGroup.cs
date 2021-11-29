using System.Collections;
using System.Collections.Generic;
namespace Lunari.Tsuki.Entities.Editor {
    public class TraitGroup : IEnumerable<Trait> {
        private List<Trait> traits;
        public TraitGroup() : this(new List<Trait>()) {
        }
        public TraitGroup(List<Trait> traits) {
            this.traits = traits;
        }

        public void Add(Trait trait) {
            traits.Add(trait);
        }
        public IEnumerator<Trait> GetEnumerator() {
            return traits.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator() {
            return GetEnumerator();
        }
    }
}