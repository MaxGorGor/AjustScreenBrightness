using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjustScreenBrightness.Model
{
    public class ScreenDisplay
    {
        /// <summary>
        /// 亮度
        /// </summary>
        public short Brightness = short.MinValue;
        /// <summary>
        /// 对比度
        /// </summary>
        public short Contrast = short.MinValue;
        /// <summary>
        /// 伽玛
        /// </summary>
        public short Gamma = short.MinValue;
    }
}
