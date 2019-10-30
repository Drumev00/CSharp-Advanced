using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Same_Values
{
	class Program
	{
		static void Main(string[] args)
		{
			double[] input = Console.ReadLine()
				.Split()
				.Select(double.Parse)
				.ToArray();
			var numbers = new Dictionary<double, int>();
			foreach (var number in input)
			{
				if (!numbers.ContainsKey(number))
				{
					numbers.Add(number, 1);
				}
				else
				{
					numbers[number]++;
				}
			}
			foreach (var kvp in numbers)
			{
				Console.WriteLine($"{kvp.Key} - {kvp.Value} times");
			}
		}
	}
}
