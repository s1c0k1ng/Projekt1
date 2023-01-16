using Projekt1.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1.CONTROLLER.Shapes.ShapeCalculation
{
    internal class Diamond : Interfacial
    {
        public ApplicationDbContext dbContext { get; set; }
        public Diamond(ApplicationDbContext db)
        {
            dbContext = db;
        }
        public void Run()
        {
            try
            {

                Console.Clear();

                var dateNow = DateTime.Today;
                double hight, sideLength, area, perimeter;

                Console.WriteLine("\tDIAMOND");
                var shapeName = "diamond";

                Console.WriteLine("\nInput the side lenght (cm): ");
                sideLength = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("\nInput hight (cm): ");
                hight = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("\nRESULT");
                area = hight * sideLength;
                Console.WriteLine($"\nArea: {Math.Round(area, 2)} cm");

                perimeter = 4 * sideLength;
                Console.WriteLine($"\nPerimeter: {Math.Round(perimeter, 2)} cm");
                Console.WriteLine($"(\n{dateNow}");


                dbContext.Shapes.Add(new Shape
                {
                    Date = dateNow,
                    Type = shapeName,
                    Area = area,
                    Perimeter = perimeter

                });

                dbContext.SaveChanges();

                Console.ReadLine();
            }
            catch(Exception) 
            {
                Console.WriteLine("INVALID INPUT GOING BACK TO MAIN MENU");
                Console.ReadLine();
            }
        }
    }
}
