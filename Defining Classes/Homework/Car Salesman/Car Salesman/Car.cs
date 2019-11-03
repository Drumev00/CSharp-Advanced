using System;
using System.Collections.Generic;
using System.Text;


public class Car
{
	public string Model { get; set; }
	public Engine CarEngine { get; set; }
	public string Weight { get; set; }
	public string Color { get; set; }

	public Car(string model, Engine inputEngine, string weight = "n/a", string color = "n/a")
	{
		Model = model;
		CarEngine = new Engine(inputEngine.Model, inputEngine.Power, inputEngine.Displacement, inputEngine.Efficiency);
		Weight = weight;
		Color = color;
	}
}

