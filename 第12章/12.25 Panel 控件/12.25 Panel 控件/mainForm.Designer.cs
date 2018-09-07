namespace _12._25_Panel_控件
{
    partial class mainForm
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.wgbtn = new System.Windows.Forms.Button();
            this.xzbtn = new System.Windows.Forms.Button();
            this.cgbtn = new System.Windows.Forms.Button();
            this.ycxzbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // wgbtn
            // 
            this.wgbtn.Location = new System.Drawing.Point(77, 219);
            this.wgbtn.Name = "wgbtn";
            this.wgbtn.Size = new System.Drawing.Size(75, 23);
            this.wgbtn.TabIndex = 0;
            this.wgbtn.Text = "外观";
            this.wgbtn.UseVisualStyleBackColor = true;
            // 
            // xzbtn
            // 
            this.xzbtn.Location = new System.Drawing.Point(77, 155);
            this.xzbtn.Name = "xzbtn";
            this.xzbtn.Size = new System.Drawing.Size(75, 23);
            this.xzbtn.TabIndex = 1;
            this.xzbtn.Text = "下载";
            this.xzbtn.UseVisualStyleBackColor = true;
            this.xzbtn.Click += new System.EventHandler(this.xzbtn_Click);
            // 
            // cgbtn
            // 
            this.cgbtn.Location = new System.Drawing.Point(77, 91);
            this.cgbtn.Name = "cgbtn";
            this.cgbtn.Size = new System.Drawing.Size(75, 23);
            this.cgbtn.TabIndex = 2;
            this.cgbtn.Text = "常规";
            this.cgbtn.UseVisualStyleBackColor = true;
            this.cgbtn.Click += new System.EventHandler(this.cgbtn_Click);
            // 
            // ycxzbtn
            // 
            this.ycxzbtn.Location = new System.Drawing.Point(77, 283);
            this.ycxzbtn.Name = "ycxzbtn";
            this.ycxzbtn.Size = new System.Drawing.Size(75, 23);
            this.ycxzbtn.TabIndex = 3;
            this.ycxzbtn.Text = "远程下载";
            this.ycxzbtn.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(158, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 215);
            this.panel1.TabIndex = 4;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 381);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ycxzbtn);
            this.Controls.Add(this.cgbtn);
            this.Controls.Add(this.xzbtn);
            this.Controls.Add(this.wgbtn);
            this.Name = "mainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button wgbtn;
        private System.Windows.Forms.Button xzbtn;
        private System.Windows.Forms.Button cgbtn;
        private System.Windows.Forms.Button ycxzbtn;
        private System.Windows.Forms.Panel panel1;

    }
}

