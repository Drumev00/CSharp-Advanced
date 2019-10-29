using System;

namespace Pascal_Triangle
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			long[][] jaggedArray = new long[n][];
			int columns = 1;
			for (int i = 0; i < n; i++)
			{
				jaggedArray[i] = new long[columns];
				jaggedArray[i][0] = 1;
				jaggedArray[i][jaggedArray[i].Length - 1] = 1;

				if (columns > 2)
				{
					long[] previousArray = jaggedArray[i - 1];
					for (int j = 1; j < columns - 1; j++)
					{
						jaggedArray[i][j] = previousArray[j] + previousArray[j - 1];
					}
				}

				columns++;
			}
			foreach (var item in jaggedArray)
			{
				Console.WriteLine(string.Join(" ", item));
			}
		}
	}
}
