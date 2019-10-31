using System;
using System.Collections.Generic;
using System.IO;

namespace Merge_Files
{
	class Program
	{
		static void Main(string[] args)
		{
			string folder = "04. Merge Files";
			string firstFile = "FileOne.txt";
			string secondFile = "FileTwo.txt";
			string[] firstNumbers = File.ReadAllLines(Path.Combine(folder, firstFile));
			string[] secondNumbers = File.ReadAllLines(Path.Combine(folder, secondFile));

			using (var writer = new StreamWriter("output.txt"))
			{
				int firstIndex = 0;
				int secondIndex = 0;
				for (int i = 0; i < firstNumbers.Length + secondNumbers.Length; i++)
				{
					if (i % 2 == 0)
					{
						writer.WriteLine(firstNumbers[firstIndex]);
						firstIndex++;
					}
					else
					{
						writer.WriteLine(secondNumbers[secondIndex]);
						secondIndex++;
					}
				}
			}
		}
	}
}
