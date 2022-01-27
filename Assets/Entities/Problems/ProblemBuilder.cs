using System;
namespace Lunari.Tsuki.Entities.Problems {
    public class ProblemBuilder {
        private TraitDescriptor descriptor;
        private Problem problem;
        public ProblemBuilder(TraitDescriptor descriptor, string description) {
            this.descriptor = descriptor;
            problem = new Problem(descriptor.Of, descriptor.Entity, description);
        }
        public ProblemBuilder WithSolution(Solution solution) {
            problem.WithSolution(solution);
            return this;
        }
        public ProblemBuilder WithSolution(string description, Action solution) {
            problem.WithSolution(description, solution);
            return this;
        }
    }
}