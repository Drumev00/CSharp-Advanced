using System;


public class Program
{
	public static void Main(string[] args)
	{
		int n = int.Parse(Console.ReadLine());
		Family family = new Family();


		for (int i = 0; i < n; i++)
		{
			string[] people = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
			Person member = new Person(people[0], int.Parse(people[1]));
			family.AddMember(member);
		}
		Person oldest = new Person(family.GetOldestMember());
		Console.WriteLine($"{oldest.Name} {oldest.Age}");
	}
}

