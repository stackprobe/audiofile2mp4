using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Charlotte.Tools;
using System.Windows.Forms;
using System.Drawing;

namespace Charlotte
{
	public class Consts
	{
		public const string S_TRUE = "true";
		public const string S_FALSE = "false";

		public const int FPS_MIN = 1;
		public const int FPS_DEF = 3;
		public const int FPS_MAX = 30;

		public const string IMAGE_INITIAL_FILE = "*.bmp;*.gif;*.jpg;*.jpeg;*.png";
		public const string IMAGE_FILTER = "画像ファイル(*.bmp;*.gif;*.jpg;*.jpeg;*.png)|*.bmp;*.gif;*.jpg;*.jpeg;*.png|すべてのファイル(*.*)|*.*";

		public const string MOVIE_EXT = ".mp4";

		public static readonly Color LabelDefForeColor = new Label().ForeColor;
		public static readonly Color LabelDefBackColor = new Label().BackColor;
	}
}
