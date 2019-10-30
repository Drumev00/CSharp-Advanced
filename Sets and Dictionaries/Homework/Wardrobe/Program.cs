using System;
using System.Collections.Generic;
using System.Linq;

namespace Wardrobe
{
	class Program
	{
		static void Main(string[] args)
		{
			int nLines = int.Parse(Console.ReadLine());
			var clothes = new Dictionary<string, Dictionary<string, int>>();
			for (int i = 0; i < nLines; i++)
			{
				List<string> input = Console.ReadLine()
					.Split(new[] { " ", "->", "," }, StringSplitOptions.RemoveEmptyEntries)
					.ToList();
				string color = input[0];
				bool alreadyLooped = false;
				if (!clothes.ContainsKey(color))
				{
					clothes[color] = new Dictionary<string, int>();
					input.RemoveAt(0);
				}
				else if (clothes.ContainsKey(color))
				{
					input.RemoveAt(0);
					for (int j = 0; j < input.Count; j++)
					{
						if (!clothes[color].ContainsKey(input[j]))
						{
							clothes[color].Add(input[j], 1);
						}
						else
						{
							clothes[color][input[j]]++;
						}
					}
					alreadyLooped = true;
				}
				if (!alreadyLooped)
				{
					for (int j = 0; j < input.Count; j++)
					{
						if (!clothes[color].ContainsKey(input[j]))
						{
							clothes[color].Add(input[j], 1);
						}
						else
						{
							clothes[color][input[j]]++;
						}

					}
				}
			}
			string[] neededDress = Console.ReadLine().Split();
			
			foreach (var kvp in clothes)
			{
				Console.WriteLine($"{kvp.Key} clothes:");
				foreach (var item in kvp.Value)
				{
					bool printed = false;
					if (kvp.Key == neededDress[0] && item.Key == neededDress[1])
					{
						Console.WriteLine($"* {item.Key} - {item.Value} (found!)");
						printed = true;
					}
					if (!printed)
					{
						Console.WriteLine($"* {item.Key} - {item.Value}");
					}
					
					
				}
			}
		}
	}
}
