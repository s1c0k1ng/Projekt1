using Microsoft.EntityFrameworkCore;
using Projekt1.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
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


            while (true)
            {

                try
                {
                    Console.WriteLine("\nChoose ID to udpdate: ");
                    var shapeO = Convert.ToInt32(Console.ReadLine());
                    var shapeUpdate = DbContext.Shapes.First(s => s.ShapeID == shapeO);

               

                    Console.WriteLine("\nChoose a shape to update:");
                    Console.WriteLine("1.Rectangle");
                    Console.WriteLine("2.Parallellogram");
                    Console.WriteLine("3.Triangle");
                    Console.WriteLine("4.Diamond");
                    Console.WriteLine("5.Cirlce");
                    Console.WriteLine("\n0. Exit");
                    var selectionOf = Convert.ToInt32(Console.ReadLine());
                    if (selectionOf < 1 || selectionOf > 5)
                    {
                        break;
                    }

                    if (selectionOf == 1)
                    {
                        Console.Clear();

                        var dateNow = DateTime.UtcNow;
                        double newLength, newWidth, newArea, newPerimeter;


                        Console.WriteLine("\nInput the lenght (cm): ");
                        newLength = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("\nInput witdth (cm): ");
                        newWidth = Convert.ToDouble(Console.ReadLine());

                        newArea = newLength * newWidth;
                        Console.WriteLine($"\nArea: {Math.Round(newArea, 2)} cm");

                        newPerimeter = 2 * (newLength * newWidth);
                        Console.WriteLine($"\nPerimeter: {Math.Round(newPerimeter, 2)} cm");
                        Console.WriteLine(dateNow);

                        shapeUpdate.Perimeter = newPerimeter;
                        shapeUpdate.Date = dateNow;
                        shapeUpdate.Area = newArea;
                        shapeUpdate.input1 = newLength;
                        shapeUpdate.input2 = newWidth;

                        DbContext.SaveChanges();
                       
                        Console.WriteLine("DONE");
                        Console.ReadLine();
                        break;
                    }

                    if (selectionOf == 2)
                    {
                        Console.Clear();

                        var dateNow = DateTime.UtcNow;
                        double newHight, newLength, newWidth, newArea, newPerimeter;

                        Console.WriteLine("\nInput the lenght (cm): ");
                        newLength = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("\nInput witdth (cm): ");
                        newWidth = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("\nInput hight (cm): ");
                        newHight = Convert.ToDouble(Console.ReadLine());

                        newArea = newHight * newWidth;
                        Console.WriteLine($"\nArea: {Math.Round(newArea, 2)} cm");

                        newPerimeter = (2 * newLength) + (2 * newHight);
                        Console.WriteLine($"\nPerimeter: {Math.Round(newPerimeter, 2)} cm");
                        Console.WriteLine(dateNow);

                        shapeUpdate.input1 = newLength;
                        shapeUpdate.input2 = newWidth;
                        shapeUpdate.input3 = newHight;
                        shapeUpdate.Date = dateNow;
                        shapeUpdate.Area = newArea;
                        shapeUpdate.Perimeter = newPerimeter;


                        DbContext.SaveChanges();
                       
                        Console.WriteLine("DONE");
                        Console.ReadLine();
                        break;
                    }

                    if (selectionOf == 3)
                    {
                        Console.Clear();

                        var dateNow = DateTime.UtcNow;
                        double newHight, newLength, newWidth, newArea, newPerimeter, newSide1, newSide2, newSide3;

                        Console.WriteLine("\nInput side 1 (cm): ");
                        newSide1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Input side 2 (cm): ");
                        newSide2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Input side 3 (cm): ");
                        newSide3 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("\nInput witdth (cm): ");
                        newWidth = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("\nInput hight (cm): ");
                        newHight = Convert.ToDouble(Console.ReadLine());

                        newArea = (newWidth * newHight) / 2;
                        Console.WriteLine($"\nArea: {Math.Round(newArea, 2)} cm");

                        newPerimeter = newSide1 + newSide2 + newSide3;
                        Console.WriteLine($"\nPerimeter: {Math.Round(newPerimeter, 2)} cm");

                        shapeUpdate.input1 = newSide1;
                        shapeUpdate.input2 = newSide2;
                        shapeUpdate.input3 = newSide3;
                        shapeUpdate.input4 = newWidth;
                        shapeUpdate.input5 = newHight;
                        shapeUpdate.Date = dateNow;
                        shapeUpdate.Area = newArea;
                        shapeUpdate.Perimeter = newPerimeter;


                        DbContext.SaveChanges();
                       
                        Console.WriteLine("DONE");
                        Console.ReadLine();
                        break;
                    }

                    if (selectionOf == 4)
                    {
                        Console.Clear();

                        var dateNow = DateTime.UtcNow;
                        double newHight, newSideLength, newArea, newPerimeter;



                        Console.WriteLine("\nInput the side lenght (cm): ");
                        newSideLength = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("\nInput hight (cm): ");
                        newHight = Convert.ToDouble(Console.ReadLine());

                        newArea = newHight * newSideLength;
                        Console.WriteLine($"\nArea: {Math.Round(newArea, 2)} cm");

                        newPerimeter = 4 * newSideLength;
                        Console.WriteLine($"\nPerimeter: {Math.Round(newPerimeter, 2)} cm");
                        Console.WriteLine(dateNow);

                        shapeUpdate.input1 = newSideLength;
                        shapeUpdate.input2 = newHight;
                        shapeUpdate.Date = dateNow;
                        shapeUpdate.Area = newArea;
                        shapeUpdate.Perimeter = newPerimeter;

                        DbContext.SaveChanges();
                       
                        Console.WriteLine("DONE");
                        Console.ReadLine();
                        break;

                    }

                    if (selectionOf == 5)
                    {
                        Console.Clear();


                        var dateNow = DateTime.UtcNow;
                        double newRadius, newPerimeterCircle, newAreaCircle;
                        double PI = Math.PI;

                        Console.WriteLine("\nInput the radius of the circle (cm): ");
                        newRadius = Convert.ToDouble(Console.ReadLine());

                        newPerimeterCircle = 2 * PI * newRadius;
                        Console.WriteLine($"\nPerimeter: {Math.Round(newPerimeterCircle, 2)} cm");

                        newAreaCircle = PI * newRadius * newRadius;
                        Console.WriteLine($"\nArea: {Math.Round(newAreaCircle, 2)} cm");
                        Console.WriteLine(dateNow);

                        shapeUpdate.input1 = newRadius;
                        shapeUpdate.Date = dateNow;
                        shapeUpdate.Area = newAreaCircle;
                        shapeUpdate.Perimeter = newPerimeterCircle;

                        DbContext.SaveChanges();
                        
                        Console.WriteLine("DONE");
                        Console.ReadLine();
                        break;
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("\nINVALID INPUT");
                    Console.ReadLine();
                    continue;
                }
            }
            
        }
  
    }
}
 

