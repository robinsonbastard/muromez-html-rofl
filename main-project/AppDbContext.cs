using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using TrueMuromez.Models;

namespace TrueMuromez
{
    public class AppDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public Microsoft.EntityFrameworkCore.DbSet<Product> Product { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Training> Training { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<ProductContent> ProductContent { get; set; }
    }
}
