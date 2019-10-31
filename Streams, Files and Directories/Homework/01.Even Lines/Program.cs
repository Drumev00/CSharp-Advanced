using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Even_Lines
{
	class Program
	{
		static void Main(string[] args)
		{
			using (var reader = new StreamReader("text.txt"))
			{
				string line = string.Empty;
				int count = 0;
				var sentences = new List<string>();
				while ((line = reader.ReadLine()) != null)
				{
					if (count % 2 == 0)
					{
						sentences.Add(line);
					}
					count++;
				}
				var reversedWords = new List<string>();
				for (int i = 0; i < sentences.Count; i++)
				{
					string[] words = sentences[i].Split();
					StringBuilder temp = new StringBuilder();
					for (int j = words.Length - 1; j >= 0; j--)
					{
						temp.Append(words[j] + " ");
					}
					reversedWords.Add(temp.ToString());
				}
				for (int i = 0; i < reversedWords.Count; i++)
				{
					string replacingSymbols = reversedWords[i];
					foreach (var letter in replacingSymbols)
					{
						if (letter == '-' || letter == ',' || letter == '.' || letter == '!' || letter == '?')
						{
							replacingSymbols = replacingSymbols.Replace(letter, '@');
						}
					}
					Console.WriteLine(replacingSymbols);
				}
			}
		}
	}
}
