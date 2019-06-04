using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Charlotte.Tools;

namespace Charlotte
{
	public class ImageExtensions
	{
		private string[] Extensions;

		public ImageExtensions()
		{
			string file = Path.Combine(ProcMain.SelfDir, "image_extensions.txt");

			if (File.Exists(file) == false)
				file = @"..\..\..\..\doc\image_extensions.txt";

			this.Extensions = File.ReadAllLines(file, Encoding.ASCII);
			this.Extensions = this.Extensions.Select(ext => "." + ext).ToArray(); // "bmp" -> ".bmp"
		}

		public bool IsImageFile(string path)
		{
			return this.Extensions.Any(ext => StringTools.EndsWithIgnoreCase(path, ext));
		}
	}
}
