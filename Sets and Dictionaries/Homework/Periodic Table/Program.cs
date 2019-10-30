using System;
using System.Collections.Generic;
using System.Linq;

namespace Periodic_Table
{
	class Program
	{
		static void Main(string[] args)
		{
			int nLines = int.Parse(Console.ReadLine());
			var uniqueChemicals = new HashSet<string>();
			for (int i = 0; i < nLines; i++)
			{
				string[] chemicalCompounds = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
				for (int j = 0; j < chemicalCompounds.Length; j++)
				{
					uniqueChemicals.Add(chemicalCompounds[j]);
				}
			}
			foreach (var compound in uniqueChemicals.OrderBy(x => x))
			{
				Console.Write($"{compound} ");
			}
		}
	}
}
