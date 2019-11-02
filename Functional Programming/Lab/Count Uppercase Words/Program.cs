using System;
using System.Linq;

namespace Count_Uppercase_Words
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] text = Console.ReadLine()
				.Split(" ", StringSplitOptions.RemoveEmptyEntries)
				.Where(UpperWord)
				.ToArray();
			foreach (var upperWord in text)
			{
				Console.WriteLine(upperWord);
			}
		}
		static Func<string, bool> UpperWord = w => char.IsUpper(w[0]);
	}
}
