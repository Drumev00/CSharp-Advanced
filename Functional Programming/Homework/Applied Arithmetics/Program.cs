using System;
using System.Linq;

namespace Applied_Arithmetics
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] collection = Console.ReadLine()
				.Split(" ", StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToArray();
			string command = string.Empty;

			while ((command = Console.ReadLine()) != "end")
			{
				if (command == "add")
				{
					collection = Add(collection);
					
				}
				else if (command == "multiply")
				{
					collection = Multiply(collection);
				}
				else if (command == "subtract")
				{
					collection = Subtract(collection);
				}
				else if (command == "print")
				{
					Action<int[]> Printer = every => Console.WriteLine(string.Join(" ", collection));
					Printer(collection);
				}
			}
		}

		private static int[] Subtract(int[] collection)
		{
			Func<int[], int[]> increment = n =>
			{
				for (int i = 0; i < collection.Length; i++)
				{
					n[i] -= 1;
				}
				return collection;
			};
			return increment(collection);
		}

		private static int[] Multiply(int[] collection)
		{
			Func<int[], int[]> increment = n =>
			{
				for (int i = 0; i < collection.Length; i++)
				{
					n[i] *= 2;
				}
				return collection;
			};
			return increment(collection);
		}

		private static int[] Add(int[] collection)
		{
			Func<int[], int[]> increment = n =>
			{
				for (int i = 0; i < collection.Length; i++)
				{
					n[i] += 1;
				}
				return collection;
			};
			return increment(collection);
		}
	}
}
