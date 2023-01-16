using Microsoft.EntityFrameworkCore;
using Projekt1.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1.CONTROLLER.Shapes
{
    public class UpdateShapes : Interfacial
    {
        public ApplicationDbContext DbContext { get; set; }
        public UpdateShapes(ApplicationDbContext db)
        {
            DbContext = db;
        }

        public void Run()
        {
            Console.Clear();
            Console.WriteLine("\tUPDATE EXISTING CALCULATION ");

            foreach (var shape in DbContext.Shapes)
            {
                Console.WriteLine($"\nID:{shape.ShapeID}");
                Console.WriteLine($"Shape:{shape.Type}");
                Console.WriteLine($"Area: {shape.Area} cm");
                Console.WriteLine($"Perimeter: {shape.Perimeter} cm");
            }

            try
            {
                Console.WriteLine("\nChoose ID to udpdate: ");
                var shapeO = Convert.ToInt32(Console.ReadLine());
                var shapeUpdate = DbContext.Shapes.First(s => s.ShapeID == shapeO);

                while (true)
                {

                    Console.WriteLine("\nChoose a shape to update:");
                    Console.WriteLine("1.Rectangle");
                    Console.WriteLine("2.Parallellogram");
                    Console.WriteLine("3.Triangle");
                    Console.WriteLine("4.Diamond");
                    Console.WriteLine("5.Cirlce");
                    Console.WriteLine("\n0. Exit");
                    var selectionOf = Convert.ToInt32(Console.ReadLine());

                    if (selectionOf == 1)
                    {
                        Console.Clear();

                        var dateNow = DateTime.Today;
                        double length, width, newArea, newPerimeter;


                        Console.WriteLine("\nInput the lenght (cm): ");
                        length = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("\nInput witdth (cm): ");
                        width = Convert.ToDouble(Console.ReadLine());

                        newArea = length * width;
                        Console.WriteLine($"\nArea: {Math.Round(newArea, 2)} cm");

                        newPerimeter = 2 * (length * width);
                        Console.WriteLine($"\nPerimeter: {Math.Round(newPerimeter, 2)} cm");
                        Console.WriteLine(dateNow);

                        shapeUpdate.Perimeter = newPerimeter;
                        shapeUpdate.Date = dateNow;
                        shapeUpdate.Area = newArea;

                        DbContext.SaveChanges();
                        Console.WriteLine("DONE");
                        Console.ReadLine();
                    }

                    if (selectionOf == 2)
                    {
                        Console.Clear();

                        var dateNow = DateTime.Today;
                        double hight, length, width, newArea, newPerimeter;

                        Console.WriteLine("\nInput the lenght (cm): ");
                        length = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("\nInput witdth (cm): ");
                        width = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("\nInput hight (cm): ");
                        hight = Convert.ToDouble(Console.ReadLine());

                        newArea = hight * width;
                        Console.WriteLine($"\nArea: {Math.Round(newArea, 2)} cm");

                        newPerimeter = (2 * length) + (2 * hight);
                        Console.WriteLine($"\nPerimeter: {Math.Round(newPerimeter, 2)} cm");
                        Console.WriteLine(dateNow);

                        shapeUpdate.Date = dateNow;
                        shapeUpdate.Area = newArea;
                        shapeUpdate.Perimeter = newPerimeter;


                        DbContext.SaveChanges();
                        Console.WriteLine("DONE");
                        Console.ReadLine();
                    }

                    if (selectionOf == 3)
                    {
                        Console.Clear();

                        var dateNow = DateTime.Today;
                        double hight, length, width, newArea, newPerimeter;

                        Console.WriteLine("\nInput the lenght (cm): ");
                        length = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("\nInput witdth (cm): ");
                        width = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("\nInput hight (cm): ");
                        hight = Convert.ToDouble(Console.ReadLine());

                        newArea = (width * hight) / 2;
                        Console.WriteLine($"\nArea: {Math.Round(newArea, 2)} cm");

                        newPerimeter = hight + length + width;
                        Console.WriteLine($"\nPerimeter: {Math.Round(newPerimeter, 2)} cm");

                        shapeUpdate.Date = dateNow;
                        shapeUpdate.Area = newArea;
                        shapeUpdate.Perimeter = newPerimeter;


                        DbContext.SaveChanges();
                        Console.WriteLine("DONE");
                        Console.ReadLine();
                    }

                    if (selectionOf == 4)
                    {
                        Console.Clear();

                        var dateNow = DateTime.Today;
                        double hight, sideLength, newArea, newPerimeter;



                        Console.WriteLine("\nInput the side lenght (cm): ");
                        sideLength = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("\nInput hight (cm): ");
                        hight = Convert.ToDouble(Console.ReadLine());

                        newArea = hight * sideLength;
                        Console.WriteLine($"\nArea: {Math.Round(newArea, 2)} cm");

                        newPerimeter = 4 * sideLength;
                        Console.WriteLine($"\nPerimeter: {Math.Round(newPerimeter, 2)} cm");
                        Console.WriteLine(dateNow);

                        shapeUpdate.Date = dateNow;
                        shapeUpdate.Area = newArea;
                        shapeUpdate.Perimeter = newPerimeter;

                        DbContext.SaveChanges();
                        Console.WriteLine("DONE");
                        Console.ReadLine();

                    }

                    if (selectionOf == 5)
                    {
                        Console.Clear();


                        var dateNow = DateTime.Today;
                        double radius, newPerimeterCircle, newAreaCircle;
                        double PI = Math.PI;

                        Console.WriteLine("\nInput the radius of the circle (cm): ");
                        radius = Convert.ToDouble(Console.ReadLine());

                        newPerimeterCircle = 2 * PI * radius;
                        Console.WriteLine($"\nPerimeter: {Math.Round(newPerimeterCircle, 2)} cm");

                        newAreaCircle = PI * radius * radius;
                        Console.WriteLine($"\nArea: {Math.Round(newAreaCircle, 2)} cm");
                        Console.WriteLine(dateNow);

                        shapeUpdate.Date = dateNow;
                        shapeUpdate.Area = newAreaCircle;
                        shapeUpdate.Perimeter = newPerimeterCircle;

                        DbContext.SaveChanges();
                        Console.WriteLine("DONE");
                        Console.ReadLine();
                    }

                    else if (selectionOf == 0) break;

                }
            }
            catch (Exception)
            {
                Console.WriteLine("\nINVALID INPUT GOING BACK TO MAIN MENU");
                Console.ReadLine();
            }
        }
  
    }
}
 

