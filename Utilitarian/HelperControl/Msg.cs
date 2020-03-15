using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utilitarian.HelperControl
{
    public class Msg
    {
        public DialogResult Ok_Info(string msj, string title = "Mensaje")
        {
            return MessageBox.Show(msj, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public DialogResult Ok_Wng(string msj, string title = "Mensaje")
        {
            return MessageBox.Show(msj, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public DialogResult Ok_Err(string msj, string title = "Mensaje")
        {
            return MessageBox.Show(msj, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public DialogResult YesNo_Ques(string msj, string title = "Confirmación")
        {
            return MessageBox.Show(msj, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        public DialogResult OkCancel_Ques(string msj, string title = "Mensaje")
        {
            return MessageBox.Show(msj, title, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }

        public DialogResult OkCancel_Wng(string msj, string title = "Mensaje")
        {
            return MessageBox.Show(msj, title, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }
    }
}
