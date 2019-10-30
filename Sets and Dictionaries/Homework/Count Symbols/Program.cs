using System;
using System.Collections.Generic;

namespace Count_Symbols
{
	class Program
	{
		static void Main(string[] args)
		{
			string text = Console.ReadLine();
			var collectionOfSymbols = new SortedDictionary<char, int>();
			foreach (char letter in text)
			{
				if (!collectionOfSymbols.ContainsKey(letter))
				{
					collectionOfSymbols[letter] = 1;
				}
				else
				{
					collectionOfSymbols[letter]++;
				}
			}
			foreach (var item in collectionOfSymbols)
			{
				Console.WriteLine($"{item.Key}: {item.Value} time/s");
			}
		}
	}
}
