using System;
namespace Lunari.Tsuki {
    public static class Paths {
        public static string RelativeTo(string path, string relativeTo) {
            var second = new Uri(path);
            var first = new Uri(relativeTo);
            return first.MakeRelativeUri(second).ToString();
        }
    }
}