using Newtonsoft.Json.Linq;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DiskMonitor
{
    public partial class DiskProgress : UserControl
    {
        private int threshold = 10;
        private JsonUtil jsonUtil = JsonUtil.GetSingleton();
        private MesBox mesBox = MesBox.GetSingleton();
        private DriveInfo driveInfo;

        public DiskProgress(DriveInfo driveInfo)
        {
            this.driveInfo = driveInfo;
            if (!jsonUtil.Contains(driveInfo.Name))
            {
                jsonUtil.SetAndSave(new JObject { { driveInfo.Name, threshold } });
            }
            InitializeComponent();
            DiskProgressLoad();
        }

        internal void DiskProgressLoad()
        {
            threshold = (int)jsonUtil.Get(driveInfo.Name);
            textBox_threshold.Text = threshold.ToString();

            int totalSize = KB2GB(driveInfo.TotalSize);
            int totalFreeSpace = KB2GB(driveInfo.TotalFreeSpace);
            int totalUsedSpace = totalSize - totalFreeSpace;

            label_name.Text = driveInfo.Name;
            label_fore.Width = (int)(totalUsedSpace * label_back.Width / totalSize);
            if (totalFreeSpace > threshold)
            {
                label_fore.BackColor = Color.Green;
            }
            else
            {
                label_fore.BackColor = Color.Red;
                mesBox.ShowMessage(driveInfo.Name);
            }
            label_free.Text = $"{totalUsedSpace}/{totalSize}GB";
        }        

        private void textBox_threshold_TextChanged(object sender, EventArgs e)
        {
            if (textBox_threshold.Text != string.Empty)
            {
                threshold = int.Parse(textBox_threshold.Text);
                jsonUtil.SetAndSave(new JObject { { driveInfo.Name, threshold } });
            }
        }
        private int KB2GB(long size)
        {
            return (int)(size / 1024 / 1024 / 1024);
        }
    }
}
