using Microsoft.EntityFrameworkCore;
using Projekt1.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Projekt1.CONTROLLER.Shapes.ShapeCalculation
{
    public class Circle : Interfacial
    {
        public ApplicationDbContext dbContext { get; set; }
        public Circle(ApplicationDbContext db)
        {
            dbContext = db;
        }
       
        public void Run()
        {
            try
            {

                Console.Clear();
                Console.WriteLine("\tCIRCLE");
                var shapeName = "circle";

                var dateNow = DateTime.Today;
                double radius, perimeterCircle, areaCircle;
                double PI = Math.PI;

                Console.WriteLine("\nInput the radius of the circle (cm): ");
                radius = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("\nRESULT");
                perimeterCircle = 2 * PI * radius;
                Console.WriteLine($"\nPerimeter: {Math.Round(perimeterCircle, 2)} cm");

                areaCircle = PI * radius * radius;
                Console.WriteLine($"\nArea: {Math.Round(areaCircle, 2)} cm");
                Console.WriteLine($"(\n{dateNow}");



                dbContext.Shapes.Add(new Shape
                {
                    Date = dateNow,
                    Type = shapeName,
                    Area = areaCircle,
                    Perimeter = perimeterCircle

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
