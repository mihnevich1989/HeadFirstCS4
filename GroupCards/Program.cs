using GroupCards;

internal class Programm {
	static void Main(string[] args) {

		var deck = new Deck()
			.Shuffle()
			.Take(16);

		IEnumerable<IGrouping<Suits, Card>> grouped = NewMethod(deck);

		foreach(var group in grouped) {
			Console.WriteLine($@"Group: {group.Key}
				Count: {group.Count()}
				Minimum: {group.Min()}
				Maximum: {group.Max()}");
		}
	}

	private static IEnumerable<IGrouping<Suits, Card>> NewMethod(IEnumerable<Card> deck) {
		return from card in deck
			   group card by card.Suit into suitGroup
			   select suitGroup;
	}
}
