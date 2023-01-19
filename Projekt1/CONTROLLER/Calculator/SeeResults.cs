using Projekt1.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1.CONTROLLER.Calculator
{
    public class SeeResults : Interfacial
    {
        public ApplicationDbContext DbContext { get; set; }
        public SeeResults(ApplicationDbContext db)
        {
            DbContext = db;
        }

        public void Run()
        {
            Console.Clear();

            Console.WriteLine("\tALL RESULTS ");

            
                foreach (var result in DbContext.Calculators)
                {
                    Console.WriteLine($"\nID: {result.CalculatorID}");
                    Console.WriteLine($"Method: {result.CalculationMethod}");
                    Console.WriteLine($"Results: {result.Sum}");
                    Console.WriteLine($"Result (Square of nr.2): {result.Sum2}");
                }
            

            Console.WriteLine("\n Press to Exit");
            Console.ReadLine();
        }
    }
}
