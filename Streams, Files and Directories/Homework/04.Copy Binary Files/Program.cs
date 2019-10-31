using System;
using System.IO;

namespace Copy_Binary_Files
{
	class Program
	{
		static void Main(string[] args)
		{
			using (var fs = new FileStream("copyMe.png", FileMode.Open))
			{
				byte[] buffer = new byte[4096];
				using (var writer = new FileStream("Copy Here.png", FileMode.Create))
				{
					while (true)
					{
						long length = fs.Length;
						int readedBytes = fs.Read(buffer, 0, buffer.Length);
						if (readedBytes <= 0)
						{
							break;
						}

						writer.Write(buffer, 0, readedBytes);
					}
				}
			}
		}
	}
}
