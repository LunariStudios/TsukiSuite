using Lunari.Tsuki.Entities;
using UnityEngine;
namespace Lunari.Tsuki.Entities {
    public static class Dependencies {
        public static bool DependsOn<A>(this TraitDependencies dependencies, out A first) where A : Trait {
            var found = dependencies.DependsOn<A>();
            if (dependencies.Successful) {
                first = found;
            } else {
                first = null;
            }
            return dependencies.Successful;
        }
        public static bool DependsOn<A, B>(this TraitDependencies dependencies, out A first, out B second) where A : Trait where B : Trait {
            var a = dependencies.DependsOn(out first);
            var b = dependencies.DependsOn(out second);
            return a && b;
        }
        public static bool DependsOn<A, B, C>(this TraitDependencies dependencies, out A first, out B second, out C third) where A : Trait where B : Trait where C : Trait {
            var a = dependencies.DependsOn(out first, out second);
            var b = dependencies.DependsOn(out third);
            return a && b;
        }
        public static bool DependsOn<A, B, C, D>(this TraitDependencies dependencies, out A first, out B second, out C third, out D fourth) where A : Trait where B : Trait where C : Trait where D : Trait {
            var a = dependencies.DependsOn(out first, out second, out third);
            var b = dependencies.DependsOn(out fourth);
            return a && b;
        }
        public static bool DependsOn<A, B, C, D, E>(this TraitDependencies dependencies, out A first, out B second, out C third, out D fourth, out E fifth) where A : Trait where B : Trait where C : Trait where D : Trait where E : Trait {
            var a = dependencies.DependsOn(out first, out second, out third, out fourth);
            var b = dependencies.DependsOn(out fifth);
            return a && b;
        }
        public static bool DependsOn<A, B, C, D, E, F>(this TraitDependencies dependencies, out A first, out B second, out C third, out D fourth, out E fifth, out F sixth) where A : Trait where B : Trait where C : Trait where D : Trait where E : Trait where F : Trait {
            var a = dependencies.DependsOn(out first, out second, out third, out fourth, out fifth);
            var b = dependencies.DependsOn(out sixth);
            return a && b;
        }
        public static bool DependsOn<A, B, C, D, E, F, G>(this TraitDependencies dependencies, out A first, out B second, out C third, out D fourth, out E fifth, out F sixth, out G seventh) where A : Trait where B : Trait where C : Trait where D : Trait where E : Trait where F : Trait where G : Trait {
            var a = dependencies.DependsOn(out first, out second, out third, out fourth, out fifth, out sixth);
            var b = dependencies.DependsOn(out seventh);
            return a && b;
        }
        public static bool DependsOn<A, B, C, D, E, F, G, H>(this TraitDependencies dependencies, out A first, out B second, out C third, out D fourth, out E fifth, out F sixth, out G seventh, out H eighth) where A : Trait where B : Trait where C : Trait where D : Trait where E : Trait where F : Trait where G : Trait where H : Trait {
            var a = dependencies.DependsOn(out first, out second, out third, out fourth, out fifth, out sixth, out seventh);
            var b = dependencies.DependsOn(out eighth);
            return a && b;
        }
        public static bool RequiresComponent<A>(this TraitDependencies dependencies, out A first) where A : Component {
            var found = dependencies.RequiresComponent<A>();
            if (dependencies.Successful) {
                first = found;
            } else {
                first = null;
            }
            return dependencies.Successful;
        }
        public static bool RequiresComponent<A, B>(this TraitDependencies dependencies, out A first, out B second) where A : Component where B : Component {
            var a = dependencies.RequiresComponent(out first);
            var b = dependencies.RequiresComponent(out second);
            return a && b;
        }
        public static bool RequiresComponent<A, B, C>(this TraitDependencies dependencies, out A first, out B second, out C third) where A : Component where B : Component where C : Component {
            var a = dependencies.RequiresComponent(out first, out second);
            var b = dependencies.RequiresComponent(out third);
            return a && b;
        }
        public static bool RequiresComponent<A, B, C, D>(this TraitDependencies dependencies, out A first, out B second, out C third, out D fourth) where A : Component where B : Component where C : Component where D : Component {
            var a = dependencies.RequiresComponent(out first, out second, out third);
            var b = dependencies.RequiresComponent(out fourth);
            return a && b;
        }
        public static bool RequiresComponent<A, B, C, D, E>(this TraitDependencies dependencies, out A first, out B second, out C third, out D fourth, out E fifth) where A : Component where B : Component where C : Component where D : Component where E : Component {
            var a = dependencies.RequiresComponent(out first, out second, out third, out fourth);
            var b = dependencies.RequiresComponent(out fifth);
            return a && b;
        }
        public static bool RequiresComponent<A, B, C, D, E, F>(this TraitDependencies dependencies, out A first, out B second, out C third, out D fourth, out E fifth, out F sixth) where A : Component where B : Component where C : Component where D : Component where E : Component where F : Component {
            var a = dependencies.RequiresComponent(out first, out second, out third, out fourth, out fifth);
            var b = dependencies.RequiresComponent(out sixth);
            return a && b;
        }
        public static bool RequiresComponent<A, B, C, D, E, F, G>(this TraitDependencies dependencies, out A first, out B second, out C third, out D fourth, out E fifth, out F sixth, out G seventh) where A : Component where B : Component where C : Component where D : Component where E : Component where F : Component where G : Component {
            var a = dependencies.RequiresComponent(out first, out second, out third, out fourth, out fifth, out sixth);
            var b = dependencies.RequiresComponent(out seventh);
            return a && b;
        }
        public static bool RequiresComponent<A, B, C, D, E, F, G, H>(this TraitDependencies dependencies, out A first, out B second, out C third, out D fourth, out E fifth, out F sixth, out G seventh, out H eighth) where A : Component where B : Component where C : Component where D : Component where E : Component where F : Component where G : Component where H : Component {
            var a = dependencies.RequiresComponent(out first, out second, out third, out fourth, out fifth, out sixth, out seventh);
            var b = dependencies.RequiresComponent(out eighth);
            return a && b;
        }
    }
}