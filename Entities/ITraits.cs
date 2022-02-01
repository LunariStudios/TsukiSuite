using System.Collections.Generic;

namespace Lunari.Tsuki.Entities {
    public interface ITraits {
        T GetTrait<T>(bool allowSubclass = false) where T : ITrait;
        IEnumerable<T> GetTraits<T>() where T : ITrait;
    }
}