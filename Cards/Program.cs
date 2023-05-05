namespace Cards
{
    internal class Program
    {
        private static readonly Random random = new Random();

        static Card RandomCard()
        {
            return new Card((Values)random.Next(1, 14), (Suits)random.Next(4));
        }

        static void PrintCard(List<Card> cards)
        {
            foreach (Card card in cards)
                Console.WriteLine(card); 
        }

        static void Main(string[] args)
        {
            List<Card> cards = new List<Card>();
            Console.WriteLine($"Enter number cards: ");
            if(int.TryParse(Console.ReadLine(), out int numberOfCard))
            {
                for(int i = 0; i < numberOfCard; i++)
                {
                    cards.Add(RandomCard());
                }
            }

            PrintCard(cards);

            cards.Sort(new CardComparerByValue());
            Console.WriteLine("\n... sorting the cards ...\n");
            PrintCard(cards);



        }
    }
}