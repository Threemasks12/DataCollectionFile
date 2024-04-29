
using System;
using System.IO;

class FileReader
{
    static void Main(string[] args)
    {
        int counterWins = 0;
        int counterLoss = 0;
        
        if (args.Length == 0)
        {
            Console.WriteLine("Please provide a file path as an argument.");
            return;
        }

        string searchTerm1 = "you lose"; 
        string searchTerm2 = "You win";
        
        
            using (StreamReader sr = new StreamReader(args[0]))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {                    
                    if (line.Contains(searchTerm1))
                    {
                        counterLoss++; 
                        Console.WriteLine("Found: " + line);
                    }
                         
                    else if (line.Contains(searchTerm2))
                    {
                        counterWins++;
                        Console.WriteLine("Found: " + line);
                    }                         
                }

                    Console.WriteLine($"People won the game " + counterWins + " times");
                    Console.WriteLine($"People lost the game " + counterLoss + " times");
                    

                     int totalGames = counterWins + counterLoss;
                     if (totalGames > 0)
                        
                        {
                            double winPercentage = ((double)counterWins / totalGames) * 100;
                            Console.WriteLine($"Win Percentage: {winPercentage:F2}%");
                        }
                    else
                        
                        {

                            Console.WriteLine("No games played. Win percentage is undefined.");
                        }
            }
    }
}
