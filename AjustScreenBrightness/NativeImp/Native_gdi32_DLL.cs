using AjustScreenBrightness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static AjustScreenBrightness.AjustScreenByGdi32;

namespace AjustScreenBrightness.NativeImp
{
    public static partial class Native
    {
        public static class gdi32
        {
            [DllImport("gdi32.dll")]
            public static extern bool GetDeviceGammaRamp(IntPtr hDC, ref RAMP lpRamp);

            [DllImport("gdi32.dll")]
            public static extern bool SetDeviceGammaRamp(IntPtr hDC, ref RAMP lpRamp);
        }      
    }
}
