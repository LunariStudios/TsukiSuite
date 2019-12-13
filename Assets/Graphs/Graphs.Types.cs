using System;

namespace Lunari.Tsuki.Graphs {
    public interface IWeighted<T> where T : IComparable<T> {
        T Weight { get; set; }
    }

    public interface ILabeled<T> {
        T Label { get; set; }
    }
}