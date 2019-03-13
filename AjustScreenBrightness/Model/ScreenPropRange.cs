using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjustScreenBrightness.Model
{
    public class ScreenPropRange
    {
        public Range Brightness = new Range();
        public Range Contrast = new Range();
        public Range Gamma = new Range();

        public class Range
        {
            public float Maximun;
            public float Minimun; 
        }
    }
}
