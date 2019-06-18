using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Charlotte.Tools;
using System.IO;

namespace Charlotte
{
	public class CommonUtils
	{
		public static string GetConverterFile()
		{
			string file = "Converter.exe";

			if (File.Exists(file) == false)
			{
				file = @"..\..\..\..\Converter\Converter\bin\Release\Converter.exe"; // Debug は Press ENTER があるため、

				if (File.Exists(file) == false)
					throw new Exception("no Converter.exe");
			}
			return file;
		}

		public static string GetImgToolsFile()
		{
			string file = "ImgTools.exe";

			if (File.Exists(file) == false)
			{
				file = @"C:\app\Kit\ImgTools\ImgTools.exe";

				if (File.Exists(file) == false)
					throw new Exception("no ImgTools.exe");
			}
			return file;
		}

		public static string GetBmpToCsvFile()
		{
			string file = "BmpToCsv.exe";

			if (File.Exists(file) == false)
			{
				file = @"C:\app\Kit\BmpToCsv\BmpToCsv.exe";

				if (File.Exists(file) == false)
					throw new Exception("no BmpToCsv.exe");
			}
			return file;
		}

		public static string Encode(string str)
		{
			return new Base64Unit().Encode(Encoding.UTF8.GetBytes(str));
		}

		public static bool IsRootDir(string dir)
		{
			string fmt = dir;

			fmt = StringTools.ReplaceChars(fmt, StringTools.ALPHA + StringTools.alpha, 'A');

			return fmt == "A:\\";
		}
	}
}
