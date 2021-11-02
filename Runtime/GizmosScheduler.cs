using System.Collections.Generic;
using Lunari.Tsuki.Singletons;
namespace Lunari.Tsuki {
    public delegate void GizmosAction();

    public class GizmosScheduler : StaticSingleton<GizmosScheduler> {
        public List<GizmosAction> Actions { get; } = new List<GizmosAction>();

        public void Schedule(GizmosAction action) {
            Actions.Add(action);
        }

        public void DeSchedule(GizmosAction action) {
            Actions.Remove(action);
        }


        private void OnDrawGizmos() {
            foreach (var gizmosAction in Actions) {
                gizmosAction();
            }
        }
    }
}