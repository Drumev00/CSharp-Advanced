using System;
using System.Collections.Generic;
using System.Linq;

namespace Key_Revolver
{
	class Program
	{
		static void Main(string[] args)
		{
			int bulletPrice = int.Parse(Console.ReadLine());
			int barrelLimit = int.Parse(Console.ReadLine());
			int[] bulletValues = Console.ReadLine()
				.Split(" ", StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToArray();
			int[] lockValues = Console.ReadLine()
				.Split(" ", StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToArray();
			int recipePrice = int.Parse(Console.ReadLine());

			var bullets = new Stack<int>(bulletValues);
			var locks = new Queue<int>(lockValues);
			int spentMoney = 0;
			int bulletsFired = 0;

			bool noMoreLocks = false;
			bool noMoreBullets = false;

			while (true)
			{
				if (locks.Count == 0)
				{
					noMoreLocks = true;
					break;
				}
				if (bullets.Count == 0)
				{
					noMoreBullets = true;
					break;
				}
				if (locks.Peek() < bullets.Peek())
				{
					bullets.Pop();
					bulletsFired++;
					spentMoney += bulletPrice;
					Console.WriteLine("Ping!");
					Reload(barrelLimit, bulletsFired, bullets);
				}
				else if (locks.Peek() >= bullets.Peek())
				{
					locks.Dequeue();
					bullets.Pop();
					bulletsFired++;
					spentMoney += bulletPrice;
					Console.WriteLine("Bang!");
					Reload(barrelLimit, bulletsFired, bullets);
				}
			}
			if (noMoreLocks)
			{
				Console.WriteLine($"{bullets.Count} bullets left. Earned ${recipePrice - spentMoney}");
			}
			if (noMoreBullets)
			{
				Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
			}

		}

		private static void Reload(int barrelLimit, int bulletsFired, Stack<int> bullets)
		{
			if (bulletsFired % barrelLimit == 0 && bullets.Count > 0)
			{
				Console.WriteLine("Reloading!");
			}
		}
	}
}
