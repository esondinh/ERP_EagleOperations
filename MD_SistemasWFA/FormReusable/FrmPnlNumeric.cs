using InterfacesManager.IM_BL;
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

namespace MD_SistemasWFA.FormReusable
{
    public partial class FrmPnlNumeric : MetroForm
    {

        #region GLOBAL VARIABLES
        private Msg msg = null;

        public string _nameControl;
        private string _textSave = "";
        private Control _ctnTxtInput;
        private Color _controlColor;

        private ControlEventBL _objControlEventBL;
   
        #endregion

        public FrmPnlNumeric()
        {
            InitializeComponent();
            {
            }
        }

        #region WINDOW METHODS
        public void FindTextControl(Control ControlReceived = null)
        {
            try
            {
                if (ControlReceived != null)
                {
                    //To check if text control exists
                    _ctnTxtInput = ControlReceived;
                }
                else
                {
                    //To show info message
                    msg = new Msg();
                    msg.Ok_Info("No se ha encontrado ningun control para el texto.");
                }
            }
            catch (Exception ex)
            {
                //To show info message
                msg = new Msg();
                msg.Ok_Info("Se ha producido un error. Vuelva a intentarlo.");
                //throw;
            }
        }
        #endregion

        #region WINDOW EVENTS

        //MOUSE ENTER AND LEAVE (METHO GENERAL)
        private void Control_MouseEnter(object sender, EventArgs e)
        {
            _objControlEventBL = new ControlEventBL();
            var ctn = (Button)sender;
            ctn = _objControlEventBL.MouseEnter(sender);
        }
        private void Control_MouseLeave(object sender, EventArgs e)
        {
            var ctn = (Button)sender;
            ctn = _objControlEventBL.MouseLeave(sender);
            _objControlEventBL = null;
        }

        private void ControlBackColor_MouseEnter(object sender, EventArgs e)
        {
            var ctn = (Button)sender;
            //ctn.UseVisualStyleBackColor = true;
            _controlColor = ctn.BackColor;
            ctn.BackColor = Color.LightSteelBlue;
        }
        private void ControlBackColor_MouseLeave(object sender, EventArgs e)
        {
            var ctn = (Button)sender;
            ctn.UseVisualStyleBackColor = false;
            ctn.BackColor = _controlColor;
        }

        //To send numeric text
        private void btnNum_Click(object sender, EventArgs e)
        {
            if (_ctnTxtInput != null)
            {
                var ctn = (Button)sender;
                //To send its value
                _ctnTxtInput.Text += ctn.Text;
                _textSave = _ctnTxtInput.Text;
            }
        }
  
        //To send sign to the text
        private void btnSign_Click(object sender, EventArgs e)
        {
            if (_ctnTxtInput != null)
            {
                var ctn = (Button)sender;
                //To send its value
                _ctnTxtInput.Text = ctn.Text;
                _textSave = _ctnTxtInput.Text;
            }
        }

        //To delete the text
        private void btnActDelete_Click(object sender, EventArgs e)
        {
            if (_ctnTxtInput != null)
            {
                if (_textSave!="")
                {
                    _textSave = _textSave.Remove(_textSave.Length - 1);
                    //To send its value
                    _ctnTxtInput.Text = _textSave;
                }
            }
        }


        #endregion
    }
}
