using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Charlotte.Tools;

namespace Charlotte
{
	public class AudioExtensions
	{
		private string[] Extensions;

		public AudioExtensions()
		{
			string file = Path.Combine(ProcMain.SelfDir, "audio_extensions.txt");

			if (File.Exists(file) == false)
				file = @"..\..\..\..\doc\audio_extensions.txt";

			this.Extensions = File.ReadAllLines(file, Encoding.ASCII);
			this.Extensions = this.Extensions.Where(v => v != "").Select(v => "." + v).ToArray(); // "mp3" -> ".mp3"

			ProcMain.WriteLog("音楽ファイルの拡張子 ⇒ " + string.Join("\n", this.Extensions));
		}

		public bool IsAudioFile(string path)
		{
			return this.Extensions.Any(ext => StringTools.EndsWithIgnoreCase(path, ext));
		}
	}
}
