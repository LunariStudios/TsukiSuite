using System;
using UnityEngine;
namespace Lunari.Tsuki.Misc {
    [Serializable]
    public struct Clock {
        public float cooldown;

        public float TickRate {
            get => 1 / cooldown;
            set => cooldown = 1 / value;
        }

        private float currentTime;

        public float CurrentTime {
            get => currentTime;
            set => currentTime = value;
        }

        public void Reset() {
            currentTime = cooldown;
        }

        public bool Tick() {
            return Tick(Time.deltaTime);
        }

        public bool Tick(float elapsedTime) {
            var completed = (currentTime -= elapsedTime) <= 0;
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