using AjustScreenBrightness.UserControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AjustScreenBrightness
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();

            AjustScreenByGdi32 cls = new AjustScreenByGdi32();
            var ctrl = new AjustDisplayControl(cls);
            ctrl.Parent = this;
            ctrl.Location = new Point(10, 10);

        }
    }
}
