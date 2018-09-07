namespace _12._3_RichTextBox控件
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bluebtn = new System.Windows.Forms.Button();
            this.redbtn = new System.Windows.Forms.Button();
            this.ls18btn = new System.Windows.Forms.Button();
            this.itembtn = new System.Windows.Forms.Button();
            this.diwenbtn = new System.Windows.Forms.Button();
            this.restbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.richTextBox1.Location = new System.Drawing.Point(12, 58);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(424, 318);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(146, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "文本输入区";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F);
            this.label2.Location = new System.Drawing.Point(470, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "操作区";
            // 
            // bluebtn
            // 
            this.bluebtn.Location = new System.Drawing.Point(473, 81);
            this.bluebtn.Name = "bluebtn";
            this.bluebtn.Size = new System.Drawing.Size(75, 23);
            this.bluebtn.TabIndex = 2;
            this.bluebtn.Text = "蓝色";
            this.bluebtn.UseVisualStyleBackColor = true;
            this.bluebtn.Click += new System.EventHandler(this.bluebtn_Click);
            // 
            // redbtn
            // 
            this.redbtn.Location = new System.Drawing.Point(473, 135);
            this.redbtn.Name = "redbtn";
            this.redbtn.Size = new System.Drawing.Size(75, 23);
            this.redbtn.TabIndex = 2;
            this.redbtn.Text = "红色";
            this.redbtn.UseVisualStyleBackColor = true;
            this.redbtn.Click += new System.EventHandler(this.redbtn_Click);
            // 
            // ls18btn
            // 
            this.ls18btn.Location = new System.Drawing.Point(473, 189);
            this.ls18btn.Name = "ls18btn";
            this.ls18btn.Size = new System.Drawing.Size(75, 23);
            this.ls18btn.TabIndex = 2;
            this.ls18btn.Text = "隶书 18";
            this.ls18btn.UseVisualStyleBackColor = true;
            this.ls18btn.Click += new System.EventHandler(this.ls18btn_Click);
            // 
            // itembtn
            // 
            this.itembtn.Location = new System.Drawing.Point(473, 243);
            this.itembtn.Name = "itembtn";
            this.itembtn.Size = new System.Drawing.Size(75, 23);
            this.itembtn.TabIndex = 2;
            this.itembtn.Text = "项目符号";
            this.itembtn.UseVisualStyleBackColor = true;
            this.itembtn.Click += new System.EventHandler(this.itembtn_Click);
            // 
            // diwenbtn
            // 
            this.diwenbtn.Location = new System.Drawing.Point(473, 297);
            this.diwenbtn.Name = "diwenbtn";
            this.diwenbtn.Size = new System.Drawing.Size(75, 23);
            this.diwenbtn.TabIndex = 2;
            this.diwenbtn.Text = "底纹";
            this.diwenbtn.UseVisualStyleBackColor = true;
            this.diwenbtn.Click += new System.EventHandler(this.diwenbtn_Click);
            // 
            // restbtn
            // 
            this.restbtn.Location = new System.Drawing.Point(473, 351);
            this.restbtn.Name = "restbtn";
            this.restbtn.Size = new System.Drawing.Size(75, 23);
            this.restbtn.TabIndex = 2;
            this.restbtn.Text = "复原";
            this.restbtn.UseVisualStyleBackColor = true;
            this.restbtn.Click += new System.EventHandler(this.restbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 388);
            this.Controls.Add(this.restbtn);
            this.Controls.Add(this.diwenbtn);
            this.Controls.Add(this.itembtn);
            this.Controls.Add(this.ls18btn);
            this.Controls.Add(this.redbtn);
            this.Controls.Add(this.bluebtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "RechiTexBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bluebtn;
        private System.Windows.Forms.Button redbtn;
        private System.Windows.Forms.Button ls18btn;
        private System.Windows.Forms.Button itembtn;
        private System.Windows.Forms.Button diwenbtn;
        private System.Windows.Forms.Button restbtn;
    }
}

