using System.Drawing;

namespace DiskMonitor
{
    partial class MesBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MesBox));
            this.pictureBox_warn = new System.Windows.Forms.PictureBox();
            this.label_warn = new System.Windows.Forms.Label();
            this.button_ok = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_warn)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_warn
            // 
            this.pictureBox_warn.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_warn.Image")));
            this.pictureBox_warn.Location = new System.Drawing.Point(40, 36);
            this.pictureBox_warn.Name = "pictureBox_warn";
            this.pictureBox_warn.Size = new System.Drawing.Size(61, 60);
            this.pictureBox_warn.TabIndex = 0;
            this.pictureBox_warn.TabStop = false;
            // 
            // label_warn
            // 
            this.label_warn.AutoSize = true;
            this.label_warn.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_warn.ForeColor = System.Drawing.Color.Orange;
            this.label_warn.Location = new System.Drawing.Point(123, 45);
            this.label_warn.Name = "label_warn";
            this.label_warn.Size = new System.Drawing.Size(65, 25);
            this.label_warn.TabIndex = 1;
            this.label_warn.Text = "label1";
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(140, 100);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(100, 30);
            this.button_ok.TabIndex = 2;
            this.button_ok.Text = "确认";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // MesBox
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 160);
            this.ControlBox = false;
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.label_warn);
            this.Controls.Add(this.pictureBox_warn);
            this.Name = "MesBox";
            this.Text = "磁盘监控告警";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_warn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_warn;
        private System.Windows.Forms.Label label_warn;
        private System.Windows.Forms.Button button_ok;
    }
}