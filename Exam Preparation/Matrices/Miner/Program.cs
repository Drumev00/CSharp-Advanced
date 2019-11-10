using System;
using System.Collections.Generic;
using System.Linq;

namespace Miner
{
	class Program
	{
		static void Main(string[] args)
		{
			int fieldSize = int.Parse(Console.ReadLine());
			List<string> movements = Console.ReadLine().Split().ToList();
			string[,] matrix = new string[fieldSize, fieldSize];

			int[] startIndexes = new int[2];
			int coalAmount = 0;

			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				string[] fieldEnvironment = Console.ReadLine().Split();
				for (int j = 0; j < matrix.GetLength(1); j++)
				{
					matrix[i, j] = fieldEnvironment[j];
					if (matrix[i, j] == "s")
					{
						startIndexes[0] = i;
						startIndexes[1] = j;
					}
					else if (matrix[i, j] == "c")
					{
						coalAmount++;
					}
				}
			}
			int index = 0;
			while (coalAmount > 0)
			{
				if (movements.Count == 0)
				{
					Console.WriteLine($"{coalAmount} coals left. ({startIndexes[0]}, {startIndexes[1]})");
					break;
				}
				
				if (movements[index] == "up")
				{
					if (startIndexes[0] - 1 < matrix.GetLength(0) && startIndexes[0] - 1 >= 0)
					{
						if (matrix[startIndexes[0] - 1, startIndexes[1]] == "c")
						{
							matrix[startIndexes[0], startIndexes[1]] = "*";
							matrix[startIndexes[0] - 1, startIndexes[1]] = "s";
							movements.RemoveAt(index);
							coalAmount--;
							startIndexes[0]--;
						}
						else if (matrix[startIndexes[0] - 1, startIndexes[1]] == "e")
						{
							Console.WriteLine($"Game over! ({startIndexes[0] - 1}, {startIndexes[1]})");
							break;
						}
						else
						{
							matrix[startIndexes[0], startIndexes[1]] = "*";
							matrix[startIndexes[0] - 1, startIndexes[1]] = "s";
							startIndexes[0]--;
							movements.RemoveAt(index);
						}

					}
					else
					{
						movements.RemoveAt(index);
					}
				}
				else if (movements[index] == "down")
				{
					if (startIndexes[0] + 1 < matrix.GetLength(0) && startIndexes[0] + 1 >= 0)
					{
						if (matrix[startIndexes[0] + 1, startIndexes[1]] == "c")
						{
							matrix[startIndexes[0], startIndexes[1]] = "*";
							matrix[startIndexes[0] + 1, startIndexes[1]] = "s";
							startIndexes[0]++;
							movements.RemoveAt(index);
							coalAmount--;
						}
						else if (matrix[startIndexes[0] + 1, startIndexes[1]] == "e")
						{
							Console.WriteLine($"Game over! ({startIndexes[0] + 1}, {startIndexes[1]})");
							break;

						}
						else
						{
							matrix[startIndexes[0], startIndexes[1]] = "*";
							matrix[startIndexes[0] + 1, startIndexes[1]] = "s";
							startIndexes[0]++;
							movements.RemoveAt(index);
						}
					}
					else
					{
						movements.RemoveAt(index);
					}
				}
				else if (movements[index] == "left")
				{
					if (startIndexes[1] - 1 < matrix.GetLength(1) && startIndexes[1] - 1 >= 0)
					{
						if (matrix[startIndexes[0], startIndexes[1] - 1] == "c")
						{
							matrix[startIndexes[0], startIndexes[1]] = "*";
							matrix[startIndexes[0], startIndexes[1] - 1] = "s";
							startIndexes[1]--;
							movements.RemoveAt(index);
							coalAmount--;
						}
						else if (matrix[startIndexes[0], startIndexes[1] - 1] == "e")
						{
							Console.WriteLine($"Game over! ({startIndexes[0]}, {startIndexes[1] - 1})");
							break;

						}
						else
						{
							matrix[startIndexes[0], startIndexes[1]] = "*";
							matrix[startIndexes[0], startIndexes[1] - 1] = "s";
							startIndexes[1]--;
							movements.RemoveAt(index);
						}
					}
					else
					{
						movements.RemoveAt(index);
					}
				}
				else if (movements[index] == "right")
				{
					if (startIndexes[1] + 1 < matrix.GetLength(1) && startIndexes[1] + 1 >= 0)
					{
						if (matrix[startIndexes[0], startIndexes[1] + 1] == "c")
						{
							matrix[startIndexes[0], startIndexes[1]] = "*";
							matrix[startIndexes[0], startIndexes[1] + 1] = "s";
							startIndexes[1]++;
							movements.RemoveAt(index);
							coalAmount--;
						}
						else if (matrix[startIndexes[0], startIndexes[1] + 1] == "e")
						{
							Console.WriteLine($"Game over! ({startIndexes[0]}, {startIndexes[1] + 1})");
							break;

						}
						else
						{
							matrix[startIndexes[0], startIndexes[1]] = "*";
							matrix[startIndexes[0], startIndexes[1] + 1] = "s";
							startIndexes[1]++;
							movements.RemoveAt(index);
						}
					}
					else
					{
						movements.RemoveAt(index);
					}
				}
			}
			if (coalAmount == 0)
			{
				Console.WriteLine($"You collected all coals! ({startIndexes[0]}, {startIndexes[1]})");
			}
		}
	}
}
