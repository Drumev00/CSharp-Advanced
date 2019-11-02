using System;

namespace Knights_of_Honor
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] knights = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
			Print(knights);
		}

		static Action<string[]> Print = Chivalry;
		private static void Chivalry(string[] knights)
		{
			foreach (var knight in knights)
			{
				Console.WriteLine($"Sir {knight}");
			}
		}
	}
}
