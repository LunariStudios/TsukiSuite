using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
namespace Lunari.Tsuki.Entities.Problems {
    public class MissingComponent : Problem {
        private static Type[] blacklist = new[] {
            typeof(Collider2D),
            typeof(Collider)
        };
        public MissingComponent(
            Entity entity,
            Type dependencyType,
            Trait requisitor,
            string expectedLocation = null
        ) : base(requisitor, entity, $"Entity {entity.name} does not have a component of type {dependencyType.Name} which is a dependency of {requisitor} ") {
            DependencyType = dependencyType;
            if (!dependencyType.IsAbstract && !IsBlacklisted(dependencyType) && expectedLocation != null) {
                WithSolution($"Add {dependencyType.Name}", delegate {
                    var path = new Queue<string>();

                    foreach (var s in expectedLocation.Split('/')) {
                        path.Enqueue(s);
                    }
                    var toAddOn = entity.gameObject.transform;
                    foreach (var s in path) {
                        var found = toAddOn.transform.Find(s);
                        if (found == null) {
                            found = new GameObject(s).transform;
                            found.SetParent(toAddOn);
                        }
                        toAddOn = found;
                    }
                    toAddOn.gameObject.AddComponent(dependencyType);
                });
            }
        }
        private bool IsBlacklisted(Type dependencyType) {
            return blacklist.Contains(dependencyType);
        }

        public Type DependencyType {
            get;
        }
    }
}