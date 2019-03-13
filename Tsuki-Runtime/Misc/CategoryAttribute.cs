using System;

namespace Lunari.Tsuki.Misc {
    public class CategoryAttribute : Attribute {
        public string Category { get; }

        public CategoryAttribute(string category) {
            Category = category;
        }
    }
}