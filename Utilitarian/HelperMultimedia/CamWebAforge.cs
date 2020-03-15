using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AForge.Video;
using AForge.Video.DirectShow;

namespace Utilitarian.HelperMultimedia
{
    public class CamWebAforge
    {
        public FilterInfoCollection Devices = null;
        public VideoCaptureDevice ImageDevices = null;


        public FilterInfoCollection ListDevices()
        {
            Devices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (Devices!= null)
            {
                ImageDevices = new VideoCaptureDevice();
            }
            return Devices;
        }
    }
}
