using System;
using System.Collections.Generic;
using System.Text;


public class Car
{
	public HashSet<string> Model { get; set; }
	public double FuelAmount { get; set; }
	public double FuelConsumptionPerKilometer { get; set; }
	public double TravelledDistance { get; set; }

	public Car()
	{
		Model = new HashSet<string>();
		TravelledDistance = 0;
	}

	public void Drive(string model, double disance)
	{
		double totalFuelConsumption = FuelConsumptionPerKilometer * disance;
		if (totalFuelConsumption > FuelAmount)
		{
			Console.WriteLine("Insufficient fuel for the drive");
		}
		else
		{
			FuelAmount -= totalFuelConsumption;
			TravelledDistance += disance;
		}
	}
}

