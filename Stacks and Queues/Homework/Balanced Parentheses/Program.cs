using System;
using System.Collections.Generic;
using System.Linq;

namespace Balanced_Parentheses
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			var stack = new Stack<char>();
			bool isValid = true;
			for (int i = 0; i < input.Length; i++)
			{
				if (input[i] == '(' || input[i] == '[' || input[i] == '{')
				{
					stack.Push(input[i]);
				}
				else if (stack.Count > 0 && input[i] == ')' && stack.Peek() == '(')
				{
					stack.Pop();
				}
				else if (stack.Count > 0 && input[i] == ']' && stack.Peek() == '[')
				{
					stack.Pop();
				}
				else if (stack.Count > 0 && input[i] == '}' && stack.Peek() == '{')
				{
					stack.Pop();
				}
				else
				{
					isValid = false;
					Console.WriteLine("NO");
					break;
				}
			}
			if (isValid)
			{
				Console.WriteLine("YES");
			}
		}
	}
}
