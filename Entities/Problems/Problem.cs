namespace Lunari.Tsuki.Entities.Problems {


    public class Problem {

        public Problem(Trait requisitor, Entity entity, string description) {
            Requisitor = requisitor;
            Entity = entity;
            Description = description;
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