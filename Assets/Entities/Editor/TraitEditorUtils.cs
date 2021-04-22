using System.Collections.Generic;
using Lunari.Tsuki.Runtime;
using Lunari.Tsuki.Runtime.Algorithm;

namespace Lunari.Tsuki.Entities.Editor {
    public static class TraitEditorUtils {
        public static Tree<string, List<Trait>> CalcTraitTreeOf(IEnumerable<Trait> traits) {
            var tree = new Tree<string, List<Trait>>(new List<Trait>());
            foreach (var trait in traits) {
                var location = TraitExtensions.FindTraitLocation(trait);
                var node = location.IsNullOrEmpty() ? tree.Root.Value : tree.FindOrCreate(location);
                node.Add(trait);
            }

            return tree;
        }
    }
}