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
        public string message { 
			get { return toastBackground.Text; }
			set { toastBackground.Text = value; } }
    }
}
