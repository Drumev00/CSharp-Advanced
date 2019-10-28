using System;
using System.Collections.Generic;
using System.Linq;

namespace Stack_Sum
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] input = Console.ReadLine()
				.Split(" ", StringSplitOptions.RemoveEmptyEntries);
			var stack = new Stack<int>();
			for (int i = 0; i < input.Length; i++)
			{
				stack.Push(int.Parse(input[i]));
			}
			string command = Console.ReadLine().ToLower();
			string[] tokens = command.Split();
			while (command != "end")
			{
				if (tokens[0] == "add")
				{
					for (int i = 1; i < tokens.Length; i++)
					{
						stack.Push(int.Parse(tokens[i]));
					}
				}
				else if (tokens[0] == "remove")
				{
					int removedNumbers = int.Parse(tokens[1]);
					if (removedNumbers <= stack.Count)
					{
						for (int i = 0; i < removedNumbers; i++)
						{
							stack.Pop();
						}
					}
				}
				command = Console.ReadLine().ToLower();
				tokens = command.Split();
			}
			Console.WriteLine($"Sum: {stack.Sum()}");
		}
	}
}
