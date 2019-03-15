using AjustScreenBrightness.Abstract;
using AjustScreenBrightness.Model;
using AjustScreenBrightness.NativeImp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjustScreenBrightness
{
    class AjustScreenByGdi32 : AjustScreenClass
    {
        public override string AjustTypeDes => "使用Gdi32.dll";

        public override bool AllowBrightness => false;

        public override bool AllowContrast => false;

        public override bool AllowGamma => true;

        IntPtr _screenHandle = Native.user32.GetDC(IntPtr.Zero);
        IntPtr _screenHandle2 = Graphics.FromHwnd(IntPtr.Zero).GetHdc();

        public AjustScreenByGdi32()
        {
            _propRange.Gamma.Maximun = 1;
            _propRange.Gamma.Minimun = 0.5f;
            _screenHandle = _screenHandle2;
        }

        public override short GetBrightnessDefault()
        {
            throw new NotImplementedException();
        }

        public override short GetContrastDefault()
        {
            throw new NotImplementedException();
        }

        public override double GetGammaDefault()
        {
            var ramp = default(RAMP);
            var bok = Native.gdi32.GetDeviceGammaRamp(_screenHandle, ref ramp);
            double gamma = bok ? CalAllGammaVal(ramp) : double.MinValue;
            return gamma;

        }

        public override ScreenConfig GetScreenConfigDefault()
        {
            throw new NotImplementedException();
        }

        public override bool SetBrightnessDefault(short val)
        {
            throw new NotImplementedException();
        }

        public override bool SetContrastDefault(short val)
        {
            throw new NotImplementedException();
        }

        public override bool SetGammaDefault(double val)
        {
            RAMP ramp = default(RAMP);
            ramp.Red = new ushort[256];
            ramp.Green = new ushort[256];
            ramp.Blue = new ushort[256];
            
            for (int i = 1; i < 256; i++)
            {
                // gamma 必须在3和44之间
                //ramp.Red[i] = ramp.Green[i] = ramp.Blue[i] = 
                //    (ushort)(Math.Min(65535, 
                //    Math.Max(0, Math.Pow((i + 1) / 256.0, gamma * 0.1) * 65535 + 0.5)
                //    ));

                //     ramp.Red[i] = ramp.Green[i] = ramp.Blue[i] =
                //(ushort)(Math.Min(65535, Math.Max(0, Math.Pow((i + 1) / 256.0, val * 0.1) * 65535 + 0.5)));

                var tmp = (ushort)(i * 255 * val);

                ramp.Red[i] = ramp.Green[i] = ramp.Blue[i]
                    = (ushort)(Math.Max(ushort.MinValue, Math.Min(ushort.MaxValue, tmp)));
            }
            var bok = Native.gdi32.SetDeviceGammaRamp(_screenHandle, ref ramp);

            return bok;
        }

        public override bool SetScreenConfigDefault(ScreenConfig config)
        {
            throw new NotImplementedException();
        }

        private double CalAllGammaVal(RAMP ramp)
        {
            return Math.Round(((CalColorGammaVal(ramp.Blue) + CalColorGammaVal(ramp.Red) +
                CalColorGammaVal(ramp.Green)) / 3), 2);
            
        }

        private double CalColorGammaVal(ushort[] line)
        {            
            var max = line.Max();
            var min = line[0];
            var index = Array.FindIndex(line, n => n == max);
            var gamma = Math.Round((((double)(max - min) / index) / 255),2);
            return gamma;
        }
    }
}
