using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_Count_Method_Strings
{
	public class Box<T> where T : IComparable
	{
		public T Name { get; set; }

		public override string ToString()
		{
			return $"{Name.GetType()}: {Name}";
		}

		public List<T> Swap(int firstIndex, int secondIndex, List<T> list)
		{
			T temp = default;
			temp = list[firstIndex];
			list[firstIndex] = list[secondIndex];
			list[secondIndex] = temp;
			return list;
		}

		public int Count(List<T> list, T element)
		{
			int number = 0;
			for (int i = 0; i < list.Count; i++)
			{
				if (list[i].CompareTo(element) > 0)
				{
					number++;
				}
			}
			return number;
		}
	}
}
