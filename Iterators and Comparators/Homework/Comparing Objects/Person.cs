using System;
using System.Collections.Generic;
using System.Text;


public class Person : IComparable<Person>
{
	public string Name { get; set; }
	public int Age { get; set; }
	public string Town { get; set; }

	public Person(string name, int age, string town)
	{
		Name = name;
		Age = age;
		Town = town;
	}

	public int CompareTo(Person other)
	{
		int compare = this.Name.CompareTo(other.Name);

		if (compare == 0)
		{
			compare = this.Age.CompareTo(other.Age);

			if (compare == 0)
			{
				compare = this.Town.CompareTo(other.Town);
			}
		}

		return compare;
	}
}
