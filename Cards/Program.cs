namespace Cards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numberBetween0and3 = random.Next(4);
            int numberBetween1and13 = random.Next(1, 14);
            int anyRandomInteger = random.Next();

            //Card myCard = new Card((Values)numberBetween1and13, (Suits)numberBetween0and3);
            //Console.WriteLine(myCard.Name);

            List<Card> cards = new List<Card>();
            cards.Add(new Card(Values.Ace, Suits.Hearts));
            cards.Add(new Card(Values.Jack, Suits.Spades));
            cards.Add(new Card(Values.Five, Suits.Clubs));

            foreach (Card card in cards)
            {
                Console.WriteLine(card.Name);
            }
        }
    }
}