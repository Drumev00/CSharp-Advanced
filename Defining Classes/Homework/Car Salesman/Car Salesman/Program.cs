using System;
using System.Collections.Generic;


public class Program
{
	public static void Main(string[] args)
	{
		int amounfOfEngines = int.Parse(Console.ReadLine());
		List<Engine> engines = new List<Engine>();
		List<Car> cars = new List<Car>();
		for (int i = 0; i < amounfOfEngines; i++)
		{
			string[] engineParts = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
			if (engineParts.Length == 2)
			{
				engines.Add(new Engine(engineParts[0], engineParts[1]));
			}
			else if (engineParts.Length == 3)
			{
				if (char.IsDigit(engineParts[2][0]))
				{
					engines.Add(new Engine(engineParts[0], engineParts[1], engineParts[2]));
				}
				else
				{
					engines.Add(new Engine(engineParts[0], engineParts[1], "n/a", engineParts[2]));
				}
			}
			else if (engineParts.Length == 4)
			{
				engines.Add(new Engine(engineParts[0], engineParts[1], engineParts[2], engineParts[3]));
			}
		}

		int amountOfCars = int.Parse(Console.ReadLine());
		for (int i = 0; i < amountOfCars; i++)
		{
			string[] carParts = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
			Predicate<Engine> sameEngine = e => e.Model == carParts[1];
			if (carParts.Length == 2)
			{
				Engine neededEngine = engines.Find(sameEngine);
				cars.Add(new Car(carParts[0], neededEngine));
			}
			if (carParts.Length == 3)
			{
				Engine neededEngine = engines.Find(sameEngine);
				if (char.IsDigit(carParts[2][0]))
				{
					cars.Add(new Car(carParts[0], neededEngine, carParts[2]));
				}
				else
				{
					cars.Add(new Car(carParts[0], neededEngine, "n/a", carParts[2]));
				}

			}
			if (carParts.Length == 4)
			{
				Engine neededEngine = engines.Find(sameEngine);
				if (char.IsDigit(carParts[2][0]))
				{
					cars.Add(new Car(carParts[0], neededEngine, carParts[2], carParts[3]));
				}
				else
				{
					cars.Add(new Car(carParts[0], neededEngine, carParts[3], carParts[2]));
				}
			}
		}
		foreach (var car in cars)
		{
			Console.WriteLine($"{car.Model}:\n   {car.CarEngine.Model}:\n     Power: {car.CarEngine.Power}\n     " +
				$"Displacement: {car.CarEngine.Displacement}\n     Efficiency: {car.CarEngine.Efficiency}\n   Weight: {car.Weight}\n   Color: {car.Color}");

		}
	}
}


