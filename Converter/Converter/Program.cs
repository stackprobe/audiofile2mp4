using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using Charlotte.Tools;

namespace Charlotte
{
	class Program
	{
		public const string APP_IDENT = "{704b36e4-2ea7-4965-af95-1f9584d211f2}";
		public const string APP_TITLE = "Converter";

		static void Main(string[] args)
		{
			ProcMain.CUIMain(new Program().Main2, APP_IDENT, APP_TITLE);

#if DEBUG
			if (ProcMain.CUIError)
			{
				Console.WriteLine("Press ENTER.");
				Console.ReadLine();
			}
#endif
		}

		private void Main2(ArgsReader ar)
		{
			while (true)
			{
				if (ar.ArgIs("/WD"))
				{
					Ground.I.WorkDir = CommonUtils.Decode(ar.NextArg());
					continue;
				}
				if (ar.ArgIs("/FFMD"))
				{
					Ground.I.ffmpegDir = CommonUtils.Decode(ar.NextArg());
					continue;
				}
				if (ar.ArgIs("/ITF"))
				{
					Ground.I.ImgToolsFile = CommonUtils.Decode(ar.NextArg());
					continue;
				}
				if (ar.ArgIs("/BCF"))
				{
					Ground.I.BmpToCsvFile = CommonUtils.Decode(ar.NextArg());
					continue;
				}
				if (ar.ArgIs("/MST-F"))
				{
					Ground.I.MasterFile = CommonUtils.Decode(ar.NextArg());
					continue;
				}
				if (ar.ArgIs("/AF"))
				{
					Ground.I.AudioFile = CommonUtils.Decode(ar.NextArg());
					continue;
				}
				if (ar.ArgIs("/IF"))
				{
					Ground.I.ImageFile = CommonUtils.Decode(ar.NextArg());
					continue;
				}
				if (ar.ArgIs("/MF"))
				{
					Ground.I.MovieFile = CommonUtils.Decode(ar.NextArg());
					continue;
				}
				if (ar.ArgIs("/FPS"))
				{
					Ground.I.FramePerSecond = int.Parse(ar.NextArg());
					continue;
				}
				if (ar.ArgIs("/JQ"))
				{
					Ground.I.JpegQuality = int.Parse(ar.NextArg());
					continue;
				}
				if (ar.ArgIs("/EMF"))
				{
					Ground.I.ErrorMessageFile = CommonUtils.Decode(ar.NextArg());
					continue;
				}
				if (ar.ArgIs("/LF"))
				{
					Ground.I.LogFile = CommonUtils.Decode(ar.NextArg());
					continue;
				}
				if (ar.ArgIs("/AG"))
				{
					Ground.I.ApproveGuest = int.Parse(ar.NextArg()) != 0;
					continue;
				}
				if (ar.ArgIs("/DI"))
				{
					Ground.I.画像を二重に表示 = int.Parse(ar.NextArg()) != 0;
					continue;
				}
				if (ar.ArgIs("/DI-W"))
				{
					Ground.I.画像を二重に表示_MonitorW = int.Parse(ar.NextArg());
					continue;
				}
				if (ar.ArgIs("/DI-H"))
				{
					Ground.I.画像を二重に表示_MonitorH = int.Parse(ar.NextArg());
					continue;
				}
				if (ar.ArgIs("/DI-B"))
				{
					Ground.I.画像を二重に表示_ぼかし = int.Parse(ar.NextArg());
					continue;
				}
				if (ar.ArgIs("/DI-A"))
				{
					Ground.I.画像を二重に表示_明るさ = int.Parse(ar.NextArg());
					continue;
				}
				if (ar.ArgIs("/M"))
				{
					Ground.I.MasteringFlag = int.Parse(ar.NextArg()) != 0;
					continue;
				}
				break;
			}
			if (ar.HasArgs())
				throw new Exception("不明なコマンド引数");

			FileTools.Delete(Ground.I.MovieFile);
			FileTools.Delete(Ground.I.ErrorMessageFile);
			FileTools.Delete(Ground.I.LogFile);

			ProcMain.WriteLog = message =>
			{
				try
				{
					using (new MSection("{d49cc1ff-9c18-4ad9-9a3e-24795d4c14d5}")) // 念の為ロック
					{
						using (StreamWriter writer = new StreamWriter(Ground.I.LogFile, true, Encoding.UTF8))
						{
							writer.WriteLine("[" + DateTime.Now + "] " + message);
						}
					}
				}
				catch
				{ }
			};

			try
			{
				ProcMain.WriteLog("<<<< Converter START >>>>");

				new Converter().Main();

				ProcMain.WriteLog("<<<< Converter END >>>>");
			}
			catch (Exception e)
			{
				ProcMain.WriteLog(e);

				File.WriteAllText(Ground.I.ErrorMessageFile, e.Message, Encoding.UTF8);
			}
		}
	}
}
