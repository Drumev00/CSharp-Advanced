using System;
using System.Linq;

namespace ListyIteratos
{
	class Program
	{
		static void Main(string[] args)
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
					string res = iter.Print();

					Console.WriteLine(res);
				}

				line = Console.ReadLine();
			}
		}
	}
}
