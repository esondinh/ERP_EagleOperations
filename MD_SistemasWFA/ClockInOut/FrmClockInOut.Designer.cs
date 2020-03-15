namespace MD_SistemasWFA.ClockInOut
{
    partial class FrmClockInOut
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
            this.gbxTakenFace = new System.Windows.Forms.GroupBox();
            this.picTakenPhoto = new System.Windows.Forms.PictureBox();
            this.lblNombreForm = new System.Windows.Forms.Label();
            this.pnlOptions = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnTakePhoto = new System.Windows.Forms.Button();
            this.cboDevices = new System.Windows.Forms.ComboBox();
            this.pnlTakingPhoto = new System.Windows.Forms.Panel();
            this.pnlTakingPhotoBottom = new System.Windows.Forms.Panel();
            this.pnlTakingPhotoTop = new System.Windows.Forms.Panel();
            this.pnlTakingPhotoRight = new System.Windows.Forms.Panel();
            this.pnlTakingPhotoLeft = new System.Windows.Forms.Panel();
            this.picTakingPhoto = new System.Windows.Forms.PictureBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.btnCerrar = new MetroFramework.Controls.MetroLink();
            this.gbxTakenFace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTakenPhoto)).BeginInit();
            this.pnlOptions.SuspendLayout();
            this.pnlTakingPhoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTakingPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxTakenFace
            // 
            this.gbxTakenFace.Controls.Add(this.picTakenPhoto);
            this.gbxTakenFace.Location = new System.Drawing.Point(497, 96);
            this.gbxTakenFace.Name = "gbxTakenFace";
            this.gbxTakenFace.Size = new System.Drawing.Size(280, 375);
            this.gbxTakenFace.TabIndex = 0;
            this.gbxTakenFace.TabStop = false;
            this.gbxTakenFace.Text = "Rostro Reconocido ";
            // 
            // picTakenPhoto
            // 
            this.picTakenPhoto.Location = new System.Drawing.Point(6, 21);
            this.picTakenPhoto.Name = "picTakenPhoto";
            this.picTakenPhoto.Size = new System.Drawing.Size(268, 350);
            this.picTakenPhoto.TabIndex = 0;
            this.picTakenPhoto.TabStop = false;
            // 
            // lblNombreForm
            // 
            this.lblNombreForm.AutoSize = true;
            this.lblNombreForm.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreForm.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNombreForm.Location = new System.Drawing.Point(100, 45);
            this.lblNombreForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreForm.Name = "lblNombreForm";
            this.lblNombreForm.Size = new System.Drawing.Size(190, 41);
            this.lblNombreForm.TabIndex = 105;
            this.lblNombreForm.Text = "Taking Photo";
            // 
            // pnlOptions
            // 
            this.pnlOptions.Controls.Add(this.textBox1);
            this.pnlOptions.Controls.Add(this.btnConfirm);
            this.pnlOptions.Controls.Add(this.btnCancel);
            this.pnlOptions.Controls.Add(this.btnTakePhoto);
            this.pnlOptions.Location = new System.Drawing.Point(23, 477);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Size = new System.Drawing.Size(754, 100);
            this.pnlOptions.TabIndex = 106;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(289, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(226, 94);
            this.textBox1.TabIndex = 6;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.LightGreen;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe Print", 16F, System.Drawing.FontStyle.Bold);
            this.btnConfirm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnConfirm.Image = global::MD_SistemasWFA.Properties.Resources.check_mark_32_N;
            this.btnConfirm.Location = new System.Drawing.Point(521, 3);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(112, 94);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Font = new System.Drawing.Font("Segoe Print", 16F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancel.Image = global::MD_SistemasWFA.Properties.Resources.cancel_32_N;
            this.btnCancel.Location = new System.Drawing.Point(639, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 94);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnTakePhoto
            // 
            this.btnTakePhoto.BackColor = System.Drawing.Color.SkyBlue;
            this.btnTakePhoto.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTakePhoto.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnTakePhoto.Location = new System.Drawing.Point(3, 3);
            this.btnTakePhoto.Name = "btnTakePhoto";
            this.btnTakePhoto.Size = new System.Drawing.Size(280, 94);
            this.btnTakePhoto.TabIndex = 0;
            this.btnTakePhoto.Text = "Iniciar";
            this.btnTakePhoto.UseVisualStyleBackColor = false;
            this.btnTakePhoto.Click += new System.EventHandler(this.btnTakePhoto_Click);
            // 
            // cboDevices
            // 
            this.cboDevices.FormattingEnabled = true;
            this.cboDevices.Location = new System.Drawing.Point(603, 63);
            this.cboDevices.Name = "cboDevices";
            this.cboDevices.Size = new System.Drawing.Size(174, 24);
            this.cboDevices.TabIndex = 1;
            // 
            // pnlTakingPhoto
            // 
            this.pnlTakingPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTakingPhoto.Controls.Add(this.pnlTakingPhotoBottom);
            this.pnlTakingPhoto.Controls.Add(this.pnlTakingPhotoTop);
            this.pnlTakingPhoto.Controls.Add(this.pnlTakingPhotoRight);
            this.pnlTakingPhoto.Controls.Add(this.pnlTakingPhotoLeft);
            this.pnlTakingPhoto.Controls.Add(this.picTakingPhoto);
            this.pnlTakingPhoto.Location = new System.Drawing.Point(23, 105);
            this.pnlTakingPhoto.Name = "pnlTakingPhoto";
            this.pnlTakingPhoto.Size = new System.Drawing.Size(472, 366);
            this.pnlTakingPhoto.TabIndex = 107;
            // 
            // pnlTakingPhotoBottom
            // 
            this.pnlTakingPhotoBottom.Location = new System.Drawing.Point(123, 313);
            this.pnlTakingPhotoBottom.Name = "pnlTakingPhotoBottom";
            this.pnlTakingPhotoBottom.Size = new System.Drawing.Size(238, 11);
            this.pnlTakingPhotoBottom.TabIndex = 4;
            this.pnlTakingPhotoBottom.Visible = false;
            // 
            // pnlTakingPhotoTop
            // 
            this.pnlTakingPhotoTop.Location = new System.Drawing.Point(123, 35);
            this.pnlTakingPhotoTop.Name = "pnlTakingPhotoTop";
            this.pnlTakingPhotoTop.Size = new System.Drawing.Size(238, 11);
            this.pnlTakingPhotoTop.TabIndex = 3;
            this.pnlTakingPhotoTop.Visible = false;
            // 
            // pnlTakingPhotoRight
            // 
            this.pnlTakingPhotoRight.Location = new System.Drawing.Point(425, 65);
            this.pnlTakingPhotoRight.Name = "pnlTakingPhotoRight";
            this.pnlTakingPhotoRight.Size = new System.Drawing.Size(10, 222);
            this.pnlTakingPhotoRight.TabIndex = 2;
            this.pnlTakingPhotoRight.Visible = false;
            // 
            // pnlTakingPhotoLeft
            // 
            this.pnlTakingPhotoLeft.Location = new System.Drawing.Point(37, 65);
            this.pnlTakingPhotoLeft.Name = "pnlTakingPhotoLeft";
            this.pnlTakingPhotoLeft.Size = new System.Drawing.Size(10, 222);
            this.pnlTakingPhotoLeft.TabIndex = 1;
            this.pnlTakingPhotoLeft.Visible = false;
            // 
            // picTakingPhoto
            // 
            this.picTakingPhoto.BackColor = System.Drawing.Color.Gray;
            this.picTakingPhoto.Location = new System.Drawing.Point(3, 3);
            this.picTakingPhoto.Name = "picTakingPhoto";
            this.picTakingPhoto.Size = new System.Drawing.Size(464, 358);
            this.picTakingPhoto.TabIndex = 0;
            this.picTakingPhoto.TabStop = false;
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
            this.btnCerrar.TabIndex = 104;
            this.btnCerrar.UseCustomBackColor = true;
            this.btnCerrar.UseSelectable = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FormClockInOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.ControlBox = false;
            this.Controls.Add(this.pnlTakingPhoto);
            this.Controls.Add(this.cboDevices);
            this.Controls.Add(this.pnlOptions);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblNombreForm);
            this.Controls.Add(this.gbxTakenFace);
            this.Name = "FormClockInOut";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormClockInOut_FormClosing);
            this.Load += new System.EventHandler(this.FormClockInOut_Load);
            this.gbxTakenFace.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTakenPhoto)).EndInit();
            this.pnlOptions.ResumeLayout(false);
            this.pnlOptions.PerformLayout();
            this.pnlTakingPhoto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTakingPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxTakenFace;
        private MetroFramework.Controls.MetroLink btnCerrar;
        private System.Windows.Forms.Label lblNombreForm;
        private System.Windows.Forms.Panel pnlOptions;
        private System.Windows.Forms.Panel pnlTakingPhoto;
        private System.Windows.Forms.PictureBox picTakenPhoto;
        private System.Windows.Forms.PictureBox picTakingPhoto;
        private System.Windows.Forms.Button btnTakePhoto;
        private System.Windows.Forms.ComboBox cboDevices;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel pnlTakingPhotoBottom;
        private System.Windows.Forms.Panel pnlTakingPhotoTop;
        private System.Windows.Forms.Panel pnlTakingPhotoRight;
        private System.Windows.Forms.Panel pnlTakingPhotoLeft;
    }
}