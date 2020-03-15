namespace MD_SistemasWFA
{
    partial class FormOrder
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
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.pnl_InsideLeft = new System.Windows.Forms.Panel();
            this.btn_SelecCantidad = new MetroFramework.Controls.MetroTile();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_send = new System.Windows.Forms.TextBox();
            this.pnl_InsideLeft.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.Transparent;
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(20, 417);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(404, 44);
            this.pnlBottom.TabIndex = 3;
            // 
            // pnl_InsideLeft
            // 
            this.pnl_InsideLeft.Controls.Add(this.btn_SelecCantidad);
            this.pnl_InsideLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_InsideLeft.Location = new System.Drawing.Point(0, 0);
            this.pnl_InsideLeft.Name = "pnl_InsideLeft";
            this.pnl_InsideLeft.Size = new System.Drawing.Size(44, 401);
            this.pnl_InsideLeft.TabIndex = 0;
            // 
            // btn_SelecCantidad
            // 
            this.btn_SelecCantidad.ActiveControl = null;
            this.btn_SelecCantidad.Location = new System.Drawing.Point(4, 4);
            this.btn_SelecCantidad.Name = "btn_SelecCantidad";
            this.btn_SelecCantidad.Size = new System.Drawing.Size(37, 48);
            this.btn_SelecCantidad.TabIndex = 0;
            this.btn_SelecCantidad.Text = "#";
            this.btn_SelecCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_SelecCantidad.UseSelectable = true;
            this.btn_SelecCantidad.Click += new System.EventHandler(this.btn_SelecCantidad_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(360, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(44, 401);
            this.panel2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(44, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 44);
            this.panel1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.txt_send);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.pnl_InsideLeft);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(20, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(404, 401);
            this.panel3.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(115, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_send
            // 
            this.txt_send.Location = new System.Drawing.Point(139, 67);
            this.txt_send.Name = "txt_send";
            this.txt_send.Size = new System.Drawing.Size(100, 20);
            this.txt_send.TabIndex = 5;
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 481);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.panel3);
            this.Name = "FormOrder";
            this.Text = "FormOrder";
            this.pnl_InsideLeft.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnl_InsideLeft;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private MetroFramework.Controls.MetroTile btn_SelecCantidad;
        private System.Windows.Forms.TextBox txt_send;
    }
}