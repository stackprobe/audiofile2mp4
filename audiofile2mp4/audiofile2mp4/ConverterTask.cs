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

		public void MainTh()
		{
			try
			{
				this.Main2();

				this.Info.Status = AudioInfo.Status_e.SUCCESSFUL;
				this.Info.ErrorMessage = "";
			}
			catch (Exception e)
			{
				ProcMain.WriteLog(e);

				this.Info.Status = AudioInfo.Status_e.ERROR;
				this.Info.ErrorMessage = e.Message;
			}
		}

		private void Main2()
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



			Thread.Sleep(5000); // ダミー処理



			File.WriteAllText(this.Info.MovieFile, "1234", Encoding.UTF8); // ダミーデータ
		}
	}
}
