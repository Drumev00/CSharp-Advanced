using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceStationRecruitment
{
	public class SpaceStation
	{
		private List<Astronaut> data;
		public string Name { get; set; }
		public int Capacity { get; set; }
		public int Count => data.Count;

		public SpaceStation(string name, int capacity)
		{
			Name = name;
			Capacity = capacity;
			data = new List<Astronaut>();
		}

		public void Add(Astronaut astronaut)
		{
			if (data.Count < Capacity)
			{
				data.Add(astronaut);
			}
		}

		public bool Remove(string name)
		{
			bool found = false;
			for (int i = 0; i < data.Count; i++)
			{
				if (data[i].Name == name)
				{
					found = true;
					data.RemoveAt(i);
				}
			}
			return found;
		}

		public Astronaut GetOldestAstronaut()
		{
			Astronaut astronaut = data.OrderByDescending(x => x.Age).FirstOrDefault();
			return astronaut;
		}

		public Astronaut GetAstronaut(string name)
		{
			return data.FirstOrDefault(x => x.Name == name);
		}

		public string Report()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine($"Astronauts working at Space Station {Name}:");
			for (int i = 0; i < data.Count; i++)
			{
				sb.AppendLine($"{data[i].ToString()}");
			}
			return sb.ToString().TrimEnd();
		}
	}
}
