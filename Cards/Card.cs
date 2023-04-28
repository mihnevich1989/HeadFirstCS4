namespace Cards
{
    internal class Card
    {
        public Suits Suit { get; private set; }
        public Values Value { get; private set; }

        public string Name => $"{Value} of {Suit}";

        public Card(Values value, Suits suit)
        {
            this.Suit = suit;
            this.Value = value;
        }
    }
}
