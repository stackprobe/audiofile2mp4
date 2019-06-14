using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Charlotte.Tools;

namespace Charlotte
{
	public class CommonUtils
	{
		public static string Decode(string str)
		{
			return Encoding.UTF8.GetString(new Base64Unit().Decode(str));
		}

		public static bool NoFileOrEmptyFile(string file)
		{
			return File.Exists(file) == false || new FileInfo(file).Length == 0L;
		}
	}
}
