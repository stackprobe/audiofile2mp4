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

		public string ffprobeFile = @"C:\app\ffmpeg-4.1.3-win64-shared\bin\ffprobe.exe";
		public string ffmpegFile = @"C:\app\ffmpeg-4.1.3-win64-shared\bin\ffmpeg.exe";
		public string AudioFile =
			///////////////////////////////////////////////////////////// ///////////////// ////////////////// // $_git:secret
		public string ImageFile =
			////////////////////////////////////////////////////////////////////////// // $_git:secret
		public string MovieFile = @"C:\temp\Converter_test_out.mp4";
		public int FramePerSecond = 3;
	}
}
