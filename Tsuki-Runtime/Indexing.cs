using System;

namespace Lunari.Tsuki {
    public static class Indexing {
        public static int IndexOf(int x, int y, int width) {
            return x + y * width;
        }
    }

    public interface IIndexable {
        
    }
}