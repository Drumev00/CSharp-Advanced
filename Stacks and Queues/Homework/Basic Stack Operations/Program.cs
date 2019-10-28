using System;
using System.Collections.Generic;
using System.Linq;

namespace Basic_Stack_Operations
{
	class Program
	{
		static void Main(string[] args)
		{
			var stackOfNumbers = new Stack<int>();
			int[] input = Console.ReadLine()
				.Split()
				.Select(int.Parse)
				.ToArray();
			int pushElements = input[0];
			int popElements = input[1];
			int checkElement = input[2];

			int[] pushArray = Console.ReadLine()
				.Split()
				.Select(int.Parse)
				.ToArray();
			for (int i = 0; i < pushElements; i++)
			{
				stackOfNumbers.Push(pushArray[i]);
			}
			
			for (int i = 0; i < popElements; i++)
			{
				stackOfNumbers.Pop();
			}
			if (stackOfNumbers.Contains(checkElement))
			{
				Console.WriteLine("true");
			}
			else
			{
				int smallestNumber = int.MaxValue;
				for (int i = 0; i < stackOfNumbers.Count; i++)
				{
					if (smallestNumber > stackOfNumbers.Peek())
					{
						smallestNumber = stackOfNumbers.Pop();
					}
					else
					{
						stackOfNumbers.Pop();
					}
				}
				if (smallestNumber == int.MaxValue)
				{
					Console.WriteLine(0);
				}
				else
				{
					Console.WriteLine(smallestNumber);
				}
				
			}
		}
	}
}
