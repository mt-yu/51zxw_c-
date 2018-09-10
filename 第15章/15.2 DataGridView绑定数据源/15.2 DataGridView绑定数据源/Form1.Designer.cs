namespace _15._2_DataGridView绑定数据源
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvBindMode = new System.Windows.Forms.DataGridView();
            this.dgvNonBindMode = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBindMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNonBindMode)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "绑定模式";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(453, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "非绑定模式";
            // 
            // dgvBindMode
            // 
            this.dgvBindMode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBindMode.Location = new System.Drawing.Point(3, 97);
            this.dgvBindMode.Name = "dgvBindMode";
            this.dgvBindMode.RowTemplate.Height = 23;
            this.dgvBindMode.Size = new System.Drawing.Size(331, 150);
            this.dgvBindMode.TabIndex = 2;
            // 
            // dgvNonBindMode
            // 
            this.dgvNonBindMode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNonBindMode.Location = new System.Drawing.Point(392, 97);
            this.dgvNonBindMode.Name = "dgvNonBindMode";
            this.dgvNonBindMode.RowTemplate.Height = 23;
            this.dgvNonBindMode.Size = new System.Drawing.Size(331, 150);
            this.dgvNonBindMode.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 434);
            this.Controls.Add(this.dgvNonBindMode);
            this.Controls.Add(this.dgvBindMode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBindMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNonBindMode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvBindMode;
        private System.Windows.Forms.DataGridView dgvNonBindMode;
    }
}

