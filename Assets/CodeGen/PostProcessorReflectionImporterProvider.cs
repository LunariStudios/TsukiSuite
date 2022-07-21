using Mono.Cecil;
namespace Lunari.Tsuki.CodeGen {
    internal class PostProcessorReflectionImporterProvider : IReflectionImporterProvider {
        public IReflectionImporter GetReflectionImporter(ModuleDefinition moduleDefinition) {
            return new PostProcessorReflectionImporter(moduleDefinition);
        }
    }
}