using Lunari.Tsuki.Entities;
namespace Lunari.Tsuki.Samples.Entities.Health {
    public enum Alignment {
        Ally,
        Enemy,
        Neutral
    }
    
    [TraitLocation(CommonLocation.Combat)]
    public class Combatant : Trait {

        public Alignment alignment;

        private Living living;
 
        public override void Describe(TraitDescriptor descriptor) {
            descriptor.DependsOn(out living);
        }

    }
}