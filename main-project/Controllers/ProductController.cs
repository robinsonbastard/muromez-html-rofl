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
    public class ProductController : Controller
    {
        private IGenericRepos<Product> _productRepos;

        public ProductController(IGenericRepos<Product> productRepos)
        {
            _productRepos = productRepos;
        }

        public ActionResult ProductView()
        {
            var prodModel = new ProductViewModel
            {
                Products = _productRepos.GetWithInclude(c => c.Contents)
                              
            };

            return View(prodModel);
        }
    }
}
