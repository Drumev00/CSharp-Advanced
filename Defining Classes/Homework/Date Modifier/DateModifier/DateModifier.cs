using System;
using System.Collections.Generic;
using System.Text;


public class DateModifier
{
	private DateTime date1;
	private DateTime date2;

	public double DayDifference(string date1, string date2)
	{
		string[] tokens1 = date1.Split(" ", StringSplitOptions.RemoveEmptyEntries);
		string[] tokens2 = date2.Split(" ", StringSplitOptions.RemoveEmptyEntries);

		this.date1 = new DateTime(int.Parse(tokens1[0]), int.Parse(tokens1[1]), int.Parse(tokens1[2]));
		this.date2 = new DateTime(int.Parse(tokens2[0]), int.Parse(tokens2[1]), int.Parse(tokens2[2]));

		return Math.Abs((this.date1 - this.date2).TotalDays);
	}
}

