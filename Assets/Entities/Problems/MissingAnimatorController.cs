using UnityEngine;
namespace Lunari.Tsuki.Entities.Problems {
    public class MissingAnimatorController : Problem {
        public MissingAnimatorController(ITrait requisitor, Entity entity, Animator animator) : base(requisitor, entity, $"Animator {animator} does not have an animator controller") {
        }
    }
}