using System;
using System.Collections.Generic;
using System.Linq;

namespace Bombs
{
	class Program
	{
		static void Main(string[] args)
		{
			int matrixSize = int.Parse(Console.ReadLine());
			int[,] matrix = new int[matrixSize, matrixSize];
			for (int i = 0; i < matrixSize; i++)
			{
				int[] numbers = Console.ReadLine()
					.Split()
					.Select(int.Parse)
					.ToArray();
				for (int j = 0; j < matrixSize; j++)
				{
					matrix[i, j] = numbers[j];
				}
			}
			int[] bombCoordinates = Console.ReadLine()
				.Split(new[] { " ", "," }, StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToArray();
			Queue<int> bombIndexes = new Queue<int>(bombCoordinates);

			while (bombIndexes.Count > 0)
			{
				int row = bombIndexes.Dequeue();
				int col = bombIndexes.Dequeue();
				int bombValue = matrix[row, col];
				matrix[row, col] -= bombValue;
				if (row - 1 < matrix.GetLength(0)
					&& row - 1 >= 0
					&& col - 1 < matrix.GetLength(1)
					&& col - 1 >= 0)
				{
					if (matrix[row - 1, col - 1] > 0)
					{
						matrix[row - 1, col - 1] -= bombValue;
					}
				}
				if (row - 1 < matrix.GetLength(0) && row - 1 >= 0)
				{
					if (matrix[row - 1, col] > 0)
					{
						matrix[row - 1, col] -= bombValue;
					}
				}
				if (row - 1 < matrix.GetLength(0)
					&& row - 1 >= 0
					&& col + 1 < matrix.GetLength(1)
					&& col + 1 >= 0)
				{
					if (matrix[row - 1, col + 1] > 0)
					{
						matrix[row - 1, col + 1] -= bombValue;
					}
				}
				if (col + 1 < matrix.GetLength(1) && col + 1 >= 0)
				{
					if (matrix[row, col + 1] > 0)
					{
						matrix[row, col + 1] -= bombValue;
					}
				}
				if (row + 1 < matrix.GetLength(0)
					&& row + 1 >= 0
					&& col + 1 < matrix.GetLength(1)
					&& col + 1 >= 0)
				{
					if (matrix[row + 1, col + 1] > 0)
					{
						matrix[row + 1, col + 1] -= bombValue;
					}
				}
				if (row + 1 < matrix.GetLength(0) && row + 1 >= 0)
				{
					if (matrix[row + 1, col] > 0)
					{
						matrix[row + 1, col] -= bombValue;
					}
				}
				if (row + 1 < matrix.GetLength(0)
					&& row + 1 >= 0
					&& col - 1 < matrix.GetLength(1)
					&& col - 1 >= 0)
				{
					if (matrix[row + 1, col - 1] > 0)
					{
						matrix[row + 1, col - 1] -= bombValue;
					}
				}
				if (col - 1 < matrix.GetLength(1) && col - 1 >= 0)
				{
					if (matrix[row, col - 1] > 0)
					{
						matrix[row, col - 1] -= bombValue;
					}
				}
			}
			int matrixSum = 0;
			int aliveCells = 0;
			foreach (var item in matrix)
			{
				if (item > 0)
				{
					matrixSum += item;
					aliveCells++;
				}
			}
			Console.WriteLine($"Alive cells: {aliveCells}\nSum: {matrixSum}");
			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				for (int j = 0; j < matrix.GetLength(1); j++)
				{
					Console.Write($"{matrix[i, j]} ");
				}
				Console.WriteLine();
			}
		}
	}
		
}
