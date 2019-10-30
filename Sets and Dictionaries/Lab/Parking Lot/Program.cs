using System;
using System.Collections.Generic;

namespace Parking_Lot
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = string.Empty;
			var parkedCars = new HashSet<string>();
			while ((input = Console.ReadLine().ToUpper()) != "END")
			{
				string[] tokens = input.Split(", ");
				if (tokens[0] == "IN")
				{
					parkedCars.Add(tokens[1]);
				}
				else if (tokens[0] == "OUT" && parkedCars.Contains(tokens[1]))
				{
					parkedCars.Remove(tokens[1]);
				}
			}
			if (parkedCars.Count > 0)
			{
				foreach (var car in parkedCars)
				{
					Console.WriteLine(car);
				}
			}
			else
			{
				Console.WriteLine("Parking Lot is Empty");
			}
		}
	}
}
