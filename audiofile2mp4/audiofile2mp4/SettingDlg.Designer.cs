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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.画像を二重に表示Grp = new System.Windows.Forms.GroupBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.画像を二重に表示_MonitorH = new System.Windows.Forms.NumericUpDown();
			this.画像を二重に表示_MonitorW = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.画像を二重に表示_明るさ = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.画像を二重に表示_ぼかし = new System.Windows.Forms.NumericUpDown();
			this.画像を二重に表示 = new System.Windows.Forms.CheckBox();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ErrorProv)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DefaultFPS)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.画像を二重に表示Grp.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.画像を二重に表示_MonitorH)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.画像を二重に表示_MonitorW)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.画像を二重に表示_明るさ)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.画像を二重に表示_ぼかし)).BeginInit();
			this.SuspendLayout();
			// 
			// BtnOk
			// 
			this.BtnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnOk.Location = new System.Drawing.Point(216, 399);
			this.BtnOk.Name = "BtnOk";
			this.BtnOk.Size = new System.Drawing.Size(100, 50);
			this.BtnOk.TabIndex = 1;
			this.BtnOk.Text = "OK";
			this.BtnOk.UseVisualStyleBackColor = true;
			this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
			// 
			// BtnCancel
			// 
			this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnCancel.Location = new System.Drawing.Point(322, 399);
			this.BtnCancel.Name = "BtnCancel";
			this.BtnCancel.Size = new System.Drawing.Size(100, 50);
			this.BtnCancel.TabIndex = 2;
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
			this.groupBox1.Location = new System.Drawing.Point(6, 6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(390, 130);
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
			this.label1.Location = new System.Drawing.Point(8, 154);
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
			this.AllowOverwrite.Location = new System.Drawing.Point(12, 194);
			this.AllowOverwrite.Name = "AllowOverwrite";
			this.AllowOverwrite.Size = new System.Drawing.Size(282, 24);
			this.AllowOverwrite.TabIndex = 3;
			this.AllowOverwrite.Text = "動画ファイル (出力先) の上書きを許可する";
			this.AllowOverwrite.UseVisualStyleBackColor = true;
			// 
			// 同じ音楽ファイルを追加させない
			// 
			this.同じ音楽ファイルを追加させない.AutoSize = true;
			this.同じ音楽ファイルを追加させない.Location = new System.Drawing.Point(12, 224);
			this.同じ音楽ファイルを追加させない.Name = "同じ音楽ファイルを追加させない";
			this.同じ音楽ファイルを追加させない.Size = new System.Drawing.Size(314, 24);
			this.同じ音楽ファイルを追加させない.TabIndex = 4;
			this.同じ音楽ファイルを追加させない.Text = "音楽ファイルを重複して追加出来ないようにする";
			this.同じ音楽ファイルを追加させない.UseVisualStyleBackColor = true;
			// 
			// DefaultFPS
			// 
			this.DefaultFPS.Location = new System.Drawing.Point(124, 152);
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
			this.XPressAndStopConverter.Location = new System.Drawing.Point(12, 254);
			this.XPressAndStopConverter.Name = "XPressAndStopConverter";
			this.XPressAndStopConverter.Size = new System.Drawing.Size(258, 24);
			this.XPressAndStopConverter.TabIndex = 5;
			this.XPressAndStopConverter.Text = "[×]ボタン押下でコンバータを停止する";
			this.XPressAndStopConverter.UseVisualStyleBackColor = true;
			// 
			// IgnoreBeginDot
			// 
			this.IgnoreBeginDot.AutoSize = true;
			this.IgnoreBeginDot.Location = new System.Drawing.Point(12, 284);
			this.IgnoreBeginDot.Name = "IgnoreBeginDot";
			this.IgnoreBeginDot.Size = new System.Drawing.Size(275, 24);
			this.IgnoreBeginDot.TabIndex = 6;
			this.IgnoreBeginDot.Text = "半角ピリオドで始まるファイルを無視する";
			this.IgnoreBeginDot.UseVisualStyleBackColor = true;
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(12, 12);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(410, 381);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.groupBox1);
			this.tabPage1.Controls.Add(this.IgnoreBeginDot);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this.XPressAndStopConverter);
			this.tabPage1.Controls.Add(this.AllowOverwrite);
			this.tabPage1.Controls.Add(this.DefaultFPS);
			this.tabPage1.Controls.Add(this.同じ音楽ファイルを追加させない);
			this.tabPage1.Location = new System.Drawing.Point(4, 29);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(402, 348);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "基本";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.画像を二重に表示Grp);
			this.tabPage2.Controls.Add(this.画像を二重に表示);
			this.tabPage2.Location = new System.Drawing.Point(4, 29);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(402, 348);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "二重に表示";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// 画像を二重に表示Grp
			// 
			this.画像を二重に表示Grp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.画像を二重に表示Grp.Controls.Add(this.label9);
			this.画像を二重に表示Grp.Controls.Add(this.label8);
			this.画像を二重に表示Grp.Controls.Add(this.label7);
			this.画像を二重に表示Grp.Controls.Add(this.label6);
			this.画像を二重に表示Grp.Controls.Add(this.画像を二重に表示_MonitorH);
			this.画像を二重に表示Grp.Controls.Add(this.画像を二重に表示_MonitorW);
			this.画像を二重に表示Grp.Controls.Add(this.label5);
			this.画像を二重に表示Grp.Controls.Add(this.label4);
			this.画像を二重に表示Grp.Controls.Add(this.画像を二重に表示_明るさ);
			this.画像を二重に表示Grp.Controls.Add(this.label3);
			this.画像を二重に表示Grp.Controls.Add(this.label2);
			this.画像を二重に表示Grp.Controls.Add(this.画像を二重に表示_ぼかし);
			this.画像を二重に表示Grp.Location = new System.Drawing.Point(6, 36);
			this.画像を二重に表示Grp.Name = "画像を二重に表示Grp";
			this.画像を二重に表示Grp.Size = new System.Drawing.Size(390, 306);
			this.画像を二重に表示Grp.TabIndex = 1;
			this.画像を二重に表示Grp.TabStop = false;
			this.画像を二重に表示Grp.Text = "設定";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("メイリオ", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label9.Location = new System.Drawing.Point(231, 77);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(76, 17);
			this.label9.TabIndex = 5;
			this.label9.Text = "300 ～ 3000";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("メイリオ", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label8.Location = new System.Drawing.Point(231, 44);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(76, 17);
			this.label8.TabIndex = 2;
			this.label8.Text = "300 ～ 3000";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(72, 75);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(48, 20);
			this.label7.TabIndex = 3;
			this.label7.Text = "高さ：";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 42);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(113, 20);
			this.label6.TabIndex = 0;
			this.label6.Text = "画面サイズ　幅：";
			// 
			// 画像を二重に表示_MonitorH
			// 
			this.画像を二重に表示_MonitorH.Location = new System.Drawing.Point(125, 73);
			this.画像を二重に表示_MonitorH.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
			this.画像を二重に表示_MonitorH.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            0});
			this.画像を二重に表示_MonitorH.Name = "画像を二重に表示_MonitorH";
			this.画像を二重に表示_MonitorH.Size = new System.Drawing.Size(100, 27);
			this.画像を二重に表示_MonitorH.TabIndex = 4;
			this.画像を二重に表示_MonitorH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.画像を二重に表示_MonitorH.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
			// 
			// 画像を二重に表示_MonitorW
			// 
			this.画像を二重に表示_MonitorW.Location = new System.Drawing.Point(125, 40);
			this.画像を二重に表示_MonitorW.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
			this.画像を二重に表示_MonitorW.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            0});
			this.画像を二重に表示_MonitorW.Name = "画像を二重に表示_MonitorW";
			this.画像を二重に表示_MonitorW.Size = new System.Drawing.Size(100, 27);
			this.画像を二重に表示_MonitorW.TabIndex = 1;
			this.画像を二重に表示_MonitorW.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.画像を二重に表示_MonitorW.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("メイリオ", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label5.Location = new System.Drawing.Point(179, 194);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(142, 17);
			this.label5.TabIndex = 11;
			this.label5.Text = "0 ～ 100 : 暗い ～ 明るい";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("メイリオ", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label4.Location = new System.Drawing.Point(179, 144);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(186, 17);
			this.label4.TabIndex = 8;
			this.label4.Text = "0 ～ 100 : ぼかし無し ～ ぼかし強";
			// 
			// 画像を二重に表示_明るさ
			// 
			this.画像を二重に表示_明るさ.Location = new System.Drawing.Point(73, 190);
			this.画像を二重に表示_明るさ.Name = "画像を二重に表示_明るさ";
			this.画像を二重に表示_明るさ.Size = new System.Drawing.Size(100, 27);
			this.画像を二重に表示_明るさ.TabIndex = 10;
			this.画像を二重に表示_明るさ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.画像を二重に表示_明るさ.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 192);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(61, 20);
			this.label3.TabIndex = 9;
			this.label3.Text = "明るさ：";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 142);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 20);
			this.label2.TabIndex = 6;
			this.label2.Text = "ぼかし：";
			// 
			// 画像を二重に表示_ぼかし
			// 
			this.画像を二重に表示_ぼかし.Location = new System.Drawing.Point(73, 140);
			this.画像を二重に表示_ぼかし.Name = "画像を二重に表示_ぼかし";
			this.画像を二重に表示_ぼかし.Size = new System.Drawing.Size(100, 27);
			this.画像を二重に表示_ぼかし.TabIndex = 7;
			this.画像を二重に表示_ぼかし.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.画像を二重に表示_ぼかし.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// 画像を二重に表示
			// 
			this.画像を二重に表示.AutoSize = true;
			this.画像を二重に表示.Location = new System.Drawing.Point(6, 6);
			this.画像を二重に表示.Name = "画像を二重に表示";
			this.画像を二重に表示.Size = new System.Drawing.Size(158, 24);
			this.画像を二重に表示.TabIndex = 0;
			this.画像を二重に表示.Text = "画像を二重に表示する";
			this.画像を二重に表示.UseVisualStyleBackColor = true;
			this.画像を二重に表示.CheckedChanged += new System.EventHandler(this.画像を二重に表示_CheckedChanged);
			// 
			// SettingDlg
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(434, 461);
			this.Controls.Add(this.tabControl1);
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
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.画像を二重に表示Grp.ResumeLayout(false);
			this.画像を二重に表示Grp.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.画像を二重に表示_MonitorH)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.画像を二重に表示_MonitorW)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.画像を二重に表示_明るさ)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.画像を二重に表示_ぼかし)).EndInit();
			this.ResumeLayout(false);

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
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.GroupBox 画像を二重に表示Grp;
		private System.Windows.Forms.CheckBox 画像を二重に表示;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown 画像を二重に表示_明るさ;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown 画像を二重に表示_ぼかし;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.NumericUpDown 画像を二重に表示_MonitorH;
		private System.Windows.Forms.NumericUpDown 画像を二重に表示_MonitorW;
	}
}
