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
    public partial class InputShortcut : Form
    {
        public InputShortcut()
        {
            InitializeComponent();
            Program.changeShortcut = false;
        }

        private void InputShortcut_KeyDown(object sender, KeyEventArgs e)
        {
            Console.WriteLine(Program.gobalKey + "AA");
            if (Program.gobalKey != "")
            {
                Program.changeShortcut = true;
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
