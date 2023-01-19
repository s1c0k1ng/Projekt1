using Projekt1.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1.CONTROLLER.Shapes.ShapeCalculation
{
    public class Triangle : Interfacial
    {
        public ApplicationDbContext dbContext { get; set; }
        public Triangle(ApplicationDbContext db)
        {
            dbContext = db;
        }
       
        public void Run()
        {
            try
            {

                Console.Clear();

                var dateNow = DateTime.UtcNow;
                double hight, side1, side2, side3, width, area, perimeter;

                Console.WriteLine("\tTRIANGLE");
                var shapeName = "triangle";

                Console.WriteLine("\nInput side 1 (cm): ");
                side1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Input side 2 (cm): ");
                side2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Input side 3 (cm): ");
                side3 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("\nInput witdth (cm): ");
                width = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("\nInput hight (cm): ");
                hight = Convert.ToDouble(Console.ReadLine());


                Console.WriteLine("\nRESULT");
                area = (width * hight) / 2;
                Console.WriteLine($"\nArea: {Math.Round(area, 2)} cm");

                perimeter = side1 + side2 + side3;
                Console.WriteLine($"\nPerimeter: {Math.Round(perimeter, 2)} cm");
                Console.WriteLine($"\n{dateNow}");

                dbContext.Shapes.Add(new Shape
                {
                    input1 = side1,
                    input2 = side2,
                    input3 = side3,
                    input4 = width,
                    input5 = hight,
                    Date = dateNow,
                    Type = shapeName,
                    Area = Math.Round(area, 2),
                    Perimeter = Math.Round(perimeter, 2)
                });

                dbContext.SaveChanges();

                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("INVALID INPUT GOING BACK TO MAIN MENU");
                Console.ReadLine();
            }
        }
    }
}
