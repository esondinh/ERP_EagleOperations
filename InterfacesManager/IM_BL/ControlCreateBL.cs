using InterfacesManager.IM_DA;
using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesManager.IM_BL
{
    public class ControlCreateBL
    {
        ControlCreateDA objControlDA = new ControlCreateDA();

        #region (METHOD) CREATE BUTTON
        //LEE LA LISTA Y CREA BOTONES
        public MetroTile CreateButton(string name, string text, string tag)
        {
            return objControlDA.CreateButton(name, text, tag);
        }
        #endregion
    }
}
