using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            var connStr = ConfigurationManager.ConnectionStrings["default"].ToString();

            //MessageBox.Show(connStr);

            //SqlConnection conn = new SqlConnection(connStr);
            //conn.Open();
            //conn.Close();

            using(var conn = new SqlConnection(connStr))
            {
                conn.Open();
                //...
            }

            MessageBox.Show("成功連結到db,開啟連線, 並結束連線");
        }

		private void buttonEditCategory_Click(object sender, EventArgs e)
		{
            var frm = new FormEditCategory(2);
            frm.ShowDialog();
		}
	}
}
