using Lunari.Tsuki.Entities;

namespace Lunari.Tsuki.Samples.Entities {
    [TraitLocation(CommonLocation.View)]
    public class TraitA : Trait {
        
    }
    [TraitLocation(CommonLocation.Attack)]
    public class TraitB : Trait {
        
    }
    [TraitLocation(CommonLocation.AI)]
    public class TraitC : Trait {
        
    }
    [TraitLocation(CommonLocation.AI)]
    public class AITraitThatDoStuff : Trait {
        
    }

    [TraitLocation(CommonLocation.View)]
    public class SpriteFlipper : Trait {
        
    }

    [TraitLocation(CommonLocation.Combat)]
    public class Combatant : Trait {
        
    }
    [TraitLocation(CommonLocation.Combat)]
    public class Combatant2 : Trait {
        
    }
}