﻿using System;
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

			try
			{
				Screen screen = Screen.AllScreens[0];

				this.画像を二重に表示_MonitorW = screen.Bounds.Width;
				this.画像を二重に表示_MonitorH = screen.Bounds.Height;
			}
			catch
			{
				this.画像を二重に表示_MonitorW = Consts.MonitorW_Min;
				this.画像を二重に表示_MonitorH = Consts.MonitorH_Min;
			}

			this.画像を二重に表示_MonitorW = IntTools.ToRange(this.画像を二重に表示_MonitorW, Consts.MonitorW_Min, Consts.MonitorW_Max);
			this.画像を二重に表示_MonitorH = IntTools.ToRange(this.画像を二重に表示_MonitorH, Consts.MonitorH_Min, Consts.MonitorH_Max);
		}

		public void LoadFromFile()
		{
			try
			{
				if (File.Exists(this.SaveFile) == false)
					return;

				string[] lines = File.ReadAllLines(this.SaveFile, Encoding.UTF8);
				int c = 0;

				if (int.Parse(lines[c++]) != lines.Length)
					throw new Exception("Bad item number");

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
				this.XPressAndStopConverter = lines[c++] == Consts.S_TRUE;
				this.IgnoreBeginDot = lines[c++] == Consts.S_TRUE;
				this.画像を二重に表示 = lines[c++] == Consts.S_TRUE;
				this.画像を二重に表示_MonitorW = int.Parse(lines[c++]);
				this.画像を二重に表示_MonitorH = int.Parse(lines[c++]);
				this.画像を二重に表示_ぼかし = int.Parse(lines[c++]);
				this.画像を二重に表示_明るさ = int.Parse(lines[c++]);

				// ----
			}
			catch (Exception e)
			{
				ProcMain.WriteLog(e);

				//MessageBox.Show(e.Message, "データファイル読み込みエラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public void SaveToFile()
		{
			{
				List<string> lines = new List<string>();

				lines.Add(null);

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
				lines.Add(this.XPressAndStopConverter ? Consts.S_TRUE : Consts.S_FALSE);
				lines.Add(this.IgnoreBeginDot ? Consts.S_TRUE : Consts.S_FALSE);
				lines.Add(this.画像を二重に表示 ? Consts.S_TRUE : Consts.S_FALSE);
				lines.Add("" + this.画像を二重に表示_MonitorW);
				lines.Add("" + this.画像を二重に表示_MonitorH);
				lines.Add("" + this.画像を二重に表示_ぼかし);
				lines.Add("" + this.画像を二重に表示_明るさ);

				// ----

				lines[0] = "" + lines.Count;

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
		public bool XPressAndStopConverter = false;
		public bool IgnoreBeginDot = false;
		public bool 画像を二重に表示 = false;
		public int 画像を二重に表示_MonitorW; // Consts.MonitorW_Min ～ Consts.MonitorW_Max
		public int 画像を二重に表示_MonitorH; // Consts.MonitorH_Min ～ Consts.MonitorH_Max
		public int 画像を二重に表示_ぼかし = 30; // 0 ～ 100
		public int 画像を二重に表示_明るさ = 50; // 0 ～ 100

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
		public bool ConverterActive = false;
	}
}
