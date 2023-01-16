using Projekt1.CONTROLLER;
using Projekt1.CONTROLLER.Calculator;
using Projekt1.CONTROLLER.Shapes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1
{
    public class App
    {
        public void Run() 
        {
            var newBuilder = new Builder();
            var DbContext = newBuilder.Build();

            try
            {
                while (true)
                {
                    var selectionOf = Menu.MainMenu();

                    switch (selectionOf)
                    {

                        case 1:
                            var menuS = new sMenu(DbContext);
                            menuS.Run();
                            break;
                        case 2:
                            var menuC = new cMenu(DbContext);
                            menuC.Run();
                            break;

                        default:
                            break;

                    }

                }
            }
            catch (Exception)
            {
                Console.WriteLine("\nINVALID INPUT");
                Console.ReadLine();
            }
        }
    }
}
