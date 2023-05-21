using System.Collections.Generic;
using TrueMuromez.Models;

namespace TrueMuromez.ViewModels
{
    public class TrainingViewModel
    {
        public IEnumerable<Training> Trainings { get; set; }
        public IEnumerable<TrainingCategory> TrainingCategories { get; set; }
    }
}
