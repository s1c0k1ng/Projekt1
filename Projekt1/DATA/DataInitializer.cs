using Microsoft.EntityFrameworkCore;
using Projekt1.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1.DATA
{
    public class DataInitializer
    {
        public void MigrateAndSeed(ApplicationDbContext dbContext)
        {
            dbContext.Database.Migrate();
            ShapeSeed(dbContext);
            CalculatorSeed(dbContext);
            dbContext.SaveChanges();
        }

        public void ShapeSeed(ApplicationDbContext dbContext)
        {
            if (!dbContext.Shapes.Any(s => s.ShapeID == 1))
            {
                dbContext.Shapes.Add(new Shape
                {
                    Type = "rectangle",
                    Area = 10,
                    Perimeter = 12,
                    Date = DateTime.UtcNow

                });
                
            }
           
            if (!dbContext.Shapes.Any(s => s.ShapeID == 2))
            {
                dbContext.Shapes.Add(new Shape
                {
                    Type = "parallellogram",
                    Area = 4,
                    Perimeter = 8,
                   Date = DateTime.UtcNow
                });
            }

            if (!dbContext.Shapes.Any(s => s.ShapeID == 3))
            {
                dbContext.Shapes.Add(new Shape
                {
                    Type = "triangle",
                    Area = 13,
                    Perimeter = 5,
                    Date = DateTime.UtcNow
                });
            }

            if (!dbContext.Shapes.Any(s => s.ShapeID == 4))
            {
                dbContext.Shapes.Add(new Shape
                {
                   
                    Type = "diamond",
                    Area = 9,
                    Perimeter = 18,
                    Date = DateTime.UtcNow

                });
            }

            if (!dbContext.Shapes.Any(s => s.ShapeID == 5))
            {
                dbContext.Shapes.Add(new Shape
                {
                    
                    Type = "circle",
                    Area = 22,
                    Perimeter = 24,
                    Date = DateTime.UtcNow
                    
                    

                });
            }
        }

        public void CalculatorSeed(ApplicationDbContext dbContext)
        {
            
            dbContext.Calculators.Any(c => c.CalculatorID == 1);
            dbContext.Calculators.Any(c => c.CalculatorID == 2);
            dbContext.Calculators.Any(c => c.CalculatorID == 3);
            dbContext.Calculators.Any(c => c.CalculatorID == 4);
            dbContext.Calculators.Any(c => c.CalculatorID == 5);
            dbContext.Calculators.Any(c => c.CalculatorID == 6);
            

        }

    }
}

