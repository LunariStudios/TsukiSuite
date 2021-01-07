using System;
namespace Lunari.Tsuki.Entities.Problems {
    public class MissingComponent : Problem {
        public MissingComponent(
            Entity entity,
            Type dependencyType,
            Trait requisitor
        ) : base(requisitor, entity, $"Entity {entity.name} does not have a component of type {dependencyType.Name} which is a dependency of {requisitor} ") {
            DependencyType = dependencyType;
        }

        public Type DependencyType {
            get;
        }
    }
}