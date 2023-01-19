using Projekt1.DATA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1.CONTROLLER.Calculator
{
    public class UpdateResult : Interfacial
    {
        public ApplicationDbContext DbContext { get; set; }
        public UpdateResult(ApplicationDbContext db)
        {
            DbContext = db;
        }
        public void Run()
        {
            Console.Clear();
            
            Console.WriteLine("\nUPDATE RESULTS");
          
            while (true)
            {

                foreach (var result in DbContext.Calculators)
                {   
                    Console.WriteLine($"\nID: {result.CalculatorID}");
                    Console.WriteLine($"Method: {result.CalculationMethod}");
                    Console.WriteLine($"Result: {result.Sum}");
                    Console.WriteLine($"Result (Square of nr2): {result.Sum2}");
                }
              
                try
                {
                    double newSumOf, newDifOf, newProdOf, newQuotOf, newRootOf, newRootOf2, newRemainOf, newNumber1, newNumber2;
                    var dateNow = DateTime.UtcNow;

                    Console.WriteLine("\nChoose an ID to update: ");
                    var resultID = Convert.ToInt32(Console.ReadLine());
                    var resultUpdate = DbContext.Calculators.First(r => r.CalculatorID  == resultID);


                    Console.WriteLine("\nType in new number: ");
                    newNumber1 = Convert.ToDouble(Console.ReadLine());
                       

                    Console.WriteLine("\nType in second new number: ");
                    newNumber2 = Convert.ToDouble(Console.ReadLine());
                    


                    Console.WriteLine("\n\tChoose a method:");

                    Console.WriteLine("\n1. Addition +");
                    Console.WriteLine("2. Subtraction -");
                    Console.WriteLine("3. Multiplication *");
                    Console.WriteLine("4. Division /");
                    Console.WriteLine("5. Square root of √");
                    Console.WriteLine("6. Modulus %");
                    Console.WriteLine("\n0. Exit");

                    var selectionOf = Convert.ToInt32(Console.ReadLine());
                    if (selectionOf < 1 || selectionOf > 6)
                    {
                         break;
                    }

                    if (selectionOf == 1)
                    {
                        Console.Clear();
                        newSumOf = newNumber1 + newNumber2;

                        Console.WriteLine($"\nSum of {newNumber1} + {newNumber2} is: {Math.Round(newSumOf, 2)}");
                        Console.WriteLine($"\nDATE: {dateNow}");

                        resultUpdate.FirstNumb = newNumber1;
                        resultUpdate.SecondNumb = newNumber2;
                        resultUpdate.Sum = Math.Round(newSumOf, 2);
                        resultUpdate.Date = dateNow;

                        DbContext.SaveChanges();
                        
                        Console.WriteLine("DONE");
                        Console.ReadLine();
                        break;

                    }
                    if (selectionOf == 2)
                    {
                        Console.Clear();
                        newDifOf = newNumber1 - newNumber2;

                        Console.WriteLine($"\nDif of {newNumber1} - {newNumber2} is: {Math.Round(newDifOf, 2)}");
                        Console.WriteLine($"\nDATE: {dateNow}");

                        resultUpdate.FirstNumb = newNumber1;
                        resultUpdate.SecondNumb = newNumber2;
                        resultUpdate.Sum = Math.Round(newDifOf, 2);
                        resultUpdate.Date = dateNow;

                        DbContext.SaveChanges();

                        Console.WriteLine("DONE");
                        Console.ReadLine();
                        break;
                    }
                    if (selectionOf == 3)
                    {
                        Console.Clear();
                        newProdOf = newNumber1 * newNumber2;

                        Console.WriteLine($"\nProd of {newNumber1} * {newNumber2} is: {Math.Round(newProdOf, 2)}");
                        Console.WriteLine($"\nDATE: {dateNow}");

                        resultUpdate.FirstNumb = newNumber1;
                        resultUpdate.SecondNumb = newNumber2;
                        resultUpdate.Sum = Math.Round(newProdOf, 2);
                        resultUpdate.Date = dateNow;

                        DbContext.SaveChanges();

                        Console.WriteLine("DONE");
                        Console.ReadLine();
                        break;
                    }
                    if (selectionOf == 4)
                    {
                        Console.Clear();
                        newQuotOf = newNumber1 / newNumber2;

                        Console.WriteLine($"\nQuotient of {newNumber1} / {newNumber2} is: {Math.Round(newQuotOf, 2)}");
                        Console.WriteLine($"\nDATE: {dateNow}");

                        resultUpdate.FirstNumb = newNumber1;
                        resultUpdate.SecondNumb = newNumber2;
                        resultUpdate.Sum = Math.Round(newQuotOf, 2);
                        resultUpdate.Date = dateNow;

                        DbContext.SaveChanges();
                        
                        Console.WriteLine("DONE");
                        Console.ReadLine();
                        break;
                    }
                    if (selectionOf == 5)
                    {
                        Console.Clear();
                        
                        newRootOf = Math.Sqrt(newNumber1);
                        newRootOf2 = Math.Sqrt(newNumber2);
                        
                        Console.WriteLine($"\nSquare root of {newNumber1} is: {Math.Round(newRootOf, 2)}");
                        Console.WriteLine($"Square root of {newNumber2} is: {Math.Round(newRootOf2, 2)}");
                        Console.WriteLine($"\nDATE: {dateNow}");

                        resultUpdate.FirstNumb = newNumber1;
                        resultUpdate.SecondNumb = newNumber2;
                        resultUpdate.Sum = Math.Round(newRootOf, 2);
                        resultUpdate.Sum2 = Math.Round(newRootOf2, 2);
                        resultUpdate.Date = dateNow;

                        DbContext.SaveChanges();
                        
                        Console.WriteLine("DONE");
                        Console.ReadLine();
                        break;
                    }
                    if (selectionOf == 6)
                    {
                        Console.Clear();

                        newRemainOf = newNumber1 % newNumber2;
                        Console.WriteLine($"\nRemainder of {newNumber1} and {newNumber2} is: {Math.Round(newRemainOf, 2)}");
                        Console.WriteLine($"\nDATE: {dateNow}");

                        resultUpdate.FirstNumb = newNumber1;
                        resultUpdate.SecondNumb = newNumber2;
                        resultUpdate.Sum = Math.Round(newRemainOf, 2);
                        resultUpdate.Date = dateNow;

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
