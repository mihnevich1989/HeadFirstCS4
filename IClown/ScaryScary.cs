namespace IClown {
	internal class ScaryScary : FunnyFunny, IScaryClown {
		private readonly int scaryThingCount;

		public string ScaryThingIHave { get => $"{scaryThingCount} spiders."; }

		public ScaryScary(string funnyThing, int scaryThingCount) : base(funnyThing) {
			this.scaryThingCount = scaryThingCount;
		}

		public void ScareLittleChildren() => Console.WriteLine($"Boo! Gotcha! Look at my {ScaryThingIHave}");
	}
}

