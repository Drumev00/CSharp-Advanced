using System;

namespace Tuple
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] input1 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
			string name = input1[0] + " " + input1[1];
			string adress = input1[2];
			CustomTuple<string, string> tuple1 = new CustomTuple<string, string>(name, adress);
			Console.WriteLine(tuple1.ToString());

			string[] input2 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
			string singleName = input2[0];
			int beerLitters = int.Parse(input2[1]);
			var tuple2 = new CustomTuple<string, int>(singleName, beerLitters);
			Console.WriteLine(tuple2.ToString());

			string[] input3 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
			int number = int.Parse(input3[0]);
			double floatNumber = double.Parse(input3[1]);
			var tuple3 = new CustomTuple<int, double>(number, floatNumber);
			Console.WriteLine(tuple3.ToString());
		}
	}
}
