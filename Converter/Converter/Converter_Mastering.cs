using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Charlotte.Tools;
using System.IO;

namespace Charlotte
{
	public partial class Converter
	{
		public bool Mastering(string audioExt)
		{
			if (StringTools.EqualsIgnoreCase(audioExt, ".wav"))
			{
				Run("Master.exe audio.wav audio_m.wav Master-Report.tmp");

				if (File.Exists("Master-Report.tmp") == false) // ? レポート未出力 -> audio.wav の読み込みに失敗したと判断する。
				{
					Run("bin\\ffmpeg.exe -i audio.wav -ac 2 audio_s.wav"); // ステレオに変換する。

					if (File.Exists("audio_s.wav") == false)
						throw new Exception("音楽ファイルの変換に失敗しました。(audio.wav -> audio_s.wav)");

					Run("Master.exe audio_s.wav audio_m.wav Master-Report.tmp");

					if (File.Exists("Master-Report.tmp") == false) // ? レポート未出力
						throw new Exception("音楽ファイルの読み込みに失敗しました。(audio_s.wav)_1");
				}
			}
			else
			{
				Run("bin\\ffmpeg.exe -i audio" + audioExt + " -ac 2 audio_s.wav"); // ステレオ .wav ファイルに変換する。
				Run("Master.exe audio_s.wav audio_m.wav Master-Report.tmp");

				if (File.Exists("Master-Report.tmp") == false) // ? レポート未出力
					throw new Exception("音楽ファイルの読み込みに失敗しました。(audio_s.wav)_2");
			}

			ProcMain.WriteLog("Master-Report: " + File.ReadAllText("Master-Report.tmp", StringTools.ENCODING_SJIS));

			return File.Exists("audio_m.wav");
		}
	}
}
