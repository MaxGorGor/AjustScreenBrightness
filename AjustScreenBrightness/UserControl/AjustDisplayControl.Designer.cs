
using System.Windows.Forms;

namespace AjustScreenBrightness.UserControl
{
    partial class AjustDisplayControl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.plGamma = new System.Windows.Forms.Panel();
            this.lblGammaVal = new System.Windows.Forms.Label();
            this.tbGamma = new System.Windows.Forms.TrackBar();
            this.lblGamma = new System.Windows.Forms.Label();
            this.plContrast = new System.Windows.Forms.Panel();
            this.lblContrastVal = new System.Windows.Forms.Label();
            this.lblContrast = new System.Windows.Forms.Label();
            this.tbContrast = new System.Windows.Forms.TrackBar();
            this.plBrightness = new System.Windows.Forms.Panel();
            this.lblBrightnessVal = new System.Windows.Forms.Label();
            this.lblBright = new System.Windows.Forms.Label();
            this.tbBrightness = new System.Windows.Forms.TrackBar();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblTip = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.plGamma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbGamma)).BeginInit();
            this.plContrast.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbContrast)).BeginInit();
            this.plBrightness.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbBrightness)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTip);
            this.groupBox1.Controls.Add(this.plGamma);
            this.groupBox1.Controls.Add(this.plContrast);
            this.groupBox1.Controls.Add(this.plBrightness);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnOK);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 240);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "屏幕界面";
            // 
            // plGamma
            // 
            this.plGamma.Controls.Add(this.lblGammaVal);
            this.plGamma.Controls.Add(this.tbGamma);
            this.plGamma.Controls.Add(this.lblGamma);
            this.plGamma.Location = new System.Drawing.Point(6, 135);
            this.plGamma.Name = "plGamma";
            this.plGamma.Size = new System.Drawing.Size(309, 53);
            this.plGamma.TabIndex = 15;
            // 
            // lblGammaVal
            // 
            this.lblGammaVal.AutoSize = true;
            this.lblGammaVal.Location = new System.Drawing.Point(265, 11);
            this.lblGammaVal.Name = "lblGammaVal";
            this.lblGammaVal.Size = new System.Drawing.Size(41, 12);
            this.lblGammaVal.TabIndex = 12;
            this.lblGammaVal.Text = "label3";
            // 
            // tbGamma
            // 
            this.tbGamma.Location = new System.Drawing.Point(55, 4);
            this.tbGamma.Maximum = 200;
            this.tbGamma.Name = "tbGamma";
            this.tbGamma.Size = new System.Drawing.Size(209, 45);
            this.tbGamma.TabIndex = 6;
            this.tbGamma.TickFrequency = 10;
            // 
            // lblGamma
            // 
            this.lblGamma.AutoSize = true;
            this.lblGamma.Location = new System.Drawing.Point(5, 11);
            this.lblGamma.Name = "lblGamma";
            this.lblGamma.Size = new System.Drawing.Size(41, 12);
            this.lblGamma.TabIndex = 9;
            this.lblGamma.Text = "伽玛：";
            // 
            // plContrast
            // 
            this.plContrast.Controls.Add(this.lblContrastVal);
            this.plContrast.Controls.Add(this.lblContrast);
            this.plContrast.Controls.Add(this.tbContrast);
            this.plContrast.Location = new System.Drawing.Point(6, 76);
            this.plContrast.Name = "plContrast";
            this.plContrast.Size = new System.Drawing.Size(309, 53);
            this.plContrast.TabIndex = 14;
            // 
            // lblContrastVal
            // 
            this.lblContrastVal.AutoSize = true;
            this.lblContrastVal.Location = new System.Drawing.Point(265, 11);
            this.lblContrastVal.Name = "lblContrastVal";
            this.lblContrastVal.Size = new System.Drawing.Size(41, 12);
            this.lblContrastVal.TabIndex = 11;
            this.lblContrastVal.Text = "label2";
            // 
            // lblContrast
            // 
            this.lblContrast.AutoSize = true;
            this.lblContrast.Location = new System.Drawing.Point(5, 11);
            this.lblContrast.Name = "lblContrast";
            this.lblContrast.Size = new System.Drawing.Size(53, 12);
            this.lblContrast.TabIndex = 10;
            this.lblContrast.Text = "对比度：";
            // 
            // tbContrast
            // 
            this.tbContrast.Location = new System.Drawing.Point(55, 4);
            this.tbContrast.Name = "tbContrast";
            this.tbContrast.Size = new System.Drawing.Size(209, 45);
            this.tbContrast.TabIndex = 9;
            this.tbContrast.TickFrequency = 10;
            // 
            // plBrightness
            // 
            this.plBrightness.Controls.Add(this.lblBrightnessVal);
            this.plBrightness.Controls.Add(this.lblBright);
            this.plBrightness.Controls.Add(this.tbBrightness);
            this.plBrightness.Location = new System.Drawing.Point(6, 17);
            this.plBrightness.Name = "plBrightness";
            this.plBrightness.Size = new System.Drawing.Size(309, 53);
            this.plBrightness.TabIndex = 13;
            // 
            // lblBrightnessVal
            // 
            this.lblBrightnessVal.AutoSize = true;
            this.lblBrightnessVal.Location = new System.Drawing.Point(265, 11);
            this.lblBrightnessVal.Name = "lblBrightnessVal";
            this.lblBrightnessVal.Size = new System.Drawing.Size(41, 12);
            this.lblBrightnessVal.TabIndex = 10;
            this.lblBrightnessVal.Text = "label1";
            // 
            // lblBright
            // 
            this.lblBright.AutoSize = true;
            this.lblBright.Location = new System.Drawing.Point(5, 11);
            this.lblBright.Name = "lblBright";
            this.lblBright.Size = new System.Drawing.Size(41, 12);
            this.lblBright.TabIndex = 9;
            this.lblBright.Text = "亮度：";
            // 
            // tbBrightness
            // 
            this.tbBrightness.Location = new System.Drawing.Point(55, 4);
            this.tbBrightness.Name = "tbBrightness";
            this.tbBrightness.Size = new System.Drawing.Size(209, 45);
            this.tbBrightness.TabIndex = 8;
            this.tbBrightness.TickFrequency = 10;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(223, 196);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "重置";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(123, 196);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(30, 196);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Location = new System.Drawing.Point(23, 201);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(29, 12);
            this.lblTip.TabIndex = 13;
            this.lblTip.Text = "提示";
            // 
            // AjustDisplayControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "AjustDisplayControl";
            this.Size = new System.Drawing.Size(321, 240);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.plGamma.ResumeLayout(false);
            this.plGamma.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbGamma)).EndInit();
            this.plContrast.ResumeLayout(false);
            this.plContrast.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbContrast)).EndInit();
            this.plBrightness.ResumeLayout(false);
            this.plBrightness.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbBrightness)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button btnCancel;
        private Button btnOK;
        private Label lblGamma;
        private TrackBar tbGamma;
        private Button btnReset;
        private Label lblContrast;
        private TrackBar tbContrast;
        private Panel plBrightness;
        private Label lblBright;
        private TrackBar tbBrightness;
        private Panel plGamma;
        private Panel plContrast;
        private Label lblGammaVal;
        private Label lblContrastVal;
        private Label lblBrightnessVal;
        private Label lblTip;
    }
}
