using FightingArena;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Arena
{
	private List<Gladiator> gladiators;

	public int Count => gladiators.Count;

	public Arena(string name)
	{
		this.gladiators = new List<Gladiator>();
		Name = name;
	}
	public string Name { get; set; }

	public void Add(Gladiator gladiator)
	{
		this.gladiators.Add(gladiator);
	}

	public void Remove(string name)
	{
		foreach (var fighter in gladiators)
		{
			if (fighter.Name == name)
			{
				gladiators.Remove(fighter);
				break;
			}
		}
	}

	public Gladiator GetGladitorWithHighestStatPower()
	{
		Gladiator glad = this.gladiators.OrderByDescending(sp => sp.GetStatPower()).FirstOrDefault();

		return glad;
	}

	public Gladiator GetGladitorWithHighestWeaponPower()
	{
		Gladiator glad = this.gladiators.OrderByDescending(sp => sp.GetWeaponPower()).FirstOrDefault();

		return glad;
	}

	public Gladiator GetGladitorWithHighestTotalPower()
	{
		Gladiator glad = this.gladiators.OrderByDescending(sp => sp.GetTotalPower()).FirstOrDefault();

		return glad;
	}

	public override string ToString()
	{
		return $"[{Name}] - [{Count}] gladiators are participating.";
	}

}
