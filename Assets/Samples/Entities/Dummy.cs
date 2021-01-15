using System;
using Lunari.Tsuki.Entities;
using Lunari.Tsuki.Entities.Common;
using UnityEngine;
namespace Lunari.Tsuki.Samples.Entities {
    public class Dummy : Trait {
        private Gauge gauge;
        public override void Configure(TraitDependencies dependencies) {
            dependencies.DependsOn(out gauge);
            dependencies.RequiresComponent<Animator>(TraitLocations.View);
            dependencies.RequiresComponent<CharacterController>(TraitLocations.Root);
            foreach (AnimatorControllerParameterType value in Enum.GetValues(typeof(AnimatorControllerParameterType))) {
                dependencies.RequiresAnimatorParameter(value.ToString(), value);
            }
        }
    }
}