namespace PassWordSaver
{
	partial class DashBoard_FRM
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard_FRM));
			this.TitlePanel_PNL = new System.Windows.Forms.Panel();
			this.MainTitle_LBL = new System.Windows.Forms.Label();
			this.BodyPanel_PNL = new System.Windows.Forms.Panel();
			this.Delete_BTN = new System.Windows.Forms.Button();
			this.SavedComBo_CMBX = new System.Windows.Forms.ComboBox();
			this.PassWord_TB = new System.Windows.Forms.TextBox();
			this.UserName_TB = new System.Windows.Forms.TextBox();
			this.TheTitleName_TB = new System.Windows.Forms.TextBox();
			this.AddNewRecord_BTN = new System.Windows.Forms.Button();
			this.UserPassViewer_DGR = new System.Windows.Forms.DataGridView();
			this.SelectSavedInfo_LBL = new System.Windows.Forms.Label();
			this.PassWord_LBL = new System.Windows.Forms.Label();
			this.TheTitle_LBL = new System.Windows.Forms.Label();
			this.UserName_LBL = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.GitHub_IMG = new System.Windows.Forms.PictureBox();
			this.TogglePass_BTN = new System.Windows.Forms.Button();
			this.TitlePanel_PNL.SuspendLayout();
			this.BodyPanel_PNL.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.UserPassViewer_DGR)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.GitHub_IMG)).BeginInit();
			this.SuspendLayout();
			// 
			// TitlePanel_PNL
			// 
			this.TitlePanel_PNL.BackColor = System.Drawing.SystemColors.Control;
			this.TitlePanel_PNL.Controls.Add(this.MainTitle_LBL);
			this.TitlePanel_PNL.Location = new System.Drawing.Point(13, 13);
			this.TitlePanel_PNL.Name = "TitlePanel_PNL";
			this.TitlePanel_PNL.Size = new System.Drawing.Size(775, 88);
			this.TitlePanel_PNL.TabIndex = 0;
			// 
			// MainTitle_LBL
			// 
			this.MainTitle_LBL.AutoSize = true;
			this.MainTitle_LBL.Font = new System.Drawing.Font("Candara", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.MainTitle_LBL.Location = new System.Drawing.Point(271, 25);
			this.MainTitle_LBL.Name = "MainTitle_LBL";
			this.MainTitle_LBL.Size = new System.Drawing.Size(211, 37);
			this.MainTitle_LBL.TabIndex = 0;
			this.MainTitle_LBL.Text = "Save Your Pass";
			// 
			// BodyPanel_PNL
			// 
			this.BodyPanel_PNL.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.BodyPanel_PNL.Controls.Add(this.TogglePass_BTN);
			this.BodyPanel_PNL.Controls.Add(this.Delete_BTN);
			this.BodyPanel_PNL.Controls.Add(this.SavedComBo_CMBX);
			this.BodyPanel_PNL.Controls.Add(this.PassWord_TB);
			this.BodyPanel_PNL.Controls.Add(this.UserName_TB);
			this.BodyPanel_PNL.Controls.Add(this.TheTitleName_TB);
			this.BodyPanel_PNL.Controls.Add(this.AddNewRecord_BTN);
			this.BodyPanel_PNL.Controls.Add(this.UserPassViewer_DGR);
			this.BodyPanel_PNL.Controls.Add(this.SelectSavedInfo_LBL);
			this.BodyPanel_PNL.Controls.Add(this.PassWord_LBL);
			this.BodyPanel_PNL.Controls.Add(this.TheTitle_LBL);
			this.BodyPanel_PNL.Controls.Add(this.UserName_LBL);
			this.BodyPanel_PNL.Location = new System.Drawing.Point(13, 108);
			this.BodyPanel_PNL.Name = "BodyPanel_PNL";
			this.BodyPanel_PNL.Size = new System.Drawing.Size(775, 402);
			this.BodyPanel_PNL.TabIndex = 1;
			// 
			// Delete_BTN
			// 
			this.Delete_BTN.BackColor = System.Drawing.Color.IndianRed;
			this.Delete_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Delete_BTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Delete_BTN.Location = new System.Drawing.Point(425, 355);
			this.Delete_BTN.Name = "Delete_BTN";
			this.Delete_BTN.Size = new System.Drawing.Size(155, 24);
			this.Delete_BTN.TabIndex = 10;
			this.Delete_BTN.Text = "Delete";
			this.Delete_BTN.UseVisualStyleBackColor = false;
			this.Delete_BTN.Click += new System.EventHandler(this.Delete_BTN_Click);
			// 
			// SavedComBo_CMBX
			// 
			this.SavedComBo_CMBX.BackColor = System.Drawing.SystemColors.Info;
			this.SavedComBo_CMBX.FormattingEnabled = true;
			this.SavedComBo_CMBX.Location = new System.Drawing.Point(192, 113);
			this.SavedComBo_CMBX.Name = "SavedComBo_CMBX";
			this.SavedComBo_CMBX.Size = new System.Drawing.Size(549, 25);
			this.SavedComBo_CMBX.TabIndex = 9;
			// 
			// PassWord_TB
			// 
			this.PassWord_TB.BackColor = System.Drawing.SystemColors.Info;
			this.PassWord_TB.Location = new System.Drawing.Point(192, 83);
			this.PassWord_TB.Name = "PassWord_TB";
			this.PassWord_TB.Size = new System.Drawing.Size(549, 25);
			this.PassWord_TB.TabIndex = 8;
			// 
			// UserName_TB
			// 
			this.UserName_TB.BackColor = System.Drawing.SystemColors.Info;
			this.UserName_TB.Location = new System.Drawing.Point(192, 54);
			this.UserName_TB.Name = "UserName_TB";
			this.UserName_TB.Size = new System.Drawing.Size(549, 25);
			this.UserName_TB.TabIndex = 7;
			// 
			// TheTitleName_TB
			// 
			this.TheTitleName_TB.BackColor = System.Drawing.SystemColors.Info;
			this.TheTitleName_TB.Location = new System.Drawing.Point(192, 25);
			this.TheTitleName_TB.Name = "TheTitleName_TB";
			this.TheTitleName_TB.Size = new System.Drawing.Size(549, 25);
			this.TheTitleName_TB.TabIndex = 6;
			// 
			// AddNewRecord_BTN
			// 
			this.AddNewRecord_BTN.BackColor = System.Drawing.SystemColors.Highlight;
			this.AddNewRecord_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
			this.AddNewRecord_BTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.AddNewRecord_BTN.Location = new System.Drawing.Point(586, 356);
			this.AddNewRecord_BTN.Name = "AddNewRecord_BTN";
			this.AddNewRecord_BTN.Size = new System.Drawing.Size(155, 24);
			this.AddNewRecord_BTN.TabIndex = 5;
			this.AddNewRecord_BTN.Text = "Add New";
			this.AddNewRecord_BTN.UseVisualStyleBackColor = false;
			this.AddNewRecord_BTN.Click += new System.EventHandler(this.AddNewRecord_BTN_Click);
			// 
			// UserPassViewer_DGR
			// 
			this.UserPassViewer_DGR.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
			this.UserPassViewer_DGR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.UserPassViewer_DGR.Location = new System.Drawing.Point(35, 145);
			this.UserPassViewer_DGR.Name = "UserPassViewer_DGR";
			this.UserPassViewer_DGR.Size = new System.Drawing.Size(706, 204);
			this.UserPassViewer_DGR.TabIndex = 4;
			// 
			// SelectSavedInfo_LBL
			// 
			this.SelectSavedInfo_LBL.AutoSize = true;
			this.SelectSavedInfo_LBL.Location = new System.Drawing.Point(32, 116);
			this.SelectSavedInfo_LBL.Name = "SelectSavedInfo_LBL";
			this.SelectSavedInfo_LBL.Size = new System.Drawing.Size(154, 17);
			this.SelectSavedInfo_LBL.TabIndex = 3;
			this.SelectSavedInfo_LBL.Text = "Choose Saved UserPass:";
			// 
			// PassWord_LBL
			// 
			this.PassWord_LBL.AutoSize = true;
			this.PassWord_LBL.Location = new System.Drawing.Point(32, 85);
			this.PassWord_LBL.Name = "PassWord_LBL";
			this.PassWord_LBL.Size = new System.Drawing.Size(72, 17);
			this.PassWord_LBL.TabIndex = 2;
			this.PassWord_LBL.Text = "PassWord:";
			// 
			// TheTitle_LBL
			// 
			this.TheTitle_LBL.AutoSize = true;
			this.TheTitle_LBL.Location = new System.Drawing.Point(34, 28);
			this.TheTitle_LBL.Name = "TheTitle_LBL";
			this.TheTitle_LBL.Size = new System.Drawing.Size(37, 17);
			this.TheTitle_LBL.TabIndex = 1;
			this.TheTitle_LBL.Text = "Title:";
			// 
			// UserName_LBL
			// 
			this.UserName_LBL.AutoSize = true;
			this.UserName_LBL.Location = new System.Drawing.Point(32, 56);
			this.UserName_LBL.Name = "UserName_LBL";
			this.UserName_LBL.Size = new System.Drawing.Size(74, 17);
			this.UserName_LBL.TabIndex = 0;
			this.UserName_LBL.Text = "UserName:";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.panel1.Controls.Add(this.GitHub_IMG);
			this.panel1.Location = new System.Drawing.Point(13, 517);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(775, 38);
			this.panel1.TabIndex = 2;
			// 
			// GitHub_IMG
			// 
			this.GitHub_IMG.Cursor = System.Windows.Forms.Cursors.Hand;
			this.GitHub_IMG.Image = global::PassWordSaver.Properties.Resources.icons8_github_32px;
			this.GitHub_IMG.Location = new System.Drawing.Point(368, 3);
			this.GitHub_IMG.Name = "GitHub_IMG";
			this.GitHub_IMG.Size = new System.Drawing.Size(32, 32);
			this.GitHub_IMG.TabIndex = 0;
			this.GitHub_IMG.TabStop = false;
			this.GitHub_IMG.Click += new System.EventHandler(this.GitHub_IMG_Click);
			// 
			// TogglePass_BTN
			// 
			this.TogglePass_BTN.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.TogglePass_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
			this.TogglePass_BTN.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.TogglePass_BTN.Location = new System.Drawing.Point(663, 80);
			this.TogglePass_BTN.Name = "TogglePass_BTN";
			this.TogglePass_BTN.Size = new System.Drawing.Size(78, 25);
			this.TogglePass_BTN.TabIndex = 11;
			this.TogglePass_BTN.Text = "Show";
			this.TogglePass_BTN.UseVisualStyleBackColor = false;
			this.TogglePass_BTN.Click += new System.EventHandler(this.TogglePass_BTN_Click_1);
			// 
			// DashBoard_FRM
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(800, 567);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.BodyPanel_PNL);
			this.Controls.Add(this.TitlePanel_PNL);
			this.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.Name = "DashBoard_FRM";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "DashBorad";
			this.Load += new System.EventHandler(this.DashBoard_FRM_Load);
			this.TitlePanel_PNL.ResumeLayout(false);
			this.TitlePanel_PNL.PerformLayout();
			this.BodyPanel_PNL.ResumeLayout(false);
			this.BodyPanel_PNL.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.UserPassViewer_DGR)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.GitHub_IMG)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel TitlePanel_PNL;
		private System.Windows.Forms.Label MainTitle_LBL;
		private System.Windows.Forms.Panel BodyPanel_PNL;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox GitHub_IMG;
		private System.Windows.Forms.DataGridView UserPassViewer_DGR;
		private System.Windows.Forms.Label SelectSavedInfo_LBL;
		private System.Windows.Forms.Label PassWord_LBL;
		private System.Windows.Forms.Label TheTitle_LBL;
		private System.Windows.Forms.Label UserName_LBL;
		private System.Windows.Forms.Button AddNewRecord_BTN;
		private System.Windows.Forms.ComboBox SavedComBo_CMBX;
		private System.Windows.Forms.TextBox PassWord_TB;
		private System.Windows.Forms.TextBox UserName_TB;
		private System.Windows.Forms.TextBox TheTitleName_TB;
		private System.Windows.Forms.Button Delete_BTN;
		private System.Windows.Forms.Button TogglePass_BTN;
	}
}

