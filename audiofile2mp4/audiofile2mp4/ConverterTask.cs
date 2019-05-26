using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using Charlotte.Tools;

namespace Charlotte
{
	public class ConverterTask
	{
		public AudioInfo Info;
		public int MS_RowIndex;

		// <--- prm

		private Thread Th = null; // 仮
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

			if (File.Exists(this.Info.AudioFile) == false)
				throw new Exception("映像用の画像が見つかりません。");

			if (File.Exists(this.Info.MovieFile) && Ground.I.AllowOverwrite)
				throw new Exception("動画ファイル(出力先)は既に存在します。(上書きは許可されていません)");

			FileTools.CreateDir(Path.GetDirectoryName(this.Info.MovieFile));

			File.WriteAllBytes(this.Info.MovieFile, BinTools.EMPTY); // 書き込みテスト
			FileTools.Delete(this.Info.MovieFile);



			// TODO



			this.Th = new Thread(() =>
			{
				Thread.Sleep(5000); // ダミー処理

				File.WriteAllText(this.Info.MovieFile, "1234", Encoding.UTF8); // ダミーデータ
			});
		}

		public bool IsCompleted()
		{
			if (this.Th != null && this.Th.IsAlive == false)
				this.Th = null;

			if (this.Th == null)
				this.End();

			return this.Th == null;
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
