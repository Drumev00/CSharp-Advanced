using System;
using System.Collections.Generic;

namespace Simple_Calculator
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] expression = Console.ReadLine().Split();
			var stack = new Stack<string>();
			for (int i = expression.Length - 1; i >= 0; i--)
			{
				stack.Push(expression[i].ToString());
			}
			int result = 0;
			while (stack.Count > 1)
			{
				int numberOne = int.Parse(stack.Pop());
				string operand = stack.Pop();
				int numberTwo = int.Parse(stack.Pop());
				if (operand == "+")
				{
					result = numberOne + numberTwo;
					stack.Push(result.ToString());
				}
				else if (operand == "-")
				{
					result = numberOne - numberTwo;
					stack.Push(result.ToString());
				}
			}
			Console.WriteLine(stack.Pop());
		}
	}
}
