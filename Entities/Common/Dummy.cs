namespace Lunari.Tsuki.Entities.Common {
    [TraitLocation(TraitLocations.View)]
    public class Dummy : Trait {
        public override void Configure(TraitDependencies dependencies) {
            dependencies.DependsOn<Living>();
        }
    }
}