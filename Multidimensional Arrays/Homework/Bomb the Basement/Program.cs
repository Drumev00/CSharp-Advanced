using System;
using System.Collections.Generic;
using System.Linq;

namespace Bomb_the_Basement
{
	class Program
	{
		static void Main(string[] args)
		{


			int[] sizes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

			string[] bombArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
			int bombRow = int.Parse(bombArgs[0]);
			int bombCol = int.Parse(bombArgs[1]);
			int bombRad = int.Parse(bombArgs[2]);

			int[,] matrix = new int[sizes[0], sizes[1]];

			for (int row = 0; row < sizes[0]; row++)
			{
				for (int col = 0; col < sizes[1]; col++)
				{
					double distance = Math.Sqrt(Math.Pow(row - bombRow, 2) + Math.Pow(col - bombCol, 2));

					if (distance <= bombRad)
					{
						matrix[row, col] = 1;
					}
					else
					{
						matrix[row, col] = 0;
					}
				}
			}

			int[,] secondMatrix = new int[sizes[0], sizes[1]];

			for (int col = 0; col < sizes[1]; col++)
			{
				List<int> colValues = new List<int>();
				for (int row = 0; row < sizes[0]; row++)
				{
					colValues.Add(matrix[row, col]);
				}

				colValues = colValues.OrderByDescending(x => x).ToList();

				for (int row = 0; row < colValues.Count; row++)
				{
					secondMatrix[row, col] = colValues[row];
				}
			}

			for (int row = 0; row < secondMatrix.GetLength(0); row++)
			{
				for (int col = 0; col < secondMatrix.GetLength(1); col++)
				{
					Console.Write(secondMatrix[row, col]);
				}

				Console.WriteLine();
			}
		}
        

    }

    
}
