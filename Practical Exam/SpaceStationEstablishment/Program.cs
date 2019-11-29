using System;

namespace SpaceStationEstablishment
{
	class Program
	{
		static int stephenRow;
		static int stephenCol;

		static int starEnergy;

		static void Main(string[] args)
		{
			int size = int.Parse(Console.ReadLine());
			char[,] matrix = new char[size, size];
			for (int i = 0; i < size; i++)
			{
				char[] rows = Console.ReadLine().ToCharArray();
				for (int j = 0; j < size; j++)
				{
					matrix[i, j] = rows[j];
					if (rows[j] == 'S')
					{
						stephenRow = i;
						stephenCol = j;
					}
					
				}
			}

			while (true)
			{
				if (starEnergy >= 50)
				{
					Console.WriteLine($"Good news! Stephen succeeded in collecting enough star power!");
					break;
				}
				string movement = Console.ReadLine();
				MakeMove(matrix, movement);
				
				if (stephenRow < 0 || stephenRow >= matrix.GetLength(0) ||
					stephenCol < 0 || stephenCol >= matrix.GetLength(1))
				{
					Console.WriteLine($"Bad news, the spaceship went to the void.");
					break;
				}
				else
				{
					SpecificAction(matrix);
				}
			}
			Console.WriteLine($"Star power collected: {starEnergy}");
			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				for (int j = 0; j < matrix.GetLength(1); j++)
				{
					Console.Write($"{matrix[i, j]}");
				}
				Console.WriteLine();
			}
		}

		private static void SpecificAction(char[,] matrix)
		{
			if (char.IsDigit(matrix[stephenRow, stephenCol]))
			{
				starEnergy += int.Parse(matrix[stephenRow, stephenCol].ToString());
				matrix[stephenRow, stephenCol] = 'S';
			}
			else if (matrix[stephenRow, stephenCol] == 'O')
			{
				matrix[stephenRow, stephenCol] = '-';
				for (int row = 0; row < matrix.GetLength(0); row++)
				{
					for (int col = 0; col < matrix.GetLength(1); col++)
					{
						if (matrix[row, col] == 'O')
						{
							stephenRow = row;
							stephenCol = col;
						}
					}
				}
				matrix[stephenRow, stephenCol] = 'S';
			}
			else if (matrix[stephenRow, stephenCol] == '-')
			{
				matrix[stephenRow, stephenCol] = 'S';
			}
			

		}

		private static void MakeMove(char[,] matrix, string movement)
		{
			matrix[stephenRow, stephenCol] = '-';
			if (movement == "up")
			{
				stephenRow--;
			}
			else if (movement == "down")
			{
				stephenRow++;
			}
			else if (movement == "left")
			{
				stephenCol--;
			}
			else if (movement == "right")
			{
				stephenCol++;
			}
		}
	}
}
