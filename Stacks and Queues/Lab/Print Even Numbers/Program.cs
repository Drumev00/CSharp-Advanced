﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace Print_Even_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] numbers = Console.ReadLine()
				.Split(" ", StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToArray();
			var evenNumbers = new Queue<int>();
			for (int i = 0; i < numbers.Length; i++)
			{
				if (numbers[i] % 2 == 0)
				{
					evenNumbers.Enqueue(numbers[i]);
				}
			}
			Console.WriteLine(string.Join(", ", evenNumbers));
		}
	}
}
