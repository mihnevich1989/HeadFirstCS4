using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            double odds = 0.75;
            Guy player = new Guy() { Name = "The player", Cash = 100 };

            Console.WriteLine("Welcome to the casino. The odds are " + odds);

            while (player.Cash > 0)
            {
                player.WrtiteMyInfo();
                Console.Write("How much to you want to bet: ");
                string howMuch = Console.ReadLine();

                if (int.TryParse(howMuch, out int amount))
                {
                    int pot = player.GiveCash(amount) * 2;
                    if (pot > 0)
                    {
                        
                        if (random.NextDouble() > odds)
                        {
                            int winnings = pot;
                            Console.WriteLine($"You win {winnings}");
                            player.RecieveCash(winnings);
                        }
                        else
                        {
                            Console.WriteLine("Bad luck, you lose.");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid number");
                }
            }
            Console.WriteLine("The house always wins.");
        }
    }
}
