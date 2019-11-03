using System;
using System.Collections.Generic;

namespace SpeedRacing
{
	public class Program
	{
		public static void Main(string[] args)
		{
			int amountOfCars = int.Parse(Console.ReadLine());
			List<Car> cars = new List<Car>();
			for (int i = 0; i < amountOfCars; i++)
			{
				Car car = new Car();
				string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
				car.Model.Add(tokens[0]);
				car.FuelAmount = double.Parse(tokens[1]);
				car.FuelConsumptionPerKilometer = double.Parse(tokens[2]);
				cars.Add(car);
			}
			string command = string.Empty;
			while ((command = Console.ReadLine()) != "End")
			{
				string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
				for (int i = 0; i < cars.Count; i++)
				{
					if (cars[i].Model.Contains(tokens[1]))
					{
						cars[i].Drive(tokens[1], double.Parse(tokens[2]));
					}
				}
			}
			foreach (var car in cars)
			{
				Console.WriteLine($"{string.Join(" ", car.Model)} {car.FuelAmount:F2} {car.TravelledDistance}");
			}
		}
	}
}
