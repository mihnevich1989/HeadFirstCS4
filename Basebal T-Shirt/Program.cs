using System.Collections.Generic;

namespace Basebal
{
    internal class Programm
    {
        static void Main(string[] args)
        {
            Dictionary<int, RetiredPlayer> retiredYankees = new Dictionary<int, RetiredPlayer>()
            {
                {3, new RetiredPlayer("Babe Ruth", 1948)},
                {4, new RetiredPlayer("Lou Gehrig", 1939)},
                {5, new RetiredPlayer("Joe DiMaggio", 1952)},
                {7, new RetiredPlayer("Mickey Mantle", 1969)},
                {8, new RetiredPlayer("Yogi Berra", 1972)},
                {10, new RetiredPlayer("Phil Rizzuto", 1985)},
                {23, new RetiredPlayer("Don Mattingly", 1997)},
                {42, new RetiredPlayer("Jackie Robinson", 1993)},
                {44, new RetiredPlayer("Reggie Jackson", 1993)},
            };

            //foreach (int jerseyNumber in retiredYankees.Keys)
            //{
            //    RetiredPlayer player = retiredYankees[jerseyNumber];
            //    Console.WriteLine($"{player.Name} #{jerseyNumber} retired in {player.YearRetired}");
            //}

            Stack<int> stackInt = new Stack<int>();
            stackInt.Push(11);
            stackInt.Push(22);
            stackInt.Push(33);
            stackInt.Push(44);

            Queue<int> myQueue = new Queue<int>(stackInt);
            Console.WriteLine(myQueue.Count);
            List<int> myList = new List<int>(myQueue);
            Console.WriteLine(myList.Count);
            Stack<int> myStack = new Stack<int>(myList);
            Console.WriteLine(myStack.Count);



        }
    }
}