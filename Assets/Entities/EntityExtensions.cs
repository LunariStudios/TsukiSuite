using UnityEngine;
namespace Lunari.Tsuki.Entities {
    public static class EntityExtensions {
        public static bool FindEntity(this GameObject gameObject, out Entity entity) {
            return gameObject.TryGetComponentInParent(out entity);
        }
        public static bool FindEntity(this Collider2D collider, out Entity entity) {
            return collider.TryGetComponentInParent(out entity);
        }

        public static bool FindEntity(this Collider collider, out Entity entity) {
            return collider.TryGetComponentInParent(out entity);
        }
        public static bool FindTrait<T>(this GameObject gameObject, out T trait) where T : ITrait {
            if (!gameObject.FindEntity(out var entity)) {
                return entity.Access(out trait);
            }
            trait = default;
            return false;
        }
        public static bool FindTrait<T>(this Collider2D collider, out T trait) where T : ITrait {
            if (collider.FindEntity(out var entity)) {
                return entity.Access(out trait);
            }
            trait = default;
            return false;
        }

        public static bool FindTrait<T>(this Collider collider, out T trait) where T : ITrait {
            if (!collider.FindEntity(out var entity)) {
                return entity.Access(out trait);
            }
            trait = default;
            return false;
        }
    }
}