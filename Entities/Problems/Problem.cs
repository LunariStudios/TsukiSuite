using System;
using System.Collections.Generic;
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
            Solutions = new List<Solution>();
            if (solution != null) {
                WithSolution(solution);
            }
        }
        public  void WithSolution(Solution description) {
            Solutions.Add(description);
        }
        public void WithSolution(string description, Action solution) {
            WithSolution(new Solution(description, solution));
        }


        public List<Solution> Solutions {
            get;
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