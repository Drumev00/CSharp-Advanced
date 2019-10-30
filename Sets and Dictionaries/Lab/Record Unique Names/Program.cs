using System;
using System.Collections.Generic;

namespace Record_Unique_Names
{
	class Program
	{
		static void Main(string[] args)
		{
			int numberOfNames = int.Parse(Console.ReadLine());
			var uniqueNames = new HashSet<string>();
			for (int i = 0; i < numberOfNames; i++)
			{
				string name = Console.ReadLine();
				uniqueNames.Add(name);
			}
			foreach (var item in uniqueNames)
			{
				Console.WriteLine(item);
			}
		}
	}
}
