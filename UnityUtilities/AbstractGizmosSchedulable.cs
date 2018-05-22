using UnityEngine;

namespace UnityUtilities {
    public class AbstractGizmosSchedulable : MonoBehaviour, IGizmosSchedulable {
        private event GizmosAction onGizmosDrawn;

        public void ScheduleGizmos(GizmosAction action) {
            onGizmosDrawn += action;
        }

        public void DescheduleGizmos(GizmosAction action) {
            onGizmosDrawn -= action;
        }

        protected virtual void OnDrawGizmos() {
            var handler = onGizmosDrawn;
            if (handler != null) {
                handler();
            }
        }
    }
}