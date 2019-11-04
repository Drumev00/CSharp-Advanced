using System;
using System.Collections.Generic;

namespace Generic_Count_Method_Strings
{
	public class Program
	{
		public static void Main(string[] args)
		{
			int lines = int.Parse(Console.ReadLine());
			var list = new List<string>();
			for (int i = 0; i < lines; i++)
			{
				string words = Console.ReadLine();
				list.Add(words);
			}
			var box = new Box<string>();
			string element = Console.ReadLine();
			Console.WriteLine(box.Count(list, element));
		}
	}
}
