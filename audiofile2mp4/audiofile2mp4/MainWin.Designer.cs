namespace Charlotte
{
	partial class MainWin
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWin));
			this.MainTimer = new System.Windows.Forms.Timer(this.components);
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.アプリToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.終了ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ffmpegの場所ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.OutputDirMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Default映像用の画像MenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.その他ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.実行ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Converter開始MenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Converter停止MenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
			this.エラーを解除するToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.エラーを解除して再開するToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.South = new System.Windows.Forms.ToolStripStatusLabel();
			this.SouthWest = new System.Windows.Forms.ToolStripStatusLabel();
			this.MainSheet = new System.Windows.Forms.DataGridView();
			this.MainSheetMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.選択解除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.全て選択するToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.リフレッシュToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
			this.削除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.全てクリアToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
			this.映像用の画像を設定するToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.選択ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.SelectReadyRowMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.SelectErrorRowMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.SelectSuccessfulRowMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.MainSheet)).BeginInit();
			this.MainSheetMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// MainTimer
			// 
			this.MainTimer.Enabled = true;
			this.MainTimer.Tick += new System.EventHandler(this.MainTimer_Tick);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.アプリToolStripMenuItem,
            this.設定ToolStripMenuItem,
            this.実行ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(774, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// アプリToolStripMenuItem
			// 
			this.アプリToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.終了ToolStripMenuItem});
			this.アプリToolStripMenuItem.Name = "アプリToolStripMenuItem";
			this.アプリToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
			this.アプリToolStripMenuItem.Text = "アプリ";
			// 
			// 終了ToolStripMenuItem
			// 
			this.終了ToolStripMenuItem.Name = "終了ToolStripMenuItem";
			this.終了ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
			this.終了ToolStripMenuItem.Text = "終了";
			this.終了ToolStripMenuItem.Click += new System.EventHandler(this.終了ToolStripMenuItem_Click);
			// 
			// 設定ToolStripMenuItem
			// 
			this.設定ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ffmpegの場所ToolStripMenuItem,
            this.OutputDirMenuItem,
            this.Default映像用の画像MenuItem,
            this.toolStripMenuItem1,
            this.その他ToolStripMenuItem});
			this.設定ToolStripMenuItem.Name = "設定ToolStripMenuItem";
			this.設定ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
			this.設定ToolStripMenuItem.Text = "設定";
			// 
			// ffmpegの場所ToolStripMenuItem
			// 
			this.ffmpegの場所ToolStripMenuItem.Name = "ffmpegの場所ToolStripMenuItem";
			this.ffmpegの場所ToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
			this.ffmpegの場所ToolStripMenuItem.Text = "ffmpegの場所";
			this.ffmpegの場所ToolStripMenuItem.Click += new System.EventHandler(this.ffmpegの場所ToolStripMenuItem_Click);
			// 
			// OutputDirMenuItem
			// 
			this.OutputDirMenuItem.Name = "OutputDirMenuItem";
			this.OutputDirMenuItem.Size = new System.Drawing.Size(203, 22);
			this.OutputDirMenuItem.Text = "出力先";
			this.OutputDirMenuItem.Click += new System.EventHandler(this.OutputDirMenuItem_Click);
			// 
			// Default映像用の画像MenuItem
			// 
			this.Default映像用の画像MenuItem.Name = "Default映像用の画像MenuItem";
			this.Default映像用の画像MenuItem.Size = new System.Drawing.Size(203, 22);
			this.Default映像用の画像MenuItem.Text = "デフォルト の 映像用の画像";
			this.Default映像用の画像MenuItem.Click += new System.EventHandler(this.Default映像用の画像MenuItem_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(200, 6);
			// 
			// その他ToolStripMenuItem
			// 
			this.その他ToolStripMenuItem.Name = "その他ToolStripMenuItem";
			this.その他ToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
			this.その他ToolStripMenuItem.Text = "その他の設定";
			this.その他ToolStripMenuItem.Click += new System.EventHandler(this.その他ToolStripMenuItem_Click);
			// 
			// 実行ToolStripMenuItem
			// 
			this.実行ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Converter開始MenuItem,
            this.Converter停止MenuItem,
            this.toolStripMenuItem4,
            this.エラーを解除するToolStripMenuItem,
            this.エラーを解除して再開するToolStripMenuItem});
			this.実行ToolStripMenuItem.Name = "実行ToolStripMenuItem";
			this.実行ToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
			this.実行ToolStripMenuItem.Text = "コンバータ";
			// 
			// Converter開始MenuItem
			// 
			this.Converter開始MenuItem.Name = "Converter開始MenuItem";
			this.Converter開始MenuItem.Size = new System.Drawing.Size(192, 22);
			this.Converter開始MenuItem.Text = "開始";
			this.Converter開始MenuItem.Click += new System.EventHandler(this.開始ToolStripMenuItem_Click);
			// 
			// Converter停止MenuItem
			// 
			this.Converter停止MenuItem.Name = "Converter停止MenuItem";
			this.Converter停止MenuItem.Size = new System.Drawing.Size(192, 22);
			this.Converter停止MenuItem.Text = "停止";
			this.Converter停止MenuItem.Click += new System.EventHandler(this.停止ToolStripMenuItem_Click);
			// 
			// toolStripMenuItem4
			// 
			this.toolStripMenuItem4.Name = "toolStripMenuItem4";
			this.toolStripMenuItem4.Size = new System.Drawing.Size(189, 6);
			// 
			// エラーを解除するToolStripMenuItem
			// 
			this.エラーを解除するToolStripMenuItem.Name = "エラーを解除するToolStripMenuItem";
			this.エラーを解除するToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
			this.エラーを解除するToolStripMenuItem.Text = "エラーを解除する";
			this.エラーを解除するToolStripMenuItem.Click += new System.EventHandler(this.エラーを解除するToolStripMenuItem_Click);
			// 
			// エラーを解除して再開するToolStripMenuItem
			// 
			this.エラーを解除して再開するToolStripMenuItem.Name = "エラーを解除して再開するToolStripMenuItem";
			this.エラーを解除して再開するToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
			this.エラーを解除して再開するToolStripMenuItem.Text = "エラーを解除して再開する";
			this.エラーを解除して再開するToolStripMenuItem.Click += new System.EventHandler(this.エラーを解除して再開するToolStripMenuItem_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.South,
            this.SouthWest});
			this.statusStrip1.Location = new System.Drawing.Point(0, 529);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(774, 22);
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// South
			// 
			this.South.Name = "South";
			this.South.Size = new System.Drawing.Size(645, 17);
			this.South.Spring = true;
			this.South.Text = "準備しています... (S)";
			this.South.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// SouthWest
			// 
			this.SouthWest.Name = "SouthWest";
			this.SouthWest.Size = new System.Drawing.Size(114, 17);
			this.SouthWest.Text = "準備しています... (SW)";
			// 
			// MainSheet
			// 
			this.MainSheet.AllowDrop = true;
			this.MainSheet.AllowUserToAddRows = false;
			this.MainSheet.AllowUserToDeleteRows = false;
			this.MainSheet.AllowUserToResizeRows = false;
			this.MainSheet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.MainSheet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.MainSheet.ContextMenuStrip = this.MainSheetMenu;
			this.MainSheet.Location = new System.Drawing.Point(12, 27);
			this.MainSheet.Name = "MainSheet";
			this.MainSheet.ReadOnly = true;
			this.MainSheet.RowHeadersVisible = false;
			this.MainSheet.RowTemplate.Height = 21;
			this.MainSheet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.MainSheet.Size = new System.Drawing.Size(750, 499);
			this.MainSheet.TabIndex = 2;
			this.MainSheet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MainSheet_CellContentClick);
			this.MainSheet.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.MainSheet_ColumnHeaderMouseClick);
			this.MainSheet.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainSheet_DragDrop);
			this.MainSheet.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainSheet_DragEnter);
			// 
			// MainSheetMenu
			// 
			this.MainSheetMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.選択解除ToolStripMenuItem,
            this.全て選択するToolStripMenuItem,
            this.選択ToolStripMenuItem,
            this.toolStripMenuItem2,
            this.削除ToolStripMenuItem,
            this.全てクリアToolStripMenuItem,
            this.toolStripMenuItem3,
            this.リフレッシュToolStripMenuItem,
            this.toolStripMenuItem5,
            this.映像用の画像を設定するToolStripMenuItem});
			this.MainSheetMenu.Name = "MainSheetMenu";
			this.MainSheetMenu.Size = new System.Drawing.Size(197, 198);
			// 
			// 選択解除ToolStripMenuItem
			// 
			this.選択解除ToolStripMenuItem.Name = "選択解除ToolStripMenuItem";
			this.選択解除ToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
			this.選択解除ToolStripMenuItem.Text = "選択解除";
			this.選択解除ToolStripMenuItem.Click += new System.EventHandler(this.選択解除ToolStripMenuItem_Click);
			// 
			// 全て選択するToolStripMenuItem
			// 
			this.全て選択するToolStripMenuItem.Name = "全て選択するToolStripMenuItem";
			this.全て選択するToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
			this.全て選択するToolStripMenuItem.Text = "全て選択する";
			this.全て選択するToolStripMenuItem.Click += new System.EventHandler(this.全て選択するToolStripMenuItem_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(193, 6);
			// 
			// リフレッシュToolStripMenuItem
			// 
			this.リフレッシュToolStripMenuItem.Name = "リフレッシュToolStripMenuItem";
			this.リフレッシュToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
			this.リフレッシュToolStripMenuItem.Text = "リフレッシュ";
			this.リフレッシュToolStripMenuItem.Click += new System.EventHandler(this.リフレッシュToolStripMenuItem_Click);
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(193, 6);
			// 
			// 削除ToolStripMenuItem
			// 
			this.削除ToolStripMenuItem.Name = "削除ToolStripMenuItem";
			this.削除ToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
			this.削除ToolStripMenuItem.Text = "クリア";
			this.削除ToolStripMenuItem.Click += new System.EventHandler(this.削除ToolStripMenuItem_Click);
			// 
			// 全てクリアToolStripMenuItem
			// 
			this.全てクリアToolStripMenuItem.Name = "全てクリアToolStripMenuItem";
			this.全てクリアToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
			this.全てクリアToolStripMenuItem.Text = "全てクリア";
			this.全てクリアToolStripMenuItem.Click += new System.EventHandler(this.全てクリアToolStripMenuItem_Click);
			// 
			// toolStripMenuItem5
			// 
			this.toolStripMenuItem5.Name = "toolStripMenuItem5";
			this.toolStripMenuItem5.Size = new System.Drawing.Size(193, 6);
			// 
			// 映像用の画像を設定するToolStripMenuItem
			// 
			this.映像用の画像を設定するToolStripMenuItem.Name = "映像用の画像を設定するToolStripMenuItem";
			this.映像用の画像を設定するToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
			this.映像用の画像を設定するToolStripMenuItem.Text = "映像用の画像を設定する";
			this.映像用の画像を設定するToolStripMenuItem.Click += new System.EventHandler(this.映像用の画像を設定するToolStripMenuItem_Click);
			// 
			// 選択ToolStripMenuItem
			// 
			this.選択ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SelectReadyRowMenuItem,
            this.SelectErrorRowMenuItem,
            this.SelectSuccessfulRowMenuItem});
			this.選択ToolStripMenuItem.Name = "選択ToolStripMenuItem";
			this.選択ToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
			this.選択ToolStripMenuItem.Text = "選択";
			// 
			// SelectReadyRowMenuItem
			// 
			this.SelectReadyRowMenuItem.Name = "SelectReadyRowMenuItem";
			this.SelectReadyRowMenuItem.Size = new System.Drawing.Size(169, 22);
			this.SelectReadyRowMenuItem.Text = "待機中のファイル";
			this.SelectReadyRowMenuItem.Click += new System.EventHandler(this.SelectReadyRowMenuItem_Click);
			// 
			// SelectErrorRowMenuItem
			// 
			this.SelectErrorRowMenuItem.Name = "SelectErrorRowMenuItem";
			this.SelectErrorRowMenuItem.Size = new System.Drawing.Size(169, 22);
			this.SelectErrorRowMenuItem.Text = "エラーになったファイル";
			this.SelectErrorRowMenuItem.Click += new System.EventHandler(this.SelectErrorRowMenuItem_Click);
			// 
			// SelectSuccessfulRowMenuItem
			// 
			this.SelectSuccessfulRowMenuItem.Name = "SelectSuccessfulRowMenuItem";
			this.SelectSuccessfulRowMenuItem.Size = new System.Drawing.Size(169, 22);
			this.SelectSuccessfulRowMenuItem.Text = "成功したファイル";
			this.SelectSuccessfulRowMenuItem.Click += new System.EventHandler(this.SelectSuccessfulRowMenuItem_Click);
			// 
			// MainWin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(774, 551);
			this.Controls.Add(this.MainSheet);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.statusStrip1);
			this.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "MainWin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "audio file to mp4";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWin_FormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWin_FormClosed);
			this.Load += new System.EventHandler(this.MainWin_Load);
			this.Shown += new System.EventHandler(this.MainWin_Shown);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.MainSheet)).EndInit();
			this.MainSheetMenu.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Timer MainTimer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DataGridView MainSheet;
		private System.Windows.Forms.ToolStripMenuItem アプリToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 終了ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 設定ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ffmpegの場所ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem OutputDirMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 実行ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem Converter開始MenuItem;
		private System.Windows.Forms.ToolStripMenuItem Converter停止MenuItem;
		private System.Windows.Forms.ToolStripStatusLabel South;
		private System.Windows.Forms.ToolStripStatusLabel SouthWest;
		private System.Windows.Forms.ContextMenuStrip MainSheetMenu;
		private System.Windows.Forms.ToolStripMenuItem 選択解除ToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem その他ToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem リフレッシュToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem 削除ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 全てクリアToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
		private System.Windows.Forms.ToolStripMenuItem エラーを解除するToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem エラーを解除して再開するToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 全て選択するToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem Default映像用の画像MenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
		private System.Windows.Forms.ToolStripMenuItem 映像用の画像を設定するToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 選択ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem SelectReadyRowMenuItem;
		private System.Windows.Forms.ToolStripMenuItem SelectErrorRowMenuItem;
		private System.Windows.Forms.ToolStripMenuItem SelectSuccessfulRowMenuItem;
	}
}

