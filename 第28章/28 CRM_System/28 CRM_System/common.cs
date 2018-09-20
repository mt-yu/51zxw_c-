using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace _28_CRM_System
{
    class common
    {
        database db = new database();
        /// <summary>
        /// 32位MD5加密方法
        /// </summary>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public string md5(string pwd)
        {
            string returnPwd = "";
            MD5 md5 = MD5.Create();
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(pwd);
            bytes = md5.ComputeHash(bytes);
            md5.Clear();
            for (int i = 0; i < bytes.Length; i++)
            {
                returnPwd += Convert.ToString(bytes[i], 16).PadLeft(2, '0');
            }
            return returnPwd.PadLeft(32, '0');
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cb"></param>
        /// <param name="sql"></param>
        public void bindComboBox(ComboBox cb, string sql)
        {
            DataTable dt = new DataTable();
            dt = createSource(sql);
            cb.DataSource = dt;
            cb.DisplayMember = dt.Columns[1].ColumnName;
            cb.ValueMember = dt.Columns[0].ColumnName;
        }

        public void bindListBox(ListBox lb, string sql)
        {
            DataTable dt = new DataTable();
            dt = createSource(sql);
            lb.DataSource = dt;
            lb.DisplayMember = dt.Columns[1].ColumnName;
            lb.ValueMember = dt.Columns[0].ColumnName;
        }

        private DataTable createSource(string sql)
        {
            DataTable dt = new DataTable();
            SqlDataReader dr;
            db.runSql(sql, out dr);
            dt = db.ConvertDataReaderToDataTable(dr);
            return dt;
        }

        public void bindDGV(DataGridView dgv, string sql)
        {
            dgv.DataSource = createSource(sql);
        }

        public void cbbIndexByText(ComboBox cbb, string value)
        {
            for (int i = 0; i < cbb.Items.Count; i++)
            {
                if (cbb.Items[i].ToString() == value)
                {
                    cbb.SelectedIndex = i;
                    break;
                }
            }
        }
    }
}
