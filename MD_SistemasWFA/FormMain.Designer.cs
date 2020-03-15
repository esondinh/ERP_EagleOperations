namespace MD_SistemasWFA
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.panelUp = new MetroFramework.Controls.MetroPanel();
            this.lblNameUser = new System.Windows.Forms.Label();
            this.lblDate2 = new MetroFramework.Controls.MetroTile();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtPassword2 = new MetroFramework.Controls.MetroTile();
            this.txtCodUser = new MetroFramework.Controls.MetroTextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.pnlCenterDownNumbers = new System.Windows.Forms.Panel();
            this.panelRightDownYN = new System.Windows.Forms.Panel();
            this.btnNot = new MetroFramework.Controls.MetroTile();
            this.btnYes = new MetroFramework.Controls.MetroTile();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panelLeftDownChannels = new System.Windows.Forms.FlowLayoutPanel();
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.pnlTitle = new MetroFramework.Controls.MetroTile();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.btnInputOuput = new MetroFramework.Controls.MetroTile();
            this.pnlImage = new System.Windows.Forms.Panel();
            this.panelUp.SuspendLayout();
            this.lblDate2.SuspendLayout();
            this.txtPassword2.SuspendLayout();
            this.panelRightDownYN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.panelCenter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUp
            // 
            this.panelUp.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelUp.Controls.Add(this.lblNameUser);
            this.panelUp.HorizontalScrollbarBarColor = true;
            this.panelUp.HorizontalScrollbarHighlightOnWheel = false;
            this.panelUp.HorizontalScrollbarSize = 12;
            this.panelUp.Location = new System.Drawing.Point(31, 39);
            this.panelUp.Margin = new System.Windows.Forms.Padding(4);
            this.panelUp.Name = "panelUp";
            this.panelUp.Size = new System.Drawing.Size(1005, 30);
            this.panelUp.Style = MetroFramework.MetroColorStyle.Silver;
            this.panelUp.TabIndex = 0;
            this.panelUp.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.panelUp.UseCustomBackColor = true;
            this.panelUp.UseCustomForeColor = true;
            this.panelUp.UseStyleColors = true;
            this.panelUp.VerticalScrollbarBarColor = true;
            this.panelUp.VerticalScrollbarHighlightOnWheel = false;
            this.panelUp.VerticalScrollbarSize = 13;
            // 
            // lblNameUser
            // 
            this.lblNameUser.AutoSize = true;
            this.lblNameUser.BackColor = System.Drawing.Color.Transparent;
            this.lblNameUser.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameUser.ForeColor = System.Drawing.Color.Navy;
            this.lblNameUser.Location = new System.Drawing.Point(-1, 1);
            this.lblNameUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameUser.Name = "lblNameUser";
            this.lblNameUser.Size = new System.Drawing.Size(116, 25);
            this.lblNameUser.TabIndex = 2;
            this.lblNameUser.Text = "Name User";
            // 
            // lblDate2
            // 
            this.lblDate2.ActiveControl = null;
            this.lblDate2.Controls.Add(this.lblDate);
            this.lblDate2.ForeColor = System.Drawing.Color.Navy;
            this.lblDate2.Location = new System.Drawing.Point(0, 4);
            this.lblDate2.Margin = new System.Windows.Forms.Padding(4);
            this.lblDate2.Name = "lblDate2";
            this.lblDate2.Size = new System.Drawing.Size(501, 50);
            this.lblDate2.TabIndex = 0;
            this.lblDate2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDate2.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.lblDate2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.lblDate2.UseCustomForeColor = true;
            this.lblDate2.UseSelectable = true;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Microsoft JhengHei", 12F);
            this.lblDate.Location = new System.Drawing.Point(19, 11);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(79, 25);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "lblDate";
            // 
            // txtPassword2
            // 
            this.txtPassword2.ActiveControl = null;
            this.txtPassword2.Controls.Add(this.txtCodUser);
            this.txtPassword2.Controls.Add(this.lblPassword);
            this.txtPassword2.Location = new System.Drawing.Point(504, 4);
            this.txtPassword2.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.Size = new System.Drawing.Size(501, 50);
            this.txtPassword2.TabIndex = 1;
            this.txtPassword2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.txtPassword2.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.txtPassword2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.txtPassword2.UseSelectable = true;
            // 
            // txtCodUser
            // 
            this.txtCodUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtCodUser.CustomButton.BackgroundImage = global::MD_SistemasWFA.Properties.Resources.cancel_32_N;
            this.txtCodUser.CustomButton.Image = null;
            this.txtCodUser.CustomButton.Location = new System.Drawing.Point(174, 2);
            this.txtCodUser.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodUser.CustomButton.Name = "";
            this.txtCodUser.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtCodUser.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCodUser.CustomButton.TabIndex = 1;
            this.txtCodUser.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCodUser.CustomButton.UseSelectable = true;
            this.txtCodUser.CustomButton.Visible = false;
            this.txtCodUser.Icon = global::MD_SistemasWFA.Properties.Resources.enter_32_N;
            this.txtCodUser.Lines = new string[0];
            this.txtCodUser.Location = new System.Drawing.Point(297, 10);
            this.txtCodUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodUser.MaxLength = 32767;
            this.txtCodUser.Name = "txtCodUser";
            this.txtCodUser.PasswordChar = '●';
            this.txtCodUser.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCodUser.SelectedText = "";
            this.txtCodUser.SelectionLength = 0;
            this.txtCodUser.SelectionStart = 0;
            this.txtCodUser.ShortcutsEnabled = true;
            this.txtCodUser.ShowClearButton = true;
            this.txtCodUser.Size = new System.Drawing.Size(200, 28);
            this.txtCodUser.TabIndex = 1;
            this.txtCodUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCodUser.UseCustomBackColor = true;
            this.txtCodUser.UseCustomForeColor = true;
            this.txtCodUser.UseSelectable = true;
            this.txtCodUser.UseSystemPasswordChar = true;
            this.txtCodUser.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCodUser.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCodUser.ClearClicked += new MetroFramework.Controls.MetroTextBox.LUClear(this.txtPassword_ClearClicked);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.Navy;
            this.lblPassword.Location = new System.Drawing.Point(7, 11);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(247, 25);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "Asignar: Ingrese Código: ";
            // 
            // pnlCenterDownNumbers
            // 
            this.pnlCenterDownNumbers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlCenterDownNumbers.Location = new System.Drawing.Point(363, 356);
            this.pnlCenterDownNumbers.Margin = new System.Windows.Forms.Padding(4);
            this.pnlCenterDownNumbers.Name = "pnlCenterDownNumbers";
            this.pnlCenterDownNumbers.Size = new System.Drawing.Size(344, 354);
            this.pnlCenterDownNumbers.TabIndex = 3;
            // 
            // panelRightDownYN
            // 
            this.panelRightDownYN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelRightDownYN.Controls.Add(this.btnNot);
            this.panelRightDownYN.Controls.Add(this.btnYes);
            this.panelRightDownYN.Location = new System.Drawing.Point(713, 356);
            this.panelRightDownYN.Margin = new System.Windows.Forms.Padding(4);
            this.panelRightDownYN.Name = "panelRightDownYN";
            this.panelRightDownYN.Size = new System.Drawing.Size(323, 354);
            this.panelRightDownYN.TabIndex = 3;
            // 
            // btnNot
            // 
            this.btnNot.ActiveControl = null;
            this.btnNot.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNot.Location = new System.Drawing.Point(161, 0);
            this.btnNot.Margin = new System.Windows.Forms.Padding(4);
            this.btnNot.Name = "btnNot";
            this.btnNot.Size = new System.Drawing.Size(161, 127);
            this.btnNot.Style = MetroFramework.MetroColorStyle.Red;
            this.btnNot.TabIndex = 10;
            this.btnNot.Tag = "cancel_48_N";
            this.btnNot.Text = "Close";
            this.btnNot.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNot.TileImage = global::MD_SistemasWFA.Properties.Resources.cancel_48_N;
            this.btnNot.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNot.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnNot.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnNot.UseSelectable = true;
            this.btnNot.UseTileImage = true;
            this.btnNot.Click += new System.EventHandler(this.btnNot_Click);
            // 
            // btnYes
            // 
            this.btnYes.ActiveControl = null;
            this.btnYes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnYes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnYes.Location = new System.Drawing.Point(0, 0);
            this.btnYes.Margin = new System.Windows.Forms.Padding(4);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(161, 127);
            this.btnYes.Style = MetroFramework.MetroColorStyle.Green;
            this.btnYes.TabIndex = 9;
            this.btnYes.Tag = "check_mark_48_N";
            this.btnYes.Text = "Open";
            this.btnYes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnYes.TileImage = global::MD_SistemasWFA.Properties.Resources.check_mark_48_N;
            this.btnYes.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnYes.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnYes.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnYes.UseSelectable = true;
            this.btnYes.UseTileImage = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // panelLeftDownChannels
            // 
            this.panelLeftDownChannels.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelLeftDownChannels.Location = new System.Drawing.Point(31, 356);
            this.panelLeftDownChannels.Margin = new System.Windows.Forms.Padding(4);
            this.panelLeftDownChannels.Name = "panelLeftDownChannels";
            this.panelLeftDownChannels.Size = new System.Drawing.Size(323, 354);
            this.panelLeftDownChannels.TabIndex = 4;
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = this;
            // 
            // pnlTitle
            // 
            this.pnlTitle.ActiveControl = null;
            this.pnlTitle.Location = new System.Drawing.Point(265, 78);
            this.pnlTitle.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(771, 213);
            this.pnlTitle.TabIndex = 6;
            this.pnlTitle.Text = "Sistemas";
            this.pnlTitle.UseSelectable = true;
            // 
            // panelCenter
            // 
            this.panelCenter.Controls.Add(this.txtPassword2);
            this.panelCenter.Controls.Add(this.lblDate2);
            this.panelCenter.Location = new System.Drawing.Point(31, 294);
            this.panelCenter.Margin = new System.Windows.Forms.Padding(4);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(1005, 58);
            this.panelCenter.TabIndex = 7;
            // 
            // btnInputOuput
            // 
            this.btnInputOuput.ActiveControl = null;
            this.btnInputOuput.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnInputOuput.Location = new System.Drawing.Point(713, 481);
            this.btnInputOuput.Margin = new System.Windows.Forms.Padding(4);
            this.btnInputOuput.Name = "btnInputOuput";
            this.btnInputOuput.Size = new System.Drawing.Size(323, 229);
            this.btnInputOuput.Style = MetroFramework.MetroColorStyle.Yellow;
            this.btnInputOuput.TabIndex = 11;
            this.btnInputOuput.Tag = "enter_96_N";
            this.btnInputOuput.Text = "Input / Ouput";
            this.btnInputOuput.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInputOuput.TileImage = global::MD_SistemasWFA.Properties.Resources.enter_96_N;
            this.btnInputOuput.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnInputOuput.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnInputOuput.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnInputOuput.UseSelectable = true;
            this.btnInputOuput.UseTileImage = true;
            this.btnInputOuput.Click += new System.EventHandler(this.btnActInputOutput_Click);
            // 
            // pnlImage
            // 
            this.pnlImage.BackColor = System.Drawing.Color.Transparent;
            this.pnlImage.BackgroundImage = global::MD_SistemasWFA.Properties.Resources.blue_pc_128;
            this.pnlImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlImage.Location = new System.Drawing.Point(31, 78);
            this.pnlImage.Margin = new System.Windows.Forms.Padding(4);
            this.pnlImage.Name = "pnlImage";
            this.pnlImage.Size = new System.Drawing.Size(227, 213);
            this.pnlImage.TabIndex = 5;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 738);
            this.Controls.Add(this.btnInputOuput);
            this.Controls.Add(this.panelCenter);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.pnlImage);
            this.Controls.Add(this.panelLeftDownChannels);
            this.Controls.Add(this.pnlCenterDownNumbers);
            this.Controls.Add(this.panelRightDownYN);
            this.Controls.Add(this.panelUp);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1067, 738);
            this.Name = "FormMain";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            this.panelUp.ResumeLayout(false);
            this.panelUp.PerformLayout();
            this.lblDate2.ResumeLayout(false);
            this.lblDate2.PerformLayout();
            this.txtPassword2.ResumeLayout(false);
            this.txtPassword2.PerformLayout();
            this.panelRightDownYN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.panelCenter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel panelUp;
        private MetroFramework.Controls.MetroTile lblDate2;
        private MetroFramework.Controls.MetroTile txtPassword2;
        private System.Windows.Forms.Panel pnlCenterDownNumbers;
        private System.Windows.Forms.Panel panelRightDownYN;
        private System.Windows.Forms.Timer timer;
        private MetroFramework.Controls.MetroTile btnInputOuput;
        private MetroFramework.Controls.MetroTile btnNot;
        private MetroFramework.Controls.MetroTile btnYes;
        private System.Windows.Forms.FlowLayoutPanel panelLeftDownChannels;
        private System.Windows.Forms.Panel pnlImage;
        private MetroFramework.Components.MetroStyleManager metroStyleManager;
        private MetroFramework.Controls.MetroTile pnlTitle;
        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.Label lblPassword;
        private MetroFramework.Controls.MetroTextBox txtCodUser;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblNameUser;
    }
}

