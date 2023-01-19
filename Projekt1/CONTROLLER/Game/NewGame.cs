using Projekt1.CONTROLLER.Shapes;
using Projekt1.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1.CONTROLLER.Game
{
    public class NewGame : Interfacial
    {
        public ApplicationDbContext DbContext { get; set; }
        public NewGame(ApplicationDbContext db)
        {
            DbContext = db;
        }
       
        public void Run()
        {
            Console.Clear();

            Console.WriteLine("\tROCK, PAPER, SCISSORS");

                bool newGame = true;
                var dateNow = DateTime.UtcNow;
                string playAgain;
                int currScore = 0;
                double winsCount = 0;
                double GameYouPlay = 0;
                double avaregeScore = GameYouPlay / winsCount;

            while (newGame)
            {
                try
                {
                    Console.WriteLine("\nChoose!");
                    Console.WriteLine("\n1. ROCK");
                    Console.WriteLine("2. PAPER");
                    Console.WriteLine("3. SCISSORS");
                    Console.WriteLine("\n0. Exit");
                    var playerChoice = Convert.ToInt32(Console.ReadLine());
                    if (playerChoice < 1 || playerChoice > 3) { break; }
                   
                    Random randomNumb = new Random();
                    var cpuChoice = randomNumb.Next(1, 4);
                   
                    switch (cpuChoice)
                    {
                        case 1:
                            if (playerChoice == 1)
                            {  
                                Console.WriteLine($"The computer chose ROCK");
                                Console.WriteLine("IT IS A DRAW!");
                                Console.WriteLine($"Current Score: {currScore}");
                                GameYouPlay++;
                                DbContext.Games.Add(new DATA.Game
                                {
                                    Date = dateNow,
                                    GamesPlayed = GameYouPlay

                                });
                                DbContext.SaveChanges();
                                
                                Console.ReadLine();
                                Console.Clear();
                            }
                            else if(playerChoice == 3) 
                            {
                                Console.WriteLine($"The computer chose ROCK");
                                Console.WriteLine("YOU LOOSE!");
                                currScore--;
                                GameYouPlay++;
                                Console.WriteLine($"Current Score: {currScore}");

                                DbContext.Games.Add(new DATA.Game
                                {
                                    Date = dateNow,
                                    Score = currScore,
                                    GamesPlayed = GameYouPlay

                                });
                                DbContext.SaveChanges();

                                Console.ReadLine();
                                Console.Clear();
                            }
                            else if (playerChoice == 2)
                            {
                                Console.WriteLine($"The computer chose ROCK");
                                Console.WriteLine("YOU WIN!");
                                GameYouPlay++;
                                currScore++;
                                winsCount++;
                                Console.WriteLine($"Current Score: {currScore}");

                                DbContext.Games.Add(new DATA.Game
                                {
                                    Date = dateNow,
                                    Score = currScore,
                                    Wins = winsCount,
                                    GamesPlayed = GameYouPlay

                                });
                                DbContext.SaveChanges();

                                Console.ReadLine();
                                Console.Clear();
                            }
                            break;
                       
                        case 2:
                            if (playerChoice == 2)
                            {
                                Console.WriteLine($"The computer chose PAPER");
                                Console.WriteLine("IT IS A DRAW!");
                                Console.WriteLine($"Current Score: {currScore}");
                                GameYouPlay++;
                                DbContext.Games.Add(new DATA.Game
                                {
                                    Date = dateNow,
                                    GamesPlayed = GameYouPlay

                                });
                                DbContext.SaveChanges();

                                Console.ReadLine();
                                Console.Clear();
                            }
                            else if (playerChoice == 1)
                            {
                                Console.WriteLine($"The computer chose PAPER");
                                Console.WriteLine("YOU LOOSE!");
                                currScore--;
                                GameYouPlay++;
                                Console.WriteLine($"Current Score: {currScore}");

                                DbContext.Games.Add(new DATA.Game
                                {
                                    Date = dateNow,
                                    Score = currScore,
                                    GamesPlayed= GameYouPlay

                                });
                                DbContext.SaveChanges();

                                Console.ReadLine();
                                Console.Clear();
                            }
                            else if (playerChoice == 3)
                            {
                                Console.WriteLine($"The computer chose PAPER");
                                Console.WriteLine("YOU WIN!");
                                GameYouPlay++;
                                currScore++;
                                winsCount++;
                                Console.WriteLine($"Current Score: {currScore}");

                                DbContext.Games.Add(new DATA.Game
                                {
                                    Date = dateNow,
                                    Score = currScore,
                                    Wins = winsCount,
                                    GamesPlayed = GameYouPlay

                                });
                                DbContext.SaveChanges();

                                Console.ReadLine();
                                Console.Clear();
                            }
                            break;
                           
                        case 3:
                            if (playerChoice == 3)
                            {
                                Console.WriteLine($"The computer chose SCISSORS");
                                Console.WriteLine("IT IS A DRAW!");
                                Console.WriteLine($"Current Score: {currScore}");
                                GameYouPlay++;
                                DbContext.Games.Add(new DATA.Game
                                {
                                    Date = dateNow,
                                    GamesPlayed = GameYouPlay

                                });
                                DbContext.SaveChanges();
                                Console.ReadLine();
                                Console.Clear();
                            }
                            else if (playerChoice == 2)
                            {
                                Console.WriteLine($"The computer chose SCISSORS");
                                Console.WriteLine("YOU LOOSE!");
                                currScore--;
                                GameYouPlay++;
                                Console.WriteLine($"Current Score: {currScore}");

                                DbContext.Games.Add(new DATA.Game
                                {
                                    Date = dateNow,
                                    Score = currScore,
                                    GamesPlayed = GameYouPlay

                                });
                                DbContext.SaveChanges();

                                Console.ReadLine();
                                Console.Clear();
                            }
                            else if (playerChoice == 1)
                            {
                                Console.WriteLine($"The computer chose SCISSORS");
                                Console.WriteLine("YOU WIN!");
                                GameYouPlay++;
                                currScore++;
                                winsCount++;
                                Console.WriteLine($"Current Score: {currScore}");

                                DbContext.Games.Add(new DATA.Game
                                {
                                    Date = dateNow,
                                    Score = currScore,
                                    Wins = winsCount,
                                    GamesPlayed = GameYouPlay

                                });
                                DbContext.SaveChanges();

                                Console.ReadLine();
                                Console.Clear();
                            }
                            break;

                    }
                    
                    Console.WriteLine("\nPlay Again? Y/N: ");
                    playAgain = Console.ReadLine().ToLower();

                    switch (playAgain)
                    {
                        case "y":
                            newGame = true;
                            break;

                        case "n":
                            newGame = false;
                           
                            Console.WriteLine($"\nYour score!: {currScore}");
                            Console.ReadLine();

                            DbContext.Games.Add(new DATA.Game
                            {
                                Date = dateNow,
                                AvarageScore = avaregeScore
                            });
                            DbContext.SaveChanges();
                            break;
                    }
                }
                catch (Exception)
                {
                    continue;
                }

            }
            
        }
    }
}
