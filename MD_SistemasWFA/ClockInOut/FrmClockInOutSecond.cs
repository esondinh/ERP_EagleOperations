using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilitarian.HelperControl;

namespace MD_SistemasWFA.ClockInOut
{
    public partial class FrmClockInOutSecond : MetroForm
    {
        #region GLOBAL VARIABLES

        private Msg msg = null;
        public String _assignedWork = null;
        
        #endregion

        public FrmClockInOutSecond()
        {
            InitializeComponent();
            //disable button  
            btnConfirm.Enabled = false;
        }

        #region WINDOW METHODS
        #endregion

        #region WINDOW EVENTS
        private void lstWorkAssignment_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                _assignedWork = lstAssignedWork.SelectedIndex.ToString();
                _assignedWork = lstAssignedWork.SelectedItem.ToString();
                //enable button
                btnConfirm.Enabled = true;
            }
            catch (Exception)
            {
                msg = new Msg();
                msg.Ok_Info("Se ha producido un error. Vuelva a intentarlo.");
                //throw;
            }
        }
        // CONFIRM AND CANCEL
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if(_asignacionTrabajo==null)
            //        msg = new Msg();
            //        msg.Ok_Info("No seleccionó su Asignación de Trabajo. Vuelva e intentarlo.");
            //}
            //catch (Exception)
            //{

            //    throw;
            //}
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                Msg msg = new Msg();
                DialogResult res = msg.YesNo_Ques("Usted desea salir del Registro de Asignación de Trabajo?");
                if (res == DialogResult.Yes)
                {
                    Dispose();
                }
            }
            catch (Exception)
            {
                msg = new Msg();
                msg.Ok_Info("Se ha producido un error. Vuelva a intentarlo.");
                //throw;
            }
        }
        #endregion

    }
}
