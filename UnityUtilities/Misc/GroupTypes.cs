namespace UnityUtilities.Misc {
    public sealed class Tuple<A, B> {
        private readonly A first;
        private readonly B second;

        public Tuple(A first, B second) {
            this.first = first;
            this.second = second;
        }

        public A First {
            get {
                return first;
            }
        }

        public B Second {
            get {
                return second;
            }
        }
    }

    public sealed class Triple<A, B, C> {
        private readonly A first;
        private readonly B second;
        private readonly C third;

        public Triple(A first, B second, C third) {
            this.first = first;
            this.second = second;
            this.third = third;
        }

        public A First {
            get {
                return first;
            }
        }

        public B Second {
            get {
                return second;
            }
        }

        public C Third {
            get {
                return third;
            }
        }
    }
}