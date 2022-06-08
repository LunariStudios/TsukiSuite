using System;
using System.Collections;
using UnityEngine;
namespace Lunari.Tsuki.Misc {
    [Serializable]
    public class Cooldown {
        private float _currentTime = 0;
        public float cooldown = 1;

        public void Use() {
            _currentTime = cooldown;
        }

        public bool Tick() {
            _currentTime -= Time.deltaTime;
            if (_currentTime < 0) {
                _currentTime = 0;
                return true;
            }
            return Available;
        }

        public bool Available => _currentTime <= 0;

        public WaitUntil WaitUntilReady() {
            return new WaitUntil(Tick);
        }
        public IEnumerator UseAndWait() {
            Use();
            yield return WaitUntilReady();
        }
    }
}