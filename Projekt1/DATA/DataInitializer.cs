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
                    Type = "rectangle"
                    
                });
            }
           
            if (!dbContext.Shapes.Any(s => s.ShapeID == 2))
            {
                dbContext.Shapes.Add(new Shape
                {
                    Type = "parallellogram"
                   
                });
            }

            if (!dbContext.Shapes.Any(s => s.ShapeID == 3))
            {
                dbContext.Shapes.Add(new Shape
                {
                    Type = "triangle"
                });
            }

            if (!dbContext.Shapes.Any(s => s.ShapeID == 4))
            {
                dbContext.Shapes.Add(new Shape
                {
                   
                    Type = "diamond"
               
                });
            }

            if (!dbContext.Shapes.Any(s => s.ShapeID == 5))
            {
                dbContext.Shapes.Add(new Shape
                {
                    
                    Type = "circle"

                });
            }
        }

        public void CalculatorSeed(ApplicationDbContext dbContext)
        {
            if (!dbContext.Calculators.Any(c => c.CalculatorID == 1))
            {
                dbContext.Calculators.Add(new Calculator
                {
                    CalculationMethod = "addition"

                });
            }
            if (!dbContext.Calculators.Any(c => c.CalculatorID == 2))
            {
                dbContext.Calculators.Add(new Calculator
                {
                    CalculationMethod = "substraction"

                });
            }
            if (!dbContext.Calculators.Any(c => c.CalculatorID == 3))
            {
                dbContext.Calculators.Add(new Calculator
                {
                    CalculationMethod = "multiplication"

                });
            }
            if (!dbContext.Calculators.Any(c => c.CalculatorID == 4))
            {
                dbContext.Calculators.Add(new Calculator
                {
                    CalculationMethod = "division"

                });
            }
            if (!dbContext.Calculators.Any(c => c.CalculatorID == 5))
            {
                dbContext.Calculators.Add(new Calculator
                {
                    CalculationMethod = "square root"

                });
            }
            if (!dbContext.Calculators.Any(c => c.CalculatorID == 6))
            {
                dbContext.Calculators.Add(new Calculator
                {
                    CalculationMethod = "modulus"

                });
            }

        }



    }
}

