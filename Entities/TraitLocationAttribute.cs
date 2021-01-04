using System;
namespace Lunari.Tsuki.Entities {
    public static class TraitLocations {
        public const string Root = "";
        public const string Combat = "Combat";
        public const string AI = "AI";
        public const string Attack = Combat + "/Attack";
        public const string View = "View";
        
        public const string FX = "FX";
    }

    public class TraitLocationAttribute : Attribute {
        public TraitLocationAttribute(string path) {
            Path = path;
        }

        public string Path { get; }
    }
}