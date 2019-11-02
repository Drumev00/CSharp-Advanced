using System;
using System.Linq;

namespace Predicate_For_Names
{
	class Program
	{
		static void Main(string[] args)
		{
			int lengthOfNames = int.Parse(Console.ReadLine());
			string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
			Predicate<string> enoughLength = n => n.Length <= lengthOfNames;
			names = names.Where(n => enoughLength(n)).ToArray();
			Action<string[]> Print = array => Console.WriteLine(string.Join(Environment.NewLine, names));
			Print(names);
		}
	}
}
