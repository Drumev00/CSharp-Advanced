using System;
using System.IO;

namespace Slice_a_File
{
	class Program
	{
		static void Main(string[] args)
		{
			string folder = "05. Slice File";
			string file = "sliceMe.txt";

			using (var reader = new FileStream(Path.Combine(folder, file), FileMode.OpenOrCreate))
			{
				long partSize = (long)Math.Ceiling((double)reader.Length / 4);
				byte[] buffer = new byte[partSize];
				for (int i = 1; i <= 4; i++)
				{
					using (var writer = new FileStream($"05. Slice File\\Part-{i}.txt", FileMode.Create))
					{
						int readedBytes = reader.Read(buffer, 0, (int)partSize);
						writer.Write(buffer, 0, readedBytes);
					}
				}
			} 
		}
	}
}
