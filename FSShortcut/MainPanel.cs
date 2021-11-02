﻿using System;
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
using Newtonsoft.Json;
using System.Diagnostics;

namespace FSShortcut
{
    public partial class MainPanel : Form
    {
        ToolTip tp = new ToolTip();
        Shortcut mesBox = new Shortcut("");
        clickmonitor.KeyboardHook k_hook = new clickmonitor.KeyboardHook();
        //private object pivotGridControl1;
        Dictionary<string, List<string>> shortcuts = new Dictionary<string, List<string>>();
        static List<string> CONTROL_KEYS = new List<string>() {"LShiftKey", "LControlKey", "LMenu", "RShiftKey", "RControlKey", "RMenu", "LWin", "RWin" };
        public static string keyBoardInput = "";
        public static bool followCursor = Properties.Settings.Default.FollowCursor;

        public MainPanel()
        {
            InitializeComponent();
            label1.Text = "";
            tp.ShowAlways = true;
            // this.Opacity = 0.8;

            Timer timer1 = new Timer();
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Tick += new EventHandler(timer1EventProcessor);
            Properties.Settings.Default.Reload();
            if (Properties.Settings.Default.SaveShortcut != "")
            {
                shortcuts = JsonConvert.DeserializeObject<Dictionary<string, List<string>>>(Properties.Settings.Default.SaveShortcut);
            }
            if(Properties.Settings.Default.Font != "")
                IntroNSetting.fontSize = JsonConvert.DeserializeObject<Font>(Properties.Settings.Default.Font);
            if (Properties.Settings.Default.FontColor != "")
                IntroNSetting.fontColor = JsonConvert.DeserializeObject<Color>(Properties.Settings.Default.FontColor);
            if (Properties.Settings.Default.BackColor != "")
                IntroNSetting.backColor = JsonConvert.DeserializeObject<Color>(Properties.Settings.Default.BackColor);
            // Shortcut.duration = Properties.Settings.Default.Duration_ms;
        }

        private void hook_KeyDown(object sender, KeyEventArgs e)
        {
            string funcKey = e.KeyData.ToString();
            string ctrlKeys = Control.ModifierKeys.ToString();
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
                string commandsToShow = "";
                foreach (string command in shortcuts[combinedKey])
                {
                    Console.WriteLine(command);
                    commandsToShow += (commandsToShow == "" ? "" : "\n") + command;
                }
                if (!Program.settingMode)
                {
                    showTip(commandsToShow);
                }
            }
            keyBoardInput = combinedKey;

        }

        private void showTip(string tip)
        {
            if (tip == "") return;
            // 窗口不在Live2D就爬
            Process[] processes = Process.GetProcesses();
            foreach (Process p in processes)
            {
                if (!String.IsNullOrEmpty(p.MainWindowTitle) && p.MainWindowTitle.StartsWith("Live2D Cubism Editor"))
                {
                    Console.WriteLine(p.MainWindowTitle);
                }
            }
            //mesBox.DialogResult = DialogResult.Cancel;
            if (followCursor)
            {
                mesBox.Dispose();
                mesBox = new Shortcut(tip);
                mesBox.StartPosition = FormStartPosition.Manual;
                mesBox.Location = new Point(MousePosition.X + 30, MousePosition.Y + 30);
                mesBox.Show();
            }

            label1.Text = tip;
            label1.Location = new Point((this.Width - label1.Width) / 2, label1.Location.Y);
            label1.Font = IntroNSetting.fontSize;
            label1.ForeColor = IntroNSetting.fontColor;
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
        public void timer1EventProcessor(object source, EventArgs e)
        {
            k_hook.Stop();
            k_hook = new clickmonitor.KeyboardHook();
            // 全局键盘监听
            k_hook.KeyDownEvent += new KeyEventHandler(hook_KeyDown);//钩住键按下   
            //k_hook.KeyPressEvent += Hook_KeyPressEvent;
            k_hook.Start();//安装键盘钩子
            this.BackColor = IntroNSetting.backColor;
        }

        private void Intro_Click(object sender, EventArgs e)
        {
            IntroNSetting intro = new IntroNSetting();
            intro.ShowDialog();
        }

        private void MainPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.SaveShortcut = JsonConvert.SerializeObject(shortcuts);
            Properties.Settings.Default.FollowCursor = followCursor;
            Properties.Settings.Default.Font = JsonConvert.SerializeObject(IntroNSetting.fontSize);
            Properties.Settings.Default.FontColor = JsonConvert.SerializeObject(IntroNSetting.fontColor);
            Properties.Settings.Default.BackColor = JsonConvert.SerializeObject(IntroNSetting.backColor);
            Properties.Settings.Default.Duration_ms = Shortcut.duration;
            Properties.Settings.Default.Save();
        }
    }
   
}
