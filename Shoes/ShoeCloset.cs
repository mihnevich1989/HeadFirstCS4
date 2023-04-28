namespace Shoes
{
    internal class ShoeCloset
    {
        private readonly List<Shoe> _shoes = new List<Shoe>();

        public void PrintShoes()
        {
            if (_shoes.Count == 0)
            {
                Console.WriteLine("\nThe shoe closet is empty");
            }
            else
            {
                Console.WriteLine("\nThe shoe closet contains: ");
                int i = 1;
                foreach (Shoe shoe in _shoes)
                {
                    Console.WriteLine($"Shoe  #{i++}: {shoe.Description}");
                }
            }
        }

        public void AddShoe()
        {
            Console.WriteLine("\nAdd a shoe");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine($"Press {i} to add a {(Style)i}");
            }
            Console.WriteLine("Enter a style: ");
            if (int.TryParse(Console.ReadKey().KeyChar.ToString(), out int style))
            {
                Console.WriteLine("\nEnter the color: ");
                string color = Console.ReadLine();
                Shoe shoe = new Shoe((Style)style, color);
                _shoes.Add(shoe);
            }
        }

        public void RemoveShoe()
        {
            Console.WriteLine("\nEnter the number of the shoe to remove: ");
            if(int.TryParse(Console.ReadKey().KeyChar.ToString(), out int shoeNumber) && (shoeNumber >=1) && (shoeNumber <= _shoes.Count))
            {
                Console.WriteLine($"\nRemoving {_shoes[shoeNumber - 1].Description}");
                _shoes.RemoveAt(shoeNumber-1);
            }
        }
    }
}
