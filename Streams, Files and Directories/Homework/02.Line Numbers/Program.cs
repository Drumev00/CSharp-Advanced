using System;
using System.IO;

namespace Line_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			using (var reader = new StreamReader("text.txt"))
			{
				using (var writer = new StreamWriter("output.txt"))
				{
					string line = string.Empty;
					int counter = 1;
					while ((line = reader.ReadLine()) != null)
					{
						int letters = 0;
						int punctuationMarks = 0;
						foreach (var letter in line)
						{
							if (char.IsLetter(letter))
							{
								letters++;
							}
							else if (char.IsPunctuation(letter))
							{
								punctuationMarks++;
							}
						}

						writer.WriteLine($"Line {counter}: {line} ({letters})({punctuationMarks})");
						counter++;
					}
				}
			}
		}
	}
}
