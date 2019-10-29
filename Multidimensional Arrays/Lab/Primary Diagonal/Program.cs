using System;
using System.Linq;

namespace Primary_Diagonal
{
	class Program
	{
		static void Main(string[] args)
		{
			int dimensions = int.Parse(Console.ReadLine());
			int[,] array = new int[dimensions, dimensions];
			int sum = 0;

			for (int i = 0; i < array.GetLength(0); i++)
			{
				int[] input = Console.ReadLine()
					.Split(" ", StringSplitOptions.RemoveEmptyEntries)
					.Select(int.Parse)
					.ToArray();
				for (int j = 0; j < array.GetLength(1); j++)
				{
					array[i, j] += input[j];
					if (i == j)
					{
						sum += input[j];
					}
				}
			}
			Console.WriteLine(sum);
		}
	}
}
