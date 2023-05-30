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
			this.label2.Text = @"0/" + afiledMaxCount;
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


		public void StringLength()
		{
			int currentCharacterCount = textBox1.Text.Length;
			label2.Text = $"{currentCharacterCount}/{afiledMaxCount}";

		}

		private void textBox1_TextChanged_1(object sender, EventArgs e)
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

        public void Error(string errorMessage)
        {
            panel1.Visible = true;
            label3.Text = errorMessage;
            label3.Visible = true;
        }
        /// <summary>
        /// 讓文字框變為輸入有錯誤時的樣子，錯誤訊息為「請輸入正確的[欄位名稱]」
        /// </summary>
        public void Error()
        {
            panel1.Visible = true;
            label3.Text = "請輸入正確的" + label1.Text;
            label3.Visible = true;
        }

        /// <summary>
        /// 文字框變回正常型態
        /// </summary>
        public void ReturnDefault()
        {
            panel1.Visible = false;
            label3.Visible = false;
        }
    }
}
