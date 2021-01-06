using System.Collections.Generic;

namespace Lunari.Tsuki.Entities {
    public interface ITraits {
        T GetTrait<T>() where T : Trait;
        IEnumerable<T> GetTraits<T>() where T : Trait;
    }
}