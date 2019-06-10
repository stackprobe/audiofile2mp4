using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Charlotte.Tools;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

namespace Charlotte
{
	public class Converter
	{
		public void Main()
		{
			FileTools.Delete(Ground.I.WorkDir);
			FileTools.CreateDir(Ground.I.WorkDir);
			FileTools.CreateDir(Path.Combine(Ground.I.WorkDir, "bin"));

			string audioExt = Path.GetExtension(Ground.I.AudioFile);
			string imageExt = Path.GetExtension(Ground.I.ImageFile);

			if (IsFairExt(audioExt) == false)
				throw new Exception("音楽ファイルの拡張子に問題があります。");

			if (IsFairExt(imageExt) == false)
				throw new Exception("画像ファイルの拡張子に問題があります。");

			audioExt = audioExt.ToLower();
			imageExt = imageExt.ToLower();

			foreach (string file in Directory.GetFiles(ffmpegUtils.GetBinDir(Ground.I.ffmpegDir)))
				File.Copy(file, Path.Combine(Ground.I.WorkDir, "bin", Path.GetFileName(file)));

			File.Copy(Ground.I.ImgToolsFile, Path.Combine(Ground.I.WorkDir, "ImgTools.exe"));
			File.Copy(Ground.I.BmpToCsvFile, Path.Combine(Ground.I.WorkDir, "BmpToCsv.exe"));
			File.Copy(Ground.I.AudioFile, Path.Combine(Ground.I.WorkDir, "audio" + audioExt));
			File.Copy(Ground.I.ImageFile, Path.Combine(Ground.I.WorkDir, "image" + imageExt));

			string homeDir = Directory.GetCurrentDirectory();

			Directory.SetCurrentDirectory(Ground.I.WorkDir);
			try
			{
				Run("bin\\ffprobe.exe audio" + audioExt);

				MediaInfo mi = new MediaInfo();
				mi.SetOutputFile("stderr.tmp");

				ProcMain.WriteLog("TotalTimeCentisecond: " + mi.TotalTimeCentisecond);
				ProcMain.WriteLog("AudioStreamCount: " + mi.AudioStreamCount);
				ProcMain.WriteLog("VideoStreamCount: " + mi.VideoStreamCount);
				ProcMain.WriteLog("AudioStreamIndex: " + mi.AudioStreamIndex);

				if (mi.TotalTimeCentisecond == -1L)
					throw new Exception("再生時間を取得できませんでした。");

				// 9 * 3600 * 100 * (30 as FPS_MAX) == 97200000 == 8 桁

				if (9 * 3600 * 100 < mi.TotalTimeCentisecond) // ? 9 hour <
					throw new Exception("再生時間が長すぎます。");

				if (mi.AudioStreamCount == 0)
					throw new Exception("音楽ストリームがありません。");

				if (mi.VideoStreamCount != 0)
				{
					//throw new Exception("動画ファイルです。"); // mjepgかもしれない！
					ProcMain.WriteLog("動画ファイルかもしれませんが続行します。");
				}
				if (mi.AudioStreamCount == -1)
					throw new Exception("音楽ストリームを取得できませんでした。");

				ConvImageJpeg("image" + imageExt, "image2.jpg", "image_mid_");

				int pictureCount = (int)((mi.TotalTimeCentisecond / 100.0) * Ground.I.FramePerSecond + 1);

				for (int count = 1; count <= pictureCount; count++)
				{
					File.Copy("image2.jpg", string.Format("picture_{0:D8}.jpg", count));
				}

				Run("bin\\ffmpeg.exe -r " + Ground.I.FramePerSecond + " -i picture_%%08d.jpg video.mp4");

				if (File.Exists("video.mp4") == false)
					throw new Exception("映像ファイルの生成に失敗しました。");

				Run("bin\\ffmpeg.exe -i video.mp4 -i audio" + audioExt + " -map 0:0 -map 1:" + mi.AudioStreamIndex + " -vcodec copy -codec:a copy movie.mp4");

				if (File.Exists("movie.mp4") == false)
					throw new Exception("動画ファイルの生成に失敗しました。");

				File.Move("movie.mp4", Ground.I.MovieFile);
			}
			finally
			{
				Directory.SetCurrentDirectory(homeDir);
			}
		}

		private static ImageCodecInfo GetICI(ImageFormat imgFmt)
		{
			return (from ici in ImageCodecInfo.GetImageEncoders() where ici.FormatID == imgFmt.Guid select ici).ToList()[0];
		}

		private static bool IsFairExt(string ext)
		{
			return ext != "" && ext[0] == '.' && StringTools.LiteValidate(ext.Substring(1), StringTools.DECIMAL + StringTools.ALPHA + StringTools.alpha);
		}

		private static void ConvImageJpeg(string rFile, string wFile, string midPathBase)
		{
			int w;
			int h;

			using (Image bmp = Bitmap.FromFile(rFile))
			{
				w = bmp.Width;
				h = bmp.Height;

				bmp.Save(midPathBase + "1.bmp", ImageFormat.Bmp); // 透過を無効にしたいだけ、、、
			}

			ProcMain.WriteLog("w: " + w);
			ProcMain.WriteLog("h: " + h);

			if (w < 1 || IntTools.IMAX < w)
				throw new Exception("画像ファイルの幅に問題があります。");

			if (h < 1 || IntTools.IMAX < h)
				throw new Exception("画像ファイルの高さに問題があります。");

			int ww = IntTools.Range(w, Consts.IMAGE_WH_MIN, Consts.IMAGE_WH_MAX);
			int hh;

			{
				long t = h;
				t *= ww;
				t /= w;

				if (Consts.IMAGE_WH_MIN <= t && t <= Consts.IMAGE_WH_MAX)
				{
					hh = (int)t;
				}
				else
				{
					hh = IntTools.Range(h, Consts.IMAGE_WH_MIN, Consts.IMAGE_WH_MAX);

					t = w;
					t *= hh;
					t /= h;
					t = LongTools.Range(t, Consts.IMAGE_WH_MIN, Consts.IMAGE_WH_MAX);

					ww = (int)t;
				}
			}

			ProcMain.WriteLog("ww.1: " + ww);
			ProcMain.WriteLog("hh.1: " + hh);

			// 高さと幅はそれぞれ偶数でなければならないっぽい。
			ww &= ~1;
			hh &= ~1;

			ProcMain.WriteLog("ww.2: " + ww);
			ProcMain.WriteLog("hh.2: " + hh);

			Run("ImgTools.exe /rf " + midPathBase + "1.bmp /wf " + midPathBase + "2.png /e " + ww + " " + hh);

			if (File.Exists(midPathBase + "2.png") == false)
				throw new Exception("画像処理エラー(ImgTools)");

			Run("BmpToCsv.exe /J " + Ground.I.JpegQuality + " " + midPathBase + "2.png " + midPathBase + "3.jpg");

			if (File.Exists(midPathBase + "3.jpg") == false)
				throw new Exception("画像処理エラー(BmpToCsv)");

			File.Move(midPathBase + "3.jpg", wFile);
		}

		private static void Run(string command)
		{
			command += " 1> stdout.tmp 2> stderr.tmp";

			ProcMain.WriteLog("command: " + command);

			ProcessTools.Batch(new string[] { command });

			ProcMain.WriteLog("stdout.tmp ----> " + File.ReadAllText("stdout.tmp") + " <---- ここまで");
			ProcMain.WriteLog("stderr.tmp ----> " + File.ReadAllText("stderr.tmp") + " <---- ここまで");
		}
	}
}
