namespace Charlotte
{
	partial class SettingDlg
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingDlg));
			this.BtnOk = new System.Windows.Forms.Button();
			this.BtnCancel = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.CB_MS_MovieFile_FullPath = new System.Windows.Forms.CheckBox();
			this.CB_MS_ImageFile_FullPath = new System.Windows.Forms.CheckBox();
			this.CB_MS_AudioFile_FullPath = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.ErrorProv = new System.Windows.Forms.ErrorProvider(this.components);
			this.AllowOverwrite = new System.Windows.Forms.CheckBox();
			this.同じ音楽ファイルを追加させない = new System.Windows.Forms.CheckBox();
			this.DefaultFPS = new System.Windows.Forms.NumericUpDown();
			this.XPressAndStopConverter = new System.Windows.Forms.CheckBox();
			this.IgnoreBeginDot = new System.Windows.Forms.CheckBox();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ErrorProv)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DefaultFPS)).BeginInit();
			this.SuspendLayout();
			// 
			// BtnOk
			// 
			this.BtnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnOk.Location = new System.Drawing.Point(151, 344);
			this.BtnOk.Name = "BtnOk";
			this.BtnOk.Size = new System.Drawing.Size(100, 50);
			this.BtnOk.TabIndex = 7;
			this.BtnOk.Text = "OK";
			this.BtnOk.UseVisualStyleBackColor = true;
			this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
			// 
			// BtnCancel
			// 
			this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnCancel.Location = new System.Drawing.Point(257, 344);
			this.BtnCancel.Name = "BtnCancel";
			this.BtnCancel.Size = new System.Drawing.Size(100, 50);
			this.BtnCancel.TabIndex = 8;
			this.BtnCancel.Text = "キャンセル";
			this.BtnCancel.UseVisualStyleBackColor = true;
			this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.CB_MS_MovieFile_FullPath);
			this.groupBox1.Controls.Add(this.CB_MS_ImageFile_FullPath);
			this.groupBox1.Controls.Add(this.CB_MS_AudioFile_FullPath);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(345, 130);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "フルパスで表示";
			// 
			// CB_MS_MovieFile_FullPath
			// 
			this.CB_MS_MovieFile_FullPath.AutoSize = true;
			this.CB_MS_MovieFile_FullPath.Location = new System.Drawing.Point(6, 86);
			this.CB_MS_MovieFile_FullPath.Name = "CB_MS_MovieFile_FullPath";
			this.CB_MS_MovieFile_FullPath.Size = new System.Drawing.Size(236, 24);
			this.CB_MS_MovieFile_FullPath.TabIndex = 2;
			this.CB_MS_MovieFile_FullPath.Text = "動画ファイルをフルパスで表示する";
			this.CB_MS_MovieFile_FullPath.UseVisualStyleBackColor = true;
			// 
			// CB_MS_ImageFile_FullPath
			// 
			this.CB_MS_ImageFile_FullPath.AutoSize = true;
			this.CB_MS_ImageFile_FullPath.Location = new System.Drawing.Point(6, 56);
			this.CB_MS_ImageFile_FullPath.Name = "CB_MS_ImageFile_FullPath";
			this.CB_MS_ImageFile_FullPath.Size = new System.Drawing.Size(236, 24);
			this.CB_MS_ImageFile_FullPath.TabIndex = 1;
			this.CB_MS_ImageFile_FullPath.Text = "画像ファイルをフルパスで表示する";
			this.CB_MS_ImageFile_FullPath.UseVisualStyleBackColor = true;
			// 
			// CB_MS_AudioFile_FullPath
			// 
			this.CB_MS_AudioFile_FullPath.AutoSize = true;
			this.CB_MS_AudioFile_FullPath.Location = new System.Drawing.Point(6, 26);
			this.CB_MS_AudioFile_FullPath.Name = "CB_MS_AudioFile_FullPath";
			this.CB_MS_AudioFile_FullPath.Size = new System.Drawing.Size(236, 24);
			this.CB_MS_AudioFile_FullPath.TabIndex = 0;
			this.CB_MS_AudioFile_FullPath.Text = "音楽ファイルをフルパスで表示する";
			this.CB_MS_AudioFile_FullPath.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(14, 160);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(110, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "デフォルトFPS：";
			// 
			// ErrorProv
			// 
			this.ErrorProv.ContainerControl = this;
			// 
			// AllowOverwrite
			// 
			this.AllowOverwrite.AutoSize = true;
			this.AllowOverwrite.Location = new System.Drawing.Point(18, 200);
			this.AllowOverwrite.Name = "AllowOverwrite";
			this.AllowOverwrite.Size = new System.Drawing.Size(282, 24);
			this.AllowOverwrite.TabIndex = 3;
			this.AllowOverwrite.Text = "動画ファイル (出力先) の上書きを許可する";
			this.AllowOverwrite.UseVisualStyleBackColor = true;
			// 
			// 同じ音楽ファイルを追加させない
			// 
			this.同じ音楽ファイルを追加させない.AutoSize = true;
			this.同じ音楽ファイルを追加させない.Location = new System.Drawing.Point(18, 230);
			this.同じ音楽ファイルを追加させない.Name = "同じ音楽ファイルを追加させない";
			this.同じ音楽ファイルを追加させない.Size = new System.Drawing.Size(314, 24);
			this.同じ音楽ファイルを追加させない.TabIndex = 4;
			this.同じ音楽ファイルを追加させない.Text = "音楽ファイルを重複して追加出来ないようにする";
			this.同じ音楽ファイルを追加させない.UseVisualStyleBackColor = true;
			// 
			// DefaultFPS
			// 
			this.DefaultFPS.Location = new System.Drawing.Point(130, 158);
			this.DefaultFPS.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
			this.DefaultFPS.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.DefaultFPS.Name = "DefaultFPS";
			this.DefaultFPS.Size = new System.Drawing.Size(100, 27);
			this.DefaultFPS.TabIndex = 2;
			this.DefaultFPS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.DefaultFPS.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// XPressAndStopConverter
			// 
			this.XPressAndStopConverter.AutoSize = true;
			this.XPressAndStopConverter.Location = new System.Drawing.Point(18, 260);
			this.XPressAndStopConverter.Name = "XPressAndStopConverter";
			this.XPressAndStopConverter.Size = new System.Drawing.Size(258, 24);
			this.XPressAndStopConverter.TabIndex = 5;
			this.XPressAndStopConverter.Text = "[×]ボタン押下でコンバータを停止する";
			this.XPressAndStopConverter.UseVisualStyleBackColor = true;
			// 
			// IgnoreBeginDot
			// 
			this.IgnoreBeginDot.AutoSize = true;
			this.IgnoreBeginDot.Location = new System.Drawing.Point(18, 290);
			this.IgnoreBeginDot.Name = "IgnoreBeginDot";
			this.IgnoreBeginDot.Size = new System.Drawing.Size(275, 24);
			this.IgnoreBeginDot.TabIndex = 6;
			this.IgnoreBeginDot.Text = "半角ピリオドで始まるファイルを無視する";
			this.IgnoreBeginDot.UseVisualStyleBackColor = true;
			// 
			// SettingDlg
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(369, 406);
			this.Controls.Add(this.IgnoreBeginDot);
			this.Controls.Add(this.XPressAndStopConverter);
			this.Controls.Add(this.DefaultFPS);
			this.Controls.Add(this.同じ音楽ファイルを追加させない);
			this.Controls.Add(this.AllowOverwrite);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.BtnOk);
			this.Controls.Add(this.BtnCancel);
			this.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SettingDlg";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "audio file to mp4 / 設定";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.SettingDlg_Load);
			this.Shown += new System.EventHandler(this.SettingDlg_Shown);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ErrorProv)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DefaultFPS)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button BtnOk;
		private System.Windows.Forms.Button BtnCancel;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox CB_MS_MovieFile_FullPath;
		private System.Windows.Forms.CheckBox CB_MS_ImageFile_FullPath;
		private System.Windows.Forms.CheckBox CB_MS_AudioFile_FullPath;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ErrorProvider ErrorProv;
		private System.Windows.Forms.CheckBox AllowOverwrite;
		private System.Windows.Forms.CheckBox 同じ音楽ファイルを追加させない;
		private System.Windows.Forms.NumericUpDown DefaultFPS;
		private System.Windows.Forms.CheckBox XPressAndStopConverter;
		private System.Windows.Forms.CheckBox IgnoreBeginDot;
	}
}
