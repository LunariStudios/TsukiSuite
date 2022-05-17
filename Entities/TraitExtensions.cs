using System;

namespace Lunari.Tsuki.Entities {
    public static class TraitExtensions {
        public static bool HasTrait<T>(this ITraits traits) where T : ITrait {
            return traits.GetTrait<T>() != null;
        }

        public static bool Access<T>(this ITraits traits, out T trait) where T : ITrait {
            return (trait = traits.GetTrait<T>()) != null;
        }

        public static string FindTraitLocation(ITrait trait) {
            return FindTraitLocation(trait.GetType());
        }

        public static string FindTraitLocation(Type traitType) {
            var traitLocation = traitType.GetCustomAttribute<TraitLocationAttribute>(true);
            var location = string.Empty;
            if (traitLocation != null) {
                location = traitLocation.Path;
            }

            return location;
        }
    }
}