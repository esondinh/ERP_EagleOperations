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
    public partial class FormOrder : MetroFramework.Forms.MetroForm
    {
        public FormOrder()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SI creo ");
        }


        //ALLOWS YOU TO SELECT THE QUANTITY
        private void btn_SelecCantidad_Click(object sender, EventArgs e)
        {
            ShowFormMessageNumbers sh_frm = new ShowFormMessageNumbers();
            DialogResult res = sh_frm.ShowDialog();
            if (res == DialogResult.OK) {
                FormTableOrdes news = new FormTableOrdes();
                news.Controls.Find("txt_sip",true)[0].Text = "Hola";
                txt_send.Text = "si se pudo";
            }
        }
    }
}
