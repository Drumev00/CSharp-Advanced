using System;
using System.Collections.Generic;
using System.Linq;

namespace Basic_Stack_Operations
{
	class Program
	{
		static void Main(string[] args)
		{
			var queueOfNumbers = new Queue<int>();
			int[] input = Console.ReadLine()
				.Split()
				.Select(int.Parse)
				.ToArray();
			int enqueueElements = input[0];
			int dequeueElements = input[1];
			int checkElement = input[2];

			int[] enqueueArray = Console.ReadLine()
				.Split()
				.Select(int.Parse)
				.ToArray();
			for (int i = 0; i < enqueueElements; i++)
			{
				queueOfNumbers.Enqueue(enqueueArray[i]);
			}

			for (int i = 0; i < dequeueElements; i++)
			{
				queueOfNumbers.Dequeue();
			}
			if (queueOfNumbers.Contains(checkElement))
			{
				Console.WriteLine("true");
			}
			else
			{
				int smallestNumber = int.MaxValue;
				int count = queueOfNumbers.Count;
				for (int i = 0; i < count; i++)
				{
					if (smallestNumber > queueOfNumbers.Peek())
					{
						smallestNumber = queueOfNumbers.Dequeue();
					}
					else
					{
						queueOfNumbers.Dequeue();
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
