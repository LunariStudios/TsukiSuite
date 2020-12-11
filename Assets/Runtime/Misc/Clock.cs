using System;
using UnityEngine;

namespace Lunari.Tsuki.Runtime.Misc {
    [Serializable]
    public struct Clock {
        public float cooldown;

        public float TickRate {
            get => 1 / cooldown;
            set => cooldown = 1 / value;
        }

        private float currentTime;

        public bool Tick() {
            var completed = (currentTime -= Time.deltaTime) <= 0;
            if (completed) {
                currentTime = cooldown;
            }

            return completed;
        }

        public static implicit operator Clock(float cooldown) =>
            new Clock {
                cooldown = cooldown
            };
    }
}