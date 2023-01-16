using Projekt1.CONTROLLER.Shapes;
using Projekt1.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1.CONTROLLER.Calculator
{
    public class cMenu : Interfacial
    {
        public ApplicationDbContext DbContext { get; set; }
        public cMenu(ApplicationDbContext db)
        {
            DbContext = db;
        }

        public void Run()
        {
            var newBuilder = new Builder();
            var DbContext = newBuilder.Build();

            try
            {
                while (true)
                {
                    Console.Clear();
                   
                    Console.WriteLine("\tCALCULATOR MENU ");
                    Console.WriteLine("\n1. New Calculation");
                    Console.WriteLine("2. See Results");
                    Console.WriteLine("3. Update");
                    Console.WriteLine("4. Delete");
                    Console.WriteLine("\n0. Exit");

                    var selectionOf = Convert.ToInt32(Console.ReadLine());

                    switch (selectionOf)
                    {
                        case 1:
                            var selectionCM = new newCalculationM(DbContext);
                            selectionCM.Run();
                            break;
                        case 2:
                            var selectionSR = new SeeResults(DbContext);
                            selectionSR.Run();
                            break;
                        case 3:
                            var selectionUR = new UpdateResult(DbContext);
                            selectionUR.Run();
                            break;
                        case 4:
                            var selectionDR = new DeleteResult(DbContext);
                            selectionDR.Run();
                            break;
                        
                        default: break;
                               
                    }
                    break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("INVALID INPUT GOING BACK TO MAIN MENU");
                Console.ReadLine();
            }
        }
    }
}
