using System;
using System.Collections.Generic;

namespace Hot_Potato
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] children = Console.ReadLine()
				.Split(" ", StringSplitOptions.RemoveEmptyEntries);
			int n = int.Parse(Console.ReadLine());
			var queue = new Queue<string>(children);
			while (queue.Count > 1)
			{
				for (int i = 0; i < n - 1; i++)
				{
					string player = queue.Dequeue();
					queue.Enqueue(player);
				}
				Console.WriteLine($"Removed {queue.Dequeue()}");
			}
			Console.WriteLine($"Last is {queue.Dequeue()}");
		}
	}
}
