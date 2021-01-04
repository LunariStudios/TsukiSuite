using System;
using System.Collections.Generic;
using System.Linq;
using Lunari.Tsuki.Runtime;
namespace Lunari.Tsuki.Entities {
    public class MissingTrait : Exception {
        public MissingTrait(
            Entity entity,
            Type dependencyType,
            Trait requisitor
        ) : base($"Entity {entity.name} does not have a trait of type {dependencyType.Name} which is a dependency of {requisitor} ") {
            this.DependencyType = dependencyType;
            this.Requisitor = requisitor;
            this.Entity = entity;
        }

        public Type DependencyType {
            get;
        }

        public Trait Requisitor {
            get;
        }

        public Entity Entity {
            get;
        }
    }
    public class TraitDependencies : Traits {
        private Entity entity;
        private readonly Trait of;

        public List<Exception> Problems {
            get;
        } = new List<Exception>();

        public TraitDependencies(Entity entity, Trait of, bool initialize) {
            this.entity = entity;
            this.of = of;
            this.initialize = initialize;
        }
        private bool initialize;

        public bool Successful => initialize && Problems.IsEmpty();

        public string FailureReason {
            get {
                return string.Join(Environment.NewLine, Problems.Select(exception => exception.Message));
            }
        }
        public bool DependsOn<T>() where T : Trait {
            var found = GetTrait<T>();
            if (found == null) {
                Problems.Add(new MissingTrait(entity, typeof(T), of));
            }
            return Successful;
        }
        public bool DependsOn<T>(ref T trait) where T : Trait {
            var found = GetTrait<T>();
            if (found == null) {
                Problems.Add(new MissingTrait(entity, typeof(T), of));
            }
            if (Successful) {
                trait = found;
            }
            return Successful;
        }
        public bool DependsOn<A, B>(ref A first, ref B second) where A : Trait where B : Trait {
            var a = DependsOn(ref first);
            var b = DependsOn(ref second);
            return a && b;
        }
        public bool DependsOn<A, B, C>(ref A first, ref B second, ref C third) where A : Trait where B : Trait where C : Trait {
            var a = DependsOn(ref first, ref second);
            var b = DependsOn(ref third);
            return a && b;
        }
    }
}