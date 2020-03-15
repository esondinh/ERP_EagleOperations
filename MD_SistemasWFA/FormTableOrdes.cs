using MetroFramework;
using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MD_SistemasWFA
{
    public partial class FormTableOrdes : MetroFramework.Forms.MetroForm
    {
        //SHOW FORMS
        //Form objForm;


        //TABLES
        public int MesaCantidad = 0;

        //THEME FORMS
        public MetroFramework.Components.MetroStyleManager MetroStryleManagerForm;

        public FormTableOrdes()
        {
            InitializeComponent();
            //STYLE MANAGER
            MetroStryleManagerForm = new MetroFramework.Components.MetroStyleManager();
            StyleManager = metroStyleManager;

        }

        private void FormTable_Load(object sender, EventArgs e)
        {
            metroStyleManager.Theme = MetroStryleManagerForm.Theme;
            metroStyleManager.Style = MetroStryleManagerForm.Style;

            //LOAD OTHERS
            textBox.Text = MesaCantidad + "";
        }


        #region SHOWFROM ORDERS
        public void showOrders()
        {
            pnl_Center.Controls.Clear();
            //objForm?.Close();
            //objForm = new FormOrder
            FormOrder objForm = new FormOrder
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                //Dock = DockStyle.Fill
            };
            pnl_Bottom.BackColor = Color.Transparent;
            pnl_Center.Controls.Add(objForm.Controls.Find("panel3", true)[0]);
            //pnl_Center.Controls.Add(objForm);
            //objForm.Show();
        }
        #endregion

        #region EFECTOMODAL
        //EFECTO MODAL
        public Form EffectModal()
        {
            Form frmModal = new Form();
            frmModal.BackColor = Color.White;
            frmModal.Opacity = 0.6;
            frmModal.Width = 1366;
            frmModal.Height = 768;
            return frmModal;
        }


        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            showOrders();
        }

        #region OK- CANCEL
        private void btn_Ok_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ok");
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region TIME TICK
        //THIS METHOD : BRING THE VALUES OF FORMS
        private void timer_Tick(object sender, EventArgs e)
        {
            var c = this.Controls.Find("txt_send", true);
            if (c!=null && c.Count() >0)
            {
                Control cc = this.Controls.Find("txt_send", true)[0];
                txt_sip.Text = cc.Text;
            }
        }
        #endregion
    }
}
