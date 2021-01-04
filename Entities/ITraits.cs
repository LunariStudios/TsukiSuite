namespace Lunari.Tsuki.Entities {
    public interface ITraits {
        T GetTrait<T>() where T : Trait;
    }
}