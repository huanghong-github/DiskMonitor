using System;
using System.Windows.Forms;

namespace DiskMonitor
{
    public partial class MesBox : Form
    {
        private static MesBox mesBox;
        public MesBox()
        {
            InitializeComponent();
        }

        internal static MesBox GetSingleton()
        {
            if (mesBox == null)
            {
                mesBox = new MesBox();
            }
            return mesBox;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            Hide();
        }

        internal void ShowMessage(string name)
        {
            label_warn.Text = $"{name}盘剩余空间不足";
            Show();
        }
    }
}
