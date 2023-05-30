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
	public partial class TextBoxEditable : UserControl
	{
		public TextBoxEditable()
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
		}/// <summary>
         /// 讓文字框變為輸入有錯誤時的樣子，錯誤訊息自訂
         /// </summary>
         /// <param name="errorMessage">錯誤訊息內容</param>
        public void Error(string errorMessage)
		{
			panelError.Visible = true;
			labelErrorMessage.Text = errorMessage;
			labelErrorMessage.Visible = true;
		}
		/// <summary>
		/// 讓文字框變為輸入有錯誤時的樣子，錯誤訊息為「請輸入正確的[欄位名稱]」
		/// </summary>
        public void Error()
        {
            panelError.Visible = true;
            labelErrorMessage.Text = "請輸入正確的"+label1.Text;
            labelErrorMessage.Visible = true;
        }

		/// <summary>
		/// 文字框變回正常型態
		/// </summary>
        public void ReturnDefault()
		{
            panelError.Visible = false;
            labelErrorMessage.Visible = false;
        }

	}
}
