using System;

namespace Symbol_in_Matrix
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			string[,] array = new string[n, n];
			for (int i = 0; i < n; i++)
			{
				string input = Console.ReadLine();
				for (int j = 0; j < n; j++)
				{
					array[i, j] += input[j];
				}
			}
			string symbolForSearch = Console.ReadLine();
			bool symbolFound = false;
			for (int row = 0; row < array.GetLength(0); row++)
			{
				for (int col = 0; col < array.GetLength(1); col++)
				{
					if (array[row, col] == symbolForSearch)
					{
						Console.WriteLine($"({row}, {col})");
						symbolFound = true;
						break;
					}
				}
				if (symbolFound)
					break;
			}
			if (!symbolFound)
			{
				Console.WriteLine($"{symbolForSearch} does not occur in the matrix");
			}
		}
	}
}
