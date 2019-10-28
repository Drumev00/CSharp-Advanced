using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Simple_Text_Editor
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			
			var sb = new StringBuilder();
			var previousState = new Stack<string>();
			for (int i = 0; i < n; i++)
			{
				string[] command = Console.ReadLine()
				.Split(" ", StringSplitOptions.RemoveEmptyEntries);
				if (command[0] == "1")
				{
					previousState.Push(sb.ToString());
					sb.Append(command[1]);
				}
				else if (command[0] == "2")
				{
					int index = int.Parse(command[1]);
					previousState.Push(sb.ToString());
					sb.Remove(sb.Length - index, index);
				}
				else if (command[0] == "3")
				{
					Console.WriteLine(sb[int.Parse(command[1]) - 1]);
				}
				else if (command[0] == "4")
				{
					sb.Clear();
					sb.Append(previousState.Pop());
				}
			}
		}
	}
}
