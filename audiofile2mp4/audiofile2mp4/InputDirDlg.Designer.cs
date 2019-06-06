namespace Charlotte
{
	partial class InputDirDlg
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputDirDlg));
			this.SelectedDir = new System.Windows.Forms.TextBox();
			this.BtnSelectDir = new System.Windows.Forms.Button();
			this.SelectedDirLabel = new System.Windows.Forms.Label();
			this.BtnCancel = new System.Windows.Forms.Button();
			this.BtnOk = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// SelectedDir
			// 
			this.SelectedDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.SelectedDir.Location = new System.Drawing.Point(12, 50);
			this.SelectedDir.MaxLength = 300;
			this.SelectedDir.Name = "SelectedDir";
			this.SelectedDir.Size = new System.Drawing.Size(404, 27);
			this.SelectedDir.TabIndex = 1;
			this.SelectedDir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SelectedDir_KeyPress);
			// 
			// BtnSelectDir
			// 
			this.BtnSelectDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnSelectDir.Location = new System.Drawing.Point(422, 50);
			this.BtnSelectDir.Name = "BtnSelectDir";
			this.BtnSelectDir.Size = new System.Drawing.Size(50, 27);
			this.BtnSelectDir.TabIndex = 2;
			this.BtnSelectDir.Text = "....";
			this.BtnSelectDir.UseVisualStyleBackColor = true;
			this.BtnSelectDir.Click += new System.EventHandler(this.BtnSelectDir_Click);
			// 
			// SelectedDirLabel
			// 
			this.SelectedDirLabel.AutoSize = true;
			this.SelectedDirLabel.Location = new System.Drawing.Point(12, 27);
			this.SelectedDirLabel.Name = "SelectedDirLabel";
			this.SelectedDirLabel.Size = new System.Drawing.Size(115, 20);
			this.SelectedDirLabel.TabIndex = 0;
			this.SelectedDirLabel.Text = "準備しています...";
			// 
			// BtnCancel
			// 
			this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnCancel.Location = new System.Drawing.Point(372, 99);
			this.BtnCancel.Name = "BtnCancel";
			this.BtnCancel.Size = new System.Drawing.Size(100, 50);
			this.BtnCancel.TabIndex = 4;
			this.BtnCancel.Text = "キャンセル";
			this.BtnCancel.UseVisualStyleBackColor = true;
			this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
			// 
			// BtnOk
			// 
			this.BtnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnOk.Location = new System.Drawing.Point(266, 99);
			this.BtnOk.Name = "BtnOk";
			this.BtnOk.Size = new System.Drawing.Size(100, 50);
			this.BtnOk.TabIndex = 3;
			this.BtnOk.Text = "OK";
			this.BtnOk.UseVisualStyleBackColor = true;
			this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
			// 
			// InputDirDlg
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 161);
			this.Controls.Add(this.BtnOk);
			this.Controls.Add(this.BtnCancel);
			this.Controls.Add(this.SelectedDirLabel);
			this.Controls.Add(this.BtnSelectDir);
			this.Controls.Add(this.SelectedDir);
			this.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "InputDirDlg";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "準備しています...";
			this.TopMost = true;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InputDirDlg_FormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InputDirDlg_FormClosed);
			this.Load += new System.EventHandler(this.InputDirDlg_Load);
			this.Shown += new System.EventHandler(this.InputDirDlg_Shown);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox SelectedDir;
		private System.Windows.Forms.Button BtnSelectDir;
		private System.Windows.Forms.Label SelectedDirLabel;
		private System.Windows.Forms.Button BtnCancel;
		private System.Windows.Forms.Button BtnOk;
	}
}
