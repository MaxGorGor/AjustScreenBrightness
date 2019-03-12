using AjustScreenBrightness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjustScreenBrightness.Imp
{
    public interface IAjustScreen
    {
        short GetBrightnessDefault();
        short GetContrastDefault();
        double GetGammaDefault();
        ScreenConfig GetScreenConfigDefault();

        bool SetBrightnessDefault(short val);
        bool SetContrastDefault(short val);
        bool SetGammaDefault(double val);
        bool SetScreenConfigDefault(ScreenConfig config);
    }
}
