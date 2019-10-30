using System;
using System.Collections.Generic;
using System.Linq;

namespace Sets_Of_Elements
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] setLengths = Console.ReadLine()
				.Split()
				.Select(int.Parse)
				.ToArray();
			var firstSet = new HashSet<int>();
			var secondSet = new HashSet<int>();
			var finalSet = new HashSet<int>();
			for (int i = 0; i < setLengths[0]; i++)
			{
				int numbers = int.Parse(Console.ReadLine());
				firstSet.Add(numbers);
			}
			for (int i = 0; i < setLengths[1]; i++)
			{
				int numbers = int.Parse(Console.ReadLine());
				secondSet.Add(numbers);
			}
			foreach (var numberInFirstSet in firstSet)
			{
				foreach (var numberInSecondSet in secondSet)
				{
					if (numberInFirstSet == numberInSecondSet)
					{
						finalSet.Add(numberInFirstSet);
					}
				}
			}
			Console.Write($"{string.Join(" ", finalSet)}");
		}
	}
}
