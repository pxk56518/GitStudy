using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitStudy
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnTest_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
        /// <summary>
        /// 通过控件名称获取到控件
        /// </summary>
        /// <param name="controlName">控件名称</param>
        /// <param name="containChildControlWindow">包含子控件的窗体（比如窗体是[Controls]、panel是[panel.controls]）</param>
        /// <returns></returns>
        private Control GetControlOfName(string controlName, Control.ControlCollection containChildControlWindow)
        {
            if (string.IsNullOrEmpty(controlName)) return null;

            foreach (Control item in containChildControlWindow)
            {
                if (item.Name.Equals(controlName))
                {
                    return item;
                }
            }

            return null;
        }
        int GreenIndex = 0;
        Control control = null;
        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0;i<5;i++) 
            {
                string controlName = "label" + (i+1);
                control = GetControlOfName(controlName, this.Controls);
                if ((GreenIndex % 5) == i && control != null)
                {
                    control.BackColor = Color.Red;
                }
                else 
                {
                    control.BackColor = Color.LightGray;
                }
            }
            GreenIndex++;
        }

        private void BtnTest2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label6.Text = "当前序号是:" + (GreenIndex).ToString();
        }
    }
}
