using System;
using System.Collections.Generic;
using System.Text;


public class Car
{
	public string Model { get; set; }
	public Engine CarEngine { get; set; }
	public Cargo CarCargo { get; set; }
	public Tire[] CarTires { get; set; }

	public Car(string model, Engine inputEngine, Cargo inputCargo, Tire[] inputTires)
	{
		Model = model;
		CarEngine = new Engine();
		CarEngine.Speed = inputEngine.Speed;
		CarEngine.Power = inputEngine.Power;
		CarCargo = new Cargo();
		CarCargo.Weight = inputCargo.Weight;
		CarCargo.Type = inputCargo.Type;
		CarTires = new Tire[4];
		CarTires[0] = new Tire();
		CarTires[0].Pressure = inputTires[0].Pressure;
		CarTires[0].Age = inputTires[0].Age;
		CarTires[1] = new Tire();
		CarTires[1].Pressure = inputTires[1].Pressure;
		CarTires[1].Age = inputTires[1].Age;
		CarTires[2] = new Tire();
		CarTires[2].Pressure = inputTires[2].Pressure;
		CarTires[2].Age = inputTires[2].Age;
		CarTires[3] = new Tire();
		CarTires[3].Pressure = inputTires[3].Pressure;
		CarTires[3].Age = inputTires[3].Age;
	}
}

