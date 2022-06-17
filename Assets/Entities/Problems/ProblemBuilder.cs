using System;
namespace Lunari.Tsuki.Entities.Problems {
    public class ProblemBuilder {
        private TraitDescriptor descriptor;
        public ProblemBuilder(TraitDescriptor descriptor, string description) {
            this.descriptor = descriptor;
            Problem = new Problem(descriptor.Of, descriptor.Entity, description);
        }

        public Problem Problem { get; }

        public ProblemBuilder WithSolution(Solution solution) {
            Problem.WithSolution(solution);
            return this;
        }
        public ProblemBuilder WithSolution(string description, Action solution) {
            Problem.WithSolution(description, solution);
            return this;
        }
    }
}