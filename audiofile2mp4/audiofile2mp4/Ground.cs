using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Charlotte.Tools;
using System.Windows.Forms;

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

		private string SaveFile;

		private Ground()
		{
			this.SaveFile = Path.Combine(ProcMain.SelfDir, Path.GetFileNameWithoutExtension(ProcMain.SelfFile)) + ".dat";
		}

		public void LoadFromFile()
		{
			try
			{
				if (File.Exists(this.SaveFile) == false)
					return;

				string[] lines = File.ReadAllLines(this.SaveFile, Encoding.UTF8);
				int c = 0;

				// ---- Items ----

				this.FFmpegDir = lines[c++];
				this.OutputDir = lines[c++];
				this.DefaultImageFile = lines[c++];
				this.MainWin_Maximized = lines[c++] == Consts.S_TRUE;
				this.MainWin_L = int.Parse(lines[c++]);
				this.MainWin_T = int.Parse(lines[c++]);
				this.MainWin_W = int.Parse(lines[c++]);
				this.MainWin_H = int.Parse(lines[c++]);
				this.MS_AudioFile_FullPath = lines[c++] == Consts.S_TRUE;
				this.MS_ImageFile_FullPath = lines[c++] == Consts.S_TRUE;
				this.MS_MovieFile_FullPath = lines[c++] == Consts.S_TRUE;
				this.DefaultFPS = int.Parse(lines[c++]);
				this.AllowOverwrite = lines[c++] == Consts.S_TRUE;
				this.同じ音楽ファイルを追加させない = lines[c++] == Consts.S_TRUE;

				// ----

				if (lines[c] != "\\e") // Terminator
					throw new Exception("Bad terminator");
			}
			catch (Exception e)
			{
				ProcMain.WriteLog(e);

				MessageBox.Show(e.Message, "データファイル読み込みエラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public void SaveToFile()
		{
			{
				List<string> lines = new List<string>();

				// ---- Items ----

				lines.Add(this.FFmpegDir);
				lines.Add(this.OutputDir);
				lines.Add(this.DefaultImageFile);
				lines.Add(this.MainWin_Maximized ? Consts.S_TRUE : Consts.S_FALSE);
				lines.Add("" + this.MainWin_L);
				lines.Add("" + this.MainWin_T);
				lines.Add("" + this.MainWin_W);
				lines.Add("" + this.MainWin_H);
				lines.Add(this.MS_AudioFile_FullPath ? Consts.S_TRUE : Consts.S_FALSE);
				lines.Add(this.MS_ImageFile_FullPath ? Consts.S_TRUE : Consts.S_FALSE);
				lines.Add(this.MS_MovieFile_FullPath ? Consts.S_TRUE : Consts.S_FALSE);
				lines.Add("" + this.DefaultFPS);
				lines.Add(this.AllowOverwrite ? Consts.S_TRUE : Consts.S_FALSE);
				lines.Add(this.同じ音楽ファイルを追加させない ? Consts.S_TRUE : Consts.S_FALSE);

				// ----

				lines.Add("\\e"); // Terminator

				File.WriteAllLines(this.SaveFile, lines, Encoding.UTF8);
			}
		}

		// ---- Items ----

		public string FFmpegDir = ""; // "" == 未設定
		public string OutputDir = ""; // "" == 未設定
		public string DefaultImageFile = ""; // "" == 未設定
		public bool MainWin_Maximized = false;
		public int MainWin_L;
		public int MainWin_T;
		public int MainWin_W = -1; // -1 == 未保存
		public int MainWin_H;
		public bool MS_AudioFile_FullPath = false;
		public bool MS_ImageFile_FullPath = false;
		public bool MS_MovieFile_FullPath = true;
		public int DefaultFPS = Consts.FPS_DEF;
		public bool AllowOverwrite = false;
		public bool 同じ音楽ファイルを追加させない = true;

		// ----

		public Config Config = new Config();
		public AudioExtensions AudioExtensions = new AudioExtensions();
		public ImageExtensions ImageExtensions = new ImageExtensions();
		public Converter Converter = new Converter();
		public WorkingDir WD = new WorkingDir();

		public bool NorthStickRight = false;
		public string NorthMessage = ""; // "" == メッセージの通知なし
		public string SouthMessage = ""; // "" == メッセージの通知なし
		public string SouthWestMessage = ""; // "" == メッセージの通知なし
		public bool SouthWestColorActive = false;
		public bool ConverterEnabled = false;
	}
}
