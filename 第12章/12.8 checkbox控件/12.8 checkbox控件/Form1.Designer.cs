namespace _12._8_checkbox控件
{
    partial class Form1
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
            this.ctcbx = new System.Windows.Forms.CheckBox();
            this.xtcbx = new System.Windows.Forms.CheckBox();
            this.xhxcbx = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.editbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctcbx
            // 
            this.ctcbx.AutoSize = true;
            this.ctcbx.Location = new System.Drawing.Point(45, 122);
            this.ctcbx.Name = "ctcbx";
            this.ctcbx.Size = new System.Drawing.Size(48, 16);
            this.ctcbx.TabIndex = 0;
            this.ctcbx.Text = "粗体";
            this.ctcbx.UseVisualStyleBackColor = true;
            // 
            // xtcbx
            // 
            this.xtcbx.AutoSize = true;
            this.xtcbx.Location = new System.Drawing.Point(45, 162);
            this.xtcbx.Name = "xtcbx";
            this.xtcbx.Size = new System.Drawing.Size(48, 16);
            this.xtcbx.TabIndex = 1;
            this.xtcbx.Text = "斜体";
            this.xtcbx.UseVisualStyleBackColor = true;
            // 
            // xhxcbx
            // 
            this.xhxcbx.AutoSize = true;
            this.xhxcbx.Location = new System.Drawing.Point(45, 202);
            this.xhxcbx.Name = "xhxcbx";
            this.xhxcbx.Size = new System.Drawing.Size(60, 16);
            this.xhxcbx.TabIndex = 2;
            this.xhxcbx.Text = "下划线";
            this.xhxcbx.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "设置字型";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(45, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(199, 21);
            this.textBox1.TabIndex = 4;
            // 
            // editbtn
            // 
            this.editbtn.Location = new System.Drawing.Point(45, 226);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(75, 23);
            this.editbtn.TabIndex = 5;
            this.editbtn.Text = "修改";
            this.editbtn.UseVisualStyleBackColor = true;
            this.editbtn.Click += new System.EventHandler(this.editbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.editbtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.xhxcbx);
            this.Controls.Add(this.xtcbx);
            this.Controls.Add(this.ctcbx);
            this.Name = "Form1";
            this.Text = "设置字体字型";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ctcbx;
        private System.Windows.Forms.CheckBox xtcbx;
        private System.Windows.Forms.CheckBox xhxcbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button editbtn;
    }
}

