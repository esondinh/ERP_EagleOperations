using AForge.Video;
using AForge.Video.DirectShow;
using MD_SistemasWFA.Properties;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MD_SistemasWFA.INOU
{
    public partial class FormInOu : MetroForm
    {
        public FormInOu()
        {
            InitializeComponent();

            BuscarDispositivos();
            // IMG DEFAULT
            Test();

        }

        private bool ExistenDispositivos = false;
        private FilterInfoCollection DispositivosDeVideo;
        private VideoCaptureDevice FuenteDeVideo = null;


        //EVENTS TO BUTTONS
        #region (EVENT) BTNSTART-CLOSE-CAPTURE
        private void btnStartCapture_Click(object sender, EventArgs e)
        {
            if (btnStartCapture.Text == "Start Capture")
            {
                if (ExistenDispositivos)
                {
                    FuenteDeVideo = new VideoCaptureDevice(DispositivosDeVideo[cboDevice.SelectedIndex].MonikerString);
                    FuenteDeVideo.NewFrame += new NewFrameEventHandler(video_NuevoFrame);
                    FuenteDeVideo.Start();
                    btnStartCapture.Text = "Stop Capture";
                    cboDevice.Enabled = false;
                    //gbMenu.Text = DispositivosDeVideo[cboDispositivos.SelectedIndex].Name.ToString();
                }
                else
                    MessageBox.Show("Error: No se encuentra dispositivo.");
            }
            else
            {
                if (FuenteDeVideo.IsRunning==true)
                {
                    TerminarFuenteDeVideo();
                    btnStartCapture.Text = "Start Capture";
                    cboDevice.Enabled = true;
                }
            }
        }
        #endregion
        #region (EVENT) BTNCLOSE
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult result;

            // Displays the MessageBox.
            result = MetroMessageBox.Show(this, "Usted desea cerrar? ", "Cerrando ...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, 120);
            if (result == DialogResult.Yes)
            {
                if (FuenteDeVideo!=null && FuenteDeVideo.IsRunning == true)
                {
                    TerminarFuenteDeVideo();
                    btnStartCapture.Text = "Start Capture";
                    cboDevice.Enabled = true;
                }
                //closing...
                Dispose();
            }
        }
        #endregion
        //******************************METHODS***********************************\\
        #region (METHOD AND EVENT) VIDEO NEWFRAME
        private void video_NuevoFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap Imagen = (Bitmap)eventArgs.Frame.Clone();
            pbNow.Image = Imagen; //pbFotoUser es nuestro pictureBox
        }
        #endregion
        #region (METHOD) LOAD DEVICES
        public void CargarDispositivos(FilterInfoCollection Dispositivos)
        {
            for (int i = 0; i < Dispositivos.Count; i++)
                cboDevice.Items.Add(Dispositivos[i].Name.ToString()); //cboDispositivos es nuestro combobox
            cboDevice.Text = cboDevice.Items[0].ToString();
        }
        #endregion

        #region (METHOD) SEARCH DEVICES
        public void BuscarDispositivos()
        {
            DispositivosDeVideo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (DispositivosDeVideo.Count == 0)
                ExistenDispositivos = false;
            else
            {
                ExistenDispositivos = true;
                CargarDispositivos(DispositivosDeVideo);
            }
        }
        #endregion

        #region (METHOD) END VIDEO SOURCE
        public void TerminarFuenteDeVideo()
        {
            if (!(FuenteDeVideo == null))
                if (FuenteDeVideo.IsRunning)
                {
                    FuenteDeVideo.SignalToStop();
                    FuenteDeVideo = null;
                }
        }
        #endregion

        #region (METHOD) IMG DEFAULT
        public void Test()
        {
            using (var image = (Resources.user_128_N))
                pbOld.Image = ScaleImage(image, image.Width + 70, image.Height + 70);
            //using (var newImage = ScaleImage(image, 260, 270))
            //{
            //    //newImage.Save(@"c:\test.png", ImageFormat.Png);
            //}

        }
        public static Image ScaleImage(Image image, int maxWidth, int maxHeight)
        {
            var ratioX = (double)maxWidth / image.Width;
            var ratioY = (double)maxHeight / image.Height;
            var ratio = Math.Min(ratioX, ratioY);

            var newWidth = (int)(image.Width * ratio);
            var newHeight = (int)(image.Height * ratio);

            var newImage = new Bitmap(newWidth, newHeight);

            using (var graphics = Graphics.FromImage(newImage))
                graphics.DrawImage(image, 0, 0, newWidth, newHeight);

            return newImage;
        }
        #endregion

    }
}
