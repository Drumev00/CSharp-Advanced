using System;
using System.Collections.Generic;
using System.Linq;

namespace Average_Student_Grades
{
	class Program
	{
		
		static void Main(string[] args)
		{
			int commands = int.Parse(Console.ReadLine());
			var studentGrades = new Dictionary<string, List<double>>();
			for (int i = 0; i < commands; i++)
			{
				string[] input = Console.ReadLine().Split();
				string name = input[0];
				double grade = double.Parse(input[1]);
				if (!studentGrades.ContainsKey(name))
				{
					studentGrades[name] = new List<double>();
				}
				studentGrades[name].Add(grade);
			}
			foreach (var kvp in studentGrades)
			{
				Console.Write($"{kvp.Key} -> ");
				foreach (var item in kvp.Value)
				{
					Console.Write($"{item:F2} ");
				}
				Console.Write($"(avg: {kvp.Value.Average():F2})");
				Console.WriteLine();
			}
		}
	}
}
