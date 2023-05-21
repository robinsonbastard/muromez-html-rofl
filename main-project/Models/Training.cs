using System.Collections.Generic;

namespace TrueMuromez.Models
{
    public class Training
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int TrainingCategoryID { get; set; }
        public TrainingCategory TrainingCategory { get; set; }
        public IEnumerable<TrainingContent> TrainingContents { get; set; }
    }
}
