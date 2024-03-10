using AutoMouseMover.WinHelper;
using AutoMouseMover.WinWrapper;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AutoMK
{
    public partial class Main : Form
    {
        private int sign = 1;
        private bool exit = false;
        private enum TrayAction : int
        {
            NOTHING = 0,
            AUTO_MOUSE = 1,
            AUTO_KEY = 2,
            SHOW_APP = 3
        }
        public Main()
        {
            InitializeComponent();
            comboBoxKey2Press.DataSource = Enum.GetValues(typeof(SendInputWrapper.VirtualKeyShort));
            comboBoxLeftClickTray.DataSource = Enum.GetValues(typeof(TrayAction));
            
            labelProductName.Text = Application.ProductName + " (formerly Anti Idol)";
            labelVersion.Text = string.Format("Version {0}", Application.ProductVersion);
            labelCopyright.Text = "Copyright © 2022 - 2024";
            labelCompanyName.Text = Application.CompanyName;

            using (RegistryKey r = Registry.CurrentUser.OpenSubKey("SOFTWARE\\ClearAll\\XShort\\AMI", true))
            {
                if (r != null)
                {
                    if (r.GetValue("AMI") != null)
                        numericUpDownIntervalAM.Value = (int)r.GetValue("AMI");
                    if (r.GetValue("AMIK") != null)
                        numericUpDownIntervalAK.Value = (int)r.GetValue("AMIK");
                    if (r.GetValue("AMIO") != null)
                        numericUpDownPixelNo.Value = (int)r.GetValue("AMIO");
                    if (r.GetValue("AMITray") != null)
                        checkBoxTrayIcon.Checked = true;
                    if (r.GetValue("AMIKey") != null)
                    {
                        string key = r.GetValue("AMIKey").ToString();
                        Enum.TryParse<SendInputWrapper.VirtualKeyShort>(key, out SendInputWrapper.VirtualKeyShort vk);
                        comboBoxKey2Press.SelectedItem = vk;
                    }
                    if (r.GetValue("AMITrayLA") != null)
                    {
                        comboBoxLeftClickTray.SelectedIndex = (int)r.GetValue("AMITrayLA");
                    }
                    /*if (r.GetValue("AMITrayMA") != null)
                    {
                        comboBoxMidClickTray.SelectedIndex = (int)r.GetValue("AMITrayMA");
                    }*/
                    /*if (r.GetValue("AMITrayRA") != null)
                    {
                        comboBoxRightClickTray.SelectedIndex = (int)r.GetValue("AMITrayRA");
                    }*/
                    if (r.GetValue("AlwaysHide") != null)
                       checkBoxHideApp.Checked = true;
                }
                else
                    Registry.CurrentUser.CreateSubKey("SOFTWARE\\ClearAll\\XShort\\AMI");
            }
            using (RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true))
            {
                if (registryKey.GetValue("AntiIdol") != null)
                {
                    if (registryKey.GetValue("AntiIdol").ToString() == Application.ExecutablePath)
                        checkBoxRunAtStartup.Checked = true;
                }
            }
        }

      
        private void MoveCursor(int offset)
        {
            // If mouse is outside screen, move it to the center
            // In case of multiple screens are used, the mouse will be moved to the center of the main screen
            // This has never been a problem to me, but you can modify the code to support multiple screens

            if (!CursorHelper.CheckRelativePosition(offset, offset))
            {
                var res_info = DesktopHelper.GetResolution();
                var center_screen_pos = new CursorPosition(res_info.Width / 2, res_info.Height / 2);
                CursorHelper.SetPositionAbsolute(center_screen_pos);
            }
            else
            {
                CursorHelper.SetPositionRelative(offset, offset);
            }

        }

        private void SendKey(string k)
        {
            Enum.TryParse<SendInputWrapper.ScanCodeShort>(k, out SendInputWrapper.ScanCodeShort key);
            CursorHelper.SendKey(key);
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == NativeMethods.WM_SHOWMEAUTOMK)
            {
                ShowMe();
            }
            base.WndProc(ref m);
        }

        private void ShowMe()
        {
            this.TopMost = true;
            this.Show();
            WindowState = FormWindowState.Normal;
            this.TopMost = false;
        }

        private void UpdateStatus()
        {
            bool am = checkBoxAutoMouse.Checked;
            bool ak = checkBoxAutoKey.Checked;
            if (am && ak)
            {
                notifyIconTray.Icon = Properties.Resources.all_running;
                notifyIconTray.Text = "Anti Idol - All services are running";
            }
            else if (am && !ak)
            {
                notifyIconTray.Icon = Properties.Resources.mouse_only;
                notifyIconTray.Text = "Anti Idol - Auto Mouse service is running";
            }
            else if (!am && ak)
            {
                notifyIconTray.Icon = Properties.Resources.keyboard_only;
                notifyIconTray.Text = "Anti Idol - Auto Key service is running";
            }
            else
            {
                notifyIconTray.Icon = Properties.Resources.all_ready;
                notifyIconTray.Text = "Idol/Idle";
            }
        }

        private void checkBoxAutoMouse_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAutoMouse.Checked)
            {
                timerAutoMouse.Interval = 1000 * (int)numericUpDownIntervalAM.Value;
                timerAutoMouse.Start();
            }
            else
            {
                timerAutoMouse.Stop();
            }
            numericUpDownIntervalAM.Enabled = !checkBoxAutoMouse.Checked;
            autoMouseToolStripMenuItem.Checked = checkBoxAutoMouse.Checked;
            UpdateStatus();
        }

        private void checkBoxAutoKey_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAutoKey.Checked)
            {
                timerAutoKey.Interval = 1000 * (int)numericUpDownIntervalAK.Value;
                timerAutoKey.Start();
            }
            else
            {
                timerAutoKey.Stop();
            }
            autoKeyToolStripMenuItem.Checked = checkBoxAutoKey.Checked;
            numericUpDownIntervalAK.Enabled = !checkBoxAutoKey.Checked;
            UpdateStatus();
        }

        private void notifyIconTray_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                NotifyIconClick(comboBoxLeftClickTray.SelectedIndex);
            }
            /*else
            {
                NotifyIconClick(comboBoxRightClickTray.SelectedIndex);
            }*/
        }

        private void NotifyIconClick(int index)
        {
            if (index == 1)
            {
                if (checkBoxAutoMouse.Checked)
                {
                    checkBoxAutoMouse.Checked = false;
                }
                else
                {
                    checkBoxAutoMouse.Checked = true;
                }
            }
            else if (index == 2)
            {
                if (checkBoxAutoKey.Checked)
                {
                    checkBoxAutoKey.Checked = false;
                }
                else
                {
                    checkBoxAutoKey.Checked = true;
                }
            }
            else if (index == 3)
            {
                this.Show();
                WindowState = FormWindowState.Normal;
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (RegistryKey r = Registry.CurrentUser.OpenSubKey("SOFTWARE\\ClearAll\\XShort\\AMI", true))
            {
                r.SetValue("AMI", (int)numericUpDownIntervalAM.Value);
                r.SetValue("AMIK", (int)numericUpDownIntervalAK.Value);
                r.SetValue("AMIO", (int)numericUpDownPixelNo.Value);
                if (checkBoxTrayIcon.Checked)
                    r.SetValue("AMITray", true);
                else
                    r.DeleteValue("AMITray", false);
                if (checkBoxHideApp.Checked)
                    r.SetValue("AlwaysHide", true);
                else
                    r.DeleteValue("AlwaysHide", false);
                r.SetValue("AMITrayLA", comboBoxLeftClickTray.SelectedIndex);
                //r.SetValue("AMITrayMA", comboBoxMidClickTray.SelectedIndex);
                //r.SetValue("AMITrayRA", comboBoxRightClickTray.SelectedIndex);
                r.SetValue("AMIKey", comboBoxKey2Press.SelectedValue.ToString());
            }
            using (RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true))
            {
                if (checkBoxRunAtStartup.Checked)
                {
                    registryKey.SetValue("AntiIdol", Application.ExecutablePath);
                }
                else
                {
                    registryKey.DeleteValue("AntiIdol", false);
                }
            }
            if (!exit)
            {
                if (checkBoxHideApp.Checked)
                {
                    e.Cancel = true;
                    this.Hide();
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Do you want to hide this window to tray icon?", "Hide?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        e.Cancel = true;
                        this.Hide();
                    }
                    else if (dialogResult == DialogResult.Cancel)
                    {
                        e.Cancel = true;
                    }
                }
            }
        }

        private void timerAutoMouse_Tick(object sender, EventArgs e)
        {
            MoveCursor(sign * (int)numericUpDownPixelNo.Value);
            sign = -sign;
        }

        private void checkBoxTrayIcon_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTrayIcon.Checked)
            {
                notifyIconTray.Visible = false;
                comboBoxLeftClickTray.Enabled = false;
                //comboBoxMidClickTray.Enabled = false;
               // comboBoxRightClickTray.Enabled = false;
            }
            else
            {
                notifyIconTray.Visible = true;
                comboBoxLeftClickTray.Enabled = true;
                //comboBoxMidClickTray.Enabled = true;
                //comboBoxRightClickTray.Enabled = true;
            }
        }

        private void timerAutoKey_Tick(object sender, EventArgs e)
        {
            SendKey(comboBoxKey2Press.SelectedValue.ToString());
        }

        private void openAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NotifyIconClick(3);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exit = true;
            Application.Exit();
        }

        private void autoMouseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkBoxAutoMouse.Checked = !checkBoxAutoMouse.Checked;
        }

        private void autoKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkBoxAutoKey.Checked = !checkBoxAutoKey.Checked; 
        }
    }
    internal class NativeMethods
    {
        public const int HWND_BROADCAST = 0xffff;
        public static readonly int WM_SHOWMEAUTOMK = RegisterWindowMessage("WM_SHOWMEAUTOMK");

        [DllImport("user32")]
        public static extern bool PostMessage(IntPtr hwnd, int msg, IntPtr wparam, IntPtr lparam);
        [DllImport("user32")]
        public static extern int RegisterWindowMessage(string message);
    }
}
