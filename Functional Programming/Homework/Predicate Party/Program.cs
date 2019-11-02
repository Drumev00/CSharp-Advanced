using System;
using System.Collections.Generic;
using System.Linq;

namespace Predicate_Party
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

			string command = Console.ReadLine();


			while (command != "Party!")
			{
				string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

				Func<string, bool> filter = CreateFilter(tokens);

				if (tokens[0] == "Double")
				{

					for (int i = 0; i < names.Count; i++)
					{
						if (filter(names[i]))
						{
							names.Insert(i + 1, names[i]);
							i++;
						}
					}

				}
				else if (tokens[0] == "Remove")
				{
					for (int i = 0; i < names.Count; i++)
					{
						if (filter(names[i]))
						{
							names.RemoveAt(i);
							i--;
						}
					}
				}

				command = Console.ReadLine();
			}



			if (names.Count == 0)
			{
				Console.WriteLine("Nobody is going to the party!");
			}
			else
			{
				Console.WriteLine(string.Join(", ", names) + " are going to the party!");
			}

		}

		private static Func<string, bool> CreateFilter(string[] tokens)
		{
			if (tokens[1] == "StartsWith")
			{
				return x => x.StartsWith(tokens[2]);
			}

			if (tokens[1] == "EndsWith")
			{
				return x => x.EndsWith(tokens[2]);
			}

			return x => x.Length == int.Parse(tokens[2]);
		}
	}
}
