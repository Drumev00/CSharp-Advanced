using System;
using System.Collections.Generic;

namespace Supermarket
{
	class Program
	{
		static void Main(string[] args)
		{
			string name = Console.ReadLine();
			var queue = new Queue<string>();
			while (name != "End")
			{
				if (name == "Paid")
				{
					int count = queue.Count;
					for (int i = 0; i < count; i++)
					{
						Console.WriteLine(queue.Dequeue());
					}
				}
				else
				{
					queue.Enqueue(name);
				}

				name = Console.ReadLine();
			}
			if (queue.Count >= 0)
			{
				Console.WriteLine($"{queue.Count} people remaining.");
			}
		}
	}
}
