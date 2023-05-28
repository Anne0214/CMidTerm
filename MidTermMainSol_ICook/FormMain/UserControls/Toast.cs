using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormItem
{
	public partial class Toast : UserControl
	{
        
        public Toast()
		{
			InitializeComponent();
		}
        public string AMessage { 
			get { return labToast.Text; }
			set { labToast.Text = value; } 
		}
		int duration = 0;
		public void ShowUp()
		{
			timer1.Enabled = true;
		}

        private void timer1_Tick(object sender, EventArgs e)
        {
			this.Visible = true;
			duration++;
			if(duration > 60)
			{
				duration = 0;
				timer1.Enabled = false;
				this.Visible = false;
			}
        }
    }
}
