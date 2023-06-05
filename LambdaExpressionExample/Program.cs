namespace LambdaExpressionExample {
	internal class Program {
		static void Main(string[] args) {
			int[] array = new[] { 1, 12, 37, 44, 15, 66, 17 };
			/*IEnumerable<int> result =
				from v in array
				where v < 37
				orderby -v
				select v;*/
			IEnumerable<int> result = array.Where(v => v < 37).OrderBy(v => -v).Select(v => v * 2);


			foreach(int x in result) {
				Console.WriteLine(x);
			}
		}
	}
}