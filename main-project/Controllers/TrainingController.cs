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

        public TrainingController(IGenericRepos<Training> training)
        {
            _trainingRepos = training;
        }

        public ActionResult TrainingView()
        {
            var trainMod = new TrainingViewModel
            {
                Trainings = _trainingRepos.GetAll()
            };

            return View(trainMod);
        }
    }
}
