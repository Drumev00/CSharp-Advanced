using System;
using System.Collections.Generic;
using System.Linq;

namespace Unique_Usernames
{
	class Program
	{
		static void Main(string[] args)
		{
			int numberOfNames = int.Parse(Console.ReadLine());
			var setOfNames = new HashSet<string>();
			for (int i = 0; i < numberOfNames; i++)
			{
				string name = Console.ReadLine();
				if (!setOfNames.Contains(name))
				{
					Console.WriteLine(name);
				}
				setOfNames.Add(name);
				
			}
		}
	}
}
