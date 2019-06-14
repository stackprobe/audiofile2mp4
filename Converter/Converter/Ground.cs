using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Charlotte
{
	public class Ground
	{
		private static Ground _i = null;

		public static Ground I
		{
			get
			{
				if (_i == null)
					_i = new Ground();

				return _i;
			}
		}

		public string WorkDir = @"C:\temp\Converter_test_dir";
		public string ffmpegDir = @"C:\app\ffmpeg-4.1.3-win64-shared";
		public string ImgToolsFile = @"C:\app\Kit\ImgTools\ImgTools.exe";
		public string BmpToCsvFile = @"C:\app\Kit\BmpToCsv\BmpToCsv.exe";
		public string AudioFile =
			///////////////////////////////////////////////////////////// ///////////////// ////////////////// // $_git:secret
		public string ImageFile =
			////////////////////////////////////////////////////////////////////////// // $_git:secret
		public string MovieFile = @"C:\temp\Converter_test_out.mp4";
		public int FramePerSecond = 3;
		public int JpegQuality = 90;
		public string ErrorMessageFile = @"C:\temp\Converter_test_ErrorMessage.txt";
		public string LogFile = @"C:\temp\Converter_test.log";
		public bool ApproveGuest = false;
	}
}
