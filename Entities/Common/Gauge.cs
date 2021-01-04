using UnityEngine;
#if ODIN_INSPECTOR
using Sirenix.OdinInspector;
#endif
namespace Lunari.Tsuki.Entities.Common {
    public class Gauge : Trait {
        [SerializeField]
#if ODIN_INSPECTOR
        [HideInInspector]
#endif
        private float value = 5;

        [SerializeField]
#if ODIN_INSPECTOR
        [HideInInspector]
#endif
        private float maxValue = 10;

        [SerializeField]
        private float restoration = 3;

        public bool regenerate = true;

#if ODIN_INSPECTOR
        [ShowInInspector]
#endif
        public float Value {
            get => value;
            set => this.value = Mathf.Clamp(value, 0, maxValue);
        }
#if ODIN_INSPECTOR
        [ShowInInspector]
#endif
        public float MaxValue {
            get => maxValue;
            set {
                maxValue = value;
                this.value = Mathf.Clamp(this.value, 0, maxValue);
            }
        }

        public float Percentage => value / maxValue;

        private void Update() {
            if (!regenerate) {
                return;
            }

            var accumulation = restoration * Time.deltaTime;
            if (value + accumulation > maxValue) {
                value = maxValue;
            } else {
                value += accumulation;
            }
        }

        public virtual bool Consume(float amount) {
            if (value <= amount) {
                return false;
            }

            value -= amount;
            return true;
        }
    }
}