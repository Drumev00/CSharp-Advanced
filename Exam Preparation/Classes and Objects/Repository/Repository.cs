using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
	public class Repository
	{
		private Dictionary<int, Person> data;

		private int ID { get; set; }
		public int Count => data.Count;

		public Repository()
		{
			this.data = new Dictionary<int, Person>();
			ID = 0;
		}

		public void Add(Person person)
		{
			this.data.Add(ID, person);
			ID++;
		}

		public Person Get(int id)
		{
			return this.data[id];
		}

		public bool Update(int id, Person newPerson)
		{
			if (this.data.ContainsKey(id))
			{
				this.data[id] = newPerson;
				return true;
			}
			else
			{
				return false;
			}
		}

		public bool Delete(int id)
		{
			if (this.data.ContainsKey(id))
			{
				this.data.Remove(id);
				ID--;
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
