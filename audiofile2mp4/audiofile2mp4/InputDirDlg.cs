using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Charlotte.Tools;

namespace Charlotte
{
	public partial class InputDirDlg : Form
	{
		public string DirKindTitle;
		public string Dir;
		public bool Dir無かったら作成する = false;
		public bool Dirじゃなくて読み込みファイル = false;
		public string File_InitialFile = Consts.IMAGE_INITIAL_FILE;
		public string File_Filter = Consts.IMAGE_FILTER;

		// <--- prm

		public bool OkPressed = false;

		public InputDirDlg()
		{
			InitializeComponent();

			this.MinimumSize = this.Size;
		}

		private void InputDirDlg_Load(object sender, EventArgs e)
		{
			// noop
		}

		private void InputDirDlg_Shown(object sender, EventArgs e)
		{
			this.Text = this.DirKindTitle + "選択ダイアログ";
			this.SelectedDirLabel.Text = this.DirKindTitle + "：";
			this.SelectedDir.Text = this.Dir;
			this.SelectedDir.SelectAll();
		}

		private void InputDirDlg_FormClosing(object sender, FormClosingEventArgs e)
		{
			// noop
		}

		private void InputDirDlg_FormClosed(object sender, FormClosedEventArgs e)
		{
			// noop
		}

		private void BtnSelectDir_Click(object sender, EventArgs e)
		{
			string dir = this.SelectedDir.Text;

			if (this.Dirじゃなくて読み込みファイル)
			{
				string file = dir;

				file = SaveLoadDialogs.LoadFile(
					this.DirKindTitle + "を選択して下さい。",
					"",
					file == "" ? Environment.GetFolderPath(Environment.SpecialFolder.Desktop) : Path.GetDirectoryName(file),
					file == "" ? this.File_InitialFile : Path.GetFileName(file),
					dlg => dlg.Filter = this.File_Filter
					);

				if (file != null)
				{
					this.SelectedDir.Text = file;
				}
			}
			else
			{
				if (SaveLoadDialogs.SelectFolder(ref dir, this.DirKindTitle + "を選択して下さい。"))
				{
					this.SelectedDir.Text = dir;
				}
			}
		}

		private void BtnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void BtnOk_Click(object sender, EventArgs e)
		{
			try
			{
				string dir = this.SelectedDir.Text;

				dir = FileTools.MakeFullPath(dir);

				if (this.Dir無かったら作成する)
				{
					if (Directory.Exists(dir) == false)
					{
						if (MessageBox.Show(
							"指定されたフォルダは存在しません。\n作成して宜しいですか？",
							"確認",
							MessageBoxButtons.OKCancel,
							MessageBoxIcon.Question
							)
							!= DialogResult.OK
							)
							return;

						FileTools.CreateDir(dir);
					}
				}
				else if (this.Dirじゃなくて読み込みファイル)
				{
					string file = dir;

					if (File.Exists(file) == false)
						throw new Exception("指定されたファイルは存在しません。");
				}
				else
				{
					if (Directory.Exists(dir) == false)
						throw new Exception("指定されたフォルダは存在しません。");
				}

				this.Dir = dir;
				this.OkPressed = true;
				this.Close();
			}
			catch (Exception ex)
			{
				ProcMain.WriteLog(ex);

				MessageBox.Show(ex.Message, "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void SelectedDir_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)13) // enter
			{
				this.BtnOk.Focus();
				e.Handled = true;
			}
		}
	}
}
