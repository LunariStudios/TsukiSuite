using System;
using Lunari.Tsuki.Entities;
using Lunari.Tsuki.Entities.Common;
using UnityEngine;
namespace Lunari.Tsuki.Samples.Entities {
    public class Dummy : Trait {
        private Gauge gauge;
        public override void Describe(TraitDescriptor descriptor) {
            descriptor.DependsOn(out gauge);
            descriptor.RequiresComponent<Animator>(TraitLocations.View);
            descriptor.RequiresComponent<CharacterController>(TraitLocations.Root);
            foreach (AnimatorControllerParameterType value in Enum.GetValues(typeof(AnimatorControllerParameterType))) {
                descriptor.RequiresAnimatorParameter(value.ToString(), value);
            }
        }
    }
}