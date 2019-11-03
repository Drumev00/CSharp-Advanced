using System;
using System.Collections.Generic;
using System.Linq;


public class Program
{
	public static void Main(string[] args)
	{
		int numberOfPeople = int.Parse(Console.ReadLine());
		List<Person> people = new List<Person>();

		for (int i = 0; i < numberOfPeople; i++)
		{
			string[] inputNames = Console.ReadLine().Split();
			Person person = new Person(inputNames[0], int.Parse(inputNames[1]));
			people.Add(person);
		}
		people = people.Where(x => x.Age > 30).OrderBy(x => x.Name).ToList();
		foreach (var item in people)
		{
			Console.WriteLine($"{item.Name} - {item.Age}");
		}
	}
}

