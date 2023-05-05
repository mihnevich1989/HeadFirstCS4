using System.Collections.Generic;

namespace FavoriteFood
{
    internal class Programm
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> favoriteFoods = new Dictionary<string, string>();
            favoriteFoods["Alex"] = "hot dogs";
            favoriteFoods["A'ja"] = "pizza";
            favoriteFoods["Jules"] = "falafel";
            favoriteFoods["Naima"] = "spaghetti";

            /* string name;
            while((name = Console.ReadLine()) != "")
            {
                if (favoriteFoods.ContainsKey(name))
                    Console.WriteLine($"{name}'s favorite food is {favoriteFoods[name]}");
                else
                    Console.WriteLine($"I don't know {name}'s favorite food");
            }  */
            foreach (string key in favoriteFoods.Keys)
            {
                Console.WriteLine(key);
            }
        }
    }
}
