using System;
using System.IO;

namespace Line_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			string folder = "02. Line Numbers";
			string file = "Input.txt";
			using (var reader = new StreamReader(Path.Combine(folder, file)))
			{
				string line = string.Empty;
				int count = 1;
				using (var writer = new StreamWriter("output.txt"))
				{
					while ((line = reader.ReadLine()) != null)
					{
						writer.WriteLine($"{count}. {line}");
						count++;
					}
				}
			}
		}
	}
}
