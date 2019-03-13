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


            var ctrl1 = new AjustDisplayControl(new AjustScreenByGdi32());
            ctrl1.Parent = this;
            ctrl1.Location = new Point(5, 5);
                 
            var ctrl2 = new AjustDisplayControl(new AjustScreenByIgfxDHLib());
            ctrl2.Parent = this;
            ctrl2.Location = new Point(ctrl1.Location.X + ctrl1.Size.Width + 5, 5);
          
            var ctrl3 = new AjustDisplayControl(new AjustScreenByDxva2(this.Handle));
            ctrl3.Parent = this;
            ctrl3.Location = new Point(ctrl2.Location.X + ctrl2.Size.Width + 5, 5);

            this.Size = new Size(ctrl3.Location.X + ctrl2.Size.Width + 25, ctrl1.Size.Height + 50);



        }
    }
}
