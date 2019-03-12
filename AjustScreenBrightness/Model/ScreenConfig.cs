using AjustScreenBrightness.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjustScreenBrightness.Model
{
    public class ScreenConfig
    {
        public uint Handle;
        /// <summary>
        /// 显示屏描述
        /// </summary>
        public string Des;
        public Dictionary<ScreenColorEnum, ScreenDisplay> Color;

        public ScreenConfig()
        {
            Color.Add(ScreenColorEnum.All, new ScreenDisplay());
            Color.Add(ScreenColorEnum.Red, new ScreenDisplay());
            Color.Add(ScreenColorEnum.Green, new ScreenDisplay());
            Color.Add(ScreenColorEnum.Blue, new ScreenDisplay());
        }
    }
}
