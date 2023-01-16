using Projekt1.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1.CONTROLLER
{
    public  class Menu
    {
        public ApplicationDbContext DbContext { get; set; }

        public Menu(ApplicationDbContext db)
        {
            DbContext = db;
        }

        public static int MainMenu()
      
        {
            Console.Clear();

            Console.WriteLine("\n1. Shapes");
            Console.WriteLine("2. Calculator");

            var selectionOf = Convert.ToInt32(Console.ReadLine());

            return selectionOf;
        }
    }
}
