using Microsoft.EntityFrameworkCore;
using Projekt1.CONTROLLER.Calculator;
using Projekt1.CONTROLLER.Shapes;
using Projekt1.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1.CONTROLLER.Calculator
{
    public class newCalculationM : Interfacial
    {
        public ApplicationDbContext DbContext { get; set; }
        public newCalculationM(ApplicationDbContext db)
        {
            DbContext = db;
        }
       
        public void Run()
        {
            var newBuilder = new Builder();
            var DbContext = newBuilder.Build();

            
           while (true)
           {
                try
                {
                    Console.Clear();
                    
                    var dateNow = DateTime.UtcNow;
                    double number1, number2, sumOf, difOf, prodOf, quotOf, rootOf, rootOf2, remainOf;
                    
                    
                    Console.WriteLine("\tCALCULATE");
                    Console.WriteLine("\nType in first number: ");
                    number1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("\nType in second number: ");
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
                    if (selectionOf < 1 || selectionOf > 6)
                    {
                        break;
                    }

                    switch (selectionOf)
                    {
                        case 1:
                            Console.Clear();

                            Console.WriteLine("\tADDITION");
                            var methodName = "+";

                            sumOf = number1 + number2;

                            Console.WriteLine($"\nSum of {number1} + {number2} is: {Math.Round(sumOf, 2)}");
                            Console.WriteLine($"\nDATE: {dateNow}");

                            DbContext.Calculators.Add(new DATA.Calculator
                            {
                                CalculationMethod = methodName,
                                FirstNumb = number1,
                                SecondNumb = number2,
                                Sum = Math.Round(sumOf, 2),
                                Date = dateNow,
                            });
                           
                            DbContext.SaveChanges();

                            Console.ReadLine();
                            break; 

                        case 2:
                            Console.Clear();
                            Console.WriteLine("\tSUBSTRACTION");

                            var methodName2 = "-";

                            difOf = number1 - number2;
                            Console.WriteLine($"\nDiff of {number1} - {number2} is: {Math.Round(difOf, 2)}");
                            Console.WriteLine($"\nDATE: {dateNow}");

                            DbContext.Calculators.Add(new DATA.Calculator
                            {
                                CalculationMethod = methodName2,
                                FirstNumb = number1,
                                SecondNumb = number2,
                                Sum = Math.Round(difOf, 2),
                                Date = dateNow,
                            });

                            DbContext.SaveChanges();

                            Console.ReadLine();
                            break;
                            
                        case 3:
                            Console.Clear();
                            Console.WriteLine("\tMULTIPLICATION");

                            var methodName3 = "*";

                            prodOf = number1 * number2;
                            Console.WriteLine($"\nProduct of {number1} * {number2} is: {Math.Round(prodOf, 2)}");
                            Console.WriteLine($"\nDATE: {dateNow}");

                            DbContext.Calculators.Add(new DATA.Calculator
                            {
                                CalculationMethod = methodName3,
                                FirstNumb = number1,
                                SecondNumb = number2,
                                Sum = Math.Round(prodOf, 2),
                                Date = dateNow,
                            });

                            DbContext.SaveChanges();

                            Console.ReadLine();
                            break;
                        
                        case 4:
                            Console.Clear();
                            Console.WriteLine("\tDIVISION");

                            var methodName4 = "/";

                            quotOf = number1 / number2;
                            Console.WriteLine($"\nQuotient of {number1} / {number2} is: {Math.Round(quotOf, 2)}");
                            Console.WriteLine($"\nDATE: {dateNow}");

                            DbContext.Calculators.Add(new DATA.Calculator
                            {
                                CalculationMethod = methodName4,
                                FirstNumb = number1,
                                SecondNumb = number2,
                                Sum = Math.Round(quotOf, 2),
                                Date = dateNow,
                            });

                            DbContext.SaveChanges();
                           

                            Console.ReadLine();
                            break;
                        
                        case 5:
                            Console.Clear();
                            Console.WriteLine("\tSQUARE ROOT");

                            var methodName5 = "√";

                            rootOf = Math.Sqrt(number1);
                            rootOf2 = Math.Sqrt(number2);
                            Console.WriteLine($"\nSquare root of {number1} is: {Math.Round(rootOf, 2)}");
                            Console.WriteLine($"Square root of {number2} is: {Math.Round(rootOf2, 2)}");
                            Console.WriteLine($"\nDATE: {dateNow}");

                            DbContext.Calculators.Add(new DATA.Calculator
                            {
                                CalculationMethod = methodName5,
                                FirstNumb = number1,
                                SecondNumb = number2,
                                Sum = Math.Round(rootOf, 2),
                                Sum2= Math.Round(rootOf2, 2),
                                Date = dateNow,
                            });

                            DbContext.SaveChanges();

                            Console.ReadLine();
                            break;
                       
                        case 6:
                            Console.Clear();
                            Console.WriteLine("\tMODULUS");

                            var methodName6 = "%";

                            remainOf = number1 % number2;
                            
                            Console.WriteLine($"\nRemainder of {number1} and {number2} is: {Math.Round(remainOf, 2)}");
                            Console.WriteLine($"\nDATE: {dateNow}");

                            DbContext.Calculators.Add(new DATA.Calculator
                            {
                                CalculationMethod = methodName6,
                                FirstNumb = number1,
                                SecondNumb = number2,
                                Sum = Math.Round(remainOf, 2),
                                Date = dateNow,
                            });

                            DbContext.SaveChanges();

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
