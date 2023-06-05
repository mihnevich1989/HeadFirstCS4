﻿using PrintGetting;

var listOfObjects = new List<PrintWhenGetting>();
for(int i = 1; i < 5; i++) {
	listOfObjects.Add(new PrintWhenGetting() { InstanceNumber = i });

	Console.WriteLine("Set up the query");
	var result =
		from o in listOfObjects
		select o.InstanceNumber;

	var immediate = result.ToList();
	Console.WriteLine("Run the foreach");
	foreach(var number in immediate) {
		Console.WriteLine($"Writting #{number}");
	}
}
