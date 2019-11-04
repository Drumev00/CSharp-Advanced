using System;
using System.Collections.Generic;
using System.Linq;


public class Program
{
	public static void Main(string[] args)
	{
		int n = int.Parse(Console.ReadLine());
		var list = new List<string>();
		for (int i = 0; i < n; i++)
		{
			string someString = Console.ReadLine();
			list.Add(someString);
		}
		var box = new Box<string>();
		int[] indexes = Console.ReadLine()
			.Split()
			.Select(int.Parse)
			.ToArray();

		list = box.Swap(indexes[0], indexes[1], list);
		foreach (var item in list)
		{
			Console.WriteLine($"{item.GetType()}: {item}");
		}
	}
}

