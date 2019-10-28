using System;
using System.Collections.Generic;
using System.Linq;

namespace Maximum_and_Minimum_Element
{
	class Program
	{
		static void Main(string[] args)
		{
			var stack = new Stack<int>();
			int n = int.Parse(Console.ReadLine());

			for (int i = 0; i < n; i++)
			{
				string input = Console.ReadLine();
				string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

				if (tokens[0] == "1")
				{
					int number = int.Parse(tokens[1]);
					stack = PushElement(number, stack);
				}
				else if (tokens[0] == "2")
				{
					stack = DeleteElement(stack);
				}
				else if (tokens[0] == "3")
				{
					if (stack.Count > 0)
						Console.WriteLine(stack.Max());
				}
				else if (tokens[0] == "4")
				{
					if (stack.Count > 0)
						Console.WriteLine(stack.Min());
				}
			}
			Console.WriteLine(string.Join(", ", stack));
		}
		private static Stack<int> DeleteElement(Stack<int> stack)
		{
			if (stack.Count > 0)
			stack.Pop();
			return stack;
		}

		private static Stack<int> PushElement(int number, Stack<int> stack)
		{
			stack.Push(number);
			return stack;
		}
	}
}
