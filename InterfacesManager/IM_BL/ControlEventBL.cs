using InterfacesManager.IM_DA;
using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfacesManager.IM_BL
{
    public class ControlEventBL
    {
        ControlEventDA objControlEventDA = new ControlEventDA();

        #region (METHOD) MOUSE ENTER-LEAVE
        //public MetroTile MouseEnter(object sender)
        //{
        //    return objControlEventDA.MouseEnter(sender);
        //}
        public Button MouseEnter(object sender)
        {
            return objControlEventDA.Mouseenter(sender);
        }

        public Button MouseLeave(object sender)
        {
            return objControlEventDA.Mouseleave(sender);
        }
        #endregion

        #region (METHOD) GIVE CORRECT EVENT
        //RETORNA EL EVENTO SEGÚN SU TAG   
        public Control SendCorrectEvent(Control control)
        {
            return objControlEventDA.SendCorrectEvent(control);
        }
        #endregion
    }
}
