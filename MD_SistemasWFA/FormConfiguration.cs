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
    public partial class FormConfiguration : MetroFramework.Forms.MetroForm
    {
        private List<Point> ListScreenResolutions = new List<Point>();
        //THEME FORMS
        public MetroFramework.Components.MetroStyleManager MetroStryleManagerForm;
        public FormConfiguration()
        {
            InitializeComponent();
            //THEME AND STYLE
            MetroStryleManagerForm = new MetroFramework.Components.MetroStyleManager();
            StyleManager = metroStyleManager;
            
            //VALUE OF SCREEN RESOLUTIONS
            ScreenResolutions();
        }

        # region SCREEN RESOLUTIONS
        public void ScreenResolutions()
        {
            List<Point> ListScreenResolutions = new List<Point>();
            ListScreenResolutions.Add(new Point(800, 600));
            ListScreenResolutions.Add(new Point(1024, 768));
            ListScreenResolutions.Add(new Point(1280, 720));
            ListScreenResolutions.Add(new Point(1280, 768));
            ListScreenResolutions.Add(new Point(1360, 768));
            ListScreenResolutions.Add(new Point(1366, 768));

            var width = Screen.PrimaryScreen.Bounds.Height;
            var height = Screen.PrimaryScreen.Bounds.Width;
            metroTextBox1.Text = width + "," + height;
            for (int i = 0; i < ListScreenResolutions.Count; i++)
            {
                if (ListScreenResolutions[i].X <= height && ListScreenResolutions[i].Y <= width)
                {
                    cbo_ScreenResolutions.Items.Add(ListScreenResolutions[i].X.ToString() + " - " + ListScreenResolutions[i].Y.ToString());
                    this.ListScreenResolutions.Add((new Point(ListScreenResolutions[i].X , ListScreenResolutions[i].Y)));
                }
            }
        }


        #endregion

        private void cbo_Themes_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbo_Themes.SelectedIndex)
            {
                case 0:
                    metroStyleManager.Theme = MetroFramework.MetroThemeStyle.Dark;
                    //THEME PUBLIC
                    MetroStryleManagerForm.Theme = metroStyleManager.Theme;
                    break;
                case 1:
                    metroStyleManager.Theme = MetroFramework.MetroThemeStyle.Light;
                    //THEME PUBLIC
                    MetroStryleManagerForm.Theme = metroStyleManager.Theme;
                    break;
            }
        }

        private void cbo_Color_SelectedIndexChanged(object sender, EventArgs e)
        {
            metroStyleManager.Style = (MetroFramework.MetroColorStyle)Convert.ToInt32(cbo_Color.SelectedIndex);
            //STYLE PUUBLIC
            MetroStryleManagerForm.Style = metroStyleManager.Style;
        }

        private void ConfigurationsThemes_Load(object sender, EventArgs e)
        {
            cbo_Color.SelectedIndex = 0;
            cbo_Themes.SelectedIndex = 0;
        }

        private void cbo_ScreenResolutions_SelectedIndexChanged(object sender, EventArgs e)
        {
            var valItemResolutions = cbo_ScreenResolutions.SelectedIndex;
            this.Height = ListScreenResolutions[valItemResolutions].Y;
            this.Width = ListScreenResolutions[valItemResolutions].X;
            //CENTER FORM
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                          (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
        }

        //SEND VALUE THEME
        private void metroTile2_Click(object sender, EventArgs e)
        {
        }
    }
}
