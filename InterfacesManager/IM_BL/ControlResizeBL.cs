using InterfacesManager.IM_DA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfacesManager.IM_BL
{
    public class ControlResizeBL
    {
        ControlResizeDA objControlResizeDA = new ControlResizeDA();

        #region METHOD (RESIZE)
        //METHOD (READ) ADD ALL CONTROLS 
        public void OriginalRectControls(List<Control> listOriginalControls)
        {
            objControlResizeDA.OriginalRectControls(listOriginalControls);
        }
        
        //METHOD (RETURN) RESIZE ALL CONTROLS
        public List<Control> resizeChildrenControlsAll(Form oldForm, Form NewForm)
        {
            return objControlResizeDA.resizeChildrenControls(oldForm, NewForm);
        }
        #endregion
    }
}
