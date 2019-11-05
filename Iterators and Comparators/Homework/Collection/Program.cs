using System;
using System.Linq;

namespace Collection
{
	public class Program
	{
		public static void Main(string[] args)
		{
			ListyIterator<string> iter = new ListyIterator<string>();

			string line = Console.ReadLine();

			while (line != "END")
			{
				string[] command = line.Split().ToArray();

				if (command[0] == "Create")
				{
					if (command.Length > 1)
					{
						iter = new ListyIterator<string>(command.Skip(1).ToArray());
					}
					else
					{
						iter = new ListyIterator<string>();
					}
				}
				else if (command[0] == "Move")
				{
					Console.WriteLine(iter.MoveNext());
				}
				else if (command[0] == "HasNext")
				{
					Console.WriteLine(iter.HasNext());
				}
				else if (command[0] == "Print")
				{
					try
					{
						string res = iter.Print();

						Console.WriteLine(res);
					}
					catch (Exception e)
					{
						Console.WriteLine("Invalid Operation!");
					}
				}
				else if (command[0] == "PrintAll")
				{
					try
					{
						string res = iter.PrintAll();

						Console.WriteLine(res);
					}
					catch (Exception e)
					{
						Console.WriteLine("Invalid Operation!");
					}
				}

				line = Console.ReadLine();
			}
		}
	}
}
