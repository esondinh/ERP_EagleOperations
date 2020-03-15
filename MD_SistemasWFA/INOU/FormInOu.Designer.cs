namespace MD_SistemasWFA.INOU
{
    partial class FormInOu
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
            this.lblNombreForm = new System.Windows.Forms.Label();
            this.cboDevice = new MetroFramework.Controls.MetroComboBox();
            this.btnStartCapture = new MetroFramework.Controls.MetroTile();
            this.btnCerrar = new MetroFramework.Controls.MetroLink();
            this.pbOld = new System.Windows.Forms.PictureBox();
            this.pbNow = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbOld)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNow)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombreForm
            // 
            this.lblNombreForm.AutoSize = true;
            this.lblNombreForm.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreForm.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNombreForm.Location = new System.Drawing.Point(100, 45);
            this.lblNombreForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreForm.Name = "lblNombreForm";
            this.lblNombreForm.Size = new System.Drawing.Size(207, 41);
            this.lblNombreForm.TabIndex = 97;
            this.lblNombreForm.Text = "Facial Capture";
            // 
            // cboDevice
            // 
            this.cboDevice.FormattingEnabled = true;
            this.cboDevice.ItemHeight = 24;
            this.cboDevice.Location = new System.Drawing.Point(479, 406);
            this.cboDevice.Name = "cboDevice";
            this.cboDevice.Size = new System.Drawing.Size(261, 30);
            this.cboDevice.TabIndex = 98;
            this.cboDevice.UseSelectable = true;
            // 
            // btnStartCapture
            // 
            this.btnStartCapture.ActiveControl = null;
            this.btnStartCapture.Location = new System.Drawing.Point(479, 442);
            this.btnStartCapture.Name = "btnStartCapture";
            this.btnStartCapture.Size = new System.Drawing.Size(261, 61);
            this.btnStartCapture.TabIndex = 99;
            this.btnStartCapture.Text = "Start Capture";
            this.btnStartCapture.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnStartCapture.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnStartCapture.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnStartCapture.UseSelectable = true;
            this.btnStartCapture.Click += new System.EventHandler(this.btnStartCapture_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.Image = global::MD_SistemasWFA.Properties.Resources.left_arrowx64;
            this.btnCerrar.ImageSize = 48;
            this.btnCerrar.Location = new System.Drawing.Point(20, 28);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 70);
            this.btnCerrar.TabIndex = 96;
            this.btnCerrar.UseCustomBackColor = true;
            this.btnCerrar.UseSelectable = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pbOld
            // 
            this.pbOld.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbOld.Image = global::MD_SistemasWFA.Properties.Resources.user_256_N;
            this.pbOld.Location = new System.Drawing.Point(479, 130);
            this.pbOld.Name = "pbOld";
            this.pbOld.Size = new System.Drawing.Size(260, 270);
            this.pbOld.TabIndex = 1;
            this.pbOld.TabStop = false;
            // 
            // pbNow
            // 
            this.pbNow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbNow.Location = new System.Drawing.Point(23, 130);
            this.pbNow.Name = "pbNow";
            this.pbNow.Size = new System.Drawing.Size(450, 400);
            this.pbNow.TabIndex = 0;
            this.pbNow.TabStop = false;
            // 
            // FormInOu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnStartCapture);
            this.Controls.Add(this.cboDevice);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblNombreForm);
            this.Controls.Add(this.pbOld);
            this.Controls.Add(this.pbNow);
            this.Name = "FormInOu";
            ((System.ComponentModel.ISupportInitialize)(this.pbOld)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbNow;
        private System.Windows.Forms.PictureBox pbOld;
        private MetroFramework.Controls.MetroLink btnCerrar;
        private System.Windows.Forms.Label lblNombreForm;
        private MetroFramework.Controls.MetroComboBox cboDevice;
        private MetroFramework.Controls.MetroTile btnStartCapture;
    }
}