using Projekt1.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1.CONTROLLER.Calculator
{
    public class DeleteResult : Interfacial
    {
        public ApplicationDbContext DbContext { get; set; }

        public DeleteResult(ApplicationDbContext db)
        {
            DbContext = db;
        }
        public void Run()
        {
            Console.Clear();
            Console.WriteLine("\tDELETE A RESULT");

            foreach (var result in DbContext.Calculators)
            {
                Console.WriteLine($"\nID: {result.CalculatorID}");
                Console.WriteLine($"Method: {result.CalculationMethod}");
                Console.WriteLine($"Result: {result.Sum}");
                Console.WriteLine($"Result(Square root nr.2): {result.Sum2}");
            }
           
            
            try
            {
                Console.WriteLine("Choose ID to delete: ");
                var resultID = Convert.ToInt32(Console.ReadLine());
                var resultDelete = DbContext.Calculators.First(r => r.CalculatorID == resultID);
                DbContext.Calculators.Remove(resultDelete);

                DbContext.SaveChanges();
                Console.WriteLine("DONE");
                Console.ReadLine();

            }
            catch (Exception)
            {
                Console.WriteLine("\nINVALID INPUT");
                Console.ReadLine();
            }


        }
    }
}
