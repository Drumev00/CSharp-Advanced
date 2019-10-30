using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni_Party
{
	class Program
	{
		static void Main(string[] args)
		{
			string reservationTickets = string.Empty;
			var VipGuests = new HashSet<string>();
			var regularGuests = new HashSet<string>();
			while ((reservationTickets = Console.ReadLine()) != "PARTY")
			{
				if (char.IsDigit(reservationTickets[0]))
				{
					VipGuests.Add(reservationTickets);
				}
				else
				{
					regularGuests.Add(reservationTickets);
				}
			}
			while ((reservationTickets = Console.ReadLine()) != "END")
			{
				if (VipGuests.Contains(reservationTickets))
				{
					VipGuests.Remove(reservationTickets);
				}
				else if (reservationTickets.Contains(reservationTickets))
				{
					regularGuests.Remove(reservationTickets);
				}
			}
			Console.WriteLine(VipGuests.Count + regularGuests.Count);
			foreach (var guest in VipGuests)
			{
				Console.WriteLine(guest);
			}
			foreach (var guest in regularGuests)
			{
				Console.WriteLine(guest);
			}
		}
	}
}
