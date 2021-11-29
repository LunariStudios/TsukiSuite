using System.Collections.Generic;
using Lunari.Tsuki.Algorithm;

namespace Lunari.Tsuki.Entities.Editor {
    public static class TraitEditorUtils {
        public static Tree<string, TraitGroup> FindTraitTreeOf(IEnumerable<Trait> traits) {
            var tree = new Tree<string, TraitGroup>(new TraitGroup());
            foreach (var trait in traits) {
                var location = TraitExtensions.FindTraitLocation(trait);
                var node = location.IsNullOrEmpty() ? tree.Root.Value : tree.FindOrCreate(location);
                node.Add(trait);
            }

            return tree;
        }
        public static TraitDescriptor PeekDescription(this Trait trait) {
            var entity = trait.GetComponentInParent<Entity>();
            var allTraits = entity.GetComponentsInChildren<Trait>();
            return trait.PeekDescription(entity, allTraits);
        }
        public static TraitDescriptor PeekDescription(this Trait trait, Entity entity, Trait[] all) {
            trait.TryClaim(entity, all, out var dependencies, false);
            return dependencies;
        }
    }
}