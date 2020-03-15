namespace MD_SistemasWFA
{
    partial class FormTableOrdes
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
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.pnl_Left = new System.Windows.Forms.Panel();
            this.txt_sip = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.pnl_Center = new System.Windows.Forms.Panel();
            this.pnl_Bottom = new System.Windows.Forms.Panel();
            this.btn_Cancel = new MetroFramework.Controls.MetroTile();
            this.btn_Ok = new MetroFramework.Controls.MetroTile();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.pnl_Left.SuspendLayout();
            this.pnl_Bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = this;
            // 
            // pnl_Left
            // 
            this.pnl_Left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnl_Left.Controls.Add(this.txt_sip);
            this.pnl_Left.Controls.Add(this.button1);
            this.pnl_Left.Controls.Add(this.textBox);
            this.pnl_Left.Location = new System.Drawing.Point(20, 60);
            this.pnl_Left.Name = "pnl_Left";
            this.pnl_Left.Size = new System.Drawing.Size(300, 473);
            this.pnl_Left.TabIndex = 0;
            // 
            // txt_sip
            // 
            this.txt_sip.Location = new System.Drawing.Point(21, 194);
            this.txt_sip.Name = "txt_sip";
            this.txt_sip.Size = new System.Drawing.Size(240, 20);
            this.txt_sip.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 84);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(21, 22);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(273, 20);
            this.textBox.TabIndex = 0;
            // 
            // pnl_Center
            // 
            this.pnl_Center.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(193)))), ((int)(((byte)(216)))));
            this.pnl_Center.Location = new System.Drawing.Point(320, 60);
            this.pnl_Center.Name = "pnl_Center";
            this.pnl_Center.Size = new System.Drawing.Size(460, 473);
            this.pnl_Center.TabIndex = 0;
            // 
            // pnl_Bottom
            // 
            this.pnl_Bottom.BackColor = System.Drawing.Color.White;
            this.pnl_Bottom.Controls.Add(this.btn_Cancel);
            this.pnl_Bottom.Controls.Add(this.btn_Ok);
            this.pnl_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Bottom.Location = new System.Drawing.Point(20, 536);
            this.pnl_Bottom.Name = "pnl_Bottom";
            this.pnl_Bottom.Size = new System.Drawing.Size(760, 44);
            this.pnl_Bottom.TabIndex = 0;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.ActiveControl = null;
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(637, 3);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(120, 38);
            this.btn_Cancel.Style = MetroFramework.MetroColorStyle.Red;
            this.btn_Cancel.TabIndex = 10;
            this.btn_Cancel.Text = "CANCEL";
            this.btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Cancel.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_Cancel.UseSelectable = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Ok
            // 
            this.btn_Ok.ActiveControl = null;
            this.btn_Ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Ok.Location = new System.Drawing.Point(511, 3);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(120, 38);
            this.btn_Ok.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_Ok.TabIndex = 11;
            this.btn_Ok.Text = "OK";
            this.btn_Ok.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Ok.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_Ok.UseSelectable = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // FormTableOrdes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.pnl_Bottom);
            this.Controls.Add(this.pnl_Left);
            this.Controls.Add(this.pnl_Center);
            this.Name = "FormTableOrdes";
            this.Text = "FormTableOrdes";
            this.Load += new System.EventHandler(this.FormTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.pnl_Left.ResumeLayout(false);
            this.pnl_Left.PerformLayout();
            this.pnl_Bottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Components.MetroStyleManager metroStyleManager;
        private System.Windows.Forms.Panel pnl_Left;
        private System.Windows.Forms.Panel pnl_Center;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Panel pnl_Bottom;
        private MetroFramework.Controls.MetroTile btn_Cancel;
        private MetroFramework.Controls.MetroTile btn_Ok;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_sip;
        private System.Windows.Forms.Timer timer;
    }
}