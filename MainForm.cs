using Microsoft.Win32;
using Newtonsoft.Json.Linq;
using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiskMonitor
{
    public partial class MainForm : Form
    {
        private DriveInfo[] allDirves = DriveInfo.GetDrives();
        private JsonUtil jsonUtil = JsonUtil.GetSingleton(Path.GetDirectoryName(Application.ExecutablePath));
        private volatile int interval = 10;
        private const string intervalName = "interval";
        public MainForm()
        {
            if (!jsonUtil.Contains(intervalName))
            {
                jsonUtil.SetAndSave(new JObject { { intervalName, interval } });
            }
            InitializeComponent();
            Hide();
            WindowState = FormWindowState.Minimized;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey
                (@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
            registryKey.SetValue("DiskMonitor", Application.ExecutablePath);

            interval = (int)jsonUtil.Get(intervalName);
            textBox_interval.Text = interval.ToString();

            AddControlsToPanel();

            Action action = () => { foreach (DiskProgress control in panel1.Controls) { control.DiskProgressLoad(); } };
            Task.Run(() =>
            {
                while (true)
                {
                    Thread.Sleep(1000 * 60 * interval);
                    panel1.Invoke(action);
                }
            });
        }

        private void AddControlsToPanel()
        {
            panel1.Controls.Clear();
            for (int i = 0; i < allDirves.Length; i++)
            {
                DriveInfo driveInfo = allDirves[i];
                int x = 20;
                int y = i * 45;

                panel1.Controls.Add(new DiskProgress(driveInfo) { Location = new Point(x, y) });
            }
        }

        private void textBox_interval_TextChanged(object sender, EventArgs e)
        {
            if (textBox_interval.Text != string.Empty)
            {
                interval = int.Parse(textBox_interval.Text);
                jsonUtil.SetAndSave(new JObject { { intervalName, interval } });
            }
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                Show();
                notifyIcon1.Visible = false;
            }
            else if (WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon1.Visible = true;
            }
        }

        private void NotifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }
    }
}
