using System;
using System.Linq;
using System.Collections.Generic;

namespace Fashion_Boutique
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] clothesValue = Console.ReadLine()
				.Split(" ", StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToArray();
			int rackCapacity = int.Parse(Console.ReadLine());
			var clothes = new Stack<int>(clothesValue);
			int totalRacks = 1;
			int stackedClothes = 0;

			while (clothes.Count != 0)
			{
				if (stackedClothes + clothes.Peek() < rackCapacity)
				{
					stackedClothes += clothes.Pop();
				}
				else if (stackedClothes + clothes.Peek() == rackCapacity)
				{
					stackedClothes += clothes.Pop();
					if (clothes.Count != 0)
					totalRacks++;
					stackedClothes = 0;
				}
				else if (stackedClothes + clothes.Peek() > rackCapacity)
				{
					totalRacks++;
					stackedClothes = 0;
				}
			}
			Console.WriteLine(totalRacks);
		}
	}
}
