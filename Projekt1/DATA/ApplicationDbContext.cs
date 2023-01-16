using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1.DATA
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Shape> Shapes { get; set; } 

        public DbSet<Calculator> Calculators { get; set; }

        public ApplicationDbContext()
        {

        }
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=.;Database=Projekt1;Trusted_Connection=True;TrustServerCertificate=true;");
            }
        }
    }
}
