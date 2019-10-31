using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Word_Count
{
	class Program
	{
		static void Main(string[] args)
		{
			using (var reader = new StreamReader("text.txt"))
			{
				using (var writer = new StreamWriter("actualResult.txt"))
				{
					string line = string.Empty;

					string[] words = File.ReadAllLines("words.txt");
					var frequencyOfWords = new Dictionary<string, int>()
				{
					{words[0], 0 },
					{words[1], 0 },
					{words[2], 0 }
				};
					while ((line = reader.ReadLine()) != null)
					{
						line = line.ToLower();
						string[] tokens = line.Split(new[] {"-", " ", ".", "," }, StringSplitOptions.RemoveEmptyEntries);
						for (int i = 0; i < tokens.Length; i++)
						{
							if (frequencyOfWords.ContainsKey(tokens[i]))
							{
								frequencyOfWords[tokens[i]]++;
							}
						}
					}
					foreach (var kvp in frequencyOfWords)
					{
						writer.WriteLine($"{kvp.Key} - {kvp.Value}");
					}
					using (var sortedWrite = new StreamWriter("expectedResult.txt"))
					{
						foreach (var kvp in frequencyOfWords.OrderByDescending(x => x.Value))
						{
							sortedWrite.WriteLine($"{kvp.Key} - {kvp.Value}");
						}
					}
				}
			}
			
		}
	}
}
