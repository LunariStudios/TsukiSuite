using System.Collections;
using System.Collections.Generic;
namespace Lunari.Tsuki.Entities.Editor {
    public class TraitGroup : IEnumerable<ITrait> {
        private List<ITrait> traits;
        public TraitGroup() : this(new List<ITrait>()) {
        }
        public TraitGroup(List<ITrait> traits) {
            this.traits = traits;
        }

        public void Add(ITrait trait) {
            traits.Add(trait);
        }
        public IEnumerator<ITrait> GetEnumerator() {
            return traits.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator() {
            return GetEnumerator();
        }
    }
}