using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfacesManager.IM_DA
{
    public class ControlEventDA
    {
        #region (METHOD) EVENT MOUSE ENTER-LEAVE
        //PUCLIC EVENT IMG
        Image ControlTimeImage;
        Color ControlColor;

        public Button Mouseenter(object sender)
        {
            var control = (Button)sender;
            //control.usecustombackcolor = true;
            ControlColor = control.BackColor;
            control.BackColor = Color.LightSteelBlue;
            if (control.Tag!=null)
            {
                //guardando img
                ControlTimeImage = control.Image;
                //1 forma desde resources
                string nameimage = control.Tag + "";
                nameimage = nameimage.Replace("N", "S");
                control.Image = GetImageByName(nameimage);
            }
            return control;
        }
        public Button Mouseleave(object sender)
        {
            var control = (Button)sender;
            //control.usecustombackcolor = false;
            control.BackColor = ControlColor;
            if (control.Tag != null)
            {
                control.Image = ControlTimeImage;
            }
            return control;
        }

        //public MetroTile MouseEnter(object sender)
        //{
        //    var control = (MetroTile)sender;
        //    control.UseCustomBackColor = true;
        //    if (control.UseTileImage == true)
        //    {
        //        //GUARDANDO IMG
        //        timeImage = control.TileImage;
        //        //1 FORMA DESDE RESOURCES
        //        string nameImage = control.Tag + "";
        //        nameImage = nameImage.Replace("N", "S");
        //        /* color red = 14 ,91 , 55
        //         * 2 FORMA DESDE UNA CARPETA EXTERNA
        //         * //GLOBAL NAME IMG
        //         * string imgName = "";
        //         * string path = @"C:\Resource\";
        //         * nameImage = control.Tag + ""path;
        //         * Image image1 = Image.FromFile( + imgName);
        //         * Image image1 = Image.FromFile("c:\\img1.png");
        //         */
        //        control.TileImage = GetImageByName(nameImage);
        //    }
        //    return control;
        //}
        //public MetroTile MouseLeave(object sender)
        //{
        //    var control = (MetroTile)sender;
        //    control.UseCustomBackColor = false;
        //    if (control.UseTileImage == true)
        //    {
        //        //1 FORMA DESDE RESOURCES YA NO ES NECESARIO
        //        //string nameImage = control.Tag + "";               
        //        //nameImage = nameImage.Replace("S", "N");
        //        /*2 FORMA DESDE UNA CARPETA EXTERNA
        //         * nameImage = control.Tag + ""path;
        //         * Image image1 = Image.FromFile( + imgName);
        //         */
        //        //control.TileImage = GetImageByName(nameImage);
        //        control.TileImage = timeImage;
        //    }
        //    return control;
        //}
        #endregion
        //PERMITE CAMBIAR LA IMG DESDE LOS RECURSOS
        public Bitmap GetImageByName(string imageName)
        {
            System.Reflection.Assembly asm = System.Reflection.Assembly.GetExecutingAssembly();
            string resourceName = asm.GetName().Name + ".Properties.Resources";
            var rm = new System.Resources.ResourceManager(resourceName, asm);
            //2
            /*
             *btn_EntradaSalida.TileImage = (Image)Resources.ResourceManager.GetObject(a);
             */
            return (Bitmap)rm.GetObject(imageName);
        }

        #region (METHOD) EVENT CLICK
        private void ControlEvent_Click_ListButtons(object sender, EventArgs e)
        {
            MessageBox.Show("SC");
        }
        //prueba 
        private void ControlEvent_Click_ListButtonsPrueba(object sender, EventArgs e)
        {
            MessageBox.Show("Prueba");
        }
        //(EVENT) UNO //CHANGE THE CHANNELS
        private void ControlEventChangeChannels_Click(object sender, EventArgs e)
        {
            string tag = ((MetroTile)sender).Tag+"";
            //FormMain ControlSearch = new FormMain();
            //Control Controles = ControlSearch.Controls.Find("panelLeftDownChannels",true)[0];
            MessageBox.Show(tag);
        }
        #endregion


        #region (METHOD) GIVE EVENT TRUE
        public Control SendCorrectEvent(Control control)
        {
            switch (control.Tag+"") {
                case "SC":
                    control.Click += new EventHandler(ControlEventChangeChannels_Click);
                    break;
                case "NO":
                    control.Click += new EventHandler(ControlEventChangeChannels_Click);
                    break;
            }
            return control;
        }
        #endregion
    }
}
