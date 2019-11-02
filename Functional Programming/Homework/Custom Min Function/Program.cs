using System;
using System.Collections.Generic;
using System.Linq;

namespace Custom_Min_Function
{
	class Program
	{
		static void Main(string[] args)
		{
			Func<List<int>, int> minFunction = numberArray =>
			{
				int min = int.MaxValue;
				foreach (var number in numberArray)
				{
					if (number < min)
					{
						min = number;
					}
				}
				return min;
			};

			List<int> numbers = Console.ReadLine()
				.Split(" ", StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToList();
			Console.WriteLine(minFunction(numbers));
		}
		
		

		
		
	}
}
