using System;

namespace Helen_s_Abduction
{
	class Program
	{
		static int parisRow;
		static int parisCol;

		static void Main(string[] args)
		{
			int energy = int.Parse(Console.ReadLine());
			int field = int.Parse(Console.ReadLine());
			char[][] matrix = new char[field][];

			for (int i = 0; i < matrix.Length; i++)
			{
				string row = Console.ReadLine();
				matrix[i] = new char[row.Length];
				for (int j = 0; j < matrix[i].Length; j++)
				{
					matrix[i][j] = row[j];
					if (matrix[i][j] == 'P')
					{
						parisRow = i;
						parisCol = j;
					}
				}
			}

			bool exhausted = false;
			bool abducted = false;

			while (true)
			{
				string[] tokens = Console.ReadLine().Split(" ");
				string direction = tokens[0];
				int row = int.Parse(tokens[1]);
				int col = int.Parse(tokens[2]);

				matrix[row][col] = 'S';
				if (direction == "up")
				{
					if (parisRow - 1 >= matrix.Length || parisRow - 1 < 0)
					{
						energy--;
						continue;
					}
					else if (matrix[parisRow - 1][parisCol] == '-')
					{
						matrix[parisRow][parisCol] = '-';
						parisRow--;
						matrix[parisRow][parisCol] = 'P';
						energy--;
						if (Exhausted(energy))
						{
							exhausted = true;
							matrix[parisRow][parisCol] = 'X';
							break;
						}
					}
					else if (matrix[parisRow - 1][parisCol] == 'S')
					{
						matrix[parisRow][parisCol] = '-';
						parisRow--;
						energy -= 3;

						if (Exhausted(energy))
						{					
							matrix[parisRow][parisCol] = 'X';
							exhausted = true;
							break;
						}
						else
						{
							matrix[parisRow][parisCol] = 'P';
						}

					}
					else if (matrix[parisRow - 1][parisCol] == 'H')
					{
						matrix[parisRow][parisCol] = '-';
						parisRow--;
						energy--;
						matrix[parisRow][parisCol] = '-';
						abducted = true;
						break;
					}
				}
				else if (direction == "down")
				{
					if (parisRow + 1 >= matrix.Length || parisRow + 1 < 0)
					{
						energy--;
						continue;
					}
					else if (matrix[parisRow + 1][parisCol] == '-')
					{
						matrix[parisRow][parisCol] = '-';
						parisRow++;
						matrix[parisRow][parisCol] = 'P';
						energy--;
						if (Exhausted(energy))
						{
							exhausted = true;
							matrix[parisRow][parisCol] = 'X';
							break;
						}
					}
					else if (matrix[parisRow + 1][parisCol] == 'S')
					{
						matrix[parisRow][parisCol] = '-';
						energy -= 3;
						parisRow++;
						if (Exhausted(energy))
						{						
							matrix[parisRow][parisCol] = 'X';
							exhausted = true;
							break;
						}
						else
						{
							matrix[parisRow][parisCol] = 'P';
						}
					}
					else if (matrix[parisRow + 1][parisCol] == 'H')
					{
						matrix[parisRow][parisCol] = '-';
						parisRow++;
						energy--;
						matrix[parisRow][parisCol] = '-';
						abducted = true;
						break;
					}
				}
				else if (direction == "left")
				{
					if (parisCol - 1 >= matrix[parisRow].Length || parisCol - 1 < 0)
					{
						energy--;
						continue;
					}
					else if (matrix[parisRow][parisCol - 1] == '-')
					{
						matrix[parisRow][parisCol] = '-';
						parisCol--;
						matrix[parisRow][parisCol] = 'P';
						energy--;
						if (Exhausted(energy))
						{
							exhausted = true;
							matrix[parisRow][parisCol] = 'X';
							break;
						}
					}
					else if (matrix[parisRow][parisCol - 1] == 'S')
					{
						matrix[parisRow][parisCol] = '-';
						parisCol--;
						energy -= 3;
						if (Exhausted(energy))
						{						
							matrix[parisRow][parisCol] = 'X';
							exhausted = true;
							break;
						}
						else
						{
							matrix[parisRow][parisCol] = 'P';
						}
					}
					else if (matrix[parisRow][parisCol - 1] == 'H')
					{
						matrix[parisRow][parisCol] = '-';
						parisCol--;
						energy--;
						matrix[parisRow][parisCol] = '-';
						abducted = true;
						break;
					}
				}
				else if (direction == "right")
				{
					if (parisCol + 1 >= matrix[parisRow].Length || parisCol + 1 < 0)
					{
						energy--;
						continue;
					}
					else if (matrix[parisRow][parisCol + 1] == '-')
					{
						matrix[parisRow][parisCol] = '-';
						parisCol++;
						matrix[parisRow][parisCol] = 'P';
						energy--;
						if (Exhausted(energy))
						{
							exhausted = true;
							matrix[parisRow][parisCol] = 'X';
							break;
						}
					}
					else if (matrix[parisRow][parisCol + 1] == 'S')
					{
						matrix[parisRow][parisCol] = '-';
						parisCol++;
						energy -= 3;
						if (Exhausted(energy))
						{							
							matrix[parisRow][parisCol] = 'X';
							exhausted = true;
							break;
						}
						else
						{
							matrix[parisRow][parisCol] = 'P';
						}
					}
					else if (matrix[parisRow][parisCol + 1] == 'H')
					{
						matrix[parisRow][parisCol] = '-';
						parisCol++;
						energy--;
						matrix[parisRow][parisCol] = '-';
						abducted = true;
						break;
					}
				}
			}
			if (exhausted)
			{
				Console.WriteLine($"Paris died at {parisRow};{parisCol}.");
			}
			else if (abducted)
			{
				Console.WriteLine($"Paris has successfully abducted Helen! Energy left: {energy}");

			}
			for (int i = 0; i < matrix.Length; i++)
			{
				for (int j = 0; j < matrix[i].Length; j++)
				{
					Console.Write($"{matrix[i][j]}");
				}
				Console.WriteLine();
			}
		}

		private static bool Exhausted(int energy)
		{
			return energy <= 0;
		}
	}
}
