using System;
using System.Linq;

namespace Matrix_Shuffling
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] size = Console.ReadLine()
				.Split(" ", StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToArray();
			string[,] matrix = new string[size[0], size[1]];
			for (int i = 0; i < size[0]; i++)
			{
				string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
				for (int j = 0; j < size[1]; j++)
				{
					matrix[i, j] = input[j];
				}
			}
			string command = string.Empty;
			while ((command = Console.ReadLine().ToLower()) != "end")
			{
				string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
				string validOperation = tokens[0];
				if (validOperation != "swap" || tokens.Length < 0 || tokens.Length > 5)
				{
					Console.WriteLine("Invalid input!");
					continue;
				}
				int rowForChange = int.Parse(tokens[1]);
				int colForChange = int.Parse(tokens[2]);
				int rowToChange = int.Parse(tokens[3]);
				int colToChange = int.Parse(tokens[4]);


				if (rowForChange < 0 || rowForChange > matrix.GetLength(0)
					|| colForChange < 0 || colForChange > matrix.GetLength(1)
					|| rowToChange < 0  || rowToChange > matrix.GetLength(0)
					|| colToChange < 0 || colToChange > matrix.GetLength(1))
				{
					Console.WriteLine("Invalid input!");
				}
				else
				{
					string temp = matrix[rowForChange, colForChange];
					matrix[rowForChange, colForChange] = matrix[rowToChange, colToChange];
					matrix[rowToChange, colToChange] = temp;
					for (int row = 0; row < matrix.GetLength(0); row++)
					{
						for (int col = 0; col < matrix.GetLength(1); col++)
						{
							Console.Write($"{matrix[row, col]} ");
						}
						Console.WriteLine();
					}
				}
			}
		}
	}
}
