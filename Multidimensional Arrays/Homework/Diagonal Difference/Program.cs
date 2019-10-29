using System;
using System.Linq;

namespace Diagonal_Difference
{
	class Program
	{
		static void Main(string[] args)
		{
			int size = int.Parse(Console.ReadLine());
			int[,] matrix = new int[size, size];
			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				int[] input = Console.ReadLine()
					.Split()
					.Select(int.Parse)
					.ToArray();
				for (int j = 0; j < matrix.GetLength(1); j++)
				{
					matrix[i, j] = input[j];
				}
			}
			double primarySum = 0;
			double secondarySum = 0;
			for (int row = 0; row < matrix.GetLength(0); row++)
			{
				for (int col = 0; col < matrix.GetLength(1); col++)
				{
					if (row == col)
					{
						primarySum += matrix[row, col];
					}
				}
			}
			for (int row = 0; row < matrix.GetLength(0); row++)
			{
				for (int col = matrix.GetLength(1) - 1; col >= matrix.GetLength(1) - 1; col--)
				{
					secondarySum += matrix[row, col - row];
					
				}
			}
			Console.WriteLine(Math.Abs(primarySum - secondarySum));
		}
	}
}
