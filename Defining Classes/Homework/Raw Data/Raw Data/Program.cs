using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
	public class Program
	{
		public static void Main(string[] args)
		{
			int amountOfCars = int.Parse(Console.ReadLine());
			List<Car> cars = new List<Car>();
			for (int i = 0; i < amountOfCars; i++)
			{
				string[] carInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
				Engine inputEngine = new Engine
				{
					Speed = int.Parse(carInfo[1]),
					Power = int.Parse(carInfo[2])
				};
				Cargo inputCargo = new Cargo
				{
					Weight = int.Parse(carInfo[3]),
					Type = carInfo[4]
				};
				Tire[] inputTires = new Tire[4];
				inputTires[0] = new Tire
				{
					Pressure = double.Parse(carInfo[5]),
					Age = int.Parse(carInfo[6])
				};
				inputTires[1] = new Tire
				{
					Pressure = double.Parse(carInfo[7]),
					Age = int.Parse(carInfo[8])
				};
				inputTires[2] = new Tire
				{
					Pressure = double.Parse(carInfo[9]),
					Age = int.Parse(carInfo[10])
				};
				inputTires[3] = new Tire
				{
					Pressure = double.Parse(carInfo[11]),
					Age = int.Parse(carInfo[12])
				};
				Car inputCar = new Car(carInfo[0], inputEngine, inputCargo, inputTires);
				cars.Add(inputCar);
			}
			string cargoType = Console.ReadLine();
			if (cargoType == "fragile")
			{
				cars = cars.Where(x => x.CarCargo.Type == cargoType).ToList();
				foreach (var item in cars)
				{
					for (int i = 0; i < item.CarTires.Length; i++)
					{
						if (item.CarTires[i].Pressure < 1)
						{
							Console.WriteLine($"{item.Model}");
							break;
						}
					}
				}
			}
			else if (cargoType == "flamable")
			{
				cars = cars.Where(x => x.CarCargo.Type == cargoType).ToList();
				foreach (var item in cars)
				{
					if (item.CarEngine.Power > 250)
					{
						Console.WriteLine($"{item.Model}");
					}
				}
			}
		}
	}
}

