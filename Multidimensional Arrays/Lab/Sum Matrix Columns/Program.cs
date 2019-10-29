using System;
using System.Linq;

namespace Sum_Matrix_Columns
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
			
			for (int i = 0; i < array.GetLength(0); i++)
			{
				int[] input = Console.ReadLine()
				.Split(" ", StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToArray();
				for (int j = 0; j < array.GetLength(1); j++)
				{
					array[i, j] = input[j];
				}
			}
			for (int col = 0; col < array.GetLength(1); col++)
			{
				int totalSum = 0;
				for (int row = 0; row < array.GetLength(0); row++)
				{
					totalSum += array[row, col];
				}
				Console.WriteLine(totalSum);
			}

		}
	}
}
