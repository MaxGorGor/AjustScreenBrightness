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
        public static class Kernel32
        {
            public const int FORMAT_MESSAGE_FROM_SYSTEM = 0x1000;
            public const int FORMAT_MESSAGE_IGNORE_INSERTS = 0x200;

            [DllImport("Kernel32.dll")]
            public static extern uint GetLastError();

            [DllImport("Kernel32.dll")]
            public static extern int FormatMessage(
                uint dwFlags, IntPtr lpSource, uint dwMessageId
                , uint dwLanguageId, [Out]StringBuilder lpBuffer, uint nSize
                , IntPtr arguments);

        }
    }
}
