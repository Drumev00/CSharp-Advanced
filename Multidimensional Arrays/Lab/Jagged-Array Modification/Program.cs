using System;
using System.Linq;

namespace Jagged_Array_Modification
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int[][] jaggedArray = new int[n][];
			for (int i = 0; i < jaggedArray.Length; i++)
			{
				int[] input = Console.ReadLine()
				.Split(" ", StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToArray();
				jaggedArray[i] = input;
			}
			string command = string.Empty;
			while ((command = Console.ReadLine().ToLower()) != "end")
			{
				string[] tokens = command.Split();
				string operation = tokens[0];
				int row = int.Parse(tokens[1]);
				int col = int.Parse(tokens[2]);
				int value = int.Parse(tokens[3]);
				if (row < 0 
					|| row >= n
					|| col < 0 
					|| col >= n)
				{
					Console.WriteLine("Invalid coordinates");
					continue;
				}
				if (operation == "add")
				{
					jaggedArray[row][col] += value;
				}
				else if (operation == "subtract")
				{
					jaggedArray[row][col] -= value;
				}
			}
			foreach (var item in jaggedArray)
			{
				Console.WriteLine(string.Join(" ", item));
			}
		}
	}
}
