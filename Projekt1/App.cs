using Projekt1.CONTROLLER;
using Projekt1.CONTROLLER.Calculator;
using Projekt1.CONTROLLER.Game;
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

            
            while (true)
            {
                try
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
                        
                        case 3:
                            var game = new NewGame(DbContext);
                            game.Run();
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
