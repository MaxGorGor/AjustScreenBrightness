using AjustScreenBrightness.Enum;
using AjustScreenBrightness.Model;
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
        public static class dxva2
        {
            [DllImport("dxva2.dll")]
            public static extern bool GetNumberOfPhysicalMonitorsFromHMONITOR(IntPtr hMonitor, ref uint pdwNumberOfPhysicalMonitors);

            [DllImport("dxva2.dll")]
            public static extern bool GetPhysicalMonitorsFromHMONITOR(IntPtr hMonitor,
                uint dwPhysicalMonitorArraySize, [Out] PhysicalMonitor[] pPhysicalMonitorArray);

            [DllImport("dxva2.dll")]
            public static extern bool DestroyPhysicalMonitors(uint dwPhysicalMonitorArraySize,
                [Out] PhysicalMonitor[] pPhysicalMonitorArray);

            [DllImport("dxva2.dll")]
            public static extern bool GetMonitorTechnologyType(IntPtr hMonitor,
                ref McDisplayTechnologyType pdtyDisplayTechnologyType);

            [DllImport("dxva2.dll")]
            public static extern bool GetMonitorCapabilities(IntPtr hMonitor, ref uint pdwMonitorCapabilities,
                ref uint pdwSupportedColorTemperatures);

            [DllImport("dxva2.dll")]
            public static extern bool SetMonitorBrightness(IntPtr hMonitor, short brightness);

            [DllImport("dxva2.dll")]
            public static extern bool SetMonitorContrast(IntPtr hMonitor, short contrast);

            [DllImport("dxva2.dll")]
            public static extern bool GetMonitorBrightness(IntPtr hMonitor, ref short pdwMinimumBrightness,
                ref short pdwCurrentBrightness, ref short pdwMaximumBrightness);

            [DllImport("dxva2.dll")]
            public static extern bool GetMonitorContrast(IntPtr hMonitor, ref short pwdMinimumContrast,
                ref short pwdCurrentContrast, ref short pwdMaximumContrast);
        }
    }
   
}