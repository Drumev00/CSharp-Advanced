using System;
using System.Collections.Generic;
using System.Linq;

namespace Reverse_and_Exclude
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> collection = Console.ReadLine()
				.Split(" ", StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToList();
			int filter = int.Parse(Console.ReadLine());
			Predicate<int> isDivisible = n => n % filter != 0;
			for (int i = 0; i < collection.Count / 2; i++)
			{
				int temp = collection[i];
				collection[i] = collection[collection.Count - 1 - i];
				collection[collection.Count - 1 - i] = temp;
			}
			collection = collection.Where(n => isDivisible(n)).ToList();
			Action<List<int>> Printer = numbers => Console.WriteLine(string.Join(" ", collection));
			Printer(collection);
		}
	}
}
