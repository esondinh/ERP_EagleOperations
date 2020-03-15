using BusinessEntities;
using BusinessLogic.Master;
using BusinessLogic.Person;
using InterfacesManager.IM_BL;
using MD_SistemasWFA.ClockInOut;
using MD_SistemasWFA.FormReusable;
using MD_SistemasWFA.INOU;
using MD_SistemasWFA.Master;
using MetroFramework;
using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Utilitarian;
using Utilitarian.HelperControl;

namespace MD_SistemasWFA
{
    public partial class FormMain : MetroFramework.Forms.MetroForm
    {
        #region GLOBAL VARIABLES

        private Msg msg = null;

        private bool _stateClockInOut = false;
        private string _codUser = "";
        public string channels = "";

        private FrmPnlNumeric _frmPnlNumeric;

        private PERt01_usuario _pert01Usuario;
        private UserBL _objUserBL;
        #endregion


        //Ihttp://icon-icons.com/es/icono
        //(OBJ) TO EVENS
        ControlEventBL objControlEventBL;

        // (OBJ) TO RESIZE
        ControlResizeBL objControlResizeBL;

        // (OBJ) OLD FORM
        Form OldForm = new Form();
        // (OBJ LIST) ORIGINAL SIZE CONTROLS
        List<Rectangle> listRectangleOriginalSizeControls;
        //(OBJ LIST) ORIGINAL LIST CONTROLS 
        List<Control> listOriginalControls;
        // (OBJ LIST) LIST BTN CREATING 
        List<Control> listBtnCretae;
        
        

        public FormMain()
        {
            InitializeComponent();

            //METHOD (ENABLED) ENABLED TIME        
            timer.Enabled = true;
            
            //STYLE MANAGER
            StyleManager = metroStyleManager;

            //METHOD (CREATE) CREATE CHANNELS
            CreateChannels(7);

            //METHOD (SAVE) THIS SIZE
            OldForm.Size = Size;

            //METHOD (SEND) READ ORIGINAL (RECTANGLECONTROLS AND CONTROLS)
            ReadOriginalRectControls();
        }

        #region WINDOW METHODS

        //TO LOAD PNLNUMERIC
        private void LoadPnlNumeric()
        {
            //To clear the control
            pnlCenterDownNumbers.Controls.Clear();
            _frmPnlNumeric = new FrmPnlNumeric();

            //To find control
            _frmPnlNumeric.FindTextControl(txtCodUser);

            //To call the control and  set location
            Control panelFind = (_frmPnlNumeric.Controls.Find("pnlNumbers", true)[0]);
            panelFind.Location = new Point(2, 2);
     
            //To add the control to the panel
            pnlCenterDownNumbers.Controls.Add(panelFind);
        }

        //TO REGISTER THE USER
        public void InputUser()
        {
            //To find to the user
            _objUserBL = new UserBL();
            var userList = _objUserBL.GetAllOrASingleUser(cod_usuario: _codUser);

            //To check if the user exists
            if (userList.Count > 0)
            {
                _pert01Usuario = userList[0];
                lblNameUser.Text = _pert01Usuario.txt_usuario;
                txtCodUser.Text = "";

                FrmClockInOut frmClockInOut = new FrmClockInOut
                {
                    _pert01Usuario = _pert01Usuario
                };
                frmClockInOut.Show();
            }
            else
            {
                //To show info message
                msg = new Msg();
                msg.Ok_Info("Su código es incorrecto. Vuelva a intentarlo. ");
            }
        }
        public void Output()
        {
            if (_pert01Usuario.txt_clave == txtCodUser.Text)
            {
                FrmClockInOut frmClockInOut = new FrmClockInOut
                {
                    _stateInputOutput = true,
                    _pert01Usuario = _pert01Usuario
                };
                frmClockInOut.Show();
            }
            else
            {
                //To show info message
                msg = new Msg();
                msg.Ok_Info("Su clave es incorrecta. Vuelva a intentarlo. ");
                //throw;
            }
        }

        #endregion

        #region WINDOW EVENTS

        //LOAD FORM
        private void FormMain_Load(object sender, EventArgs e)
        {
            try
            {
                //To load numeric panel 
                LoadPnlNumeric();
            }
            catch (Exception)
            {
                //To show info message
                msg = new Msg();
                msg.Ok_Info("Se ha producido un error. Vuelva a intentarlo.");
                //throw;
            }
        }

        //SHOW FORM
        private void FormMain_Shown(object sender, EventArgs e)
        {
            
        }


        private void btnActInputOutput_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodUser.Text!="")
                {
                    if (_pert01Usuario == null)
                    {
                        //To equalize the coduser
                        _codUser = txtCodUser.Text;

                        //For when the user doesn't exists
                        InputUser();

                        //To clear
                        txtCodUser.Text = "";
                    }
                    else
                    {
                        Output();

                        //To clear
                        txtCodUser.Text = "";
                    }
                }
                else
                {
                    //To show info message
                    msg = new Msg();
                    msg.Ok_Info("Ingrese su código.");
                    //throw;
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

        //ACTION YES
        private void btnYes_Click(object sender, EventArgs e)
        {
            if (_codUser!="")
            {
                if (txtCodUser.Text != "")
                {
                    if (_codUser == txtCodUser.Text)
                    {
                        FormTables frm = new FormTables();
                        frm.MetroStryleManagerForm.Theme = metroStyleManager.Theme;
                        frm.MetroStryleManagerForm.Style = metroStyleManager.Style;
                        frm.Show();

                        //To clear
                        txtCodUser.Text = "";
                    }
                    else
                    {
                        //To show info message
                        msg = new Msg();
                        msg.Ok_Info("El clave ingresada no es correcta.");

                        //To clear
                        txtCodUser.Text = "";
                        ///MetroMessageBox.Show(this, "El # de ID ingresado no es correcto ", "Error al Ingresar", MessageBoxButtons.OK, MessageBoxIcon.Error, 120);
                    }
                }
                else
                {
                    //To show info message
                    msg = new Msg();
                    msg.Ok_Info("Ingrese su clave.");
                }
            }
            else
            {
                //To show info message
                msg = new Msg();
                msg.Ok_Info("Usted debe hacer Clockin. Vuelva a intentarlo. ");
            }
            
        }

        #endregion

        //EVENTS TO BUTTONS
        #region (EVENT) TXT PASSWORDCLEAR

        private void txtPassword_ClearClicked()
        {
            _codUser = "";
        }
        #endregion
        #region (EVENT) BTN YES
        
        #endregion
        #region (EVENT) BTN NOT 
        private void btnNot_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
        #region (EVENTS) BTN INPUTOUPUT
        private void btn_EntradaSalida_Click(object sender, EventArgs e)
        {

        }
      
        #endregion

        //******************************METHODS***********************************\\
        #region (METHOD) TIME
        private void timer_Tick(object sender, EventArgs e)
        {
            //MOSTRAR LA FECHA
            string a = DateTime.Today.ToString("D");
            //string b = DateTime.Now.ToString("HH:mm:ss.f");
            string b = DateTime.Now.ToString("HH:mm:ss");
            lblDate.Text = a + " - " + b;
        }
        #endregion

        #region (METHOD) CONTROL MOUSE ENTER AND LEAVE
        //MOUSE ENTER AND LEAVE (METHO GENERAL)
        private void Control_MouseEnter(object sender, EventArgs e)
        {
            //objControlEventBL = new ControlEventBL();
            //var ctn = (MetroFramework.Controls.MetroTile)sender;
            //ctn = objControlEventBL.MouseEnter(sender);
        }
        private void Control_MouseLeave(object sender, EventArgs e)
        {
           // var ctn = (MetroFramework.Controls.MetroTile)sender;
            //ctn = objControlEventBL.MouseLeave(sender);
            //objControlEventBL = null;
        }
        #endregion

        #region (METHOD) BTN CUSTOMER BACK COLOR_GENERAL (MOUSE ENTER AND LEAVE)
        private void btnCustomerBackColor_MouseEnter(object sender, EventArgs e)
        {
            var ctn = (MetroFramework.Controls.MetroTile)sender;
            ctn.UseCustomBackColor = true;
        }

        private void btnCustomerBackColor_MouseLeave(object sender, EventArgs e)
        {
            var ctn = (MetroFramework.Controls.MetroTile)sender;
            ctn.UseCustomBackColor = false;
        }
        #endregion


        #region (METHOD) RESIZE
        private void FormMain_Resize(object sender, EventArgs e)
        {
            resizeChildrenControls();
        }
        private void resizeChildrenControls()
        {
            Form NewForm = this;
            //METHOD(RETURN) NEW SIZE CONTROLS           
            if (listOriginalControls != null )
            {
                listOriginalControls = objControlResizeBL.resizeChildrenControlsAll(OldForm, NewForm);
            }
        }
        private void ReadOriginalRectControls()
        {
            //CRETAE --> DELETE (OTHER METHOD)
            listOriginalControls = new List<Control>();
            objControlResizeBL = new ControlResizeBL();
            listRectangleOriginalSizeControls = new List<Rectangle>();

            //READ CONTROLS
            Form newForm = this;
            for (int i = 0; i < newForm.Controls.Count; i++)
            {
                listOriginalControls.Add(newForm.Controls[i]);
            }
            //ERROR:
            listOriginalControls.Add(lblDate2);
            listOriginalControls.Add(txtPassword2);
            listOriginalControls.Add(txtCodUser);

            //ERROR BTNS
            //listOriginalControls.Add(btn00);
            //listOriginalControls.Add(btnDot);
            //listOriginalControls.Add(btnDelete);
            //listOriginalControls.Add(btn01);
            //listOriginalControls.Add(btn02);
            //listOriginalControls.Add(btn03);
            //listOriginalControls.Add(btn04);
            //listOriginalControls.Add(btn05);
            //listOriginalControls.Add(btn06);
            //listOriginalControls.Add(btn07);
            //listOriginalControls.Add(btn08);
            //listOriginalControls.Add(btn09);

            //ERROR BTN SI NO E/S
            listOriginalControls.Add(btnYes);
            listOriginalControls.Add(btnNot);
            listOriginalControls.Add(btnInputOuput);
            //ERROR BTN CHANNELS
            for (int z = 0; z < listBtnCretae.Count; z++)
            {
                listOriginalControls.Add(listBtnCretae[z]);
            }
            //DELETE (OTHER METHOD)
            listBtnCretae = null;

            //ADD THE OBJCONTROLRESIZE
            objControlResizeBL.OriginalRectControls(listOriginalControls);
            //CONTROLS TO LIST<RECTANGLE> CONTROLS 

            for (int j = 0; j < listOriginalControls.Count; j++)
            {
                Rectangle RectangleControls = new Rectangle(listOriginalControls[j].Location.X, listOriginalControls[j].Location.Y, listOriginalControls[j].Width, listOriginalControls[j].Height);
                listRectangleOriginalSizeControls.Add(RectangleControls);
            }
        }
        #endregion

        #region (METHOD) CREATE CHANNELS
        public void CreateChannels(int x)
        {
            panelLeftDownChannels.Controls.Clear();
            panelLeftDownChannels.AutoScroll = false;
            panelLeftDownChannels.HorizontalScroll.Enabled = false;
            panelLeftDownChannels.HorizontalScroll.Visible = false;
            panelLeftDownChannels.HorizontalScroll.Maximum = 0;
            panelLeftDownChannels.AutoScroll = true;

            CanalBL objCanalBL = new CanalBL();
            var listMSTt04_canal_vtaBL = objCanalBL.ListCanal();
            //NEW
            ControlCreateBL objControlCreateBL = new ControlCreateBL();

            //CREATE AND DELETE
            objControlEventBL = new ControlEventBL();
            listBtnCretae = new List<Control>();

            for (int i = 0; i < listMSTt04_canal_vtaBL.Count; i++)
            {
                //SEND VALUE CHANNELS BY DEFAULT
                if (i == 0)
                    channels = listMSTt04_canal_vtaBL[i].txt_desc;

                //Button btnNuevo = new Button();
                MetroTile btnNuevo = new MetroTile();
                btnNuevo = objControlCreateBL.CreateButton(
                                                        listMSTt04_canal_vtaBL[i].txt_abrv,
                                                        listMSTt04_canal_vtaBL[i].txt_desc,
                                                        listMSTt04_canal_vtaBL[i].cod_can_vta
                                                        );
                //ASSIGN EVENT             
               // btnNuevo = (MetroTile)objControlEventBL.SendCorrectEvent(btnNuevo);
                btnNuevo.Click += new EventHandler(Control_SetChannels); 
                btnNuevo.MouseEnter += new EventHandler(btnCustomerBackColor_MouseEnter);
                btnNuevo.MouseLeave += new EventHandler(btnCustomerBackColor_MouseLeave);
                panelLeftDownChannels.Controls.Add(btnNuevo);

                //STYLE CUSTOM 
                btnNuevo.Width = 210;
                btnNuevo.Height = 135;

                listBtnCretae.Add(btnNuevo);
            }
            objControlEventBL = null;
        }
        #endregion


        #region (EVENTS) ASSIGN EVENTS 
        private void Control_SetChannels(object sender , EventArgs e) {
            channels = ((MetroTile)sender).Name+"";
            MessageBox.Show(channels+"");
        }
        #endregion








        /////
        private void GetAppConnectionData()
        {
            var dataSource = Connection.GetSettingValue(Connection.dataSource);
            var dbName = Connection.GetSettingValue(Connection.dbName);
            var dbUser = Connection.GetSettingValue(Connection.dbUser);
            var dbPassword = Connection.GetSettingValue(Connection.dbPassword);
            //probando
            btnGuardar_Click();
        }
        private void btnConnect_Click()
        {
            string _dataSource = @"LAPTOP-RK915UBP\SQLEXPRESSAA";
            string _dbUser = "saAA";
            string _dbPassword = "12345";

            string cnnString = Connection.AssembleConnectionString(_dataSource, _dbUser, _dbPassword);

            try
            {
                Conectar(cnnString);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Ocurrió una excepción cuando se intentó conectar: " + exc.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void Conectar(string cnnString)
        {
            using (new CursorWait())
            {
                if (Connection.ConnectionTest(cnnString))
                {
                    var databases = new Connection().GetDatabases(cnnString);
                    //cboDatabase.DataSource = databases;
                    MessageBox.Show("" + databases);
                }
                else
                {
                    MessageBox.Show("La autenticación de SQL es incorrecta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #region Variables
        string dataSource = "", dbName = "", dbUser = "", dbPassword = "";

        #endregion

        

        private void btnGuardar_Click()
        {
            bool isSuccessfull = true;
            if (isSuccessfull)
            {
                // si actualizo
                string _dataSource = @"LAPTOP - RK915UBP\SQLEXPRESS";
                string _dbUser = "sa";
                string _dbPassword = "12345";
                string _dbName = "Eagle";

                if (_dataSource == dataSource)
                    _dataSource = null;

                if (_dbUser == dbUser)
                    _dbUser = null;

                if (_dbPassword == dbPassword)
                    _dbPassword = null;

                if (_dbName == dbName)
                    _dbName = null;

                bool success = new Connection().EditConnectionString(_dataSource, _dbName, _dbUser, _dbPassword);

                if (success)
                {
                    //isRight = true;
                    MessageBox.Show("Los cambios se han modificado exitosamente. Cierre y vuelva abrir el programa para que los cambios surgan efecto.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo modificar los datos de conexión.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else
                MessageBox.Show("Tiene que pasar el test de conexión.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        //nuevo probando
        



        //FormInOuOpenCV frm = new FormInOuOpenCV();
        //frm.Show();
        //FormConfiguration sh_frm = new FormConfiguration();
        //DialogResult res = sh_frm.ShowDialog();
        //if (res == DialogResult.OK)
        //{
        //    metroStyleManager.Theme = sh_frm.MetroStryleManagerForm.Theme;
        //    metroStyleManager.Style = sh_frm.MetroStryleManagerForm.Style;
        //    this.Width = sh_frm.Width;
        //    this.Height = sh_frm.Height;
        //    this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
        //              (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
        //}
    }




}
