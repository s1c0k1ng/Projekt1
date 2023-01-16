using Projekt1.DATA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1.CONTROLLER.Calculator
{
    internal class UpdateResult : Interfacial
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

            foreach (var result in DbContext.Calculators)
            {
                Console.WriteLine($"ID: {result.CalculatorID}");
                Console.WriteLine($"Method: {result.CalculationMethod}");
                Console.WriteLine($"Result: {result.Sum}");
            }
            try
            {
                Console.WriteLine("Choose an ID to update: ");
                var resultID = Convert.ToInt32(Console.ReadLine());
                var resultUpdate = DbContext.Calculators.First(r => r.CalculatorID  == resultID);

                while (true)
                {
                    Console.Clear();
                    
                    double number1, number2, newSumOf, newDifOf, newProdOf, newQuotOf, newRootOf, newRootOf2, newRemainOf;
                    var dateNow = DateTime.Today;

                    Console.WriteLine("\nType in new number: ");
                    number1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("\nType in second new number: ");
                    number2 = Convert.ToDouble(Console.ReadLine());


                    Console.WriteLine("\n\tChoose a method:");

                    Console.WriteLine("\n1. Addition +");
                    Console.WriteLine("2. Subtraction -");
                    Console.WriteLine("3. Multiplication *");
                    Console.WriteLine("4. Division /");
                    Console.WriteLine("5. Square root of √");
                    Console.WriteLine("6. Modulus %");
                    Console.WriteLine("\n0. Exit");

                    var selectionOf = Convert.ToInt32(Console.ReadLine());

                    if (selectionOf == 1)
                    {
                        Console.Clear();
                        newSumOf = number1 + number2;

                        Console.WriteLine($"\nSum of {number1} + {number2} is: {Math.Round(newSumOf, 2)}");
                        Console.WriteLine($"\nDATE: {dateNow}");

                        resultUpdate.Sum = newSumOf;
                        resultUpdate.Date = dateNow;

                        DbContext.SaveChanges();
                        
                        Console.WriteLine("DONE");
                        Console.ReadLine();

                    }
                    if (selectionOf == 2)
                    {
                        Console.Clear();
                        newDifOf = number1 - number2;

                        Console.WriteLine($"\nDif of {number1} - {number2} is: {Math.Round(newDifOf, 2)}");
                        Console.WriteLine($"\nDATE: {dateNow}");

                        resultUpdate.Sum = newDifOf;
                        resultUpdate.Date = dateNow;

                        DbContext.SaveChanges();

                        Console.WriteLine("DONE");
                        Console.ReadLine();
                    }
                    if (selectionOf == 3)
                    {
                        Console.Clear();
                        newProdOf = number1 * number2;

                        Console.WriteLine($"\nProd of {number1} * {number2} is: {Math.Round(newProdOf, 2)}");
                        Console.WriteLine($"\nDATE: {dateNow}");

                        resultUpdate.Sum = newProdOf;
                        resultUpdate.Date = dateNow;

                        DbContext.SaveChanges();

                        Console.WriteLine("DONE");
                        Console.ReadLine();
                    }
                    if (selectionOf == 4)
                    {
                        Console.Clear();
                        newQuotOf = number1 / number2;

                        Console.WriteLine($"\nQuotient of {number1} / {number2} is: {Math.Round(newQuotOf, 2)}");
                        Console.WriteLine($"\nDATE: {dateNow}");

                        resultUpdate.Sum = newQuotOf;
                        resultUpdate.Date = dateNow;

                        DbContext.SaveChanges();
                        Console.WriteLine("DONE");
                        Console.ReadLine();
                    }
                    if (selectionOf == 5)
                    {
                        Console.Clear();
                        
                        newRootOf = Math.Sqrt(number1);
                        newRootOf2 = Math.Sqrt(number2);
                        
                        Console.WriteLine($"\nSquare root of {number1} is: {Math.Round(newRootOf, 2)}");
                        Console.WriteLine($"Square root of {number2} is: {Math.Round(newRootOf2, 2)}");
                        Console.WriteLine($"\nDATE: {dateNow}");

                        resultUpdate.Sum = newRootOf;
                        resultUpdate.Sum = newRootOf2;
                        resultUpdate.Date = dateNow;

                        DbContext.SaveChanges();
                        Console.WriteLine("DONE");
                        Console.ReadLine();
                    }
                    if (selectionOf == 6)
                    {
                        Console.Clear();

                        newRemainOf = number1 % number2;
                        Console.WriteLine($"\nRemainder of {number1} and {number2} is: {Math.Round(newRemainOf, 2)}");
                        Console.WriteLine($"\nDATE: {dateNow}");

                        resultUpdate.Sum = newRemainOf;
                        resultUpdate.Date = dateNow;

                        DbContext.SaveChanges();
                        Console.WriteLine("DONE");
                        Console.ReadLine();
                    }
                    
                    else if (selectionOf == 0) break;

                }
            }
            catch (Exception)
            {
                Console.WriteLine("\nINVALID INPUT GOING BACK TO MAIN MENU");
                Console.ReadLine();
            }
        }
    }
}
