using System;
using System.Linq;

namespace Sum_Matrix_Elements
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] size = Console.ReadLine()
				.Split(", ", StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToArray();
			int[,] array = new int[size[0], size[1]];
			int totalSum = 0;
			for (int i = 0; i < size[0]; i++)
			{
				int[] input = Console.ReadLine()
				.Split(", ", StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToArray();
				for (int j = 0; j < size[1]; j++)
				{
					array[i, j] = input[j];
					totalSum += input[j];
				}
			}
			Console.WriteLine(size[0]);
			Console.WriteLine(size[1]);
			Console.WriteLine(totalSum);


		}
	}
}
