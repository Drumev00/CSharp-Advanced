using System;
using System.Collections.Generic;
using System.Linq;

namespace List_of_Predicates
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			List<int> numbers = new List<int>();
			for (int i = 0; i < n; i++)
			{
				numbers.Add(i + 1);
			}
			int[] dividers = Console.ReadLine()
				.Split(" ", StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToArray();
			Func<int, int, bool> isDivisible = (myNumbers, myDividers) =>
			{
				if (myNumbers % myDividers == 0)
				{
					return true;
				}
				return false;
			};
			for (int i = 0; i < dividers.Length; i++)
			{
				 numbers = numbers.Where(num => isDivisible(num, dividers[i])).ToList();
			}
			Console.WriteLine(string.Join(" ", numbers));
		}
	}
}
