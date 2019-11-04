using System;
using System.Collections.Generic;
using System.Text;

public class Box<T>
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

}

