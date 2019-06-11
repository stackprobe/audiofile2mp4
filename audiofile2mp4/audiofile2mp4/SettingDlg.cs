﻿using System;
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
		}

		private void SaveSetting()
		{
			{
				int value = (int)this.DefaultFPS.Value;

				if (value < Consts.FPS_MIN || Consts.FPS_MAX < value)
				{
					this.ErrorProv.SetError(this.DefaultFPS, Consts.FPS_MIN + " から " + Consts.FPS_MAX + " まで");
					throw null;
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
	}
}
