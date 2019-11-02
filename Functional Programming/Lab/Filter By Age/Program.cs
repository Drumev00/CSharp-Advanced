using System;
using System.Collections.Generic;
using System.Linq;

namespace Filter_By_Age
{
	class Program
	{
		static void Main(string[] args)
		{
			int lines = int.Parse(Console.ReadLine());
			var people = new List<KeyValuePair<string, int>>();
			for (int i = 0; i < lines; i++)
			{
				string[] nameAge = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
				string name = nameAge[0];
				int age = int.Parse(nameAge[1]);

				people.Add(new KeyValuePair<string, int>(nameAge[0], int.Parse(nameAge[1])));

			}
			string condition = Console.ReadLine();
			int filterAge = int.Parse(Console.ReadLine());
			string[] format = Console.ReadLine().Split(' ');

			people.Where(p => condition == "younger" ? p.Value < filterAge : p.Value >= filterAge)
				.ToList()
				.ForEach(p => Printer(p, format));

			

		}
		static void Printer (KeyValuePair<string, int> people, string[] format)
		{
			if (format.Length > 1)
			{
				Console.WriteLine(format[0] == "name" ? $"{people.Key} - {people.Value}" :
					$"{people.Value} - {people.Key}");
			}
			else
			{
				Console.WriteLine(format[0] == "name" ? $"{people.Key}" :
					$"{people.Value}");
			}
		}
	}
}
