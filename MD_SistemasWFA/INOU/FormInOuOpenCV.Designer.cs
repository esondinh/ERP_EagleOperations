namespace MD_SistemasWFA.INOU
{
    partial class FormInOuOpenCV
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
            this.btnStartCapture = new MetroFramework.Controls.MetroTile();
            this.cboDevice = new MetroFramework.Controls.MetroComboBox();
            this.btnCerrar = new MetroFramework.Controls.MetroLink();
            this.lblNombreForm = new System.Windows.Forms.Label();
            this.pbShow = new System.Windows.Forms.PictureBox();
            this.pbCapture = new Emgu.CV.UI.ImageBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCapture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStartCapture
            // 
            this.btnStartCapture.ActiveControl = null;
            this.btnStartCapture.Location = new System.Drawing.Point(20, 463);
            this.btnStartCapture.Name = "btnStartCapture";
            this.btnStartCapture.Size = new System.Drawing.Size(457, 86);
            this.btnStartCapture.TabIndex = 105;
            this.btnStartCapture.Text = "Start Capture";
            this.btnStartCapture.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnStartCapture.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnStartCapture.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnStartCapture.UseSelectable = true;
            this.btnStartCapture.Click += new System.EventHandler(this.btnStartCapture_Click);
            // 
            // cboDevice
            // 
            this.cboDevice.FormattingEnabled = true;
            this.cboDevice.ItemHeight = 24;
            this.cboDevice.Location = new System.Drawing.Point(484, 463);
            this.cboDevice.Name = "cboDevice";
            this.cboDevice.Size = new System.Drawing.Size(294, 30);
            this.cboDevice.TabIndex = 104;
            this.cboDevice.UseSelectable = true;
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
            this.btnCerrar.TabIndex = 102;
            this.btnCerrar.UseCustomBackColor = true;
            this.btnCerrar.UseSelectable = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
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
            this.lblNombreForm.TabIndex = 103;
            this.lblNombreForm.Text = "Facial Capture";
            // 
            // pbShow
            // 
            this.pbShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbShow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbShow.Image = global::MD_SistemasWFA.Properties.Resources.user_256_N;
            this.pbShow.Location = new System.Drawing.Point(489, 105);
            this.pbShow.Name = "pbShow";
            this.pbShow.Size = new System.Drawing.Size(289, 340);
            this.pbShow.TabIndex = 101;
            this.pbShow.TabStop = false;
            // 
            // pbCapture
            // 
            this.pbCapture.InitialImage = global::MD_SistemasWFA.Properties.Resources.user_256_N;
            this.pbCapture.Location = new System.Drawing.Point(23, 105);
            this.pbCapture.Name = "pbCapture";
            this.pbCapture.Size = new System.Drawing.Size(460, 340);
            this.pbCapture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCapture.TabIndex = 2;
            this.pbCapture.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(422, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 106;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.FlipHorizontalButtonClick);
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(160, 560);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(617, 22);
            this.txtDescription.TabIndex = 107;
            this.txtDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 560);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(89, 20);
            this.metroLabel1.TabIndex = 108;
            this.metroLabel1.Text = "Descripción :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(484, 508);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(293, 41);
            this.textBox1.TabIndex = 109;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::MD_SistemasWFA.Properties.Resources.user_256_N;
            this.pictureBox1.Image = global::MD_SistemasWFA.Properties.Resources.user_256_N;
            this.pictureBox1.InitialImage = global::MD_SistemasWFA.Properties.Resources.user_256_N;
            this.pictureBox1.Location = new System.Drawing.Point(107, 166);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 217);
            this.pictureBox1.TabIndex = 116;
            this.pictureBox1.TabStop = false;
            // 
            // FormInOuOpenCV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pbCapture);
            this.Controls.Add(this.btnStartCapture);
            this.Controls.Add(this.cboDevice);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblNombreForm);
            this.Controls.Add(this.pbShow);
            this.Name = "FormInOuOpenCV";
            this.Load += new System.EventHandler(this.FormInOuOpenCV_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormInOuOpenCV_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pbShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCapture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile btnStartCapture;
        private MetroFramework.Controls.MetroComboBox cboDevice;
        private MetroFramework.Controls.MetroLink btnCerrar;
        private System.Windows.Forms.Label lblNombreForm;
        private System.Windows.Forms.PictureBox pbShow;
        private Emgu.CV.UI.ImageBox pbCapture;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtDescription;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}