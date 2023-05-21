using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TrueMuromez.Interfaces;
using TrueMuromez.Models;
using TrueMuromez.ViewModels;

namespace TrueMuromez.Controllers
{
    public class TrainingController : Controller
    {
        private IGenericRepos<Training> _trainingRepos;
        private IGenericRepos<TrainingCategory> _trainingCategoryRepos;

        public TrainingController(IGenericRepos<Training> training, IGenericRepos<TrainingCategory> trainingCategoryRepos)
        {
            _trainingRepos = training;
            _trainingCategoryRepos = trainingCategoryRepos;
        }

        public ActionResult TrainingView()
        {
            var trainMod = new TrainingViewModel
            {
                Trainings = _trainingRepos.GetWithInclude(g => g.TrainingContents, h => h.TrainingCategory),
                TrainingCategories = _trainingCategoryRepos.GetAll()
              
            };

            return View(trainMod);
        }
    }
}
