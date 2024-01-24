namespace DiskMonitor
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_interval = new System.Windows.Forms.TextBox();
            this.label_interval = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.label_unit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(-2, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(701, 211);
            this.panel1.TabIndex = 0;
            // 
            // textBox_interval
            // 
            this.textBox_interval.Location = new System.Drawing.Point(304, 249);
            this.textBox_interval.Name = "textBox_interval";
            this.textBox_interval.Size = new System.Drawing.Size(94, 25);
            this.textBox_interval.TabIndex = 1;
            this.textBox_interval.TextChanged += new System.EventHandler(this.textBox_interval_TextChanged);
            // 
            // label_interval
            // 
            this.label_interval.AutoSize = true;
            this.label_interval.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_interval.Location = new System.Drawing.Point(223, 253);
            this.label_interval.Name = "label_interval";
            this.label_interval.Size = new System.Drawing.Size(73, 20);
            this.label_interval.TabIndex = 2;
            this.label_interval.Text = "时间间隔:";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.notifyIcon1.Text = "磁盘监控";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon1_MouseClick);
            // 
            // label_unit
            // 
            this.label_unit.AutoSize = true;
            this.label_unit.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_unit.Location = new System.Drawing.Point(401, 253);
            this.label_unit.Name = "label_unit";
            this.label_unit.Size = new System.Drawing.Size(39, 20);
            this.label_unit.TabIndex = 3;
            this.label_unit.Text = "分钟";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 304);
            this.Controls.Add(this.label_unit);
            this.Controls.Add(this.label_interval);
            this.Controls.Add(this.textBox_interval);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "磁盘监控";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_interval;
        private System.Windows.Forms.Label label_interval;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label label_unit;
    }
}

