using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PickRandomCards;

namespace RandomCardsPicker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of cards to pick: ");
            string line = Console.ReadLine();
            if (int.TryParse(line, out int numberOfCards))
            {
                string[] cards = CardPicker.PickSomeCards(numberOfCards);
                foreach (string card in cards)
                {
                    Console.WriteLine(card);
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }
    }
}
