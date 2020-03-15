using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfacesManager.IM_DA
{
    public class ControlResizeDA
    {
        //ORIGINAL LIST CONTROLS 
        List<Control> listOriginalControls = new List<Control>();
        //ORIGINAL SIZE CONTROLS
        List<Rectangle> listRectangleOriginalSizeControls = new List<Rectangle>();

        #region (METHOD) RESIZE FORM
        //ONE METHOD TO CHANGE SIZE (SAVE THE CONTROLS ORIGINALS)
        public void OriginalRectControls(List<Control> listOriginalControls)
        {
            //READ CONTROLS
            this.listOriginalControls = listOriginalControls;

            //CONTROLS TO LIST<RECTANGLE> CONTROLS 
            for (int j = 0; j < listOriginalControls.Count; j++)
            {
                Rectangle RectangleControls = new Rectangle(listOriginalControls[j].Location.X, listOriginalControls[j].Location.Y, listOriginalControls[j].Width, listOriginalControls[j].Height);
                listRectangleOriginalSizeControls.Add(RectangleControls);
            }
        }

        //SECOND METHOD TO CHANGE SIZE (START SIZE)
        public List<Control> resizeChildrenControls(Form oldForm, Form NewForm)
        {
            List<Control> ListReturn = new List<Control>();
            //READ CONTROLS AND REDTANGLESCONTROLS 
            if (listOriginalControls.Count > 0)
            {
                for (int i = 0; i < listOriginalControls.Count; i++)
                {
                    ListReturn.Add(resizeControl(oldForm, NewForm, listRectangleOriginalSizeControls[i], listOriginalControls[i]));
                }
            }
            return ListReturn;
        }
        //THIRD METHOD OPERATIVE
        public Control resizeControl(Form oldForm, Form NewForm, Rectangle originalControlRect, Control control)
        {
            float xRatio = (float)(NewForm.Width) / (oldForm.Width);
            float yRatio = (float)(NewForm.Height) / (oldForm.Height);

            int newX = (int)(originalControlRect.X * xRatio);
            int newY = (int)(originalControlRect.Y * yRatio);
            int newWith = (int)(originalControlRect.Width * xRatio);
            int newHeight = (int)(originalControlRect.Height * yRatio);

            control.Location = new Point(newX, newY);
            control.Size = new Size(newWith, newHeight);
            return control;
        }
        #endregion
    }
}
