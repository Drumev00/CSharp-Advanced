using System;
using System.Collections.Generic;
using System.Linq;

namespace Reverse_Strings
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			var stack = new Stack<string>();
			for (int i = input.Length - 1; i >= 0; i--)
			{
				stack.Push(input[i].ToString());
				Console.Write(stack.Pop());
			}

		}
	}
}
