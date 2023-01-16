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

            foreach (var answers in DbContext.Calculators)
            {

                Console.WriteLine($"ID: {answers.CalculatorID}");
                Console.WriteLine($"Method: {answers.CalculationMethod}");
                Console.WriteLine($"Results: {answers.Sum}");

            }

            Console.WriteLine("\n Press to Exit");
            Console.ReadLine();
        }
    }
}
