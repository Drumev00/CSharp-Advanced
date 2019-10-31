using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Directory_Traversal
{
	class Program
	{
		static void Main(string[] args)
		{

			string[] allfiles = Directory.GetFiles(".", "*.*");
			var filesAndExtensions = new Dictionary<string, Dictionary<string, double>>();
			for (int i = 0; i < allfiles.Length; i++)
			{
				List<string> tokens = allfiles[i].Split(new[] { ".", "\\", "/" }, StringSplitOptions.RemoveEmptyEntries).ToList();
				FileInfo fileInfo = new FileInfo(allfiles[i]);
				string extension = tokens.Last();
				bool addTheRest = false;
				if (!filesAndExtensions.ContainsKey(extension))
				{
					filesAndExtensions[extension] = new Dictionary<string, double>();
					tokens.Remove(tokens.Last());
					addTheRest = true;
				}
				else if (filesAndExtensions.ContainsKey(extension) && filesAndExtensions[extension].ContainsKey(tokens[0]))
				{
					filesAndExtensions[extension][tokens[0]] = fileInfo.Length;
				}
				if (addTheRest)
				{
					filesAndExtensions[extension].Add(tokens[0], fileInfo.Length);
				}
			}
			string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"report.txt";
			foreach (var kvp in filesAndExtensions.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
			{
				File.AppendAllText(path, $".{kvp.Key}");
				
				foreach (var item in kvp.Value.OrderBy(x => x.Value))
				{
					File.AppendAllText(path, $"--{item.Key}.{kvp.Key} - {item.Value / 1024:F3}kb");
				}
			}

		}
	}
}
