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
			string folder = "03. Word Count";
			string wordsToRead = "words.txt";
			var words = new Dictionary<string, int>();
			using (var reader = new StreamReader(Path.Combine(folder, wordsToRead)))
			{
				string[] neededWords = reader.ReadLine().Split();
				for (int i = 0; i < neededWords.Length; i++)
				{
					if (!words.ContainsKey(neededWords[i].ToLower()))
					{
						words.Add(neededWords[i].ToLower(), 0);
					}
				}
				string[] wholeText = File.ReadAllText(Path.Combine(folder, "text.txt"))
					.Split(new[] { ".", ",", "-", " " }, StringSplitOptions.RemoveEmptyEntries)
					.ToArray();
				for (int i = 0; i < wholeText.Length; i++)
				{
					if (words.ContainsKey(wholeText[i].ToLower()))
					{
						words[wholeText[i].ToLower()]++;
					}
				}
				using (var writer = new StreamWriter("output.txt"))
				{
					foreach (var kvp in words.OrderByDescending(x => x.Value))
					{
						writer.WriteLine($"{kvp.Key} - {kvp.Value}");
					}
				}
			}

		}
	}
}
