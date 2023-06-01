using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//foreach(var i in tableLayoutPanel1.RowStyles)
			//{
				
			//}
			tableLayoutPanel1.RowCount += 1; //增加一個row
			int rowsCount = tableLayoutPanel1.RowCount;
			TextBox textBoxLeft = new TextBox();
			textBoxLeft.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			textBoxLeft.Size = new System.Drawing.Size(172, 29);
			textBoxLeft.Name ="textBox"+((2*rowsCount-1).ToString());

			TextBox textBoxRight = new TextBox();
			textBoxRight.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			textBoxRight.Size = new System.Drawing.Size(172, 29);
			textBoxRight.Name = "textBox" + ((2 * rowsCount).ToString());

			this.tableLayoutPanel1.Controls.Add(textBoxLeft,0,rowsCount);
			this.tableLayoutPanel1.Controls.Add(textBoxRight, 1, rowsCount);
			


			tableLayoutPanel1.RowCount += 1; //增加一個row
			//this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40));
		}
	}
}
