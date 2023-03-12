using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrueMuromez.Models;

namespace TrueMuromez.ViewModels
{
    public class ProductViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        //public IEnumerable<Content> Contents { get; set; }
    }
}
