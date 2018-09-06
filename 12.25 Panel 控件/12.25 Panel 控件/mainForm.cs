using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12._25_Panel_控件
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void cgbtn_Click(object sender, EventArgs e)
        {
            cgfrom mycgform = new cgfrom();
            mycgform.TopLevel = false;
            this.panel1.Controls.Add(mycgform);
            mycgform.FormBorderStyle = FormBorderStyle.None;
            mycgform.BringToFront();
            mycgform.Show();
        }

        private void xzbtn_Click(object sender, EventArgs e)
        {
            xzForm myxzform = new xzForm();
            myxzform.TopLevel = false;
            this.panel1.Controls.Add(myxzform);
            myxzform.FormBorderStyle = FormBorderStyle.None;
            myxzform.BringToFront();
            myxzform.Show();
        }
    }
}
