using System;

namespace Generic_Box_of_String
{
	public class Program
	{
		public static void Main(string[] args)
		{
			int instances = int.Parse(Console.ReadLine());
			for (int i = 0; i < instances; i++)
			{
				string boxValue = Console.ReadLine();
				Box<string> box = new Box<string>();
				box.Name = boxValue;
				Console.WriteLine(box.ToString());
			}
		}
	}
}
