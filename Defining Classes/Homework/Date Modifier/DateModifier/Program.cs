using System;


public class Program
{
	public static void Main(string[] args)
	{
		DateModifier dateModifier = new DateModifier();
		string date1 = Console.ReadLine();
		string date2 = Console.ReadLine();

		Console.WriteLine(dateModifier.DayDifference(date1, date2));
	}
}

