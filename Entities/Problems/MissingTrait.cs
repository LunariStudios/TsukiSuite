using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif
namespace Lunari.Tsuki.Entities.Problems {
    public class MissingTrait : Problem {
        public MissingTrait(
            Entity entity,
            Type dependencyType,
            ITrait requisitor
        ) : base(
            requisitor,
            entity,
            $"Entity {entity.name} does not have a trait of type {dependencyType.Name} which is a dependency of {requisitor} "
        ) {
            DependencyType = dependencyType;
            if (!dependencyType.IsAbstract) {
                WithSolution($"Add {dependencyType.Name}",
                    () =>
                    {
                        AddComponentTo(entity, dependencyType);
                    }
                );
            }
#if UNITY_EDITOR
            foreach (var type in TypeCache.GetTypesDerivedFrom(DependencyType)) {
                if (type.IsAbstract) {
                    continue;
                }
                WithSolution("Create and add " + type.Name, () =>
                {
                    AddComponentTo(entity, type);
                });
            }
#endif
        }
        private static void AddComponentTo(Entity entity, Type dependencyType) {
            var path = new Queue<string>();

            var loc = dependencyType.GetCustomAttribute<TraitLocationAttribute>();
            if (loc != null) {
                foreach (var s in loc.Path.Split('/')) {
                    path.Enqueue(s);
                }
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
#if UNITY_EDITOR
            EditorUtility.SetDirty(toAddOn);
#endif
        }


        public Type DependencyType { get; }
    }
}