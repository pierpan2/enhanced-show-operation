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
    public partial class KeySetting : Form
    {
        public KeySetting(Dictionary<string, List<string>> shortcuts)
        {
            InitializeComponent();
            //List<KeyValuePair<string, object>> list = new List<KeyValuePair<string, object>>();
            dataGridView1.Columns.Add("功能", "功能");
            dataGridView1.Columns[0].Width = 250;
            dataGridView1.Columns.Add("快捷键", "快捷键");
            foreach (KeyValuePair<string, List<string>> shortcut in shortcuts)
            {
                foreach (string function in shortcut.Value)
                {
                    dataGridView1.Rows.Add(shortcut.Key, function);
                }
            }
            //dataGridView1.Width = 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
