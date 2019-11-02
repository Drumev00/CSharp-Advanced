using System;
using System.Linq;

namespace Add_VAT
{
	class Program
	{
		static void Main(string[] args)
		{

			double[] prices = Console.ReadLine()
				.Split(", ", StringSplitOptions.RemoveEmptyEntries)
				.Select(AddVAT)
				.ToArray();
			foreach (var price in prices)
			{
				Console.WriteLine($"{price:F2}");
			}
				

		}
		static Func<string, double> AddVAT = n => double.Parse(n) * 1.2;
	}
}
