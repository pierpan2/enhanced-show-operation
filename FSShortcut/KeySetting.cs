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
    public partial class KeySetting : Form
    {
        Dictionary<string, List<string>> shortcuts;
        private static string AppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        public KeySetting(Dictionary<string, List<string>> shortcutsIn)
        {
            InitializeComponent();
            shortcuts = shortcutsIn;
            //List<KeyValuePair<string, object>> list = new List<KeyValuePair<string, object>>();
            shortcutGrid.Columns.Add("功能", "功能");
            shortcutGrid.Columns[0].Width = 250;
            shortcutGrid.Columns.Add("快捷键", "快捷键");
            refreshDGV();
            shortcutGrid.Columns[0].ReadOnly = true;
            shortcutGrid.Columns[1].ReadOnly = false;
            Program.settingMode = true;
        }

        private void shortcutGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {
                SetShortcut(e.RowIndex, e.ColumnIndex);
            }
        }
        private void SetShortcut(int row, int col)
        {
        }
        private void LoadLive2D_Click(object sender, EventArgs e)
        {
            LoadLive2DShortcuts();
            refreshDGV();
        }
        private void refreshDGV()
        {
            shortcutGrid.Rows.Clear();
            foreach (KeyValuePair<string, List<string>> shortcut in shortcuts)
            {
                foreach (String function in shortcut.Value)
                {
                    shortcutGrid.Rows.Add(shortcut.Key, function);
                }
            }
        }
        private Dictionary<string, string> LoadTranslate_CN()
        {
            Dictionary<string, string> trans_CN = new Dictionary<string, string>();
            string[] lines = Properties.Resources.trans_CN_Live2D.Split('\n');
            foreach (string line in lines)
            {
                string[] lineSegs = line.Split(',');
                if (lineSegs.Length > 1)
                {
                    trans_CN.Add(lineSegs[1].Substring(0, lineSegs[1].Length - 1), lineSegs[0]);
                }
            }
            return trans_CN;
        }
        private void LoadLive2DShortcuts()
        {
            shortcuts.Clear();
            // 如果AppData->Live2D里有改键后的xml
            DirectoryInfo xmlLoc = new DirectoryInfo(AppData + @"\Live2D\Cubism4_Editor\settings");
            foreach (FileInfo file in xmlLoc.GetFiles())
            {
                if (file.Name.StartsWith("shortcut"))
                {
                    PreloadXML(file.Directory.ToString() + @"\" + file.Name);
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
                PreloadXML(Path.Combine(Directory.GetCurrentDirectory(), "shortcutDefault.xml"));
                File.Delete(Path.Combine(Directory.GetCurrentDirectory(), "shortcutDefault.xml")); // 删除文件
            }
        }

        private void PreloadXML(string xmlPath)
        {
            var trans_CN = LoadTranslate_CN();
            XmlDocument xml = new XmlDocument();
            xml.Load(xmlPath);
            XmlNode xmlIn = xml.ChildNodes[1];
            foreach (XmlNode mode in xmlIn.ChildNodes)
            {
                foreach (XmlNode group in mode.ChildNodes)
                {
                    foreach (XmlNode item in group.ChildNodes)
                    {
                        try
                        {
                            string command = item.Attributes["command"].InnerText;
                            if (item.Attributes.Count > 1)
                            {
                                string shortcut = item.Attributes["shortcut"].InnerText;
                                if (!shortcuts.ContainsKey(shortcut))
                                {
                                    shortcuts.Add(shortcut, new List<string>());
                                }
                                shortcuts[shortcut].Add(trans_CN[command]);

                            }
                            if (item.Attributes.Count > 2)
                            {
                                string shortcut = item.Attributes["shortcut2"].InnerText;
                                if (!shortcuts.ContainsKey(shortcut))
                                {
                                    shortcuts.Add(shortcut, new List<string>());
                                }
                                shortcuts[shortcut].Add(trans_CN[command]);
                            }
                        }
                        catch(KeyNotFoundException e) {
                            //MessageBox.Show("读取坏坏");
                        }
                    }
                }
            }
        }

        private void shortcutGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            List<string> newShortcuts = new List<string>();
            string shortcut = shortcutGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            // string operation = shortcutGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            foreach (DataGridViewRow row in shortcutGrid.Rows)
            {
                if(row.Cells[0].Value != null && row.Cells[0].Value.ToString() == shortcut)
                {
                    newShortcuts.Add(row.Cells[1].Value.ToString());
                }
            }
            shortcuts[shortcutGrid.Rows[e.RowIndex].Cells[0].Value.ToString()] = newShortcuts;
            refreshDGV();
        }

        private void KeySetting_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.settingMode = false;
        }

        private void clearAll_Click(object sender, EventArgs e)
        {
            shortcuts = new Dictionary<string, List<string>>();
            shortcutGrid.Rows.Clear();
        }
    }
}
