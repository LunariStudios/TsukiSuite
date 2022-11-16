using Lunari.Tsuki.Algorithm;
using UnityEngine;
namespace Lunari.Tsuki.Editor.Plotting {
    public class BufferedPlotter : PlotterBase {
        private readonly RingBuffer<float> _buffer;
        private readonly Plot _plot = new Plot();
        public BufferedPlotter(int size) {
            _buffer = new RingBuffer<float>(size);
            _plot.Resize(size);
        }

        public float Min {
            get => _plot.Min;
            set => _plot.Min = value;
        }

        public float Max {
            get => _plot.Max;
            set => _plot.Max = value;
        }

        public sealed override void Plot(float height) {
            var rect = GetPlotRect(height);
            GUI.Box(rect, GUIContent.none);
            _plot.Draw(rect, _buffer);
        }
        public void Push(float value) {
            _buffer.LoopPush(value);
        }
    }
}