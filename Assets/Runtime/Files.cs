using System.IO;
namespace Lunari.Tsuki {
    public static class Files {
        public static void EnsureParentFolderExists(string file) {
            var folder = Path.GetDirectoryName(file);
            if (folder == null) {
                return;
            }
            if (!Directory.Exists(folder)) {
                Directory.CreateDirectory(folder);
            }
        }
    }
}