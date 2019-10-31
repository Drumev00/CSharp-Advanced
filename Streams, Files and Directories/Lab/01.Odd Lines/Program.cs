using System;
using System.IO;

namespace Odd_Lines
{
	class Program
	{
		static void Main(string[] args)
		{
			string folder = "01. Odd Lines";
			string file = "input.txt";
			string path = Path.Combine(folder, file);
			using (var reader = new StreamReader(path))
			{
				string line = string.Empty;
				int count = 0;
				using (var writer = new StreamWriter("ouput.txt"))
				{
					while ((line = reader.ReadLine()) != null)
					{
						if (count % 2 != 0)
						{
							writer.WriteLine(line);
						}
						count++;
					}
				}
			}
		}
	}
}
