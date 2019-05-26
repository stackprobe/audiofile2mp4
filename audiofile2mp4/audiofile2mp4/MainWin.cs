﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Charlotte.Tools;
using System.Security.Permissions;
using System.IO;
using System.Collections;

namespace Charlotte
{
	public partial class MainWin : Form
	{
		#region ALT_F4 抑止

		private bool RequestCloseWindow = false;

		[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
		protected override void WndProc(ref Message m)
		{
			const int WM_SYSCOMMAND = 0x112;
			const long SC_CLOSE = 0xF060L;

			if (m.Msg == WM_SYSCOMMAND && (m.WParam.ToInt64() & 0xFFF0L) == SC_CLOSE)
			{
				this.RequestCloseWindow = true;
				return;
			}
			base.WndProc(ref m);
		}

		#endregion

		public MainWin()
		{
			InitializeComponent();
		}

		private void MainWin_Load(object sender, EventArgs e)
		{
			{
				string logFile = Path.Combine(ProcMain.SelfDir, Path.GetFileNameWithoutExtension(ProcMain.SelfFile) + ".log");

				File.Delete(logFile);

				ProcMain.WriteLog = message =>
				{
					try
					{
						using (new MSection("{67bbcf7a-ebe2-42a9-aeb2-54ee4bb40c67}")) // 念の為ロック
						{
							using (StreamWriter writer = new StreamWriter(logFile, true, Encoding.UTF8))
							{
								writer.WriteLine("[" + DateTime.Now + "] " + message);
							}
						}
					}
					catch
					{ }
				};
			}

			Ground.I.LoadFromFile();

			if (Ground.I.MainWin_Maximized)
			{
				this.WindowState = FormWindowState.Maximized;
			}
			else if (Ground.I.MainWin_W != -1)
			{
				this.Left = Ground.I.MainWin_L;
				this.Top = Ground.I.MainWin_T;
				this.Width = Ground.I.MainWin_W;
				this.Height = Ground.I.MainWin_H;
			}
		}

		private void MainWin_Shown(object sender, EventArgs e)
		{
			this.MS_Init();

			this.South.Text = "";
			this.SouthWest.Text = "";

			this.RefreshUI();

			// ----

			this.MTEnabled = true;
		}

		private void RefreshUI()
		{
			this.Converter開始MenuItem.Checked = Ground.I.ConverterEnabled;
			this.Converter停止MenuItem.Checked = Ground.I.ConverterEnabled == false;

			this.MS_Refresh();

			this.MSMonitorStart();
		}

		private void MainWin_FormClosing(object sender, FormClosingEventArgs e)
		{
			// noop
		}

		private void MainWin_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.MTEnabled = false;

			// ----

			Ground.I.SaveToFile();
		}

		private void BeforeDialog()
		{
			this.MTEnabled = false;
		}

		private void AfterDialog()
		{
			this.MTEnabled = true;
		}

		private void CloseWindow()
		{
			// ---- 9001

			if (Ground.I.ConverterEnabled)
			{
				Ground.I.SouthMessage = "アプリケーションを終了するにはコンバータを停止して下さい。";
				return;
			}
			if (Ground.I.Converter.IsReady() == false)
			{
				Ground.I.SouthMessage = "アプリケーションを終了するにはコンバータが停止するまでお待ちください。";
				return;
			}

			// ----

			this.MTEnabled = false;

			// ---- 9009

			Ground.I.MainWin_Maximized = this.WindowState == FormWindowState.Maximized;

			if (this.WindowState == FormWindowState.Normal)
			{
				Ground.I.MainWin_L = this.Left;
				Ground.I.MainWin_T = this.Top;
				Ground.I.MainWin_W = this.Width;
				Ground.I.MainWin_H = this.Height;
			}

			// ----

			this.Close();
		}

		private bool MTEnabled;
		private bool MTBusy;
		private long MTCount;

		private int SouthMessageDisplayTimerCount = 0;
		private MSMonitor MSMonitor = new MSMonitor();
		private int PatrolRowIndex = 0;

		private void MSMonitorStart()
		{
			this.MSMonitor = new MSMonitor();
		}

		private void MainTimer_Tick(object sender, EventArgs e)
		{
			if (this.MTEnabled == false || this.MTBusy)
				return;

			this.MTBusy = true;

			try
			{
				// ---- 3001

				if (this.RequestCloseWindow)
				{
					this.RequestCloseWindow = false;
					this.CloseWindow();
					return;
				}

				if (Ground.I.SouthMessage != "")
				{
					this.South.Text = Ground.I.SouthMessage;
					Ground.I.SouthMessage = "";
					this.SouthMessageDisplayTimerCount = 0;
				}
				if (this.South.Text != "" && Ground.I.Config.SouthMessageDisplayTimerCountMax < ++this.SouthMessageDisplayTimerCount)
					this.South.Text = "";

				if (Ground.I.SouthWestMessage != "")
				{
					if (this.SouthWest.Text != Ground.I.SouthWestMessage)
						this.SouthWest.Text = Ground.I.SouthWestMessage;

					Ground.I.SouthWestMessage = "";
				}

				{
					MSMonitor mon = this.MSMonitor;

					for (int c = 0; c < 300; c++) // XXX ループ回数
					{
						if (this.MainSheet.RowCount <= mon.RowIndex)
							break;

						{
							AudioInfo info = this.MS_GetRow(mon.RowIndex);

							if (info.Status == AudioInfo.Status_e.READY)
								mon.ReadyCount++;
							else if (info.Status == AudioInfo.Status_e.PROCESSING)
								mon.ProcessingCount++;
							else if (info.Status == AudioInfo.Status_e.ERROR)
								mon.ErrorCount++;
							else if (info.Status == AudioInfo.Status_e.SUCCESSFUL)
								mon.SuccessfulCount++;
							else
								throw null; // never
						}

						mon.RowIndex++;
					}

					if (this.MTCount % 5 == 0) // 頻度を下げる。
					{
						Ground.I.SouthWestMessage =
							(Ground.I.ConverterEnabled ? "[処理中]" : "[待機中]")
							+ " / " + this.MainSheet.RowCount + " 行 中 " + this.MainSheet.SelectedRows.Count + " 行 選択中 / 待機中 = " + mon.ReadyCount
							+ " / 処理中 = " + mon.ProcessingCount
							+ " / 失敗 = " + mon.ErrorCount
							+ " / 成功 = " + mon.SuccessfulCount;
					}
				}

				if (Ground.I.Converter.IsCompleted())
				{
					ConverterTask task = Ground.I.Converter.GetTask();
					AudioInfo info = task.Info;
					int rowidx = this.MS_GetProcessingRowIndex();

					if (rowidx == -1)
						throw null;

					this.MS_SetRow(rowidx, info);
					this.PatrolRowIndex = task.MS_RowIndex + 1;
					Ground.I.Converter.Reset();
				}

				if (1 <= this.MainSheet.RowCount)
				{
					if (this.MainSheet.RowCount <= this.PatrolRowIndex)
						this.PatrolRowIndex = 0;

					// ---- Patrol ----

					if (Ground.I.ConverterEnabled && Ground.I.Converter.IsReady())
					{
						AudioInfo info = this.MS_GetRow(this.PatrolRowIndex);

						if (info.Status == AudioInfo.Status_e.READY)
						{
							info.Status = AudioInfo.Status_e.PROCESSING;
							this.MS_SetRow(this.PatrolRowIndex, info);
							Ground.I.Converter.Start(new ConverterTask()
							{
								Info = info,
								MS_RowIndex = this.PatrolRowIndex,
							});
						}
					}

					// ----

					this.PatrolRowIndex++;
				}
			}
			catch (Exception ex)
			{
				ProcMain.WriteLog(ex);
			}
			finally
			{
				this.MTBusy = false;
				this.MTCount++;
			}
		}

		private int MS_GetProcessingRowIndex()
		{
			return this.MS_GetRowIndex(row => this.MS_GetRow(row.Index).Status == AudioInfo.Status_e.PROCESSING);
		}

		private int MS_GetRowIndex(Predicate<DataGridViewRow> match)
		{
			for (int rowidx = 0; rowidx < this.MainSheet.RowCount; rowidx++)
				if (match(this.MainSheet.Rows[rowidx]))
					return rowidx;

			return -1;
		}

		private void 終了ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.CloseWindow();
		}

		private void MainSheet_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			// noop
		}

		private void MS_Init()
		{
			this.MainSheet.RowCount = 0;
			this.MainSheet.ColumnCount = 0;

			ExtraTools.SetEnabledDoubleBuffer(this.MainSheet);

			this.MS_AddColumn("ステータス", 100); // 0
			this.MS_AddColumn("エラー情報", 100); // 1
			this.MS_AddColumn("音楽ファイル (入力)", 600); // 2 絶対パス
			this.MS_AddColumn("音楽ファイル (入力)", 300); // 3 ローカルパス
			this.MS_AddColumn("映像用の画像 (入力)", 600); // 4 絶対パス
			this.MS_AddColumn("映像用の画像 (入力)", 300); // 5 ローカルパス
			this.MS_AddColumn("動画ファイル (出力)", 600); // 6 絶対パス
			this.MS_AddColumn("動画ファイル (出力)", 300); // 7 ローカルパス
			this.MS_AddColumn("FPS", 100, true); // 8

			this.MS_Refresh();
		}

		private void MS_Refresh()
		{
			this.MainSheet.Columns[2].Visible = Ground.I.MS_AudioFile_FullPath;
			this.MainSheet.Columns[3].Visible = Ground.I.MS_AudioFile_FullPath == false;
			this.MainSheet.Columns[4].Visible = Ground.I.MS_ImageFile_FullPath;
			this.MainSheet.Columns[5].Visible = Ground.I.MS_ImageFile_FullPath == false;
			this.MainSheet.Columns[6].Visible = Ground.I.MS_MovieFile_FullPath;
			this.MainSheet.Columns[7].Visible = Ground.I.MS_MovieFile_FullPath == false;
		}

		private void MS_AddColumn(string title, int width, bool rightAlign = false)
		{
			this.MainSheet.ColumnCount++;
			DataGridViewColumn column = this.MainSheet.Columns[this.MainSheet.ColumnCount - 1];

			column.HeaderText = title;
			column.Width = width;

			if (rightAlign)
				column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

			column.SortMode = DataGridViewColumnSortMode.Programmatic;
		}

		private AudioInfo MS_GetRow(int rowidx)
		{
			DataGridViewRow row = this.MainSheet.Rows[rowidx];

			return new AudioInfo()
			{
				Status = (AudioInfo.Status_e)ArrayTools.IndexOf(AudioInfo.StatusStrings, v => v == "" + row.Cells[0].Value),
				ErrorMessage = "" + row.Cells[1].Value,
				AudioFile = "" + row.Cells[2].Value,
				ImageFile = "" + row.Cells[4].Value,
				MovieFile = "" + row.Cells[6].Value,
				FPS = int.Parse("" + row.Cells[8].Value),
			};
		}

		private void MS_SetRow(int rowidx, AudioInfo info)
		{
			DataGridViewRow row = this.MainSheet.Rows[rowidx];

			row.Cells[0].Value = AudioInfo.StatusStrings[(int)info.Status];
			row.Cells[1].Value = info.ErrorMessage;
			row.Cells[2].Value = info.AudioFile;
			row.Cells[3].Value = info.AudioFile == "" ? "" : Path.GetFileName(info.AudioFile);
			row.Cells[4].Value = info.ImageFile;
			row.Cells[5].Value = info.ImageFile == "" ? "" : Path.GetFileName(info.ImageFile);
			row.Cells[6].Value = info.MovieFile;
			row.Cells[7].Value = info.MovieFile == "" ? "" : Path.GetFileName(info.MovieFile);
			row.Cells[8].Value = "" + info.FPS;

			this.MS_SetRowEffect(rowidx);
		}

		private void MS_SetRowEffect(int rowidx)
		{
			DataGridViewRow row = this.MainSheet.Rows[rowidx];
			AudioInfo info = this.MS_GetRow(rowidx);

			Color backColor = Color.White;

			if (info.Status == AudioInfo.Status_e.PROCESSING)
			{
				backColor = Color.FromArgb(222, 255, 222);
			}
			else if (info.Status == AudioInfo.Status_e.ERROR)
			{
				backColor = Color.FromArgb(255, 222, 222);
			}
			else if (info.Status == AudioInfo.Status_e.SUCCESSFUL)
			{
				backColor = Color.FromArgb(222, 222, 255);
			}

			row.DefaultCellStyle.BackColor = backColor;
		}

		private void ffmpegの場所ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.BeforeDialog();

			using (InputDirDlg f = new InputDirDlg())
			{
				f.DirKindTitle = "ffmpegのフォルダ";
				f.Dir = Ground.I.FFmpegDir;

				f.ShowDialog();

				if (f.OkPressed)
				{
					Ground.I.FFmpegDir = f.Dir;
				}
			}

			this.AfterDialog();
		}

		private void OutputDirMenuItem_Click(object sender, EventArgs e)
		{
			this.BeforeDialog();

			using (InputDirDlg f = new InputDirDlg())
			{
				f.DirKindTitle = "出力先フォルダ";
				f.Dir = Ground.I.OutputDir;

				f.ShowDialog();

				if (f.OkPressed)
				{
					Ground.I.OutputDir = f.Dir;
				}
			}

			this.AfterDialog();
		}

		private void Default映像用の画像MenuItem_Click(object sender, EventArgs e)
		{
			this.BeforeDialog();

			using (InputDirDlg f = new InputDirDlg())
			{
				f.DirKindTitle = "デフォルトの「映像用の画像」";
				f.Dir = Ground.I.DefaultImageFile;
				f.Dirじゃなくて読み込みファイル = true;

				f.ShowDialog();

				if (f.OkPressed)
				{
					Ground.I.DefaultImageFile = f.Dir;
				}
			}

			this.AfterDialog();
		}

		private void その他ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.BeforeDialog();

			using (SettingDlg f = new SettingDlg())
			{
				f.ShowDialog();
			}

			this.MS_Refresh();
			this.AfterDialog();
		}

		private void MainSheet_DragEnter(object sender, DragEventArgs e)
		{
			e.Effect = DragDropEffects.Copy;
		}

		private List<AudioInfo> AddedInfos = null;

		private void MainSheet_DragDrop(object sender, DragEventArgs e)
		{
			this.BeforeDialog();

			try
			{
				if (Ground.I.OutputDir == "")
					throw new Exception("出力先フォルダを設定して下さい。");

				if (e.Data.GetDataPresent(DataFormats.FileDrop) == false)
					throw new Exception("ファイル又はフォルダをドロップして下さい。");

				this.AddedInfos = new List<AudioInfo>();

				foreach (string path in (string[])e.Data.GetData(DataFormats.FileDrop))
				{
					this.AddPath(path);
				}
				this.MainSheet.RowCount += this.AddedInfos.Count;

				for (int index = 0; index < this.AddedInfos.Count; index++)
				{
					this.MS_SetRow(this.MainSheet.RowCount - this.AddedInfos.Count + index, this.AddedInfos[index]);
				}
				this.AddedInfos = null;
			}
			catch (Exception ex)
			{
				ProcMain.WriteLog(ex);

				MessageBox.Show(ex.Message, "ファイル又はフォルダの追加に失敗しました", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}

			this.MSMonitorStart();
			this.AfterDialog();
		}

		private void AddPath(string path)
		{
			if (Directory.Exists(path))
			{
				path = FileTools.MakeFullPath(path);

				foreach (string file in Directory.GetFiles(path, "*", SearchOption.AllDirectories))
				{
					this.AddFile(file, path);
				}
			}
			else
			{
				this.AddFile(path);
			}
		}

		private void AddFile(string file, string rootDir = null)
		{
			if (Ground.I.Config.AudioInfoMax <= this.MainSheet.RowCount + this.AddedInfos.Count)
				throw new Exception("ファイルが多すぎます。");

			AudioInfo info;

			try
			{
				if (File.Exists(file) == false)
					throw new Exception("no file");

				file = FileTools.MakeFullPath(file);

				if (Ground.I.AudioExtensions.IsAudioFile(file) == false)
				{
					ProcMain.WriteLog("音楽ファイルではないので追加しません。⇒ " + file);
					return;
				}
				if (Ground.I.同じ音楽ファイルを追加させない)
				{
					int rowidx = this.MS_GetRowIndex(row => StringTools.EqualsIgnoreCase(this.MS_GetRow(row.Index).AudioFile, file));

					if (rowidx != -1)
					{
						ProcMain.WriteLog("音楽ファイルは重複しています。⇒ " + file);
						return;
					}
				}

				string wFile;

				if (rootDir == null)
					wFile = Path.Combine(Ground.I.OutputDir, Path.GetFileName(file));
				else
					wFile = FileTools.ChangeRoot(file, rootDir, Ground.I.OutputDir);

				wFile = Path.Combine(Path.GetDirectoryName(wFile), Path.GetFileNameWithoutExtension(wFile)) + Consts.MOVIE_EXT;

				info = new AudioInfo()
				{
					AudioFile = file,
					ImageFile = Ground.I.DefaultImageFile,
					MovieFile = wFile,
				};
			}
			catch (Exception e)
			{
				ProcMain.WriteLog(e);

				info = new AudioInfo()
				{
					Status = AudioInfo.Status_e.ERROR,
					ErrorMessage = e.Message,
					AudioFile = file,
				};
			}
#if true
			this.AddedInfos.Add(info);
#else // old -- 遅い。
			this.MainSheet.RowCount++;
			this.MS_SetRow(this.MainSheet.RowCount - 1, info);
#endif
		}

		private void MainSheet_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (e.RowIndex == -1)
			{
				this.MS_Sort(e.ColumnIndex);
			}
		}

		private void MS_Sort(int colidx)
		{
			SortOrder order = this.MainSheet.Columns[colidx].HeaderCell.SortGlyphDirection;

			if (order == SortOrder.Ascending)
				order = SortOrder.Descending;
			else
				order = SortOrder.Ascending;

			if (colidx == 8) // 数値カラム
			{
				this.MS_Sort((a, b) => IntTools.Comp(
					int.Parse("" + a.Cells[colidx].Value),
					int.Parse("" + b.Cells[colidx].Value)
					) * (order == SortOrder.Ascending ? 1 : -1));
			}
			else // その他 ⇒ 文字列カラム
			{
				this.MS_Sort((a, b) => StringTools.CompIgnoreCase(
					"" + a.Cells[colidx].Value,
					"" + b.Cells[colidx].Value
					) * (order == SortOrder.Ascending ? 1 : -1));
			}

			for (int ci = 0; ci < this.MainSheet.ColumnCount; ci++)
			{
				this.MainSheet.Columns[ci].HeaderCell.SortGlyphDirection = SortOrder.None;
			}
			this.MainSheet.Columns[colidx].HeaderCell.SortGlyphDirection = order;
		}

		private void MS_Sort(Comparison<DataGridViewRow> comp)
		{
			this.MainSheet.Sort(new MS_Comp()
			{
				Comp = comp,
			});

			this.MainSheet.ClearSelection();
		}

		private class MS_Comp : IComparer
		{
			public Comparison<DataGridViewRow> Comp;

			public int Compare(object a, object b)
			{
				return Comp((DataGridViewRow)a, (DataGridViewRow)b);
			}
		}

		private void 開始ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Ground.I.ConverterEnabled = true;
			Ground.I.SouthMessage = "コンバーターを起動しました。";
			this.PatrolRowIndex = 0;
			this.RefreshUI();
		}

		private void 停止ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Ground.I.ConverterEnabled = false;
			Ground.I.SouthMessage = "コンバーターの停止をリクエストしました。停止するまで時間が掛かる場合があります。";
			this.RefreshUI();
		}

		private void エラーを解除するToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Ground.I.ConverterEnabled = false;
			Ground.I.SouthMessage = "エラーを解除しました。";
			this.ClearErrorAllRow();
			this.RefreshUI();
		}

		private void エラーを解除して再開するToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Ground.I.ConverterEnabled = true;
			Ground.I.SouthMessage = "エラーを解除して、コンバーターを起動しました。";
			this.PatrolRowIndex = 0;
			this.ClearErrorAllRow();
			this.RefreshUI();
		}

		private void ClearErrorAllRow()
		{
			for (int rowidx = 0; rowidx < this.MainSheet.RowCount; rowidx++)
			{
				AudioInfo info = this.MS_GetRow(rowidx);

				if (info.Status == AudioInfo.Status_e.ERROR)
					info.Status = AudioInfo.Status_e.READY;

				this.MS_SetRow(rowidx, info);
			}
		}

		private void 選択解除ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.MainSheet.ClearSelection();
		}

		private void 全て選択するToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.MainSheet.SelectAll();
		}

		private void SelectReadyRowMenuItem_Click(object sender, EventArgs e)
		{
			this.SelectRows(row => this.MS_GetRow(row.Index).Status == AudioInfo.Status_e.READY);
		}

		private void SelectErrorRowMenuItem_Click(object sender, EventArgs e)
		{
			this.SelectRows(row => this.MS_GetRow(row.Index).Status == AudioInfo.Status_e.ERROR);
		}

		private void SelectSuccessfulRowMenuItem_Click(object sender, EventArgs e)
		{
			this.SelectRows(row => this.MS_GetRow(row.Index).Status == AudioInfo.Status_e.SUCCESSFUL);
		}

		private void SelectRows(Predicate<DataGridViewRow> match)
		{
			for (int rowidx = 0; rowidx < this.MainSheet.RowCount; rowidx++)
			{
				this.MainSheet.Rows[rowidx].Selected = match(this.MainSheet.Rows[rowidx]);
			}
		}

		private void リフレッシュToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.MSMonitorStart();
		}

		private void 削除ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.RemoveRows(row => row.Selected);
		}

		private void 全てクリアToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.RemoveRows(row => true);
		}

		private void RemoveRows(Predicate<DataGridViewRow> match)
		{
			this.MainSheet.Visible = false;

			for (int rowidx = this.MainSheet.RowCount - 1; 0 <= rowidx; rowidx--)
			{
				if (match(this.MainSheet.Rows[rowidx]))
				{
					AudioInfo info = this.MS_GetRow(rowidx);

					if (info.Status == AudioInfo.Status_e.PROCESSING)
					{
						Ground.I.SouthMessage = "処理中の行はクリア出来ません。";
					}
					else
					{
						this.MainSheet.Rows.RemoveAt(rowidx);
					}
				}
			}

			this.MainSheet.Visible = true;
		}

		private void 映像用の画像を設定するToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.BeforeDialog();

			try
			{
				string file = SaveLoadDialogs.LoadFile(
					"映像用の画像を選択して下さい。",
					"",
					Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
					Consts.IMAGE_INITIAL_FILE,
					dlg => dlg.Filter = Consts.IMAGE_FILTER
					);

				if (file != null)
				{
					file = FileTools.MakeFullPath(file);

					for (int rowidx = 0; rowidx < this.MainSheet.RowCount; rowidx++)
					{
						if (this.MainSheet.Rows[rowidx].Selected)
						{
							AudioInfo info = this.MS_GetRow(rowidx);

							info.ImageFile = file;

							this.MS_SetRow(rowidx, info);
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProcMain.WriteLog(ex);

				MessageBox.Show(ex.Message, "映像用の画像の設定に失敗しました", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}

			this.AfterDialog();
		}
	}
}
