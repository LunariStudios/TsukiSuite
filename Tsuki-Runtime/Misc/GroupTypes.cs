namespace Lunari.Tsuki.Misc {
    public sealed class Tuple<A, B> {
        public Tuple(A first, B second) {
            First = first;
            Second = second;
        }

        public A First {
            get;
        }

        public B Second {
            get;
        }
    }

    public sealed class Triple<A, B, C> {
        public Triple(A first, B second, C third) {
            First = first;
            Second = second;
            Third = third;
        }

        public A First {
            get;
        }

        public B Second {
            get;
        }

        public C Third {
            get;
        }
    }
}