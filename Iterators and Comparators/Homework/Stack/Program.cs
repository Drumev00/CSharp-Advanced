using System;
using System.Linq;

namespace Stack
{
	class Program
	{
		static void Main(string[] args)
		{
			CustomStack<int> stack = new CustomStack<int>();

			string line = Console.ReadLine();

			while (line != "END")
			{
				string[] command = line.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

				if (command[0] == "Push")
				{
					stack.Push(command.Skip(1).Select(x => x.Replace(",", "")).Select(int.Parse).ToArray());
				}
				else if (command[0] == "Pop")
				{
					try
					{
						stack.Pop();
					}
					catch (Exception e)
					{
						Console.WriteLine("No elements");
					}
				}

				line = Console.ReadLine();
			}

			foreach (var element in stack)
			{
				Console.WriteLine(element);
			}

			foreach (var element in stack)
			{
				Console.WriteLine(element);
			}
		}
	}
}
