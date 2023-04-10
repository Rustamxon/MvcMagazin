using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMagazin.Models;

namespace MvcMagazin.Data
{
    public class MvcMagazinContext : DbContext
    {
        public MvcMagazinContext (DbContextOptions<MvcMagazinContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Product { get; set; } = default!;
    }
}
