using System;
using System.Linq;

namespace Square_with_Maximum_Sum
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
			for (int i = 0; i < size[0]; i++)
			{
				int[] input = Console.ReadLine()
				.Split(", ", StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToArray();
				for (int j = 0; j < size[1]; j++)
				{
					array[i, j] = input[j];
				}
			}
			int biggestSum = int.MinValue;

			int[] numbersInMatrix = new int[4];
			for (int row = 0; row < array.GetLength(0) - 1; row++)
			{
				for (int col = 0; col < array.GetLength(1) - 1; col++)
				{
					int sum = 0;
					sum = sum + array[row, col] 
						+ array[row + 1, col] 
						+ array[row, col + 1] 
						+ array[row + 1, col + 1];
					if (biggestSum < sum)
					{
						biggestSum = sum;
						numbersInMatrix[0] = array[row, col];
						numbersInMatrix[1] = array[row + 1, col];
						numbersInMatrix[2] = array[row, col + 1];
						numbersInMatrix[3] = array[row + 1, col + 1];
					}
				}
			}

			Console.WriteLine($"{numbersInMatrix[0]} {numbersInMatrix[2]} ");
			Console.WriteLine($"{numbersInMatrix[1]} {numbersInMatrix[3]} ");
			Console.WriteLine(biggestSum);
		}
	}
}
