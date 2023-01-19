using Projekt1.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1.CONTROLLER.Shapes
{
    public class sMenu : Interfacial
    {
        public ApplicationDbContext DbContext { get; set; } 
        public sMenu(ApplicationDbContext db)
        {
            DbContext = db;
        }

        public void Run()
        {
            var newBuilder = new Builder();
            var DbContext= newBuilder.Build();

            while (true)
            {
                try
                {
                   
                    Console.Clear();
                    Console.WriteLine(" SHAPE MENU ");

                    Console.WriteLine("\n1. Calculate Area & Perimeter");
                    Console.WriteLine("2. See all shapes");
                    Console.WriteLine("3. Update");
                    Console.WriteLine("4. Delete");
                    Console.WriteLine("\n0. Exit");

                    var selectionOf = Convert.ToInt32(Console.ReadLine());
                    if (selectionOf < 1 || selectionOf > 4)
                    {
                        break;
                    }

                    switch (selectionOf)
                    {
                        case 1:
                            var selectionCC = new CalculationMenu(DbContext);
                            selectionCC.Run();
                            break;
                        case 2:
                            var selectionR = new SeeShapes(DbContext);
                            selectionR.Run();
                            break;
                        case 3:
                            var selectionU = new UpdateShapes(DbContext);
                            selectionU.Run();
                            break;
                        case 4:
                            var selectionD = new DeleteShape(DbContext);
                            selectionD.Run();
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
