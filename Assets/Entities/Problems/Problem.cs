using System;
namespace Lunari.Tsuki.Entities.Problems {

    public class Solution {
        public Solution(string description, Action solution) {
            Description = description;
            Action = solution;
        }

        public string Description {
            get;
        }

        public Action Action {
            get;
        }

    }
    public class Problem {

        public Problem(Trait requisitor, Entity entity, string description, Solution solution = null) {
            Requisitor = requisitor;
            Entity = entity;
            Description = description;
            Solution = solution;
        }
        protected void WithSolution(string description, Action solution) {
            Solution = new Solution(description, solution);
        }


        public Solution Solution {
            get;
            private set;
        }

        public Trait Requisitor {
            get;
        }

        public Entity Entity {
            get;
        }

        public string Description {
            get;
        }
    }
}