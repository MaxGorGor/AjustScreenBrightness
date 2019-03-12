using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AjustScreenBrightness.NativeImp
{
    public static partial class Native
    {
        public static class user32
        {
            [DllImport("user32.dll")]
            public static extern IntPtr GetDC(IntPtr hWnd);

            [DllImport("user32.dll")]
            public static extern IntPtr MonitorFromWindow([In] IntPtr hwnd, uint dwFlags);
        }
  
    }
}
