using AjustScreenBrightness.Imp;
using AjustScreenBrightness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjustScreenBrightness.Abstract
{
    public abstract class AjustScreenClass : IAjustScreen
    {
        /// <summary>
        /// 该类描述
        /// </summary>
        public abstract string AjustTypeDes { get; }
        public abstract bool AllowBrightness { get; }
        public abstract bool AllowContrast { get; }
        public abstract bool AllowGamma { get; }
        public virtual ScreenPropRange PropRange { get { return _propRange; } }

        internal ScreenPropRange _propRange = new ScreenPropRange();

        private List<ushort> AllScreenHandle = new List<ushort>();
        
        public AjustScreenClass()
        {
        }

        public abstract short GetBrightnessDefault();
        public abstract short GetContrastDefault();
        public abstract double GetGammaDefault();
        public abstract ScreenConfig GetScreenConfigDefault();
        public abstract bool SetBrightnessDefault(short val);
        public abstract bool SetContrastDefault(short val);
        public abstract bool SetGammaDefault(double val);
        public abstract bool SetScreenConfigDefault(ScreenConfig config);

        /// <summary>
        /// 恢复初始值
        /// </summary>
        public virtual bool Reset()
        {
            return false;        
        }
    }
}
