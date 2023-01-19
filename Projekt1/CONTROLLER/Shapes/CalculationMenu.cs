using Microsoft.EntityFrameworkCore;
using Projekt1.CONTROLLER.Shapes.ShapeCalculation;
using Projekt1.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1.CONTROLLER.Shapes
{
    public class CalculationMenu : Interfacial
    {
        public ApplicationDbContext dbContext { get; set; }
        public CalculationMenu(ApplicationDbContext db)
        {
            dbContext = db;
        }

        public void Run()
        {
            var newBuilder = new Builder();
            var DbContext = newBuilder.Build();

            while (true)
            {
                try
                {
                    Console.Clear();

                    Console.WriteLine(" Choose a Shape ");
                    Console.WriteLine("\n1. Rectangle");
                    Console.WriteLine("2. Parallelogram");
                    Console.WriteLine("3. Triangle");
                    Console.WriteLine("4. Diamond");
                    Console.WriteLine("5. Circle");
                    Console.WriteLine("6. Go back to Shape Menu");
                    Console.WriteLine("\n0. Exit");

                    var selectionOf = Convert.ToInt32(Console.ReadLine());
                    if (selectionOf < 1 || selectionOf > 6)
                    {
                         break;
                    }

                    switch (selectionOf)
                    {
                        case 1:
                            var selectionRec = new Rectangle(DbContext);
                            selectionRec.Run();
                            break;
                        case 2:
                            var selectionPar = new Parallellogram(DbContext);
                            selectionPar.Run();
                            break;
                        case 3:
                            var selectionTri = new Triangle(DbContext);
                            selectionTri.Run();
                            break;
                        case 4:
                            var selectionDia = new Diamond(DbContext);
                            selectionDia.Run();
                            break;
                        case 5:
                            var selectionCir = new Circle(DbContext);
                            selectionCir.Run();
                            break;

                        case 6:
                            var selectionMen = new sMenu(DbContext);
                            selectionMen.Run();
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

