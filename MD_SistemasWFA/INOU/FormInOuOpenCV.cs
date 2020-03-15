using MetroFramework.Forms;
using System;
using Emgu.CV;
using Emgu.CV.Structure;
using MetroFramework;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using Emgu.CV.UI;
using Emgu.CV.Cuda;
using Emgu.CV.CvEnum;
using System.IO;
using System.Threading;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

namespace MD_SistemasWFA.INOU
{
    public partial class FormInOuOpenCV : MetroForm
    {
        #region VARIABLES
        private VideoCapture _capture = null;
        private Mat _frame;
        private bool _captureInProgress;

        private bool _StarCapture = false;
        #endregion


        public FormInOuOpenCV()
        {
            InitializeComponent();
            CvInvoke.UseOpenCL = false;
            _frame = new Mat();
            try
            {
                _capture = new VideoCapture();
                _capture.ImageGrabbed += ProcessFrame;
            }
            catch (NullReferenceException excpt)
            {
                MessageBox.Show(excpt.Message);
            }
            //_frame = new Mat();

        }
        private void ProcessFrame(object sender, EventArgs e)
        {
            if (_capture != null && _capture.Ptr != IntPtr.Zero)
            {
                _capture.Retrieve(_frame, 0);
                pbCapture.Image = _frame;
            }
        }

        #region (EVENT)
        private void btnStartCapture_Click(object sender, EventArgs e)
        {
            try
            {
                if (_capture != null)
                {
                    if (_captureInProgress)
                    {  //stop the capture
                        btnStartCapture.Text = "Start Capture";
                        _capture.Pause();

                        Run2();
                    }
                    else
                    {
                        //start the capture
                        btnStartCapture.Text = "Stop Capture";
                        _capture.Start();
                        

                        _StarCapture = true;

                        pictureBox1.BackColor = Color.White;
                        // Connect the Paint event of the PictureBox to the event handler method.
                        pictureBox1.Paint += new PaintEventHandler(this.FormInOuOpenCV_Paint);

                        // Add the PictureBox control to the Form.
                        this.Controls.Add(pictureBox1);
                    }
                    _captureInProgress = !_captureInProgress;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "");
                //stop the capture
                btnStartCapture.Text = "Start Capture";
                _capture.Pause();
                //throw;
            }
        }
        #endregion

   

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (_capture != null)
                _capture.Dispose();
        }

        //horizontal
        private void FlipHorizontalButtonClick(object sender, EventArgs e)
        {
            if (_capture != null) _capture.FlipHorizontal = !_capture.FlipHorizontal;
        }
     
        void Run2()
        {
            IImage image;
            image = pbCapture.Image;

            long detectionTime;
            List<Rectangle> faces = new List<Rectangle>();
            List<Rectangle> eyes = new List<Rectangle>();

            DetectFace.Detect(
              image, "haarcascade_frontalface_default.xml", "haarcascade_eye.xml",
              faces, eyes,
              out detectionTime);

            foreach (Rectangle face in faces)
                CvInvoke.Rectangle(image, face, new Bgr(Color.Red).MCvScalar, 2);
            foreach (Rectangle eye in eyes)
                CvInvoke.Rectangle(image, eye, new Bgr(Color.Blue).MCvScalar, 2);

            //display the image 
            InputArray iaImage = image.GetInputArray();
            //ME CODE
            //pbShow.Image = pbCapture.Image.Bitmap;
            txtDescription.Text = String.Format(
               "Completed face and eye detection using {0} in {1} milliseconds",
               (iaImage.Kind == InputArray.Type.CudaGpuMat && CudaInvoke.HasCuda) ? "CUDA" :
               (iaImage.IsUMat && CvInvoke.UseOpenCL) ? "OpenCL"
               : "CPU",
               detectionTime);
            CutImage(faces, image);
        }



        private void CutImage(List<Rectangle> faces , IImage image)
        {
            if(faces.Count > 0 )
            {
                //edit
                // Rectangle cloneRect = new Rectangle(faces[0].Location.X, faces[0].Location.Y, faces[0].Bottom, faces[0].Height);
                
                Rectangle cloneRect = faces[0];
                //var valTest = (pbShow.Height - faces[0].Height)/2;
                cloneRect = new Rectangle(faces[0].X  , faces[0].Y, pbShow.Width, pbShow.Height);
                Bitmap myBitmap = pbCapture.Image.Bitmap;

                //pbShow.DrawToBitmap(myBitmap, faces[0]);
                //pbCapture.DrawToBitmap(myBitmap, faces[0]);
               
                PixelFormat format = myBitmap.PixelFormat;

                myBitmap = myBitmap.Clone(cloneRect,format);

                textBox1.Text += faces[0].Bottom + "bottom" + faces[0].Height + "Height" +
                    faces[0].Location.X + "X" + faces[0].Location.Y + "Y";

                //myBitmap = myBitmap.Clone(faces[0], format);
                pbShow.Image = myBitmap;

                if(faces[0].Height>=160 && faces[0].Height <= 210)
                {
                    MessageBox.Show("buena foto");
                }
            }               
        }


        //private void Ruc()
        //{
        //    try
        //    {
        //        _capture = new VideoCapture();
        //    }
        //    catch (Exception ex)
        //    {
        //        MetroMessageBox.Show(this, "Mensaje :" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, 120);
        //        return;
        //    }
        //    Application.Idle += ProcessFrame;
        //}

        void Run()
        {
            IImage image;

            //Read the files as an 8-bit Bgr image  

            image = new UMat("img1.jpg", ImreadModes.Color); //UMat version
                                                             //image = new Mat("lena.jpg", ImreadModes.Color); //CPU version
            FileInfo file = new FileInfo("haarcascade_frontalface_default.xml");

            long detectionTime;
            List<Rectangle> faces = new List<Rectangle>();
            List<Rectangle> eyes = new List<Rectangle>();

            DetectFace.Detect(
              image, "haarcascade_frontalface_default.xml", "haarcascade_eye.xml",
              faces, eyes,
              out detectionTime);

            foreach (Rectangle face in faces)
                CvInvoke.Rectangle(image, face, new Bgr(Color.Red).MCvScalar, 2);
            foreach (Rectangle eye in eyes)
                CvInvoke.Rectangle(image, eye, new Bgr(Color.Blue).MCvScalar, 2);

            //display the image 
            InputArray iaImage = image.GetInputArray();
            //ME CODE
            pbCapture.Image = image;
            txtDescription.Text = String.Format(
               "Completed face and eye detection using {0} in {1} milliseconds",
               (iaImage.Kind == InputArray.Type.CudaGpuMat && CudaInvoke.HasCuda) ? "CUDA" :
               (iaImage.IsUMat && CvInvoke.UseOpenCL) ? "OpenCL"
               : "CPU",
               detectionTime);
            //ImageViewer.Show(image, String.Format(
            //   "Completed face and eye detection using {0} in {1} milliseconds",
            //   (iaImage.Kind == InputArray.Type.CudaGpuMat && CudaInvoke.HasCuda) ? "CUDA" :
            //   (iaImage.IsUMat && CvInvoke.UseOpenCL) ? "OpenCL"
            //   : "CPU",
            //   detectionTime));

        }

        private void FormInOuOpenCV_Load(object sender, EventArgs e)
        {
            
        }

        private void FormInOuOpenCV_Paint(object sender, PaintEventArgs e)
        {

            Bitmap bitmap = (Bitmap)pictureBox1.Image;
            e.Graphics.DrawImage(bitmap, 0, 0, bitmap.Width, bitmap.Height);


            Pen semiTransPen = new Pen(Color.FromArgb(128, 0, 0, 255), 15);
            e.Graphics.DrawLine(semiTransPen, 0, 60, 100, 60);
        }
    }
}
