using FormMain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormMain
{
    
    public partial class FormLogin : Form
    {
        bool isClosed = true;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Staff c = new LoginManagement().queryByEmail(textBoxEmail.Text);
            if (c != null)
            {
                if (c.password == textBoxPassword.Text)
                {
                    isClosed = false;
                    Close();
                    return;
                }
            }

            FormLoginFailed x = new FormLoginFailed();
            x.ShowDialog();
            // MessageBox.Show("帳號與密碼不符");
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = isClosed;
        }
    }
}
