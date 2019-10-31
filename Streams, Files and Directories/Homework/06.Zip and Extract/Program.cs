using System;
using System.IO;
using System.IO.Compression;

namespace Zip_and_Extract
{
	class Program
	{
		static void Main(string[] args)
		{
			string folderPath = @"..\..\..\newZip.zip";
			string fileToArchive = @"copyMe.png";

			using (var archive = ZipFile.Open(folderPath, ZipArchiveMode.Create))
			{
				archive.CreateEntryFromFile(fileToArchive, Path.GetFileName(fileToArchive));
			}
		}
	}
}
