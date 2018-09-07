namespace _13._7_TreeView_控件
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
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("节点4");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("节点5");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("节点6");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("节点0", new System.Windows.Forms.TreeNode[] {
            treeNode17,
            treeNode18,
            treeNode19});
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("节点7");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("节点8");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("节点9");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("节点1", new System.Windows.Forms.TreeNode[] {
            treeNode21,
            treeNode22,
            treeNode23});
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("节点10");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("节点11");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("节点12");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("节点2", new System.Windows.Forms.TreeNode[] {
            treeNode25,
            treeNode26,
            treeNode27});
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("节点13");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("节点14");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("节点15");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("节点3", new System.Windows.Forms.TreeNode[] {
            treeNode29,
            treeNode30,
            treeNode31});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.CheckBoxes = true;
            this.treeView1.Location = new System.Drawing.Point(65, 23);
            this.treeView1.Name = "treeView1";
            treeNode17.Name = "节点4";
            treeNode17.Text = "节点4";
            treeNode18.Name = "节点5";
            treeNode18.Text = "节点5";
            treeNode19.Name = "节点6";
            treeNode19.Text = "节点6";
            treeNode20.Name = "节点0";
            treeNode20.Text = "节点0";
            treeNode21.Name = "节点7";
            treeNode21.Text = "节点7";
            treeNode22.Name = "节点8";
            treeNode22.Text = "节点8";
            treeNode23.Name = "节点9";
            treeNode23.Text = "节点9";
            treeNode24.Name = "节点1";
            treeNode24.Text = "节点1";
            treeNode25.Name = "节点10";
            treeNode25.Text = "节点10";
            treeNode26.Name = "节点11";
            treeNode26.Text = "节点11";
            treeNode27.Name = "节点12";
            treeNode27.Text = "节点12";
            treeNode28.Name = "节点2";
            treeNode28.Text = "节点2";
            treeNode29.Name = "节点13";
            treeNode29.Text = "节点13";
            treeNode30.Name = "节点14";
            treeNode30.Text = "节点14";
            treeNode31.Name = "节点15";
            treeNode31.Text = "节点15";
            treeNode32.Name = "节点3";
            treeNode32.Text = "节点3";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode20,
            treeNode24,
            treeNode28,
            treeNode32});
            this.treeView1.Size = new System.Drawing.Size(121, 250);
            this.treeView1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(42, 303);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(166, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "添加根节点";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(254, 303);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "添加子节点";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(342, 303);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "删除选中节点";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 370);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

