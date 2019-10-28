using System;
using System.Collections.Generic;

namespace Auto_Repair_and_Service
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] input = Console.ReadLine()
				.Split(" ", StringSplitOptions.RemoveEmptyEntries);
			var queueOfVehicles = new Queue<string>(input);
			var servedCars = new Stack<string>();
			string command = Console.ReadLine();

			while (command != "End")
			{
				if (command == "Service" && queueOfVehicles.Count > 0)
				{
					string temp = queueOfVehicles.Dequeue();
					Console.WriteLine($"Vehicle {temp} got served.");
					servedCars.Push(temp);
				}
				else if (command.Contains("CarInfo-"))
				{
					string[] tokens = command.Split("-");
					if (queueOfVehicles.Contains(tokens[1]))
					{
						Console.WriteLine("Still waiting for service.");
					}
					else
					{
						Console.WriteLine("Served.");
					}
				}
				else if (command == "History")
				{
					Console.WriteLine(string.Join(", ", servedCars));
				}
				command = Console.ReadLine();
			}
			if (queueOfVehicles.Count > 0)
			Console.WriteLine($"Vehicles for service: {string.Join(", ", queueOfVehicles)}");
			if (servedCars.Count > 0)
			Console.WriteLine($"Served vehicles: {string.Join(", ", servedCars)}");
		}
	}
}
