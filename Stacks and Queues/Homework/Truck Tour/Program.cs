using System;
using System.Collections.Generic;
using System.Linq;

namespace Truck_Tour
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			var pumps = new Queue<int[]>();
			for (int i = 0; i < n; i++)
			{
				int[] currentPump = Console.ReadLine()
					.Split(" ", StringSplitOptions.RemoveEmptyEntries)
					.Select(int.Parse)
					.ToArray();
				pumps.Enqueue(currentPump);
			}
			int index = 0;

			while (true)
			{
				int totalFuel = 0;
				foreach (var item in pumps)
				{
					int petrolAmount = item[0];
					int distance = item[1];

					totalFuel += petrolAmount - distance;
					if (totalFuel < 0)
					{
						index++;
						pumps.Enqueue(pumps.Dequeue());
						break;
					}
				}
				if (totalFuel >= 0)
				{
					break;
				}
			}
			Console.WriteLine(index);
		}
	}
}
