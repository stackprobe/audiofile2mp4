using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Charlotte.Tools;

namespace Charlotte
{
	public partial class InputFPSDlg : Form
	{
		public bool OkPressed = false;
		public int Ret_FPS;

		public InputFPSDlg()
		{
			InitializeComponent();

			this.MinimumSize = this.Size;
		}

		private void InputFPSDlg_Load(object sender, EventArgs e)
		{
			// noop
		}

		private void InputFPSDlg_Shown(object sender, EventArgs e)
		{
			this.FPS.Value = Ground.I.DefaultFPS;
		}

		private void BtnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void BtnOk_Click(object sender, EventArgs e)
		{
			this.OkPressed = true;

			{
				int value = (int)this.FPS.Value;
				value = IntTools.Range(value, Consts.FPS_MIN, Consts.FPS_MAX);
				this.Ret_FPS = value;
			}

			this.Close();
		}
	}
}
