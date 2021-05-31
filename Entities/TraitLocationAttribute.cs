using System;

namespace Lunari.Tsuki.Entities {
    public static class TraitLocations {
        public const string Root = "";
        public const string Combat = "Combat";
        public const string AI = "AI";
        public const string Attack = Combat + "/Attack";
        public const string View = "View";
        public const string FX = "FX";

        public static readonly string[] Names = new[] {
            Root,
            Combat,
            AI,
            Attack,
            View,
            FX
        };

        public static string PathOf(CommonLocation common) {
            return Names[(int) common];
        }
    }

    public enum CommonLocation {
        Root,
        Combat,
        AI,
        Attack,
        View,
        FX
    }

    public interface ITraitPathConvertible {
        string Path { get; }
    }

    public class TraitLocationAttribute : Attribute {
        public TraitLocationAttribute(string path) {
            Path = path;
        }

        public TraitLocationAttribute(CommonLocation common) : this(TraitLocations.PathOf(common)) { }

        public string Path { get; }
    }
}