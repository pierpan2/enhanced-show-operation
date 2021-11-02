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
        string originShortcut;
        Timer timer1;
        public InputShortcut()
        {
            InitializeComponent();
            originShortcut = MainPanel.keyBoardInput;
            timer1 = new Timer();
            timer1.Interval = 10;
            timer1.Enabled = true;
            timer1.Tick += new EventHandler(timer1EventProcessor);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void timer1EventProcessor(object source, EventArgs e)
        {
            if (originShortcut != MainPanel.keyBoardInput)
            {
                Console.WriteLine(MainPanel.keyBoardInput);
                timer1.Stop();
                this.Close();
            }
        }
    }
}
