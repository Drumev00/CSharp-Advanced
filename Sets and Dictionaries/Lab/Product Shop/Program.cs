using System;
using System.Collections.Generic;

namespace Product_Shop
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = string.Empty;
			var shopData = new SortedDictionary<string, Dictionary<string, double>>();
			while ((input = Console.ReadLine()) != "Revision")
			{
				string[] tokens = input.Split(", ");
				string shop = tokens[0];
				string product = tokens[1];
				double price = double.Parse(tokens[2]);
				if (!shopData.ContainsKey(shop))
				{
					shopData[shop] = new Dictionary<string, double>();
				}
				shopData[shop].Add(product, price);
			}
			foreach (var kvp in shopData)
			{
				Console.WriteLine($"{kvp.Key}->");
				foreach (var item in kvp.Value)
				{
					Console.WriteLine($"Product: {item.Key}, Price: {item.Value}");
				}
			}
		}
	}
}
