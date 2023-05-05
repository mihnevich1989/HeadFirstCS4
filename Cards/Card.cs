namespace Cards
{
    internal class Card
    {
        public Suits Suit { get; private set; }
        public Values Value { get; private set; }

        public Card(Values value, Suits suit)
        {
            this.Suit = suit;
            this.Value = value;
        }

        public override string ToString()
        {
            return $"{Value} of {Suit}";
        }
    }
}
