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
    public partial class ShowFormMessageNumbers : MetroFramework.Forms.MetroForm
    {
        public string number = "";
        public ShowFormMessageNumbers()
        {
            InitializeComponent();
        }

        //BUTTONS NUMBERS
        #region BTN NUMEBERS
        private void btn_01_Click(object sender, EventArgs e)
        {
            number += "1";
            lbl_Number.Text = number; 
        }

        private void btn_02_Click(object sender, EventArgs e)
        {
            number += "2";
            lbl_Number.Text = number;
        }

        private void btn_03_Click(object sender, EventArgs e)
        {
            number += "3";
            lbl_Number.Text = number;
        }

        private void btn_04_Click(object sender, EventArgs e)
        {
            number += "4";
            lbl_Number.Text = number;
        }

        private void btn_05_Click(object sender, EventArgs e)
        {
            number += "5";
            lbl_Number.Text = number;
        }

        private void btn_06_Click(object sender, EventArgs e)
        {
            number += "6";
            lbl_Number.Text = number;
        }

        private void btn_07_Click(object sender, EventArgs e)
        {
            number += "7";
            lbl_Number.Text = number;
        }

        private void btn_08_Click(object sender, EventArgs e)
        {
            number += "8";
            lbl_Number.Text = number;
        }

        private void btn_09_Click(object sender, EventArgs e)
        {
            number += "9";
            lbl_Number.Text = number;
        }
        #endregion


        #region CUSTOMERBACKCOLOR
        private void btn_CustomerBackColor_MouseEnter(object sender, EventArgs e)
        {
            var ctn = (MetroFramework.Controls.MetroTile)sender;
            ctn.UseCustomBackColor = true;
        }

        private void btn_CustomerBackColor_MouseLeave(object sender, EventArgs e)
        {
            var ctn = (MetroFramework.Controls.MetroTile)sender;
            ctn.UseCustomBackColor = false;
        }
        #endregion

        private void lbl_Number_ButtonClick(object sender, EventArgs e)
        {
            number = "";
            lbl_Number.Text = number;
        }
    }
}
