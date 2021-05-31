using Lunari.Tsuki.Entities;
using UnityEngine;
namespace Lunari.Tsuki.Entities {
    public static class Dependencies {
        public static bool DependsOn<A>(this TraitDescriptor descriptor, out A first) where A : Trait {
            var found = descriptor.DependsOn<A>();
            if (descriptor.Successful) {
                first = found;
            } else {
                first = null;
            }
            return descriptor.Successful;
        }
        public static bool DependsOn<A, B>(this TraitDescriptor descriptor, out A first, out B second) where A : Trait where B : Trait {
            var a = descriptor.DependsOn(out first);
            var b = descriptor.DependsOn(out second);
            return a && b;
        }
        public static bool DependsOn<A, B, C>(this TraitDescriptor descriptor, out A first, out B second, out C third) where A : Trait where B : Trait where C : Trait {
            var a = descriptor.DependsOn(out first, out second);
            var b = descriptor.DependsOn(out third);
            return a && b;
        }
        public static bool DependsOn<A, B, C, D>(this TraitDescriptor descriptor, out A first, out B second, out C third, out D fourth) where A : Trait where B : Trait where C : Trait where D : Trait {
            var a = descriptor.DependsOn(out first, out second, out third);
            var b = descriptor.DependsOn(out fourth);
            return a && b;
        }
        public static bool DependsOn<A, B, C, D, E>(this TraitDescriptor descriptor, out A first, out B second, out C third, out D fourth, out E fifth) where A : Trait where B : Trait where C : Trait where D : Trait where E : Trait {
            var a = descriptor.DependsOn(out first, out second, out third, out fourth);
            var b = descriptor.DependsOn(out fifth);
            return a && b;
        }
        public static bool DependsOn<A, B, C, D, E, F>(this TraitDescriptor descriptor, out A first, out B second, out C third, out D fourth, out E fifth, out F sixth) where A : Trait where B : Trait where C : Trait where D : Trait where E : Trait where F : Trait {
            var a = descriptor.DependsOn(out first, out second, out third, out fourth, out fifth);
            var b = descriptor.DependsOn(out sixth);
            return a && b;
        }
        public static bool DependsOn<A, B, C, D, E, F, G>(this TraitDescriptor descriptor, out A first, out B second, out C third, out D fourth, out E fifth, out F sixth, out G seventh) where A : Trait where B : Trait where C : Trait where D : Trait where E : Trait where F : Trait where G : Trait {
            var a = descriptor.DependsOn(out first, out second, out third, out fourth, out fifth, out sixth);
            var b = descriptor.DependsOn(out seventh);
            return a && b;
        }
        public static bool DependsOn<A, B, C, D, E, F, G, H>(this TraitDescriptor descriptor, out A first, out B second, out C third, out D fourth, out E fifth, out F sixth, out G seventh, out H eighth) where A : Trait where B : Trait where C : Trait where D : Trait where E : Trait where F : Trait where G : Trait where H : Trait {
            var a = descriptor.DependsOn(out first, out second, out third, out fourth, out fifth, out sixth, out seventh);
            var b = descriptor.DependsOn(out eighth);
            return a && b;
        }
        public static bool RequiresComponent<A>(this TraitDescriptor descriptor, out A first) where A : Component {
            var found = descriptor.RequiresComponent<A>();
            if (descriptor.Successful) {
                first = found;
            } else {
                first = null;
            }
            return descriptor.Successful;
        }
        public static bool RequiresComponent<A, B>(this TraitDescriptor descriptor, out A first, out B second) where A : Component where B : Component {
            var a = descriptor.RequiresComponent(out first);
            var b = descriptor.RequiresComponent(out second);
            return a && b;
        }
        public static bool RequiresComponent<A, B, C>(this TraitDescriptor descriptor, out A first, out B second, out C third) where A : Component where B : Component where C : Component {
            var a = descriptor.RequiresComponent(out first, out second);
            var b = descriptor.RequiresComponent(out third);
            return a && b;
        }
        public static bool RequiresComponent<A, B, C, D>(this TraitDescriptor descriptor, out A first, out B second, out C third, out D fourth) where A : Component where B : Component where C : Component where D : Component {
            var a = descriptor.RequiresComponent(out first, out second, out third);
            var b = descriptor.RequiresComponent(out fourth);
            return a && b;
        }
        public static bool RequiresComponent<A, B, C, D, E>(this TraitDescriptor descriptor, out A first, out B second, out C third, out D fourth, out E fifth) where A : Component where B : Component where C : Component where D : Component where E : Component {
            var a = descriptor.RequiresComponent(out first, out second, out third, out fourth);
            var b = descriptor.RequiresComponent(out fifth);
            return a && b;
        }
        public static bool RequiresComponent<A, B, C, D, E, F>(this TraitDescriptor descriptor, out A first, out B second, out C third, out D fourth, out E fifth, out F sixth) where A : Component where B : Component where C : Component where D : Component where E : Component where F : Component {
            var a = descriptor.RequiresComponent(out first, out second, out third, out fourth, out fifth);
            var b = descriptor.RequiresComponent(out sixth);
            return a && b;
        }
        public static bool RequiresComponent<A, B, C, D, E, F, G>(this TraitDescriptor descriptor, out A first, out B second, out C third, out D fourth, out E fifth, out F sixth, out G seventh) where A : Component where B : Component where C : Component where D : Component where E : Component where F : Component where G : Component {
            var a = descriptor.RequiresComponent(out first, out second, out third, out fourth, out fifth, out sixth);
            var b = descriptor.RequiresComponent(out seventh);
            return a && b;
        }
        public static bool RequiresComponent<A, B, C, D, E, F, G, H>(this TraitDescriptor descriptor, out A first, out B second, out C third, out D fourth, out E fifth, out F sixth, out G seventh, out H eighth) where A : Component where B : Component where C : Component where D : Component where E : Component where F : Component where G : Component where H : Component {
            var a = descriptor.RequiresComponent(out first, out second, out third, out fourth, out fifth, out sixth, out seventh);
            var b = descriptor.RequiresComponent(out eighth);
            return a && b;
        }
    }
}