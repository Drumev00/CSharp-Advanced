﻿using System;
using System.Collections.Generic;

namespace Traffic_Jam
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			string input = Console.ReadLine();
			var queue = new Queue<string>();
			int count = 0;
			while (input != "end")
			{
				if (input != "green")
				{
					queue.Enqueue(input);
				}
				else if (input == "green")
				{
					for (int i = 0; i < n; i++)
					{
						if (queue.Count > 0)
						{
							Console.WriteLine($"{queue.Dequeue()} passed!");
							count++;
						}
					}
				}
				input = Console.ReadLine();
			}
			Console.WriteLine($"{count} cars passed the crossroads.");
		}
	}
}
