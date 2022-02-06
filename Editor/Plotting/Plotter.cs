using System.Collections.Generic;
using UnityEngine;
namespace Lunari.Tsuki.Editor.Plotting {
    public abstract class PlotterBase {
        protected static Rect GetPlotRect(float height) {
            var rect = GUILayoutUtility.GetRect(0, float.MaxValue,
                height, height,
                Styles.box
            );
            return rect;
        }
        public abstract void Plot(float height);
    }
    public class Plotter : PlotterBase {
        private List<Plot> plots;
        public void AddPlot(Plot p) {
            plots.Add(p);
        }
        public sealed override void Plot(
            float height
        ) {
            var rect = GetPlotRect(height);
            GUI.Box(rect, GUIContent.none);
            foreach (var plot in plots) {
                plot.Draw(rect);
            }
        }
    }
}