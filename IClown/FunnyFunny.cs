namespace IClown {
	internal class FunnyFunny : IClown {
		private string funnyThingHave;

		public string FunnyThingIHave => funnyThingHave;

		public FunnyFunny(string funnyThingHave) {
			this.funnyThingHave = funnyThingHave;
		}

		public void Honk() => Console.WriteLine($"Hi kids! I have a {funnyThingHave}.");
	}
}
