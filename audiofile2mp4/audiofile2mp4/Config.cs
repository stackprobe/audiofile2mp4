using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Charlotte.Tools;

namespace Charlotte
{
	public class Config
	{
		public Config()
		{
			this.LoadFromFile();
		}

		private void LoadFromFile()
		{
			string file = Path.Combine(ProcMain.SelfDir, Path.GetFileNameWithoutExtension(ProcMain.SelfFile) + ".conf");

			if (File.Exists(file) == false)
				return;

			string[] lines = File.ReadAllLines(file, StringTools.ENCODING_SJIS);
			int c = 0;

			lines = lines.Where(line => line != "" && line.Trim().StartsWith(";") == false).ToArray(); // 空行とコメント行を除去

			// ---- Items ----

			this.AudioInfoMax = int.Parse(lines[c++]);
			this.MessageDisplayTimerCountMax = int.Parse(lines[c++]);
			this.JpegQuality = int.Parse(lines[c++]);
			this.LogFileSizeMax = int.Parse(lines[c++]);
			this.ApproveGuest = lines[c++] == Consts.S_TRUE;

			// ----

			if (lines[c] != "\\e") // Terminator
				throw new Exception("Bad terminator");
		}

		// ---- Items ----

		public int AudioInfoMax = 30000;
		public int MessageDisplayTimerCountMax = 50;
		public int JpegQuality = 90;
		public int LogFileSizeMax = 1000000;
		public bool ApproveGuest = false;

		// ----
	}
}
