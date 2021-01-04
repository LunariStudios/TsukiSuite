namespace Lunari.Tsuki.Entities {
    public static class TraitExtensions {
        public static bool Access<T>(this ITraits traits, out T trait) where T : Trait {
            return (trait = traits.GetTrait<T>()) != null;
        }
    }
}