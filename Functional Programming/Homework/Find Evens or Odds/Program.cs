using System;
using System.Collections.Generic;
using System.Linq;

namespace Find_Evens_or_Odds
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] borders = Console.ReadLine()
				.Split(" ")
				.Select(int.Parse)
				.ToArray();
			var numbers = new List<int>();
			for (int i = borders[0]; i <= borders[1]; i++)
			{
				numbers.Add(i);
			}
			string numberType = Console.ReadLine();
			Predicate<int> isEven = n => n % 2 == 0;
			Predicate<int> isOdd = n => n % 2 != 0;
			if (numberType == "even")
			{
				numbers = numbers.Where(n => isEven(n)).ToList();
			}
			else
			{
				numbers = numbers.Where(n => isOdd(n)).ToList();
			}
			Action<List<int>> printer = collection => Console.WriteLine(string.Join(" ", numbers));
			printer(numbers);
		}
	}
}
