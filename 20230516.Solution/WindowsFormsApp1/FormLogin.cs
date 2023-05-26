using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class FormLogin : Form
	{
		public FormLogin()
		{
			InitializeComponent();
		}

		private void buttonLogin_Click(object sender, EventArgs e)
		{
			// todo 驗證帳密是否正確
			 
			// 若正確, 清空二個textbox

			//開啟FormMain
			var frm = new FormMain();
			frm.Owner = this;
			
			this.Hide();

			frm.ShowDialog();
		}
	}
}
