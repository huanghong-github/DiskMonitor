namespace DiskMonitor
{
    partial class DiskProgress
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label_name = new System.Windows.Forms.Label();
            this.label_back = new System.Windows.Forms.Label();
            this.label_fore = new System.Windows.Forms.Label();
            this.label_free = new System.Windows.Forms.Label();
            this.textBox_threshold = new System.Windows.Forms.TextBox();
            this.label_unit = new System.Windows.Forms.Label();
            this.label_threshold = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_name
            // 
            this.label_name.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_name.Location = new System.Drawing.Point(2, 3);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(50, 25);
            this.label_name.TabIndex = 0;
            // 
            // label_back
            // 
            this.label_back.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_back.Location = new System.Drawing.Point(60, 3);
            this.label_back.Name = "label_back";
            this.label_back.Size = new System.Drawing.Size(350, 25);
            this.label_back.TabIndex = 1;
            // 
            // label_fore
            // 
            this.label_fore.Location = new System.Drawing.Point(60, 3);
            this.label_fore.Name = "label_fore";
            this.label_fore.Size = new System.Drawing.Size(230, 25);
            this.label_fore.TabIndex = 2;
            // 
            // label_free
            // 
            this.label_free.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_free.Location = new System.Drawing.Point(420, 3);
            this.label_free.Name = "label_free";
            this.label_free.Size = new System.Drawing.Size(100, 25);
            this.label_free.TabIndex = 3;
            // 
            // label_threshold
            //             
            this.label_threshold.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_threshold.Location = new System.Drawing.Point(520, 3);
            this.label_threshold.Name = "label_threshold";
            this.label_threshold.Size = new System.Drawing.Size(50, 25);
            this.label_threshold.TabIndex = 4;
            this.label_threshold.Text = "阈值:";
            // 
            // textBox_threshold
            // 
            this.textBox_threshold.Location = new System.Drawing.Point(571, 0);
            this.textBox_threshold.Name = "textBox_threshold";
            this.textBox_threshold.Size = new System.Drawing.Size(55, 25);
            this.textBox_threshold.TabIndex = 5;
            this.textBox_threshold.TextChanged += new System.EventHandler(this.textBox_threshold_TextChanged);
            // 
            // label_unit
            // 
            this.label_unit.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_unit.Location = new System.Drawing.Point(633, 3);
            this.label_unit.Name = "label_unit";
            this.label_unit.Size = new System.Drawing.Size(40, 25);
            this.label_unit.TabIndex = 6;
            this.label_unit.Text = "GB";
            // 
            // DiskProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_threshold);
            this.Controls.Add(this.label_unit);
            this.Controls.Add(this.textBox_threshold);
            this.Controls.Add(this.label_free);
            this.Controls.Add(this.label_fore);
            this.Controls.Add(this.label_back);
            this.Controls.Add(this.label_name);
            this.Name = "DiskProgress";
            this.Size = new System.Drawing.Size(680, 30);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_back;
        private System.Windows.Forms.Label label_fore;
        private System.Windows.Forms.Label label_free;
        private System.Windows.Forms.TextBox textBox_threshold;
        private System.Windows.Forms.Label label_unit;
        private System.Windows.Forms.Label label_threshold;
    }
}
