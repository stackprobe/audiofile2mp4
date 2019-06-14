using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using Charlotte.Tools;
using System.Diagnostics;

namespace Charlotte
{
	public class ConverterTask
	{
		public AudioInfo Info;

		// <--- prm

		private Process Proc = null;
		private string WorkDir = null;
		private string ErrorMessageFile = null;
		private string LogFile = null;
		private Exception Ex = null;

		public void Start()
		{
			try
			{
				this.StartMain();
			}
			catch (Exception e)
			{
				this.Ex = e;
			}
		}

		private void StartMain()
		{
			if (this.Info.AudioFile == "")
				throw new Exception("音楽ファイルが指定されていません。");

			if (this.Info.ImageFile == "")
				throw new Exception("映像用の画像が指定されていません。");

			if (this.Info.MovieFile == "")
				throw new Exception("動画ファイル(出力先)が指定されていません。");

			if (File.Exists(this.Info.AudioFile) == false)
				throw new Exception("音楽ファイルが見つかりません。");

			if (File.Exists(this.Info.ImageFile) == false)
				throw new Exception("映像用の画像が見つかりません。");

			if (File.Exists(this.Info.MovieFile) && Ground.I.AllowOverwrite == false)
				throw new Exception("動画ファイル(出力先)は既に存在します。(上書きは許可されていません)");

			if (Ground.I.FFmpegDir == "")
				throw new Exception("ffmpegフォルダが設定されていません。");

			if (Directory.Exists(Ground.I.FFmpegDir) == false)
				throw new Exception("ffmpegフォルダが見つかりません。");

			this.WorkDir = Ground.I.WD.MakePath();
			this.ErrorMessageFile = Ground.I.WD.MakePath();
			this.LogFile = Ground.I.WD.MakePath();

			//FileTools.CreateDir(this.WorkDir); // 作成不要

			FileTools.CreateDir(Path.GetDirectoryName(this.Info.MovieFile));

			File.WriteAllBytes(this.Info.MovieFile, BinTools.EMPTY); // 書き込みテスト
			FileTools.Delete(this.Info.MovieFile);

			this.Proc = ProcessTools.Start(
				CommonUtils.GetConverterFile(),
				string.Join(" ", new string[]
				{
					"/WD",
					CommonUtils.Encode(this.WorkDir),
					"/FFMD",
					CommonUtils.Encode(Ground.I.FFmpegDir),
					"/ITF",
					CommonUtils.Encode(CommonUtils.GetImgToolsFile()),
					"/BCF",
					CommonUtils.Encode(CommonUtils.GetBmpToCsvFile()),
					"/AF",
					CommonUtils.Encode(this.Info.AudioFile),
					"/IF",
					CommonUtils.Encode(this.Info.ImageFile),
					"/MF",
					CommonUtils.Encode(this.Info.MovieFile),
					"/FPS",
					"" + this.Info.FPS,
					"/JQ",
					"" + Ground.I.Config.JpegQuality,
					"/EMF",
					CommonUtils.Encode(this.ErrorMessageFile),
					"/LF",
					CommonUtils.Encode(this.LogFile),
					"/AG",
					"" + (Ground.I.Config.ApproveGuest ? 1 : 0),
				})
				);
		}

		public bool IsCompleted()
		{
			if (this.Proc != null && this.Proc.HasExited)
				this.Proc = null;

			if (this.Proc == null)
				this.End();

			return this.Proc == null;
		}

		private bool Ended = false;

		private void End()
		{
			if (this.Ended == false)
			{
				this.EndMain();
				this.Ended = true;
			}
		}

		private void EndMain()
		{
			Exception e = this.Ex;

			if (e == null)
			{
				try
				{
					ProcMain.WriteLog("コンバータのログ ----> " + File.ReadAllText(this.LogFile, Encoding.UTF8) + " <---- ここまで");

					if (File.Exists(this.ErrorMessageFile))
						throw new Exception(File.ReadAllText(this.ErrorMessageFile, Encoding.UTF8).Trim());
				}
				catch (Exception ex)
				{
					e = ex;
				}
			}

			try { FileTools.Delete(this.WorkDir); }
			catch { }

			try { FileTools.Delete(this.ErrorMessageFile); }
			catch { }

			try { FileTools.Delete(this.LogFile); }
			catch { }

			if (e == null)
			{
				this.Info.Status = AudioInfo.Status_e.SUCCESSFUL;
				this.Info.ErrorMessage = "";
			}
			else
			{
				ProcMain.WriteLog(e);

				this.Info.Status = AudioInfo.Status_e.ERROR;
				this.Info.ErrorMessage = e.Message;
			}
		}
	}
}
