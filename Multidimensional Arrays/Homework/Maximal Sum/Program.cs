using System;
using System.Linq;

namespace Maximal_Sum
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] size = Console.ReadLine()
				.Split(" ", StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToArray();
			int[,] matrix = new int[size[0], size[1]];
			int biggestSum = int.MinValue;
			for (int i = 0; i < size[0]; i++)
			{
				int[] input = Console.ReadLine()
				.Split(" ", StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToArray();
				for (int j = 0; j < size[1]; j++)
				{
					matrix[i, j] = input[j];
				}
			}
			int[] biggestMatrix = new int[9];
			for (int row = 0; row < matrix.GetLength(0) - 2; row++)
			{
				for (int col = 0; col < matrix.GetLength(1) - 2; col++)
				{
					int currentSum = 0;
					currentSum = currentSum + matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]
						 + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
						 + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
					if (currentSum > biggestSum)
					{
						biggestSum = currentSum;
						biggestMatrix[0] = matrix[row, col];
						biggestMatrix[1] = matrix[row, col + 1];
						biggestMatrix[2] = matrix[row, col + 2];
						biggestMatrix[3] = matrix[row + 1, col];
						biggestMatrix[4] = matrix[row + 1, col + 1];
						biggestMatrix[5] = matrix[row + 1, col + 2];
						biggestMatrix[6] = matrix[row + 2, col];
						biggestMatrix[7] = matrix[row + 2, col + 1];
						biggestMatrix[8] = matrix[row + 2, col + 2];
					}
				}
			}
			Console.WriteLine($"Sum = {biggestSum}");
			Console.WriteLine($"{biggestMatrix[0]} {biggestMatrix[1]} {biggestMatrix[2]}");
			Console.WriteLine($"{biggestMatrix[3]} {biggestMatrix[4]} {biggestMatrix[5]}");
			Console.WriteLine($"{biggestMatrix[6]} {biggestMatrix[7]} {biggestMatrix[8]}");
		}
	}
}
