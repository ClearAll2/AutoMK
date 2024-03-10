using System.Windows.Forms;

namespace AutoMK
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageMain = new System.Windows.Forms.TabPage();
            this.groupBoxAutoKey = new System.Windows.Forms.GroupBox();
            this.comboBoxKey2Press = new System.Windows.Forms.ComboBox();
            this.numericUpDownIntervalAK = new System.Windows.Forms.NumericUpDown();
            this.labelIntervalAK = new System.Windows.Forms.Label();
            this.labelKey2Press = new System.Windows.Forms.Label();
            this.labelIntructAK = new System.Windows.Forms.Label();
            this.checkBoxAutoKey = new System.Windows.Forms.CheckBox();
            this.groupBoxAutoMouse = new System.Windows.Forms.GroupBox();
            this.numericUpDownIntervalAM = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPixelNo = new System.Windows.Forms.NumericUpDown();
            this.labelIntervalAM = new System.Windows.Forms.Label();
            this.labelPixelMove = new System.Windows.Forms.Label();
            this.labelIntructAM = new System.Windows.Forms.Label();
            this.checkBoxAutoMouse = new System.Windows.Forms.CheckBox();
            this.tabPageSetting = new System.Windows.Forms.TabPage();
            this.groupBoxSettings = new System.Windows.Forms.GroupBox();
            this.checkBoxHideApp = new System.Windows.Forms.CheckBox();
            this.checkBoxRunAtStartup = new System.Windows.Forms.CheckBox();
            this.groupBoxTrayOption = new System.Windows.Forms.GroupBox();
            this.labelIntructTrayIcon = new System.Windows.Forms.Label();
            this.comboBoxLeftClickTray = new System.Windows.Forms.ComboBox();
            this.labelLeftClickTray = new System.Windows.Forms.Label();
            this.checkBoxTrayIcon = new System.Windows.Forms.CheckBox();
            this.tabPageAbout = new System.Windows.Forms.TabPage();
            this.labelCredit = new System.Windows.Forms.Label();
            this.labelCompanyName = new System.Windows.Forms.Label();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelProductName = new System.Windows.Forms.Label();
            this.notifyIconTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoMouseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerAutoKey = new System.Windows.Forms.Timer(this.components);
            this.timerAutoMouse = new System.Windows.Forms.Timer(this.components);
            this.tabControlMain.SuspendLayout();
            this.tabPageMain.SuspendLayout();
            this.groupBoxAutoKey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIntervalAK)).BeginInit();
            this.groupBoxAutoMouse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIntervalAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPixelNo)).BeginInit();
            this.tabPageSetting.SuspendLayout();
            this.groupBoxSettings.SuspendLayout();
            this.groupBoxTrayOption.SuspendLayout();
            this.tabPageAbout.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageMain);
            this.tabControlMain.Controls.Add(this.tabPageSetting);
            this.tabControlMain.Controls.Add(this.tabPageAbout);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(737, 358);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageMain
            // 
            this.tabPageMain.Controls.Add(this.groupBoxAutoKey);
            this.tabPageMain.Controls.Add(this.groupBoxAutoMouse);
            this.tabPageMain.Location = new System.Drawing.Point(4, 26);
            this.tabPageMain.Name = "tabPageMain";
            this.tabPageMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMain.Size = new System.Drawing.Size(729, 328);
            this.tabPageMain.TabIndex = 0;
            this.tabPageMain.Text = "AutoMK";
            this.tabPageMain.UseVisualStyleBackColor = true;
            // 
            // groupBoxAutoKey
            // 
            this.groupBoxAutoKey.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBoxAutoKey.Controls.Add(this.comboBoxKey2Press);
            this.groupBoxAutoKey.Controls.Add(this.numericUpDownIntervalAK);
            this.groupBoxAutoKey.Controls.Add(this.labelIntervalAK);
            this.groupBoxAutoKey.Controls.Add(this.labelKey2Press);
            this.groupBoxAutoKey.Controls.Add(this.labelIntructAK);
            this.groupBoxAutoKey.Controls.Add(this.checkBoxAutoKey);
            this.groupBoxAutoKey.Location = new System.Drawing.Point(365, 6);
            this.groupBoxAutoKey.Name = "groupBoxAutoKey";
            this.groupBoxAutoKey.Size = new System.Drawing.Size(356, 314);
            this.groupBoxAutoKey.TabIndex = 1;
            this.groupBoxAutoKey.TabStop = false;
            this.groupBoxAutoKey.Text = "Auto Key";
            // 
            // comboBoxKey2Press
            // 
            this.comboBoxKey2Press.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKey2Press.FormattingEnabled = true;
            this.comboBoxKey2Press.Location = new System.Drawing.Point(172, 231);
            this.comboBoxKey2Press.Name = "comboBoxKey2Press";
            this.comboBoxKey2Press.Size = new System.Drawing.Size(151, 25);
            this.comboBoxKey2Press.TabIndex = 8;
            // 
            // numericUpDownIntervalAK
            // 
            this.numericUpDownIntervalAK.Location = new System.Drawing.Point(234, 270);
            this.numericUpDownIntervalAK.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDownIntervalAK.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownIntervalAK.Name = "numericUpDownIntervalAK";
            this.numericUpDownIntervalAK.Size = new System.Drawing.Size(89, 25);
            this.numericUpDownIntervalAK.TabIndex = 6;
            this.numericUpDownIntervalAK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownIntervalAK.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // labelIntervalAK
            // 
            this.labelIntervalAK.AutoSize = true;
            this.labelIntervalAK.Location = new System.Drawing.Point(27, 272);
            this.labelIntervalAK.Name = "labelIntervalAK";
            this.labelIntervalAK.Size = new System.Drawing.Size(160, 17);
            this.labelIntervalAK.TabIndex = 7;
            this.labelIntervalAK.Text = "Press key every (seconds):";
            // 
            // labelKey2Press
            // 
            this.labelKey2Press.AutoSize = true;
            this.labelKey2Press.Location = new System.Drawing.Point(27, 234);
            this.labelKey2Press.Name = "labelKey2Press";
            this.labelKey2Press.Size = new System.Drawing.Size(84, 17);
            this.labelKey2Press.TabIndex = 6;
            this.labelKey2Press.Text = "Key to press:";
            // 
            // labelIntructAK
            // 
            this.labelIntructAK.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelIntructAK.Location = new System.Drawing.Point(27, 60);
            this.labelIntructAK.Name = "labelIntructAK";
            this.labelIntructAK.Size = new System.Drawing.Size(296, 159);
            this.labelIntructAK.TabIndex = 6;
            this.labelIntructAK.Text = "When enabled, this service will simulate a periodical user input by automatically" +
    " pressing a key.";
            // 
            // checkBoxAutoKey
            // 
            this.checkBoxAutoKey.AutoSize = true;
            this.checkBoxAutoKey.Location = new System.Drawing.Point(27, 36);
            this.checkBoxAutoKey.Name = "checkBoxAutoKey";
            this.checkBoxAutoKey.Size = new System.Drawing.Size(110, 21);
            this.checkBoxAutoKey.TabIndex = 6;
            this.checkBoxAutoKey.Text = "Enable service";
            this.checkBoxAutoKey.UseVisualStyleBackColor = true;
            this.checkBoxAutoKey.CheckedChanged += new System.EventHandler(this.checkBoxAutoKey_CheckedChanged);
            // 
            // groupBoxAutoMouse
            // 
            this.groupBoxAutoMouse.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBoxAutoMouse.Controls.Add(this.numericUpDownIntervalAM);
            this.groupBoxAutoMouse.Controls.Add(this.numericUpDownPixelNo);
            this.groupBoxAutoMouse.Controls.Add(this.labelIntervalAM);
            this.groupBoxAutoMouse.Controls.Add(this.labelPixelMove);
            this.groupBoxAutoMouse.Controls.Add(this.labelIntructAM);
            this.groupBoxAutoMouse.Controls.Add(this.checkBoxAutoMouse);
            this.groupBoxAutoMouse.Location = new System.Drawing.Point(8, 6);
            this.groupBoxAutoMouse.Name = "groupBoxAutoMouse";
            this.groupBoxAutoMouse.Size = new System.Drawing.Size(351, 314);
            this.groupBoxAutoMouse.TabIndex = 0;
            this.groupBoxAutoMouse.TabStop = false;
            this.groupBoxAutoMouse.Text = "Auto Mouse";
            // 
            // numericUpDownIntervalAM
            // 
            this.numericUpDownIntervalAM.Location = new System.Drawing.Point(234, 270);
            this.numericUpDownIntervalAM.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDownIntervalAM.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownIntervalAM.Name = "numericUpDownIntervalAM";
            this.numericUpDownIntervalAM.Size = new System.Drawing.Size(89, 25);
            this.numericUpDownIntervalAM.TabIndex = 5;
            this.numericUpDownIntervalAM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownIntervalAM.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // numericUpDownPixelNo
            // 
            this.numericUpDownPixelNo.Location = new System.Drawing.Point(234, 232);
            this.numericUpDownPixelNo.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownPixelNo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPixelNo.Name = "numericUpDownPixelNo";
            this.numericUpDownPixelNo.Size = new System.Drawing.Size(89, 25);
            this.numericUpDownPixelNo.TabIndex = 4;
            this.numericUpDownPixelNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownPixelNo.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // labelIntervalAM
            // 
            this.labelIntervalAM.AutoSize = true;
            this.labelIntervalAM.Location = new System.Drawing.Point(27, 272);
            this.labelIntervalAM.Name = "labelIntervalAM";
            this.labelIntervalAM.Size = new System.Drawing.Size(182, 17);
            this.labelIntervalAM.TabIndex = 3;
            this.labelIntervalAM.Text = "Move mouse every (seconds):";
            // 
            // labelPixelMove
            // 
            this.labelPixelMove.AutoSize = true;
            this.labelPixelMove.Location = new System.Drawing.Point(27, 234);
            this.labelPixelMove.Name = "labelPixelMove";
            this.labelPixelMove.Size = new System.Drawing.Size(201, 17);
            this.labelPixelMove.TabIndex = 2;
            this.labelPixelMove.Text = "Number of pixel to move mouse:";
            // 
            // labelIntructAM
            // 
            this.labelIntructAM.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelIntructAM.Location = new System.Drawing.Point(27, 60);
            this.labelIntructAM.Name = "labelIntructAM";
            this.labelIntructAM.Size = new System.Drawing.Size(296, 159);
            this.labelIntructAM.TabIndex = 1;
            this.labelIntructAM.Text = resources.GetString("labelIntructAM.Text");
            this.labelIntructAM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkBoxAutoMouse
            // 
            this.checkBoxAutoMouse.AutoSize = true;
            this.checkBoxAutoMouse.Location = new System.Drawing.Point(27, 36);
            this.checkBoxAutoMouse.Name = "checkBoxAutoMouse";
            this.checkBoxAutoMouse.Size = new System.Drawing.Size(110, 21);
            this.checkBoxAutoMouse.TabIndex = 0;
            this.checkBoxAutoMouse.Text = "Enable service";
            this.checkBoxAutoMouse.UseVisualStyleBackColor = true;
            this.checkBoxAutoMouse.CheckedChanged += new System.EventHandler(this.checkBoxAutoMouse_CheckedChanged);
            // 
            // tabPageSetting
            // 
            this.tabPageSetting.Controls.Add(this.groupBoxSettings);
            this.tabPageSetting.Controls.Add(this.groupBoxTrayOption);
            this.tabPageSetting.Location = new System.Drawing.Point(4, 26);
            this.tabPageSetting.Name = "tabPageSetting";
            this.tabPageSetting.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSetting.Size = new System.Drawing.Size(729, 328);
            this.tabPageSetting.TabIndex = 1;
            this.tabPageSetting.Text = "Settings";
            this.tabPageSetting.UseVisualStyleBackColor = true;
            // 
            // groupBoxSettings
            // 
            this.groupBoxSettings.Controls.Add(this.checkBoxHideApp);
            this.groupBoxSettings.Controls.Add(this.checkBoxRunAtStartup);
            this.groupBoxSettings.Location = new System.Drawing.Point(438, 6);
            this.groupBoxSettings.Name = "groupBoxSettings";
            this.groupBoxSettings.Size = new System.Drawing.Size(285, 314);
            this.groupBoxSettings.TabIndex = 1;
            this.groupBoxSettings.TabStop = false;
            this.groupBoxSettings.Text = "Settings";
            // 
            // checkBoxHideApp
            // 
            this.checkBoxHideApp.AutoEllipsis = true;
            this.checkBoxHideApp.Location = new System.Drawing.Point(27, 63);
            this.checkBoxHideApp.Name = "checkBoxHideApp";
            this.checkBoxHideApp.Size = new System.Drawing.Size(238, 43);
            this.checkBoxHideApp.TabIndex = 2;
            this.checkBoxHideApp.Text = "Close button should always minimize AutoMK to the tray icon";
            this.checkBoxHideApp.UseVisualStyleBackColor = true;
            // 
            // checkBoxRunAtStartup
            // 
            this.checkBoxRunAtStartup.AutoSize = true;
            this.checkBoxRunAtStartup.Location = new System.Drawing.Point(27, 36);
            this.checkBoxRunAtStartup.Name = "checkBoxRunAtStartup";
            this.checkBoxRunAtStartup.Size = new System.Drawing.Size(166, 21);
            this.checkBoxRunAtStartup.TabIndex = 1;
            this.checkBoxRunAtStartup.Text = "Run at Windows startup";
            this.checkBoxRunAtStartup.UseVisualStyleBackColor = true;
            // 
            // groupBoxTrayOption
            // 
            this.groupBoxTrayOption.Controls.Add(this.labelIntructTrayIcon);
            this.groupBoxTrayOption.Controls.Add(this.comboBoxLeftClickTray);
            this.groupBoxTrayOption.Controls.Add(this.labelLeftClickTray);
            this.groupBoxTrayOption.Controls.Add(this.checkBoxTrayIcon);
            this.groupBoxTrayOption.Location = new System.Drawing.Point(8, 6);
            this.groupBoxTrayOption.Name = "groupBoxTrayOption";
            this.groupBoxTrayOption.Size = new System.Drawing.Size(424, 316);
            this.groupBoxTrayOption.TabIndex = 0;
            this.groupBoxTrayOption.TabStop = false;
            this.groupBoxTrayOption.Text = "Tray Icon Option";
            // 
            // labelIntructTrayIcon
            // 
            this.labelIntructTrayIcon.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelIntructTrayIcon.Location = new System.Drawing.Point(27, 60);
            this.labelIntructTrayIcon.Name = "labelIntructTrayIcon";
            this.labelIntructTrayIcon.Size = new System.Drawing.Size(359, 101);
            this.labelIntructTrayIcon.TabIndex = 7;
            this.labelIntructTrayIcon.Text = "Tray icon can indicate services that AutoMK is runnings.\r\nIf you hide tray icon a" +
    "nd hide app, just open app again.\r\n\r\nYou can also set actions when clicking on t" +
    "ray icon.";
            // 
            // comboBoxLeftClickTray
            // 
            this.comboBoxLeftClickTray.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLeftClickTray.FormattingEnabled = true;
            this.comboBoxLeftClickTray.Location = new System.Drawing.Point(245, 177);
            this.comboBoxLeftClickTray.Name = "comboBoxLeftClickTray";
            this.comboBoxLeftClickTray.Size = new System.Drawing.Size(141, 25);
            this.comboBoxLeftClickTray.TabIndex = 4;
            // 
            // labelLeftClickTray
            // 
            this.labelLeftClickTray.AutoSize = true;
            this.labelLeftClickTray.Location = new System.Drawing.Point(24, 180);
            this.labelLeftClickTray.Name = "labelLeftClickTray";
            this.labelLeftClickTray.Size = new System.Drawing.Size(154, 17);
            this.labelLeftClickTray.TabIndex = 1;
            this.labelLeftClickTray.Text = "Left-click tray icon action:";
            // 
            // checkBoxTrayIcon
            // 
            this.checkBoxTrayIcon.AutoSize = true;
            this.checkBoxTrayIcon.Location = new System.Drawing.Point(27, 36);
            this.checkBoxTrayIcon.Name = "checkBoxTrayIcon";
            this.checkBoxTrayIcon.Size = new System.Drawing.Size(108, 21);
            this.checkBoxTrayIcon.TabIndex = 0;
            this.checkBoxTrayIcon.Text = "Hide tray icon";
            this.checkBoxTrayIcon.UseVisualStyleBackColor = true;
            this.checkBoxTrayIcon.CheckedChanged += new System.EventHandler(this.checkBoxTrayIcon_CheckedChanged);
            // 
            // tabPageAbout
            // 
            this.tabPageAbout.Controls.Add(this.labelCredit);
            this.tabPageAbout.Controls.Add(this.labelCompanyName);
            this.tabPageAbout.Controls.Add(this.labelCopyright);
            this.tabPageAbout.Controls.Add(this.labelVersion);
            this.tabPageAbout.Controls.Add(this.labelProductName);
            this.tabPageAbout.Location = new System.Drawing.Point(4, 26);
            this.tabPageAbout.Name = "tabPageAbout";
            this.tabPageAbout.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAbout.Size = new System.Drawing.Size(729, 328);
            this.tabPageAbout.TabIndex = 2;
            this.tabPageAbout.Text = "About";
            this.tabPageAbout.UseVisualStyleBackColor = true;
            // 
            // labelCredit
            // 
            this.labelCredit.Location = new System.Drawing.Point(208, 159);
            this.labelCredit.Name = "labelCredit";
            this.labelCredit.Size = new System.Drawing.Size(312, 132);
            this.labelCredit.TabIndex = 32;
            this.labelCredit.Text = "Icons made by Freepik from Flaticon.\r\nhttps://www.flaticon.com/authors/freepik\r\n\r" +
    "\nThis app is made possible by auto_mouse_mover project of ebellocchia.\r\nhttps://" +
    "github.com/ebellocchia/auto_mouse_mover";
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.AutoSize = true;
            this.labelCompanyName.Location = new System.Drawing.Point(208, 121);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new System.Drawing.Size(63, 17);
            this.labelCompanyName.TabIndex = 31;
            this.labelCompanyName.Text = "Company";
            // 
            // labelCopyright
            // 
            this.labelCopyright.AutoSize = true;
            this.labelCopyright.Location = new System.Drawing.Point(208, 92);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(65, 17);
            this.labelCopyright.TabIndex = 30;
            this.labelCopyright.Text = "Copyright";
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(208, 65);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(51, 17);
            this.labelVersion.TabIndex = 29;
            this.labelVersion.Text = "Version";
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Location = new System.Drawing.Point(208, 38);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(92, 17);
            this.labelProductName.TabIndex = 28;
            this.labelProductName.Text = "Product Name";
            // 
            // notifyIconTray
            // 
            this.notifyIconTray.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIconTray.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconTray.Icon")));
            this.notifyIconTray.Text = "Idol/Idle";
            this.notifyIconTray.Visible = true;
            this.notifyIconTray.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIconTray_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openAppToolStripMenuItem,
            this.autoKeyToolStripMenuItem,
            this.autoMouseToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(140, 92);
            // 
            // openAppToolStripMenuItem
            // 
            this.openAppToolStripMenuItem.Name = "openAppToolStripMenuItem";
            this.openAppToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.openAppToolStripMenuItem.Text = "Open app";
            this.openAppToolStripMenuItem.Click += new System.EventHandler(this.openAppToolStripMenuItem_Click);
            // 
            // autoKeyToolStripMenuItem
            // 
            this.autoKeyToolStripMenuItem.Name = "autoKeyToolStripMenuItem";
            this.autoKeyToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.autoKeyToolStripMenuItem.Text = "Auto Key";
            this.autoKeyToolStripMenuItem.Click += new System.EventHandler(this.autoKeyToolStripMenuItem_Click);
            // 
            // autoMouseToolStripMenuItem
            // 
            this.autoMouseToolStripMenuItem.Name = "autoMouseToolStripMenuItem";
            this.autoMouseToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.autoMouseToolStripMenuItem.Text = "Auto Mouse";
            this.autoMouseToolStripMenuItem.Click += new System.EventHandler(this.autoMouseToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // timerAutoKey
            // 
            this.timerAutoKey.Tick += new System.EventHandler(this.timerAutoKey_Tick);
            // 
            // timerAutoMouse
            // 
            this.timerAutoMouse.Tick += new System.EventHandler(this.timerAutoMouse_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(737, 358);
            this.Controls.Add(this.tabControlMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoMK";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageMain.ResumeLayout(false);
            this.groupBoxAutoKey.ResumeLayout(false);
            this.groupBoxAutoKey.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIntervalAK)).EndInit();
            this.groupBoxAutoMouse.ResumeLayout(false);
            this.groupBoxAutoMouse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIntervalAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPixelNo)).EndInit();
            this.tabPageSetting.ResumeLayout(false);
            this.groupBoxSettings.ResumeLayout(false);
            this.groupBoxSettings.PerformLayout();
            this.groupBoxTrayOption.ResumeLayout(false);
            this.groupBoxTrayOption.PerformLayout();
            this.tabPageAbout.ResumeLayout(false);
            this.tabPageAbout.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControlMain;
        private TabPage tabPageMain;
        private TabPage tabPageSetting;
        private TabPage tabPageAbout;
        private GroupBox groupBoxAutoKey;
        private GroupBox groupBoxAutoMouse;
        private NumericUpDown numericUpDownIntervalAM;
        private NumericUpDown numericUpDownPixelNo;
        private Label labelIntervalAM;
        private Label labelPixelMove;
        private Label labelIntructAM;
        private CheckBox checkBoxAutoMouse;
        private ComboBox comboBoxKey2Press;
        private NumericUpDown numericUpDownIntervalAK;
        private Label labelIntervalAK;
        private Label labelKey2Press;
        private Label labelIntructAK;
        private CheckBox checkBoxAutoKey;
        private NotifyIcon notifyIconTray;
        private System.Windows.Forms.Timer timerAutoKey;
        private System.Windows.Forms.Timer timerAutoMouse;
        private GroupBox groupBoxTrayOption;
        private Label labelLeftClickTray;
        private CheckBox checkBoxTrayIcon;
        private Label labelIntructTrayIcon;
        private ComboBox comboBoxLeftClickTray;
        private GroupBox groupBoxSettings;
        private CheckBox checkBoxRunAtStartup;
        private Label labelCredit;
        private Label labelCompanyName;
        private Label labelCopyright;
        private Label labelVersion;
        private Label labelProductName;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem openAppToolStripMenuItem;
        private ToolStripMenuItem autoKeyToolStripMenuItem;
        private ToolStripMenuItem autoMouseToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private CheckBox checkBoxHideApp;
    }
}