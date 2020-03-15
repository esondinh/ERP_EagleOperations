namespace MD_SistemasWFA
{
    partial class FormConfiguration
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
            this.lblTheme = new MetroFramework.Controls.MetroLabel();
            this.cbo_Themes = new MetroFramework.Controls.MetroComboBox();
            this.lblColors = new MetroFramework.Controls.MetroLabel();
            this.cbo_Color = new MetroFramework.Controls.MetroComboBox();
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.lbl_ScreenResolution = new MetroFramework.Controls.MetroLabel();
            this.cbo_ScreenResolutions = new MetroFramework.Controls.MetroComboBox();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.btn_Cancel = new MetroFramework.Controls.MetroTile();
            this.btn_Ok = new MetroFramework.Controls.MetroTile();
            this.tabControl_ConfigurationsManager = new MetroFramework.Controls.MetroTabControl();
            this.tabPage_ThemeStyle = new MetroFramework.Controls.MetroTabPage();
            this.lbl_ThemeStyle = new MetroFramework.Controls.MetroTile();
            this.tabPage_ScreenResolutions = new MetroFramework.Controls.MetroTabPage();
            this.lbl_Resolution = new MetroFramework.Controls.MetroTile();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage4 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage5 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage6 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage7 = new MetroFramework.Controls.MetroTabPage();
            this.pnl_Bottom = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.tabControl_ConfigurationsManager.SuspendLayout();
            this.tabPage_ThemeStyle.SuspendLayout();
            this.tabPage_ScreenResolutions.SuspendLayout();
            this.pnl_Bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTheme
            // 
            this.lblTheme.AutoSize = true;
            this.lblTheme.Location = new System.Drawing.Point(23, 100);
            this.lblTheme.Name = "lblTheme";
            this.lblTheme.Size = new System.Drawing.Size(56, 19);
            this.lblTheme.TabIndex = 0;
            this.lblTheme.Text = "Theme :";
            // 
            // cbo_Themes
            // 
            this.cbo_Themes.FormattingEnabled = true;
            this.cbo_Themes.ItemHeight = 23;
            this.cbo_Themes.Items.AddRange(new object[] {
            "Dark",
            "Light"});
            this.cbo_Themes.Location = new System.Drawing.Point(96, 96);
            this.cbo_Themes.Name = "cbo_Themes";
            this.cbo_Themes.Size = new System.Drawing.Size(162, 29);
            this.cbo_Themes.TabIndex = 1;
            this.cbo_Themes.UseSelectable = true;
            this.cbo_Themes.SelectedIndexChanged += new System.EventHandler(this.cbo_Themes_SelectedIndexChanged);
            // 
            // lblColors
            // 
            this.lblColors.AutoSize = true;
            this.lblColors.Location = new System.Drawing.Point(319, 100);
            this.lblColors.Name = "lblColors";
            this.lblColors.Size = new System.Drawing.Size(49, 19);
            this.lblColors.TabIndex = 2;
            this.lblColors.Text = "Color :";
            // 
            // cbo_Color
            // 
            this.cbo_Color.FormattingEnabled = true;
            this.cbo_Color.ItemHeight = 23;
            this.cbo_Color.Items.AddRange(new object[] {
            "Default",
            "Black",
            "While",
            "Silver",
            "Blue",
            "Green",
            "Lime",
            "Teal",
            "Orange",
            "Brown",
            "Pink",
            "Magenta",
            "Purple",
            "Red",
            "Yellow"});
            this.cbo_Color.Location = new System.Drawing.Point(388, 96);
            this.cbo_Color.Name = "cbo_Color";
            this.cbo_Color.Size = new System.Drawing.Size(162, 29);
            this.cbo_Color.TabIndex = 3;
            this.cbo_Color.UseSelectable = true;
            this.cbo_Color.SelectedIndexChanged += new System.EventHandler(this.cbo_Color_SelectedIndexChanged);
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = this;
            // 
            // lbl_ScreenResolution
            // 
            this.lbl_ScreenResolution.AutoSize = true;
            this.lbl_ScreenResolution.Location = new System.Drawing.Point(23, 100);
            this.lbl_ScreenResolution.Name = "lbl_ScreenResolution";
            this.lbl_ScreenResolution.Size = new System.Drawing.Size(120, 19);
            this.lbl_ScreenResolution.TabIndex = 5;
            this.lbl_ScreenResolution.Text = "Screen Resolutions:";
            // 
            // cbo_ScreenResolutions
            // 
            this.cbo_ScreenResolutions.FormattingEnabled = true;
            this.cbo_ScreenResolutions.ItemHeight = 23;
            this.cbo_ScreenResolutions.Location = new System.Drawing.Point(149, 96);
            this.cbo_ScreenResolutions.Name = "cbo_ScreenResolutions";
            this.cbo_ScreenResolutions.Size = new System.Drawing.Size(162, 29);
            this.cbo_ScreenResolutions.TabIndex = 6;
            this.cbo_ScreenResolutions.UseSelectable = true;
            this.cbo_ScreenResolutions.SelectedIndexChanged += new System.EventHandler(this.cbo_ScreenResolutions_SelectedIndexChanged);
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(266, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[] {
        "metroTextBox1"};
            this.metroTextBox1.Location = new System.Drawing.Point(351, 100);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(288, 23);
            this.metroTextBox1.TabIndex = 7;
            this.metroTextBox1.Text = "metroTextBox1";
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.ActiveControl = null;
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(637, 3);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(120, 38);
            this.btn_Cancel.Style = MetroFramework.MetroColorStyle.Red;
            this.btn_Cancel.TabIndex = 8;
            this.btn_Cancel.Text = "CANCEL";
            this.btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Cancel.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_Cancel.UseSelectable = true;
            // 
            // btn_Ok
            // 
            this.btn_Ok.ActiveControl = null;
            this.btn_Ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Ok.Location = new System.Drawing.Point(511, 3);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(120, 38);
            this.btn_Ok.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_Ok.TabIndex = 9;
            this.btn_Ok.Text = "OK";
            this.btn_Ok.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Ok.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_Ok.UseSelectable = true;
            this.btn_Ok.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // tabControl_ConfigurationsManager
            // 
            this.tabControl_ConfigurationsManager.Controls.Add(this.tabPage_ThemeStyle);
            this.tabControl_ConfigurationsManager.Controls.Add(this.tabPage_ScreenResolutions);
            this.tabControl_ConfigurationsManager.Controls.Add(this.metroTabPage3);
            this.tabControl_ConfigurationsManager.Controls.Add(this.metroTabPage4);
            this.tabControl_ConfigurationsManager.Controls.Add(this.metroTabPage5);
            this.tabControl_ConfigurationsManager.Controls.Add(this.metroTabPage6);
            this.tabControl_ConfigurationsManager.Controls.Add(this.metroTabPage7);
            this.tabControl_ConfigurationsManager.FontWeight = MetroFramework.MetroTabControlWeight.Regular;
            this.tabControl_ConfigurationsManager.Location = new System.Drawing.Point(23, 152);
            this.tabControl_ConfigurationsManager.Name = "tabControl_ConfigurationsManager";
            this.tabControl_ConfigurationsManager.SelectedIndex = 0;
            this.tabControl_ConfigurationsManager.Size = new System.Drawing.Size(754, 279);
            this.tabControl_ConfigurationsManager.TabIndex = 10;
            this.tabControl_ConfigurationsManager.UseSelectable = true;
            // 
            // tabPage_ThemeStyle
            // 
            this.tabPage_ThemeStyle.Controls.Add(this.lbl_ThemeStyle);
            this.tabPage_ThemeStyle.Controls.Add(this.lblTheme);
            this.tabPage_ThemeStyle.Controls.Add(this.cbo_Themes);
            this.tabPage_ThemeStyle.Controls.Add(this.lblColors);
            this.tabPage_ThemeStyle.Controls.Add(this.cbo_Color);
            this.tabPage_ThemeStyle.HorizontalScrollbarBarColor = true;
            this.tabPage_ThemeStyle.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPage_ThemeStyle.HorizontalScrollbarSize = 10;
            this.tabPage_ThemeStyle.Location = new System.Drawing.Point(4, 38);
            this.tabPage_ThemeStyle.Name = "tabPage_ThemeStyle";
            this.tabPage_ThemeStyle.Size = new System.Drawing.Size(746, 237);
            this.tabPage_ThemeStyle.TabIndex = 0;
            this.tabPage_ThemeStyle.Text = "Theme / Style";
            this.tabPage_ThemeStyle.VerticalScrollbarBarColor = true;
            this.tabPage_ThemeStyle.VerticalScrollbarHighlightOnWheel = false;
            this.tabPage_ThemeStyle.VerticalScrollbarSize = 10;
            // 
            // lbl_ThemeStyle
            // 
            this.lbl_ThemeStyle.ActiveControl = null;
            this.lbl_ThemeStyle.Location = new System.Drawing.Point(23, 30);
            this.lbl_ThemeStyle.Name = "lbl_ThemeStyle";
            this.lbl_ThemeStyle.Size = new System.Drawing.Size(720, 38);
            this.lbl_ThemeStyle.TabIndex = 5;
            this.lbl_ThemeStyle.Text = "Theme / Style Main";
            this.lbl_ThemeStyle.UseSelectable = true;
            // 
            // tabPage_ScreenResolutions
            // 
            this.tabPage_ScreenResolutions.Controls.Add(this.lbl_Resolution);
            this.tabPage_ScreenResolutions.Controls.Add(this.lbl_ScreenResolution);
            this.tabPage_ScreenResolutions.Controls.Add(this.metroTextBox1);
            this.tabPage_ScreenResolutions.Controls.Add(this.cbo_ScreenResolutions);
            this.tabPage_ScreenResolutions.HorizontalScrollbarBarColor = true;
            this.tabPage_ScreenResolutions.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPage_ScreenResolutions.HorizontalScrollbarSize = 10;
            this.tabPage_ScreenResolutions.Location = new System.Drawing.Point(4, 38);
            this.tabPage_ScreenResolutions.Name = "tabPage_ScreenResolutions";
            this.tabPage_ScreenResolutions.Size = new System.Drawing.Size(746, 237);
            this.tabPage_ScreenResolutions.TabIndex = 1;
            this.tabPage_ScreenResolutions.Text = "Screen Resolutions";
            this.tabPage_ScreenResolutions.VerticalScrollbarBarColor = true;
            this.tabPage_ScreenResolutions.VerticalScrollbarHighlightOnWheel = false;
            this.tabPage_ScreenResolutions.VerticalScrollbarSize = 10;
            // 
            // lbl_Resolution
            // 
            this.lbl_Resolution.ActiveControl = null;
            this.lbl_Resolution.Location = new System.Drawing.Point(23, 30);
            this.lbl_Resolution.Name = "lbl_Resolution";
            this.lbl_Resolution.Size = new System.Drawing.Size(720, 38);
            this.lbl_Resolution.TabIndex = 11;
            this.lbl_Resolution.Text = "Screen Resolutions ";
            this.lbl_Resolution.UseSelectable = true;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(746, 237);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "metroTabPage3";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // metroTabPage4
            // 
            this.metroTabPage4.HorizontalScrollbarBarColor = true;
            this.metroTabPage4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.HorizontalScrollbarSize = 10;
            this.metroTabPage4.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage4.Name = "metroTabPage4";
            this.metroTabPage4.Size = new System.Drawing.Size(746, 237);
            this.metroTabPage4.TabIndex = 3;
            this.metroTabPage4.Text = "metroTabPage4";
            this.metroTabPage4.VerticalScrollbarBarColor = true;
            this.metroTabPage4.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.VerticalScrollbarSize = 10;
            // 
            // metroTabPage5
            // 
            this.metroTabPage5.HorizontalScrollbarBarColor = true;
            this.metroTabPage5.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage5.HorizontalScrollbarSize = 10;
            this.metroTabPage5.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage5.Name = "metroTabPage5";
            this.metroTabPage5.Size = new System.Drawing.Size(746, 237);
            this.metroTabPage5.TabIndex = 4;
            this.metroTabPage5.Text = "metroTabPage5";
            this.metroTabPage5.VerticalScrollbarBarColor = true;
            this.metroTabPage5.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage5.VerticalScrollbarSize = 10;
            // 
            // metroTabPage6
            // 
            this.metroTabPage6.HorizontalScrollbarBarColor = true;
            this.metroTabPage6.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage6.HorizontalScrollbarSize = 10;
            this.metroTabPage6.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage6.Name = "metroTabPage6";
            this.metroTabPage6.Size = new System.Drawing.Size(746, 237);
            this.metroTabPage6.TabIndex = 5;
            this.metroTabPage6.Text = "metroTabPage6";
            this.metroTabPage6.VerticalScrollbarBarColor = true;
            this.metroTabPage6.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage6.VerticalScrollbarSize = 10;
            // 
            // metroTabPage7
            // 
            this.metroTabPage7.HorizontalScrollbarBarColor = true;
            this.metroTabPage7.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage7.HorizontalScrollbarSize = 10;
            this.metroTabPage7.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage7.Name = "metroTabPage7";
            this.metroTabPage7.Size = new System.Drawing.Size(746, 237);
            this.metroTabPage7.TabIndex = 6;
            this.metroTabPage7.Text = "metroTabPage7";
            this.metroTabPage7.VerticalScrollbarBarColor = true;
            this.metroTabPage7.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage7.VerticalScrollbarSize = 10;
            // 
            // pnl_Bottom
            // 
            this.pnl_Bottom.Controls.Add(this.btn_Cancel);
            this.pnl_Bottom.Controls.Add(this.btn_Ok);
            this.pnl_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Bottom.Location = new System.Drawing.Point(20, 536);
            this.pnl_Bottom.Name = "pnl_Bottom";
            this.pnl_Bottom.Size = new System.Drawing.Size(760, 44);
            this.pnl_Bottom.TabIndex = 11;
            // 
            // FormConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.pnl_Bottom);
            this.Controls.Add(this.tabControl_ConfigurationsManager);
            this.Name = "FormConfiguration";
            this.Text = "Configurations Manager";
            this.Load += new System.EventHandler(this.ConfigurationsThemes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.tabControl_ConfigurationsManager.ResumeLayout(false);
            this.tabPage_ThemeStyle.ResumeLayout(false);
            this.tabPage_ThemeStyle.PerformLayout();
            this.tabPage_ScreenResolutions.ResumeLayout(false);
            this.tabPage_ScreenResolutions.PerformLayout();
            this.pnl_Bottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblTheme;
        private MetroFramework.Controls.MetroComboBox cbo_Themes;
        private MetroFramework.Controls.MetroLabel lblColors;
        private MetroFramework.Controls.MetroComboBox cbo_Color;
        private MetroFramework.Components.MetroStyleManager metroStyleManager;
        private MetroFramework.Controls.MetroComboBox cbo_ScreenResolutions;
        private MetroFramework.Controls.MetroLabel lbl_ScreenResolution;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroTile btn_Ok;
        private MetroFramework.Controls.MetroTile btn_Cancel;
        private MetroFramework.Controls.MetroTabControl tabControl_ConfigurationsManager;
        private MetroFramework.Controls.MetroTabPage tabPage_ThemeStyle;
        private MetroFramework.Controls.MetroTile lbl_ThemeStyle;
        private MetroFramework.Controls.MetroTabPage tabPage_ScreenResolutions;
        private MetroFramework.Controls.MetroTile lbl_Resolution;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroTabPage metroTabPage4;
        private MetroFramework.Controls.MetroTabPage metroTabPage5;
        private MetroFramework.Controls.MetroTabPage metroTabPage6;
        private MetroFramework.Controls.MetroTabPage metroTabPage7;
        private System.Windows.Forms.Panel pnl_Bottom;
    }
}