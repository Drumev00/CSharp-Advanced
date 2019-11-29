using System;
using System.Collections.Generic;
using System.Linq;

namespace SpaceshipCrafting
{
	class Program
	{
		static void Main(string[] args)
		{
			// liquid - Queue
			// physical item - Stack
			// advanced mat. - Dictionary

			int[] liquidSequence = Console.ReadLine()
				.Split()
				.Select(int.Parse)
				.ToArray();
			int[] physicalItemsSequence = Console.ReadLine()
				.Split()
				.Select(int.Parse)
				.ToArray();

			var liquids = new Queue<int>(liquidSequence);
			var physicalItems = new Stack<int>(physicalItemsSequence);

			int glass = 25;
			int aluminium = 50;
			int lithium = 75;
			int carbonFiber = 100;
			var advancedItems = new Dictionary<string, int>()
			{
				{"Glass", 0},
				{"Aluminium", 0},
				{"Lithium", 0},
				{"Carbon fiber", 0},
			};
			bool[] eachMaterial = new bool[4];
			while (liquids.Count > 0 && physicalItems.Count > 0)
			{
				int currentLiquid = liquids.Peek();
				int currentItem = physicalItems.Peek();

				if (currentItem + currentLiquid == glass)
				{
					string material = "Glass";
					MakeAnItem(liquids, physicalItems, advancedItems, material);
					eachMaterial[0] = true;
				}
				else if (currentItem + currentLiquid == aluminium)
				{
					string material = "Aluminium";
					MakeAnItem(liquids, physicalItems, advancedItems, material);
					eachMaterial[1] = true;
				}
				else if (currentItem + currentLiquid == lithium)
				{
					string material = "Lithium";
					MakeAnItem(liquids, physicalItems, advancedItems, material);
					eachMaterial[2] = true;
				}
				else if (currentItem + currentLiquid == carbonFiber)
				{
					string material = "Carbon fiber";
					MakeAnItem(liquids, physicalItems, advancedItems, material);
					eachMaterial[3] = true;
				}
				else
				{
					if (liquids.Count > 0 && physicalItems.Count > 0)
					{
						liquids.Dequeue();
						int temp = physicalItems.Pop();
						temp += 3;
						physicalItems.Push(temp);
					}
				}
			}
			if (eachMaterial.All(x => x == true))
			{
				Console.WriteLine($"Wohoo! You succeeded in building the spaceship!");
			}
			else if (eachMaterial.Any(x => x == false))
			{
				Console.WriteLine($"Ugh, what a pity! You didn't have enough materials to build the spaceship.");
			}
			if (liquids.Count == 0)
			{
				Console.WriteLine($"Liquids left: none");
			}
			else if (liquids.Count > 0)
			{
				Console.WriteLine($"Liquids left: {string.Join(", ", liquids)}");
			}
			if (physicalItems.Count == 0)
			{
				Console.WriteLine($"Physical items left: none");
			}
			else if (physicalItems.Count > 0)
			{
				Console.WriteLine($"Physical items left: {string.Join(", ", physicalItems)}");
			}
			foreach (var kvp in advancedItems.OrderBy(x => x.Key))
			{
				Console.WriteLine($"{kvp.Key}: {kvp.Value}");
			}
		}

		private static void MakeAnItem(Queue<int> liquids, Stack<int> physicalItems, Dictionary<string, int> advancedItems, string material)
		{
			liquids.Dequeue();
			physicalItems.Pop();
			advancedItems[material]++;
		}
	}
}
