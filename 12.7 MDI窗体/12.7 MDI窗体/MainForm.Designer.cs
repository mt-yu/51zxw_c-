namespace _12._7_MDI窗体
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.新建ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.层叠cToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.水平HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.垂直ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关闭ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建ToolStripMenuItem,
            this.层叠cToolStripMenuItem,
            this.水平HToolStripMenuItem,
            this.垂直ToolStripMenuItem,
            this.关闭ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 新建ToolStripMenuItem
            // 
            this.新建ToolStripMenuItem.Name = "新建ToolStripMenuItem";
            this.新建ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.新建ToolStripMenuItem.Text = "新建";
            this.新建ToolStripMenuItem.Click += new System.EventHandler(this.新建ToolStripMenuItem_Click);
            // 
            // 层叠cToolStripMenuItem
            // 
            this.层叠cToolStripMenuItem.Name = "层叠cToolStripMenuItem";
            this.层叠cToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.层叠cToolStripMenuItem.Text = "层叠";
            this.层叠cToolStripMenuItem.Click += new System.EventHandler(this.层叠cToolStripMenuItem_Click);
            // 
            // 水平HToolStripMenuItem
            // 
            this.水平HToolStripMenuItem.Name = "水平HToolStripMenuItem";
            this.水平HToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.水平HToolStripMenuItem.Text = "水平";
            this.水平HToolStripMenuItem.Click += new System.EventHandler(this.水平HToolStripMenuItem_Click);
            // 
            // 垂直ToolStripMenuItem
            // 
            this.垂直ToolStripMenuItem.Name = "垂直ToolStripMenuItem";
            this.垂直ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.垂直ToolStripMenuItem.Text = "垂直";
            this.垂直ToolStripMenuItem.Click += new System.EventHandler(this.垂直ToolStripMenuItem_Click);
            // 
            // 关闭ToolStripMenuItem
            // 
            this.关闭ToolStripMenuItem.Name = "关闭ToolStripMenuItem";
            this.关闭ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.关闭ToolStripMenuItem.Text = "关闭";
            this.关闭ToolStripMenuItem.Click += new System.EventHandler(this.关闭ToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MDI窗体";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 新建ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 层叠cToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 水平HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 垂直ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关闭ToolStripMenuItem;
    }
}

