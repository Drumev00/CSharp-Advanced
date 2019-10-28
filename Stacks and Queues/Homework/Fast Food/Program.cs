using System;
using System.Linq;
using System.Collections.Generic;

namespace Fast_Food
{
	class Program
	{
		static void Main(string[] args)
		{
			int foodQuantity = int.Parse(Console.ReadLine());
			int[] orders = Console.ReadLine()
				.Split(" ", StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToArray();
			var clientsOrder = new Queue<int>(orders);
			int count = clientsOrder.Count;
			Console.WriteLine(clientsOrder.Max());
			bool success = true;
			while (clientsOrder.Count != 0)
			{
				for (int i = 0; i < count; i++)
				{
					if (foodQuantity < orders[i])
					{
						success = false;
						break;
					}
					else
					{
						foodQuantity -= clientsOrder.Dequeue();
					}
				}
				if (!success)
					break;
			}
			if (success)
			{
				Console.WriteLine("Orders complete");
			}
			else
			{
				Console.WriteLine($"Orders left: {string.Join(" ", clientsOrder)}");
			}
		}
	}
}
