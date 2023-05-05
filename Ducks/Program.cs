using System.Collections.Generic;

namespace Ducks
{
    internal class Programm
    {
        public static void PrintDucks(List<Duck> ducks)
        {
            foreach (Duck duck in ducks)
            {
                Console.WriteLine(duck);
            }
        }
        
        static void Main(string[] args)
        {

        List<Duck> ducks = new List<Duck>()
            {
                new Duck() { Kind = KindOfDuck.Mallard, Size = 17},
                new Duck() { Kind = KindOfDuck.Muscovy, Size = 18},
                new Duck() { Kind = KindOfDuck.Loon, Size = 14},
                new Duck() { Kind = KindOfDuck.Muscovy, Size = 11},
                new Duck() { Kind = KindOfDuck.Mallard, Size = 14},
                new Duck() { Kind = KindOfDuck.Loon, Size = 13}
            };

                    
            //IComparer<Duck> sizeComparer = new DuckComparerBySize();
            //ducks.Sort(sizeComparer);
            //PrintDucks(ducks);
            //IComparer<Duck> kindComparer = new DuckComparerByKind();
            //ducks.Sort(kindComparer);
            //PrintDucks(ducks);

            DuckComparer comparer = new DuckComparer();
            Console.WriteLine("\nSorting by Kind then Size\n");
            comparer.SortBy = SortCriteria.KindThenSize;
            ducks.Sort(comparer);
            PrintDucks(ducks);

            Console.WriteLine("\nSorting by Size then Kind\n");
            comparer.SortBy = SortCriteria.SizeThenKind;
            ducks.Sort(comparer);
            PrintDucks(ducks);

            List<Breeds> breeds = new List<Breeds>();
            breeds.Add(Breeds.Pub);
            Console.WriteLine(breeds.ToString());
        }
    }
}
