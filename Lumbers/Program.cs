﻿using System.Collections.Generic;

namespace Lumbers
{
    internal class Programm
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Queue<Lumberjack> lumberjacks = new Queue<Lumberjack>();
            string name;
            Console.WriteLine("First luberjack's name: ");
            while ( (name = Console.ReadLine()) != "" )
            {
                Console.WriteLine("Number of flapjacks");
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    Lumberjack lumberjack = new Lumberjack(name);
                    for (int i = 0; i < number; i++)
                    {
                        lumberjack.TakeFlapjack((Flapjack)random.Next(0, 4));
                    }
                    lumberjacks.Enqueue(lumberjack);
                }
                Console.WriteLine("Next lumberjack's name (blank to end): ");
            }

            while(lumberjacks.Count() > 0)
            {
                Lumberjack next = lumberjacks.Dequeue();
                next.EatFlapjack();
            }
        }
    }
}