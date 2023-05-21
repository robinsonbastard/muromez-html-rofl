using System.Collections.Generic;

namespace TrueMuromez.Models
{
    public class TrainingCategory
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<Training> Trainings { get; set; }
    }
}
