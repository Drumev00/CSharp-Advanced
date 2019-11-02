using System;
using System.Collections.Generic;
using System.Linq;

namespace Action_Point
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> names = Console.ReadLine()
				.Split(' ')
				.ToList();
			Print(names);
			

		}
		static Action<List<string>> Print = Printer;

		public static void Printer(List<string> names)
		{
			foreach (var name in names)
			{
				Console.WriteLine(name);
			}
		}
	}
}
