using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiskMonitor
{
    internal class MesBox2
    {
        private static Semaphore sema = new Semaphore(1, 1);
        private static MesBox2 mesBox = new MesBox2();
        internal static MesBox2 GetSingleton()
        {
            return mesBox;
        }

        internal void Show(string name)
        {
            sema.WaitOne();
            Task.Run(() =>
            {
                MessageBox.Show($"{name}盘剩余空间不足", "磁盘监控提示", MessageBoxButtons.OK, MessageBoxIcon.Warning, defaultButton: MessageBoxDefaultButton.Button1, options: MessageBoxOptions.DefaultDesktopOnly);
                sema.Release();

            });
        }
    }
}
