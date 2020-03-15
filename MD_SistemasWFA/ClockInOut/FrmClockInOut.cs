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
using Utilitarian;
using Utilitarian.HelperMultimedia;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Drawing.Imaging;
using System.IO;
using MetroFramework;
using Utilitarian.HelperControl;
using BusinessEntities;

namespace MD_SistemasWFA.ClockInOut
{
    public partial class FrmClockInOut : MetroForm
    {
        #region GLOBAL VARIABLES

        private Msg msg = null;

        //false = input && true = output
        public bool _stateInputOutput = false;
        private String _assignedWork = null;
        private bool _statePhoto = false;


        private CamWebAforge _camaraWebAforge = null;

        public PERt01_usuario _pert01Usuario;
        #endregion

        public FrmClockInOut()
        {
            InitializeComponent();
        }

        #region WINDOW METHODS

        //FORM
        private void ImageDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {
                //To create the image
                Bitmap image = (Bitmap)eventArgs.Frame.Clone();
                //To rotate the webcam
                image.RotateFlip(RotateFlipType.Rotate180FlipY);
                //To show the image
                picTakingPhoto.Image = image;
            }
            catch (NotImplementedException ex)
            {
                //To show the info message
                msg = new Msg();
                msg.Ok_Info("Se ha producido un error. Vuelva a intentarlo.");
                //throw new NotImplementedException();
                //throw;
            }
        }
       
        //FRAME OF THE PHOTO
        public void VisibleFrame(bool Estado)
        {
            //To show the webcam frame
            pnlTakingPhotoLeft.Visible = Estado;
            pnlTakingPhotoBottom.Visible = Estado;
            pnlTakingPhotoRight.Visible = Estado;
            pnlTakingPhotoTop.Visible = Estado;
            //To change the enabled of the buttons
            btnCancel.Enabled = !Estado;
            btnCerrar.Enabled = !Estado;
            btnConfirm.Enabled = !Estado;
        }
        //TO CUT IMAGE
        private void CutImage(List<Rectangle> faces, Image image)
        {
            //To check if the face is in the frame 
            if (faces.Count > 0 && (30 <= faces[0].Y && faces[0].Y <= 100) && (30 <= faces[0].X && faces[0].X <= 170 ))
            {
                //To initialize the new frame
                Rectangle cloneRect = new Rectangle();

                //New frame for the photo
                var newSizeWidht = (picTakenPhoto.Width - faces[0].Size.Width) / 2;
                var newSiZeHeight = (picTakenPhoto.Height - faces[0].Size.Height) / 2;

                //New size of the new photo
                var newSizePhotoWidth = faces[0].Size.Width + (2 * newSizeWidht); //198
                var newSizePhotoHeight = faces[0].Size.Height + (2 * newSiZeHeight); //283

                //If the point is negative
                var newXVal = faces[0].X - newSizeWidht;
                var newYVal = faces[0].Y - newSiZeHeight;

                //to check the point X and width of the main image
                if (newXVal <= 0 || (newXVal + newSizePhotoWidth) > picTakingPhoto.Size.Width)
                {
                    newXVal = 0;
                }
                //To check the point Y and height of the main image
                if (newYVal <= 0 || (newYVal + newSizePhotoHeight) > picTakingPhoto.Size.Height)
                {
                    newYVal = 0;
                }

                //To draw the frame
                cloneRect = new Rectangle(
                                    newXVal,
                                    newYVal,
                                    newSizePhotoWidth,
                                    newSizePhotoHeight);

                //Bitmap myBitmap = new Bitmap("default.jpg");
                Bitmap myBitmap = new Bitmap(image);
                PixelFormat format = myBitmap.PixelFormat;
                
                // To cut image
                //myBitmap = myBitmap.Clone(faces[0], format);
                myBitmap = myBitmap.Clone(cloneRect, format);
                
                //To show the recognized face
                picTakenPhoto.Image = myBitmap;

                //To send the state of the user's photo
                _statePhoto = true;
            }
            else
            {
                //To send the state of the user's photo
                _statePhoto = false;
                //To show info message
                msg = new Msg();
                msg.Ok_Info("Es posible que su rostro no se encuentre dentro del marco, se recomienda centrar su rostro dentro del marco. Vuelva a intentarlo. ");

            }
        }
       
        //USER
        private void AssignWork()
        {
            FrmClockInOutSecond shFrm = new FrmClockInOutSecond();
            //To hide this form
            Hide();

            //To open the frmClockInOutSecond
            DialogResult res = shFrm.ShowDialog();

            //To show this form
            Show();

            //To check the option Ok
            if (res == DialogResult.OK)
            {
                //To check if the assigned work is null
                if ((shFrm._assignedWork) != null)
                {
                    //To send the user's assigned work 
                    _assignedWork = shFrm._assignedWork;
                    //tooooo test.....
                    textBox1.Text = _assignedWork;
                }
                else
                {
                    //to show info message
                    msg = new Msg();
                    msg.Ok_Info("No seleccionó su Asignación de Trabajo. Vuelva e intentarlo.");
                }
            }
        }
        private void RecognizeFace()
        {
            //To check if the there is any image
            if (true && picTakingPhoto.Image != null)
            {
                //To initialize the face recognizer
                DetectFaceEmgu detectFaceEmgu = new DetectFaceEmgu();

                //To check if exist the image by default
                if (File.Exists("default.jpg"))
                {
                    //To get the recognized face
                    Image faceRecognition = detectFaceEmgu.FaceRecognition(picTakingPhoto.Image);

                    //To check if there is any face
                    if (detectFaceEmgu.Faces != null)
                    {
                        //To check if the image is too large
                        if (detectFaceEmgu.Faces[0].Size.Width < picTakenPhoto.Size.Width && detectFaceEmgu.Faces[0].Size.Height < picTakenPhoto.Size.Height)
                        {
                            //To cut the recognize face
                            CutImage(detectFaceEmgu.Faces, picTakingPhoto.Image);
                        }
                        else
                        {
                            //To send the state of the user's photo
                            _statePhoto = false;

                            //To show info message
                            msg = new Msg();
                            msg.Ok_Info("Es posible que estés muy cerca a la cámara o su rostro no se encuentre dentro del marco, se recomienda alejarse un poco y centrar su rostro dentro del marco. Vuelva a intentarlo. ");
                            //msg.Ok_Info("Es posible que estés muy cerca a la cámara, aléguese un poco. Vuelva a intentarlo. ");
                        }
                    }
                    else
                    {
                        //To send the state of the user's photo
                        _statePhoto = false;

                        //To show info message
                        msg = new Msg();
                        msg.Ok_Info("No se pudo reconocer ningún rostro. Vuelva a intentarlo. ");
                    }
                }
            }
        }
        private bool SaveRecordImage()
        {
            try
            {
                string pathConfig = "C:\\imagenEagle\\";
                string pathNameUser = "user1";
                string foldeName = Path.Combine(pathConfig, pathNameUser);

                //To name and give the image format
                string imageName = "NombreArch " + DateTime.Now + ".jpg";
                imageName = imageName.Replace("/","-");
                imageName = imageName.Replace(":","I");
                //To check if there is any folder for the user 
                if (!Directory.Exists(foldeName))
                {
                    //To create the user folder
                    Directory.CreateDirectory(foldeName);
                }
                //To combine the folder name and image name
                string path = Path.Combine(foldeName, imageName);
                //To save the image
                picTakingPhoto.Image.Save(path, ImageFormat.Jpeg);

                return true;
            }
            catch (Exception ex)
            {
                //To show the info message
                //msg = new Msg();
                //msg.Ok_Info("Se ha producido un error. Vuelva a intentarlo. ");
                //throw;
                return false;                               
            }
        }
        private bool SaveRecordData()
        {
            try
            {
                string pathConfig = "C:\\imagenEagle\\";
                string pathNameUser = "user1";
                string foldeName = Path.Combine(pathConfig, pathNameUser);

                return true;
            }
            catch (Exception ex)
            {
                //To show the info message
                //msg = new Msg();
                //msg.Ok_Info("Se ha producido un error. Vuelva a intentarlo. ");
                //throw;
                return false;
            }
        }
        private bool SaveRecord()
        {
            bool savedImage = SaveRecordImage();
            bool saveData = SaveRecordData();
            if (savedImage == true && saveData == true)
                return true;
            else
                return false;
        }
        #endregion


        #region WINDOW EVENTS

        //FORM
        private void FormClockInOut_Load(object sender, EventArgs e)
        {
            try
            {
                //To initialize the camweb
                _camaraWebAforge = new CamWebAforge();
                //To check if there is any device
                if (_camaraWebAforge.ListDevices() != null)
                {
                    foreach (FilterInfo item in _camaraWebAforge.ListDevices())
                    {
                        cboDevices.Items.Add(item.Name);
                    }
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
        private void FormClockInOut_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                //To stop the webcam
                if (_camaraWebAforge.ImageDevices.IsRunning)
                    _camaraWebAforge.ImageDevices.Stop();
            }
            catch (Exception ex)
            {
                //To show the info message
                msg = new Msg();
                msg.Ok_Info("Se ha producido un error. Vuelva a intentarlo. ");
                //throw;
            }
        }

        //GENERALS
        private void btnTakePhoto_Click(object sender, EventArgs e)
        {
            try
            {
                if (_camaraWebAforge != null && cboDevices.SelectedIndex > -1)
                {
                    if (_camaraWebAforge.ImageDevices.IsRunning)
                    {
                        //To be not visible the frame
                        VisibleFrame(false);
                        btnTakePhoto.BackColor = Color.DeepSkyBlue;
                        btnTakePhoto.Text = "Iniciar";

                        //To stop the webcam
                        _camaraWebAforge.ImageDevices.Stop();
                        //picTakingPhoto.Image = null;
                        picTakingPhoto.Invalidate();

                        //To send the state of the user's photo
                        _statePhoto = true;

                        //FACE RECOGNITION
                        //To check if the facial recognition option is active
                        if (true)
                            RecognizeFace();                       
                    }
                    else
                    {
                        //To send the state of the user's photo
                        _statePhoto = false;

                        //To start the camweb
                        _camaraWebAforge.ImageDevices = new VideoCaptureDevice(_camaraWebAforge.Devices[cboDevices.SelectedIndex].MonikerString);
                        _camaraWebAforge.ImageDevices.NewFrame += new NewFrameEventHandler(ImageDevice_NewFrame);
                        _camaraWebAforge.ImageDevices.Start();

                        //To be visible the frame
                        VisibleFrame(true);
                        btnTakePhoto.BackColor = Color.OrangeRed;
                        btnTakePhoto.Text = "Capturar";
                    }
                }
            }
            catch (Exception ex)
            {
                //To show the info message
                msg = new Msg();
                msg.Ok_Info("Se ha producido un error. Vuelva a intentarlo. " + ex.Message);
                //throw;;
            }
        }

        //CONFIRM AND CANCEL/CLOSE
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                //To check if the work was assigned 
                if (_assignedWork == null)
                    AssignWork();
                //To check if the photo was taken
                if (_statePhoto == false)
                {
                    //To show the info message
                    msg = new Msg();
                    msg.Ok_Info("Usted aún no se a tomado la foto respectiva.");
                }
                else
                {
                    //To show the question message
                    msg = new Msg();
                    DialogResult res = msg.YesNo_Ques("Usted desea Registrarse?");
                    //To check if the option Yes
                    if (res == DialogResult.Yes)
                    {
                        //To set the user's data
                        bool stateSaveRecord = SaveRecordImage();

                        if (stateSaveRecord == true)
                        {
                            //To show the info message
                            msg.Ok_Info("Registro completo. Puede continuar.");
                            Dispose();
                        }
                        else
                        {
                            //To show the info message
                            msg.Ok_Info("Se ha producido un error. Vuelva a intentarlo. ");
                        }
                    }
                }

          
            }
            catch (Exception ex)
            {
                //To show the info message
                msg = new Msg();
                msg.Ok_Info("Se ha producido un error. Vuelva a intentarlo. ");
                //throw;
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                //To show the question message
                msg = new Msg();
                DialogResult res = msg.YesNo_Ques("Usted desea salir del Registro?");
                //To check if the option Yes
                if (res == DialogResult.Yes)
                {
                    //To stop the webcam
                    if (_camaraWebAforge.ImageDevices.IsRunning)
                        _camaraWebAforge.ImageDevices.Stop();
                    Dispose();
                }
            }
            catch (Exception ex)
            {
                //To show the info message
                msg = new Msg();
                msg.Ok_Info("Se ha producido un error. Vuelva a intentarlo.");
                //throw;
            }
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            try
            {
                //To show the question message
                msg = new Msg();
                DialogResult res = msg.YesNo_Ques("Usted desea salir del Registro?");
                //To check if the option Yes
                if (res == DialogResult.Yes)
                {
                    //To stop the webcam
                    if (_camaraWebAforge.ImageDevices.IsRunning)
                        _camaraWebAforge.ImageDevices.Stop();
                    Dispose();
                }
            }
            catch (Exception ex)
            {
                //To show the info message
                msg = new Msg();
                msg.Ok_Info("Se ha producido un error. Vuelva a intentarlo.");
                //throw;
            }
        }

        #endregion
    }
}
