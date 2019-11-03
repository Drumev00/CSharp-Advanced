using System;
using System.Collections.Generic;
using System.Text;


public class Engine
{
	private string displacement;
	private string efficiency;

	public string Model { get; set; }
	public string Power { get; set; }
	public string Displacement { get; set; }
	public string Efficiency { get; set; }

	public Engine(string model, string power, string displacement = "n/a", string efficiency = "n/a")
	{
		Model = model;
		Power = power;
		Displacement = displacement;
		Efficiency = efficiency;
	}
}

