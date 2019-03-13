using AjustScreenBrightness.Abstract;
using AjustScreenBrightness.Enum;
using AjustScreenBrightness.Model;
using AjustScreenBrightness.NativeImp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjustScreenBrightness
{
    /// <summary>
    /// 使用 dxva2.dll 进行操作    MSDN文档上提供的方法
    /// </summary>
    class AjustScreenByDxva2 : AjustScreenClass
    {
        public override string AjustTypeDes => "使用 dxva2.dll";

        public override bool AllowBrightness => true;

        public override bool AllowContrast => false;

        public override bool AllowGamma => false;

        PhysicalMonitor[] _screen;

        public AjustScreenByDxva2(IntPtr handle)
        {
            uint pdwNumberOfPhysicalMonitors = uint.MinValue;

            var hMonitor = Native.user32
                .MonitorFromWindow(handle, (uint)NativeConstantsEnum.MonitorDefaultToPrimary);

            var bok = Native.dxva2
                .GetNumberOfPhysicalMonitorsFromHMONITOR(hMonitor, ref pdwNumberOfPhysicalMonitors);

            _screen = new PhysicalMonitor[pdwNumberOfPhysicalMonitors];

            bok = Native.dxva2
                .GetPhysicalMonitorsFromHMONITOR(hMonitor, pdwNumberOfPhysicalMonitors
                                    , _screen);

            short current = -1, minimum = -1, maximum = -1;
            var getBrightness = Native.dxva2
               .GetMonitorBrightness(_screen[0].hPhysicalMonitor
               , ref minimum , ref current, ref maximum);

            _propRange.Brightness.Maximun = maximum;
            _propRange.Brightness.Minimun = minimum;

            Native.dxva2.GetMonitorContrast(_screen[0].hPhysicalMonitor
                , ref minimum, ref current, ref maximum);

            _propRange.Contrast.Maximun = maximum;
            _propRange.Contrast.Minimun = minimum;


        }

        public override short GetBrightnessDefault()
        {
            short current = -1, minimum = -1, maximum = -1;
            var getBrightness = Native.dxva2
                .GetMonitorBrightness(_screen[0].hPhysicalMonitor
                , ref minimum, ref current, ref maximum);

            if (!getBrightness)
            {
                var code = Native.Kernel32.GetLastError();
                uint dwFlags = Native.Kernel32.FORMAT_MESSAGE_FROM_SYSTEM | Native.Kernel32.FORMAT_MESSAGE_IGNORE_INSERTS;

                StringBuilder lpBuffer = new StringBuilder(260);    //声明StringBuilder的初始大小
                //笔记本上会出现 -- 将数据传输到 I2C 总线上的设备时出错。
                //感觉关于 DDC/CI 的问题 但是笔记本电脑没有物理按钮调整屏幕设置 目前问题还没有解决
                int count = Native.Kernel32.FormatMessage(dwFlags, IntPtr.Zero, code, 0, lpBuffer, 260, IntPtr.Zero);
            }
            return current;
        }

        public override short GetContrastDefault()
        {
            short current = -1, minimum = -1, maximum = -1;
            Native.dxva2.GetMonitorContrast(_screen[0].hPhysicalMonitor
                , ref minimum, ref current, ref maximum);
            return current;
        }

        public override double GetGammaDefault()
        {
            throw new NotImplementedException();
        }

        public override ScreenConfig GetScreenConfigDefault()
        {
            throw new NotImplementedException();
        }

        public override bool SetBrightnessDefault(short val)
        {
            var bok = Native.dxva2.SetMonitorBrightness(_screen[0].hPhysicalMonitor, val);
            return bok;
        }

        public override bool SetContrastDefault(short val)
        {
            var bok = Native.dxva2.SetMonitorContrast(_screen[0].hPhysicalMonitor
                , val);
            return bok;
        }

        public override bool SetGammaDefault(double val)
        {
            throw new NotImplementedException();
        }

        public override bool SetScreenConfigDefault(ScreenConfig config)
        {
            throw new NotImplementedException();
        }
    }
}
