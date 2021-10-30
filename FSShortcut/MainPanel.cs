using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices; 
using Microsoft.Win32; 
using System.Xml;
using System.Collections;
using System.IO;

namespace FSShortcut
{
    public partial class MainPanel : Form
    {
        ToolTip tp = new ToolTip();
        Shortcut mesBox = new Shortcut("");
        //private object pivotGridControl1;
        Dictionary<string, List<string>> shortcuts = new Dictionary<string, List<string>>();
        static List<string> CONTROL_KEYS = new List<string>() {"LShiftKey", "LControlKey", "LMenu", "RShiftKey", "RControlKey", "RMenu", "LWin", "RWin" };

        public MainPanel()
        {
            InitializeComponent();
            label1.Text = "";
            tp.ShowAlways = true;
            // this.Opacity = 0.8;

            // 全局键盘监听
            var k_hook = new clickmonitor.KeyboardHook();
            k_hook.KeyDownEvent += new KeyEventHandler(hook_KeyDown);//钩住键按下   
            //k_hook.KeyPressEvent += Hook_KeyPressEvent;
            k_hook.Start();//安装键盘钩子
        }

        private void hook_KeyDown(object sender, KeyEventArgs e)
        {
            string funcKey = e.KeyData.ToString();
            string ctrlKeys = Control.ModifierKeys.ToString();
            Program.gobalKey = "";
            if (CONTROL_KEYS.Contains(funcKey))
            {
                return;
            }
            string combinedKey = "";
            if (ctrlKeys.Contains("Control")) combinedKey += "Ctrl";
            if (ctrlKeys.Contains("Alt")) combinedKey += combinedKey == "" ? "Alt" : "+Alt";
            if (ctrlKeys.Contains("Shift")) combinedKey += combinedKey == "" ? "Shift" : "+Shift";
            if (funcKey == "Oemtilde") funcKey = "Back Quote";
            if (funcKey == "Back") funcKey = "Backspace";
            if (funcKey == "Return") funcKey = "Enter";
            if (funcKey != "Delete" &&  funcKey.Length > 1 && funcKey[0] == 'D') funcKey = "" + funcKey[1];
            combinedKey += (combinedKey == "" ? "" : "+") + funcKey;
            if (shortcuts.ContainsKey(combinedKey))
            {
                label1.Text = "";
                foreach (string command in shortcuts[combinedKey])
                {
                    // Console.WriteLine(command);
                    label1.Text += (label1.Text == "" ? "" : "\n") + command;
                }
                label1.Location = new Point( (this.Width - label1.Width) / 2, label1.Location.Y);
                showTip(label1.Text);
            }
            Program.gobalKey = combinedKey;

            // Console.WriteLine(Program.gobalKey);


        }

        private void showTip(string tip)
        {
            //mesBox.DialogResult = DialogResult.Cancel;
            mesBox.Dispose();
            mesBox = new Shortcut(tip);
            mesBox.StartPosition = FormStartPosition.Manual;
            mesBox.Location = new Point(MousePosition.X + 30, MousePosition.Y + 30);
            mesBox.Show();
        }

        private string showAll(List<string> mylist)
        {
            string result = "";
            foreach(string item in mylist)
            {
                result += item + " | ";
            }
            return result;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void SettingBut_Click(object sender, EventArgs e)
        {
            KeySetting setting = new KeySetting(shortcuts);
            setting.ShowDialog();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
   
}
