using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AjustScreenBrightness.Abstract;
using AjustScreenBrightness.NativeImp;

namespace AjustScreenBrightness.UserControl
{
    public partial class AjustDisplayControl : System.Windows.Forms.UserControl
    {
        AjustScreenClass _cls;
 

        public AjustDisplayControl(AjustScreenClass cls = null)
        {
            InitializeComponent();            
            _cls = cls;
            Init();
            RegisterEvent();
        }

        int _oriBrightness = 0;
        int _oriContrast = 0;
        int _oriGamma = 0;


        public void Init()
        {
            if (_cls == null)
            {
                this.Enabled = false;
                this.BackColor = Color.Red;
                return;
            }

            this.btnOK.Visible = false;
            this.btnCancel.Visible = false;
            this.groupBox1.Text = _cls.AjustTypeDes;

            #region 尽量不要大幅度改动一下代码 , 操作不慎后果很严重 ,整个屏幕什么都看不到
            this.tbBrightness.Maximum = (int)_cls.PropRange.Brightness.Maximun;
            this.tbBrightness.Minimum = (int)_cls.PropRange.Brightness.Minimun;
            this.tbContrast.Maximum = (int)_cls.PropRange.Contrast.Maximun;
            this.tbContrast.Minimum = (int)_cls.PropRange.Contrast.Minimun;
            this.tbGamma.Maximum = (int)(_cls.PropRange.Gamma.Maximun * 100);
            this.tbGamma.Minimum = (int)(_cls.PropRange.Gamma.Minimun * 100);
            #endregion

            this.plBrightness.Visible = _cls.AllowBrightness;
            this.plContrast.Visible = _cls.AllowContrast;
            this.plGamma.Visible = _cls.AllowGamma;

            if (_cls.AllowBrightness)
            {
                this.tbBrightness.Value = _cls.GetBrightnessDefault();
                _oriBrightness = this.tbBrightness.Value;
                lblBrightnessVal.Text = this.tbBrightness.Value + "";
            }

            if (_cls.AllowContrast)
            {
                this.tbContrast.Value = _cls.GetContrastDefault();
                _oriContrast = this.tbContrast.Value;
                lblContrastVal.Text = this.tbContrast.Value + "";
            }

            if (_cls.AllowGamma)
            {
                var val = (int)(_cls.GetGammaDefault() * 100);
                this.tbGamma.Maximum = Math.Max(val, this.tbGamma.Maximum);
                this.tbGamma.Minimum = Math.Min(val, this.tbGamma.Minimum);
                this.tbGamma.Value = val;
                _oriGamma = this.tbGamma.Value;
                lblGammaVal.Text = ((double)this.tbGamma.Value / 100) + "";
            }

        }

        void RegisterEvent()
        {
            this.btnOK.Click += BtnOK_Click;
            this.btnCancel.Click += BtnCancel_Click;
            this.btnReset.Click += BtnReset_Click;
            this.tbBrightness.ValueChanged += TbBrightness_ValueChanged;
            this.tbContrast.ValueChanged += TbContrast_ValueChanged;
            this.tbGamma.ValueChanged += TbGamma_ValueChanged;
        }

        private void TbBrightness_ValueChanged(object sender, EventArgs e)
        {
            _cls.SetBrightnessDefault((short)this.tbBrightness.Value);
            lblBrightnessVal.Text = this.tbBrightness.Value + "";
        }

        private void TbContrast_ValueChanged(object sender, EventArgs e)
        {
            _cls.SetContrastDefault((short)this.tbContrast.Value);
            lblContrastVal.Text = this.tbContrast.Value + "";
        }

        private void TbGamma_ValueChanged(object sender, EventArgs e)
        {
            var bok = _cls.SetGammaDefault(((double)this.tbGamma.Value / 100));

            lblGammaVal.Text = ((double)this.tbGamma.Value / 100) + "";

            if (bok)
            {
                this.lblTip.Visible = false;
            }
            else
            {
              
 
                var code = Native.Kernel32.GetLastError();
                uint dwFlags = Native.Kernel32.FORMAT_MESSAGE_FROM_SYSTEM | Native.Kernel32.FORMAT_MESSAGE_IGNORE_INSERTS;

                StringBuilder lpBuffer = new StringBuilder(260);    
                int count = Native.Kernel32.FormatMessage(dwFlags, IntPtr.Zero, code, 0, lpBuffer, 260, IntPtr.Zero);

                this.lblTip.Visible = true;
                this.lblTip.Text = "setting false:" + lpBuffer.ToString();

            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            if (this.plBrightness.Visible)
            {
                _cls.SetBrightnessDefault((short)_oriBrightness);
                this.tbBrightness.Value = _oriBrightness;
            }
            if (this.plContrast.Visible)
            {
                _cls.SetContrastDefault((short)_oriContrast);
                this.tbContrast.Value = _oriContrast;
            }
            if (this.plGamma.Visible)
            {
                _cls.SetGammaDefault(((double)_oriGamma / 100));
                this.tbGamma.Value = _oriGamma;
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            if (this.plBrightness.Visible)
            {
                _cls.SetBrightnessDefault((short)_oriBrightness);
                this.tbBrightness.Value = _oriBrightness;
            }
            if (this.plContrast.Visible)
            {
                _cls.SetContrastDefault((short)_oriContrast);
                this.tbContrast.Value = _oriContrast;
            }
            if (this.plGamma.Visible)
            {
                _cls.SetGammaDefault(((double)_oriGamma / 100));
                this.tbGamma.Value = _oriGamma;
            }
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (this.plBrightness.Visible)
            {
                _cls.SetBrightnessDefault((short)this.tbBrightness.Value);
            }
            if (this.plContrast.Visible)
            {
                _cls.SetContrastDefault((short)this.tbContrast.Value);
            }
            if (this.plGamma.Visible)
            {
                _cls.SetGammaDefault(((double)this.tbGamma.Value / 100));
            } 
        }
    }
}
