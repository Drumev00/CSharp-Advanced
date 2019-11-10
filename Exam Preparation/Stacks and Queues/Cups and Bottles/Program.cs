using System;
using System.Collections.Generic;
using System.Linq;

namespace Cups_and_Bottles
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] cups = Console.ReadLine()
				.Split(" ", StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToArray();
			var cupsCapacity = new Queue<int>(cups);

			int[] bottles = Console.ReadLine()
				.Split(" ", StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToArray();
			var bottlesOfWater = new Stack<int>(bottles);
			int wastedWater = 0;
			for (int i = 0; i < cups.Length; i++)
			{
				int filledWater = 0;
				int cup = cupsCapacity.Peek();
				if (cupsCapacity.Peek() > bottlesOfWater.Peek())
				{
					while (cup > 0)
					{
						cup -= bottlesOfWater.Pop();
					}
					wastedWater += Math.Abs(cup);
				}
				if (cup <= 0)
				{
					cupsCapacity.Dequeue();
				}
				else if (bottlesOfWater.Peek() >= cupsCapacity.Peek())
				{
					filledWater = bottlesOfWater.Pop() - cupsCapacity.Dequeue();
					wastedWater += Math.Abs(filledWater);
				}
				if (cupsCapacity.Count == 0 || bottlesOfWater.Count == 0)
				{
					break;
				}
			}
			if (cupsCapacity.Count == 0)
			{
				Console.WriteLine($"Bottles: {string.Join(" ", bottlesOfWater)}\nWasted litters of water: {wastedWater}");
			}
			else
			{
				Console.WriteLine($"Cups: {string.Join(" ", cupsCapacity)}\nWasted litters of water: {wastedWater}");
			}
		}
	}
}
