using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Charlotte
{
	public class AudioInfo
	{
		public static string[] StatusStrings = new string[]
		{
			"",
			"処理中",
			"エラー",
			"処理成功",
		};

		public enum Status_e
		{
			READY,
			PROCESSING,
			ERROR,
			SUCCESSFUL,
		}

		public Status_e Status = Status_e.READY;
		public string ErrorMessage = ""; // "" == エラーなし || エラー情報なし
		public string AudioFile = ""; // "" == 未設定
		public string ImageFile = ""; // "" == 未設定
		public string MovieFile = ""; // "" == 未設定
		public int FPS = Ground.I.DefaultFPS;

		// <---- ここまで行に保存される。

		// none
	}
}
