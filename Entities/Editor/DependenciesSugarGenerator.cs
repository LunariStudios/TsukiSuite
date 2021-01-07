using System;
using System.IO;
using System.Text;
using UnityEngine;
namespace Lunari.Tsuki.Entities.Editor {
    public class DependenciesSugarGenerator {
        private static string[] variantsNames = {
            "first",
            "second",
            "third",
            "fourth",
            "fifth",
            "sixth",
            "seventh",
            "eighth"
        };
        private static readonly int Variants = variantsNames.Length;
        private const string FileName = "Dependencies.gen.cs";
        public static void GenerateDependencies() {
            var builder = new StringBuilder();
            builder.AppendLine("using Lunari.Tsuki.Entities;");
            builder.AppendLine("namespace Lunari.Tsuki.Entities {");
            builder.AppendLine("public static class Dependencies {");
            GenerateFor("DependsOn", builder);
            GenerateFor("RequiresComponent", builder);
            builder.AppendLine("}");
            builder.AppendLine("}");
            var finalPath = Path.GetFullPath(FileName);
            Console.Out.WriteLine($"Generated to {finalPath}");
            File.WriteAllText(finalPath, builder.ToString());
        }
        private static string GetParameters(string modifier, int count, bool includeType) {
            var builder = new StringBuilder();
            for (var j = 0; j < count; j++) {
                builder.Append($"{modifier} ");
                if (includeType) {
                    builder.Append((char)('A' + j));
                    builder.Append(' ');
                }
                builder.Append($"{variantsNames[j]}");
                if (j != count - 1) {
                    builder.Append(", ");
                }
            }
            return builder.ToString();
        }
        private static void GenerateMethod(string method, string modifier, StringBuilder builder) {
            for (var i = 1; i <= Variants; i++) {
                builder.Append($"public static bool {method}");
                builder.Append('<');
                for (var j = 0; j < i; j++) {
                    builder.Append((char)('A' + j));
                    if (j != i - 1) {
                        builder.Append(", ");
                    }
                }
                builder.Append('>');
                builder.Append("(this TraitDependencies dependencies");
                builder.Append(", ");

                builder.Append(GetParameters(modifier, i, true));
                builder.Append(") ");
                for (var j = 0; j < i; j++) {
                    builder.Append("where ");
                    builder.Append((char)('A' + j));
                    builder.Append(" : Trait ");
                }
                builder.AppendLine(" {");
                var single = i > 1;
                if (single) {
                    builder.AppendLine($"var a = dependencies.{method}({GetParameters(modifier, i - 1, false)});");
                    builder.AppendLine($"var b = dependencies.{method}({modifier} {variantsNames[i - 1]});");
                    builder.AppendLine("return a && b;");
                } else {
                    builder.AppendLine($"var found = dependencies.{method}<A>();");
                    builder.AppendLine("if (dependencies.Successful) {");
                    builder.AppendLine("first = found;");
                    builder.AppendLine("} else {");
                    builder.AppendLine("first = null;");
                    builder.AppendLine("}");

                    builder.AppendLine("return dependencies.Successful;");
                }
                builder.AppendLine("}");
            }
        }
        private static void GenerateFor(string method, StringBuilder builder) {
            GenerateMethod(method, "out", builder);
        }
    }
}