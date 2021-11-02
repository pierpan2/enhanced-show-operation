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
    public partial class IntroNSetting : Form
    {
        public static Font fontSize = new Font("黑体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
        public static Color fontColor = Color.Black;
        public static Color backColor = DefaultBackColor;
        public IntroNSetting()
        {
            InitializeComponent();
            FontSize.Font = fontSize;
            FontSize.ForeColor = fontColor;
            FontSize.BackColor = backColor;
            followCursor.Checked = MainPanel.followCursor;
            duration.Value = (decimal)(Properties.Settings.Default.Duration_ms / 1000.0);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Shortcut.duration = (int)(duration.Value * 1000);
            Properties.Settings.Default.Duration_ms = Shortcut.duration;
        }

        private void FontSize_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                FontDialog newFont = new FontDialog();
                newFont.Font = fontSize;
                newFont.ShowDialog();
                FontSize.Font = newFont.Font;
                fontSize = newFont.Font;
            }
            if (e.Button == MouseButtons.Right)
            {
                ColorDialog newColor = new ColorDialog();
                newColor.Color = fontColor;
                newColor.ShowDialog();
                FontSize.ForeColor = newColor.Color;
                fontColor = newColor.Color;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            ColorDialog newBackColor = new ColorDialog();
            newBackColor.Color = backColor;
            newBackColor.ShowDialog();
            FontSize.BackColor = newBackColor.Color;
            backColor = newBackColor.Color;
        }

        private void followCursor_CheckedChanged(object sender, EventArgs e)
        {
            MainPanel.followCursor = followCursor.Checked;
        }

        private void button2_Click(object sender, EventArgs e)
        {
               DialogResult dialogResult = MessageBox.Show("它还挺好看的", "再好好想想？", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                fontSize = new Font("黑体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                fontColor = Color.Black;
                backColor = DefaultBackColor;
                Shortcut.duration = 800;
                followCursor.Checked = false;
                string keepShortcut = Properties.Settings.Default.SaveShortcut;
                Properties.Settings.Default.Reset();
                Properties.Settings.Default.SaveShortcut = keepShortcut;
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }
    }
}
