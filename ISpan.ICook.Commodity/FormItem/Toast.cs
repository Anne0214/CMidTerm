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
			if (duration < 30)
			{ //往下移動20
                this.Top +=3;
				duration++;
			}
			else if (duration >50 && duration<80)
			{ //往上移動
                this.Top -= 3;
                duration++;
            }
			else if (duration>80)
			{ //關閉
                duration = 0;
				timer1.Enabled = false;
				this.Visible = false;
			}
			else
			{ //停留
				duration++;
			}	
        }
    }
}
