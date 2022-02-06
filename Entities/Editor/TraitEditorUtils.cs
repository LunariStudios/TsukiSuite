using System;
using System.Collections.Generic;
using System.Linq;
using Lunari.Tsuki.Algorithm;
using UnityEditor;
using UnityEngine;

namespace Lunari.Tsuki.Entities.Editor {
    public static class TraitEditorUtils {
        public static Entity TryFindParentEntity(this Trait t) {
            return t.GetComponentInParent<Entity>();
        }
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
            if (entity == null) {
                return null;
            }
            var allTraits = entity.GetComponentsInChildren<Trait>();
            return trait.PeekDescription(entity, allTraits);
        }
        public static TraitDescriptor PeekDescription(this Trait trait, Entity entity, Trait[] all) {
            trait.TryClaim(entity, all, out var dependencies, false);
            return dependencies;
        }
        public static bool IsCurrentlySelected(Component trait) {
            var activeObject = Selection.activeObject;
            var candidates = new List<UnityEngine.Object>() {
                trait,
                trait.gameObject
            };
            var entity = trait.GetComponentInParent<Entity>();
            if (entity != null) {
                candidates.Add(entity);
            }
            return candidates.Any(candidate => candidate == activeObject);
        }
    }
}