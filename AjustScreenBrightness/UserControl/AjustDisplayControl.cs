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

            this.groupBox1.Text = _cls.AjustTypeDes;
            this.tbBrightness.Maximum = 100;
            this.tbBrightness.Minimum = 0;
            this.tbContrast.Maximum = 1;
            this.tbContrast.Minimum = 0;
            this.tbGamma.Maximum = 200;
            this.tbGamma.Minimum = 0;

            this.plBrightness.Visible = _cls.AllowBrightness;
            this.plContrast.Visible = _cls.AllowContrast;
            this.plGamma.Visible = _cls.AllowGamma;

            if (_cls.AllowBrightness)
            {
                this.tbBrightness.Value = _cls.GetBrightnessDefault();
                _oriBrightness = this.tbBrightness.Value;
            }

            if (_cls.AllowContrast)
            {
                this.tbContrast.Value = _cls.GetContrastDefault();
                _oriContrast = this.tbContrast.Value;
            }

            if (_cls.AllowGamma)
            {
                this.tbGamma.Value = (int)(_cls.GetGammaDefault() * 100);
                _oriGamma = this.tbGamma.Value;
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
        }

        private void TbContrast_ValueChanged(object sender, EventArgs e)
        {
            _cls.SetContrastDefault((short)this.tbContrast.Value);
        }

        private void TbGamma_ValueChanged(object sender, EventArgs e)
        {
            _cls.SetGammaDefault(((double)this.tbGamma.Value / 100));
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            
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
