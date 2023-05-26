using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBoxAndTable
{
	public partial class TextBoxMultiline : UserControl
	{
		public TextBoxMultiline()
		{
			InitializeComponent();
		}

		public string afiledName
		{
			get { return label1.Text; }
			set { label1.Text = value; }
		}
		public string afiledValue
		{
			get { return textBox1.Text; }
			set { textBox1.Text = value; }
		}
		public int afiledMaxCount { get; set; }

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

			if (textBox1.Text.Length >= afiledMaxCount)
			{
				textBox1.Text = textBox1.Text.Substring(0, afiledMaxCount);
				textBox1.SelectionStart = afiledMaxCount;
				label2.ForeColor = Color.Red;
				panel1.Visible = true;

			}
			else
			{
				label2.ForeColor = Color.Black;
				panel1.Visible = false;
			}

			StringLength();

		}
		public void StringLength()
		{
			int currentCharacterCount = textBox1.Text.Length;
			label2.Text = $"{currentCharacterCount}/{afiledMaxCount}";

		}
	}
}
