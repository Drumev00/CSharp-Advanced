using System;
using System.Collections.Generic;

namespace Cities_by_Continent_and_Country
{
	class Program
	{
		static void Main(string[] args)
		{
			int commands = int.Parse(Console.ReadLine());
			var destinations = new Dictionary<string, Dictionary<string, List<string>>>();
			for (int i = 0; i < commands; i++)
			{
				string[] input = Console.ReadLine().Split();
				string continent = input[0];
				string country = input[1];
				string city = input[2];
				if (!destinations.ContainsKey(continent))
				{
					destinations[continent] = new Dictionary<string, List<string>>();
				}
				if (!destinations[continent].ContainsKey(country))
				{
					destinations[continent].Add(country, new List<string>());
				}
				destinations[continent][country].Add(city);

			}
			foreach (var kvp in destinations)
			{
				Console.WriteLine($"{kvp.Key}:");
				foreach (var item in kvp.Value)
				{
					Console.WriteLine($"  {item.Key} -> {string.Join(", ", item.Value)}");
				}
			}
		}
	}
}
