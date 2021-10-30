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
        private static string AppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        Dictionary<string, List<string>> shortcuts = new Dictionary<string, List<string>>();
        Dictionary<string, string> trans_CN = new Dictionary<string, string>();

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

            LoadTranslate();
            LoadShortcuts();

            
        }
        private void LoadTranslate()
        {
            string[] lines = Properties.Resources.trans_CN_Live2D.Split('\n');
            foreach (string line in lines)
            {
                string[] lineSegs = line.Split(',');
                if (lineSegs.Length > 1)
                {
                    trans_CN.Add(lineSegs[1].Substring(0, lineSegs[1].Length - 1), lineSegs[0]);
                }
            }
        }
        private void LoadShortcuts()
        {
            // 如果AppData->Live2D里有改键后的xml
            DirectoryInfo xmlLoc = new DirectoryInfo(AppData + @"\Live2D\Cubism4_Editor\settings");
            foreach (FileInfo file in xmlLoc.GetFiles())
            {
                if (file.Name.StartsWith("shortcut"))
                {
                    //PreloadXML(file.Directory.ToString() + @"\" + file.Name);
                    break;
                }
            }
            // 没有的话，用预置的默认快捷键
            if (shortcuts.Count == 0)
            {
                FileStream fs = new FileStream("shortcutDefault.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                StreamWriter sw = new StreamWriter(fs); // 创建写入流
                sw.WriteLine(Properties.Resources.shortcutDefault_Live2D); // 写入default xml
                sw.Close(); //关闭文件
                //PreloadXML(Path.Combine(Directory.GetCurrentDirectory(), "shortcutDefault.xml"));
                File.Delete(Path.Combine(Directory.GetCurrentDirectory(), "shortcutDefault.xml")); // 删除文件
            }
        }
        private void PreloadXML(string xmlPath)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(xmlPath);
            XmlNode xmlIn = xml.ChildNodes[1];
            foreach (XmlNode mode in xmlIn.ChildNodes)
            {
                foreach (XmlNode group in mode.ChildNodes)
                {
                    foreach (XmlNode item in group.ChildNodes)
                    {
                        if (item.Attributes.Count > 1)
                        {
                            string shortcut = item.Attributes["shortcut"].InnerText;
                            string command = item.Attributes["command"].InnerText;
                            if (!shortcuts.ContainsKey(shortcut))
                            {
                                shortcuts.Add(shortcut, new List<string>() { trans_CN[ command] });
                            }
                            else
                            {
                                shortcuts[shortcut].Add(trans_CN[command]);
                            }

                        }
                        if (item.Attributes.Count > 2)
                        {
                            string shortcut = item.Attributes["shortcut2"].InnerText;
                            string command = item.Attributes["command"].InnerText;
                            if (!shortcuts.ContainsKey(shortcut))
                            {
                                shortcuts.Add(shortcut, new List<string>() {trans_CN[ command] });
                            }
                            else
                            {
                                shortcuts[shortcut].Add(trans_CN[ command]);
                            }

                        }
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void hook_KeyDown(object sender, KeyEventArgs e)
        {
            string funcKey = e.KeyData.ToString();
            string ctrlKeys = Control.ModifierKeys.ToString(); 

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
                    Console.WriteLine(command);
                    label1.Text += (label1.Text == "" ? "" : "\n") + command;
                }
                label1.Location = new Point( (this.Width - label1.Width) / 2, label1.Location.Y);
                showTip(label1.Text);
            }

            

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
