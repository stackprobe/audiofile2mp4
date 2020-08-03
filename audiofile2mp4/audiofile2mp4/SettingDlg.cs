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
	public partial class SettingDlg : Form
	{
		public SettingDlg()
		{
			InitializeComponent();

			this.MinimumSize = this.Size;
		}

		private void SettingDlg_Load(object sender, EventArgs e)
		{
			// noop
		}

		private void SettingDlg_Shown(object sender, EventArgs e)
		{
			this.LoadSetting();
			this.RefreshUI();

			CommonUtils.PostShown(this);
		}

		private void LoadSetting()
		{
			this.CB_MS_AudioFile_FullPath.Checked = Ground.I.MS_AudioFile_FullPath;
			this.CB_MS_ImageFile_FullPath.Checked = Ground.I.MS_ImageFile_FullPath;
			this.CB_MS_MovieFile_FullPath.Checked = Ground.I.MS_MovieFile_FullPath;

			this.DefaultFPS.Value = Ground.I.DefaultFPS;
			this.AllowOverwrite.Checked = Ground.I.AllowOverwrite;
			this.同じ音楽ファイルを追加させない.Checked = Ground.I.同じ音楽ファイルを追加させない;
			this.XPressAndStopConverter.Checked = Ground.I.XPressAndStopConverter;
			this.IgnoreBeginDot.Checked = Ground.I.IgnoreBeginDot;
			this.画像を二重に表示.Checked = Ground.I.画像を二重に表示;
			this.画像を二重に表示_MonitorW.Value = Ground.I.画像を二重に表示_MonitorW;
			this.画像を二重に表示_MonitorH.Value = Ground.I.画像を二重に表示_MonitorH;
			this.画像を二重に表示_ぼかし.Value = Ground.I.画像を二重に表示_ぼかし;
			this.画像を二重に表示_明るさ.Value = Ground.I.画像を二重に表示_明るさ;
			this.MasteringFlag.Checked = Ground.I.MasteringFlag;
			this.UseSameNameImageFile.Checked = Ground.I.UseSameNameImageFile;
		}

		private void SaveSetting()
		{
			this.ErrorProv.Clear();

			{
				int value = (int)this.DefaultFPS.Value;

				if (value < Consts.FPS_MIN || Consts.FPS_MAX < value)
				{
					this.ErrorProv.SetError(this.DefaultFPS, Consts.FPS_MIN + " から " + Consts.FPS_MAX + " まで");
					this.MainTab.SelectedTab = this.Tab_基本;
					throw null;
				}
			}

			if (this.画像を二重に表示.Checked)
			{
				{
					int value = (int)this.画像を二重に表示_MonitorW.Value;

					if (value % 2 != 0)
					{
						this.ErrorProv.SetError(this.画像を二重に表示_MonitorW, "画面の幅は偶数でなければなりません。");
						this.MainTab.SelectedTab = this.Tab_二重に表示;
						throw null;
					}
				}

				{
					int value = (int)this.画像を二重に表示_MonitorH.Value;

					if (value % 2 != 0)
					{
						this.ErrorProv.SetError(this.画像を二重に表示_MonitorH, "画面の高さは偶数でなければなりません。");
						this.MainTab.SelectedTab = this.Tab_二重に表示;
						throw null;
					}
				}
			}

			// <--- check

			Ground.I.MS_AudioFile_FullPath = this.CB_MS_AudioFile_FullPath.Checked;
			Ground.I.MS_ImageFile_FullPath = this.CB_MS_ImageFile_FullPath.Checked;
			Ground.I.MS_MovieFile_FullPath = this.CB_MS_MovieFile_FullPath.Checked;

			Ground.I.DefaultFPS = (int)this.DefaultFPS.Value;
			Ground.I.AllowOverwrite = this.AllowOverwrite.Checked;
			Ground.I.同じ音楽ファイルを追加させない = this.同じ音楽ファイルを追加させない.Checked;
			Ground.I.XPressAndStopConverter = this.XPressAndStopConverter.Checked;
			Ground.I.IgnoreBeginDot = this.IgnoreBeginDot.Checked;
			Ground.I.画像を二重に表示 = this.画像を二重に表示.Checked;
			Ground.I.画像を二重に表示_MonitorW = (int)this.画像を二重に表示_MonitorW.Value;
			Ground.I.画像を二重に表示_MonitorH = (int)this.画像を二重に表示_MonitorH.Value;
			Ground.I.画像を二重に表示_ぼかし = (int)this.画像を二重に表示_ぼかし.Value;
			Ground.I.画像を二重に表示_明るさ = (int)this.画像を二重に表示_明るさ.Value;
			Ground.I.MasteringFlag = this.MasteringFlag.Checked;
			Ground.I.UseSameNameImageFile = this.UseSameNameImageFile.Checked;
		}

		private void BtnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void BtnOk_Click(object sender, EventArgs e)
		{
			try
			{
				this.SaveSetting();
				this.Close();
			}
			catch (Exception ex)
			{
				ProcMain.WriteLog(ex);

				//MessageBox.Show(ex.Message, "保存に失敗しました", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void RefreshUI()
		{
			this.画像を二重に表示Grp.Enabled = this.画像を二重に表示.Checked;
		}

		private void 画像を二重に表示_CheckedChanged(object sender, EventArgs e)
		{
			this.RefreshUI();
		}
	}
}
