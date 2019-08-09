using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Charlotte.Tools;
using System.IO;

namespace Charlotte
{
	public static class ffmpegUtils
	{
		public static string GetBinDir(string ffmpegDir)
		{
			ProcMain.WriteLog("ffmpegDir: " + ffmpegDir);
			ffmpegDir = FileTools.MakeFullPath(ffmpegDir);

			if (Directory.Exists(ffmpegDir) == false)
				throw new Exception("ffmpegフォルダが見つかりません。");

			string ffmpegBinDir = Directory.GetDirectories(ffmpegDir, "*", SearchOption.AllDirectories).First(subDir => IsBinDir(subDir));
			ProcMain.WriteLog("ffmpegBinDir: " + ffmpegBinDir);
			return ffmpegBinDir;
		}

		private static bool IsBinDir(string dir)
		{
			return
				File.Exists(Path.Combine(dir, "ffprobe.exe")) &&
				File.Exists(Path.Combine(dir, "ffmpeg.exe"));
		}
	}
}
