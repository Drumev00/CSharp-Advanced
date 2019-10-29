using System;
using System.Linq;

namespace Snake_Moves
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] sizes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

			char[,] matrix = new char[sizes[0], sizes[1]];

			string snake = Console.ReadLine();

			int startIndex = 0;
			for (int row = 0; row < matrix.GetLength(0); row++)
			{

				for (int col = 0; col < matrix.GetLength(1); col++)
				{
					matrix[row, col] = snake[startIndex];
					startIndex++;
					if (startIndex >= snake.Length)
					{
						startIndex = 0;
					}
				}
			}

			for (int row = 0; row < matrix.GetLength(0); row++)
			{
				for (int col = 0; col < matrix.GetLength(1); col++)
				{
					Console.Write(matrix[row, col]);
				}

				Console.WriteLine();
			}

		}
	}
}
