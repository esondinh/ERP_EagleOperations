namespace MD_SistemasWFA.ClockInOut
{
    partial class FrmClockInOutSecond
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
            this.lstAssignedWork = new System.Windows.Forms.ListBox();
            this.pnlOptions = new System.Windows.Forms.Panel();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstAssignedWork
            // 
            this.lstAssignedWork.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAssignedWork.FormattingEnabled = true;
            this.lstAssignedWork.ItemHeight = 35;
            this.lstAssignedWork.Items.AddRange(new object[] {
            "Tipo1",
            "Tipo2",
            "Tipo3",
            "Tipo4",
            "Tipo5"});
            this.lstAssignedWork.Location = new System.Drawing.Point(23, 107);
            this.lstAssignedWork.Name = "lstAssignedWork";
            this.lstAssignedWork.Size = new System.Drawing.Size(354, 249);
            this.lstAssignedWork.TabIndex = 3;
            this.lstAssignedWork.SelectedIndexChanged += new System.EventHandler(this.lstWorkAssignment_SelectedIndexChanged);
            // 
            // pnlOptions
            // 
            this.pnlOptions.Controls.Add(this.btnConfirm);
            this.pnlOptions.Controls.Add(this.btnCancel);
            this.pnlOptions.Location = new System.Drawing.Point(23, 377);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Size = new System.Drawing.Size(354, 100);
            this.pnlOptions.TabIndex = 4;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.LightGreen;
            this.btnConfirm.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe Print", 16F, System.Drawing.FontStyle.Bold);
            this.btnConfirm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnConfirm.Image = global::MD_SistemasWFA.Properties.Resources.check_mark_32_N;
            this.btnConfirm.Location = new System.Drawing.Point(3, 3);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(112, 94);
            this.btnConfirm.TabIndex = 6;
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
            this.btnCancel.Location = new System.Drawing.Point(239, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 94);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(23, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "Seleccione su Asignación de Trabajo";
            // 
            // frmClockInOutSecond
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 500);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlOptions);
            this.Controls.Add(this.lstAssignedWork);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmClockInOutSecond";
            this.pnlOptions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstAssignedWork;
        private System.Windows.Forms.Panel pnlOptions;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
    }
}