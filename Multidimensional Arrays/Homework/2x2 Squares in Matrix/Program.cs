using System;
using System.Linq;

namespace _2x2_Squares_in_Matrix
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] size = Console.ReadLine()
				.Split()
				.Select(int.Parse)
				.ToArray();
			string[,] matrix = new string[size[0], size[1]];
			int found2x2 = 0;
			for (int i = 0; i < size[0]; i++)
			{
				string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
				for (int j = 0; j < size[1]; j++)
				{
					matrix[i, j] = input[j];
				}
			}
			for (int row = 0; row < matrix.GetLength(0) - 1; row++)
			{
				for (int col = 0; col < matrix.GetLength(1) - 1; col++)
				{
					if (matrix[row, col] == matrix[row + 1, col] 
						&& matrix[row, col + 1] == matrix[row + 1, col + 1]
						&& matrix[row, col] == matrix[row, col + 1]
						&& matrix[row, col] == matrix[row + 1, col + 1])
					{
						found2x2++;
					}
				}
			}
			Console.WriteLine(found2x2);
		}
	}
}
