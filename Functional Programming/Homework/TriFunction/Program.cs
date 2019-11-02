using System;
using System.Linq;

namespace TriFunction
{
	class Program
	{
		static void Main(string[] args)
		{

			int charsLength = int.Parse(Console.ReadLine());
			string[] names = Console.ReadLine().Split();

			Func<string, int, bool> isLarger = (name, length) => name.Sum(x => x) >= length;

			Func<string[], Func<string, int, bool>, string> filter = (array, func) 
				=> array.FirstOrDefault(x => func(x, charsLength));
			string result = filter(names, isLarger);
			Console.WriteLine(result);


		}
	}
}
