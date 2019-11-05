using System;
using System.Collections.Generic;
using System.Linq;

namespace Comparing_Objects
{
	public class Program
	{
		public static void Main(string[] args)
		{
			List<Person> persons = new List<Person>();

			string line = Console.ReadLine();

			while (line != "END")
			{
				string[] personInfo = line.Split().ToArray();

				persons.Add(new Person(personInfo[0], int.Parse(personInfo[1]), personInfo[2]));

				line = Console.ReadLine();
			}

			int n = int.Parse(Console.ReadLine());
			Person p = persons[n - 1];

			int equalPeoples = 0;
			int notEqualPeoples = 0;

			foreach (var person in persons)
			{
				int comparer = p.CompareTo(person);

				if (comparer == 0)
				{
					equalPeoples++;
				}
				else
				{
					notEqualPeoples++;
				}
			}

			if (equalPeoples == 1)
			{
				Console.WriteLine("No matches");
			}
			else
			{
				Console.WriteLine($"{equalPeoples} {notEqualPeoples} {persons.Count}");
			}
		}
	}
}
