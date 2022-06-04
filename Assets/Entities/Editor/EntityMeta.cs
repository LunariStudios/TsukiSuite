using System.Collections.Generic;
using System.Linq;
using Lunari.Tsuki.Algorithm;
using Lunari.Tsuki.Entities.Problems;
namespace Lunari.Tsuki.Entities.Editor {
    /**
     * Pre-calculated information about a entity.
     */
    public class EntityMeta {

        public Entity Entity {
            get;
        }

        public ITrait[] AllTraits {
            get;
        }

        public Tree<string, TraitGroup> TraitTree {
            get;
        }

        public EntityMeta(Entity entity) {
            Entity = entity;
            AllTraits = entity.GetComponentsInChildren<ITrait>();
            TraitTree = TraitEditorUtils.FindTraitTreeOf(AllTraits);
            foreach (var trait in AllTraits) {
                trait.PeekDescription();
            }
        }
    }
}