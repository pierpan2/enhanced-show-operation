using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FSShortcut
{
    public partial class Shortcut : Form
    {
        public static int duration = 800;
        public Shortcut(string tip)
        {
            InitializeComponent();
            this.timer1.Enabled = true;
            this.timer1.Interval = duration;
            label1.Text = tip;
            label1.Font = IntroNSetting.fontSize;
            label1.ForeColor = IntroNSetting.fontColor;
            this.BackColor = IntroNSetting.backColor;
            // this.Width = label1.Width + 20;
            // this.Height = label1.Height + 300;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MainPanel.label1.Text = "";
            this.Dispose();
        }

        private void Shortcut_Load(object sender, EventArgs e)
        {

        }
    }
}
