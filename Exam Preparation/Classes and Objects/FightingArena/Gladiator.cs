using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FightingArena
{
	public class Gladiator
	{
		public string Name { get; set; }
		public Stat Stat { get; set; }
		public Weapon Weapon { get; set; }

		public Gladiator(string name, Stat stat, Weapon weapon)
		{
			Name = name;
			Stat = new Stat(stat.Strength, stat.Flexibility, stat.Agility, stat.Skills, stat.Intelligence);
			Weapon = new Weapon(weapon.Size, weapon.Solidity, weapon.Sharpness);
		}

		public Func<int, int, int, int, int, int> StatFunc = (str, ag, flex, skill, intell) =>
		{
			int total = str + ag + flex + skill + intell;
			return total;
		};
		Func<int, int, int, int> WeaponFunc = (size, solid, sharp) => size + solid + sharp;

		public int GetStatPower()
		{
			return StatFunc(Stat.Strength, Stat.Agility, Stat.Flexibility, Stat.Skills, Stat.Intelligence);
		}

		public int GetWeaponPower()
		{
			return WeaponFunc(Weapon.Size, Weapon.Solidity, Weapon.Sharpness);
		}

		public int GetTotalPower()
		{
			int total = StatFunc(Stat.Strength, Stat.Agility, Stat.Flexibility, Stat.Skills, Stat.Intelligence) 
				+ WeaponFunc(Weapon.Size, Weapon.Solidity, Weapon.Sharpness);

			return total;
		}

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine($"[{Name}] - [{GetTotalPower()}]");
			sb.AppendLine($" Weapon Power: [{GetWeaponPower()}]");
			sb.AppendLine($" Stat Power: [{GetStatPower()}]");

			return sb.ToString().TrimEnd();
		}
	}
}
