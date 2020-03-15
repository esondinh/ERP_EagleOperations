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
    public class ControlCreateDA
    {
        #region (METHOD) CREATE BUTTON
        //CREATE BUTTONS
        public MetroTile CreateButton(string name, string text , string tag)
        {
            //Button btnNuevo = new Button();
            MetroTile btnNuevo = new MetroTile
            {
                Name = name,
                Text = text,
                AutoSize = true,
                Font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold),
                Width = 50,// panelLeftDownChannels.Width - 20;
                Height = 70,
                //STYLE METRO
                BackColor = Color.RoyalBlue,
                Cursor = Cursors.Hand,
                TextAlign = ContentAlignment.MiddleCenter,
                TileTextFontSize = MetroFramework.MetroTileTextSize.Tall,
                TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold,
                Padding = new Padding(3),
                //TAG TO EVENT
                Tag = tag
            };
            return btnNuevo;


        }
        #endregion
        
    }
}
