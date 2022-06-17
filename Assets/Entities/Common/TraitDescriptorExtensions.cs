using System.Linq;
using System.Text;
using Lunari.Tsuki.Entities.Problems;
using UnityEngine.Events;

namespace Lunari.Tsuki.Entities.Common {
    public static class TraitDescriptorExtensions {
        private static ProblemBuilder CreateValueNotEqualProblem<T>(this TraitDescriptor descriptor, T value, T required, string fieldName) {
            var builder = new StringBuilder();
            builder.Append($"Value {value} ");
            if (fieldName != null) {
                builder.Append($"({fieldName}) ");
            }
            return descriptor.AddProblem($"is not equal to {required}");
        }
        public static void EnsureEqual<T>(this TraitDescriptor descriptor, ref T value, T required, string fieldName = null) {
            if (!value.Equals(required)) {
                value = required;
            }
        }
        public static void EnsureEqual<T>(this TraitDescriptor descriptor, T value, T required, string fieldName = null) {
            if (!value.Equals(required)) {
                descriptor.CreateValueNotEqualProblem(value, required, fieldName);
            }
        }
     
        public static void EnsureEqual<T>(this TraitDescriptor descriptor, T value, T required, UnityAction<T> setter, string fieldName = null) {
            if (!value.Equals(required)) {
                descriptor.CreateValueNotEqualProblem(value, required, fieldName)
                    .WithSolution($"Set {fieldName} to {required}", () => {
                        setter(required);
                    });

            }
        }
        public static void EnsureIsAnyOf<T>(this TraitDescriptor descriptor, T value, UnityAction<T> setter, string fieldName = null, params T[] required) {
            if (!required.Contains(value)) {
                var p = descriptor.AddProblem($"{fieldName ?? "Value "} {value} is not one of: {string.Join(", ", required)}");
                foreach (var r in required) {
                    p.WithSolution($"Set {fieldName} to {r}", () => {
                        setter(r);
                    });
                }
            }
        }
    }
}