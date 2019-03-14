using AjustScreenBrightness.Abstract;
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

            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;

            AjustScreenClass[] classes = { new AjustScreenByGdi32(), new AjustScreenByDxva2(this.Handle) };

            AjustDisplayControl ctrl = null;
            int maxWidth = 0;

            for(int i = 0; i < classes.Length; i++)
            {
                ctrl = new AjustDisplayControl(classes[i]);
                ctrl.Parent = this;
                ctrl.Location = new Point(5 * (i + 1) + ctrl.Size.Width * (i), 5);
                maxWidth = ctrl.Location.X + ctrl.Size.Width;
            }
 
            this.Size = new Size(maxWidth + 25, ctrl.Size.Height + 50);



        }
    }
}
