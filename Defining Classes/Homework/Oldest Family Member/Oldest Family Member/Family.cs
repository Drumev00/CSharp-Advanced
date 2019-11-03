using System;
using System.Collections.Generic;
using System.Text;

public class Family
{
	public List<Person> Members { get; set; }

	public Family()
	{
		Members = new List<Person>();
	}
	public void AddMember(Person member)
	{
		Members.Add(member);
	}

	public Person GetOldestMember()
	{
		Person result = new Person();
		int oldest = int.MinValue;
		for (int i = 0; i < Members.Count; i++)
		{
			if (Members[i].Age > oldest)
			{
				oldest = Members[i].Age;
				result.Name = Members[i].Name;
				result.Age = oldest;
			}
		}
		return result;
	}
}

