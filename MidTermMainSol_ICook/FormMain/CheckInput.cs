using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBoxAndTable;

namespace FormMain
{
	public static class CheckInput
	{
		/// <summary>
		/// 檢查價格是否整數且不為0，若違反則會讓文字框顯示錯誤
		/// </summary>
		/// <param name="textBox"></param>
		/// <param name="price"></param>
		/// <returns></returns>
		public static bool CheckPrice(TextBoxEditable textBox, out int price)
		{
			if (!(int.TryParse(textBox.afiledValue, out int num)) || num == 0)
			{
				textBox.Error("請輸入大於0數字");
				price = 0;
				return true;
			}
			else
			{
				price = num;
				textBox.ReturnDefault();
				return false;
			}
		}
		public static bool CheckString(TextBoxEditable textBox, out string value)
		{
			if (string.IsNullOrEmpty(textBox.afiledValue))
			{
				textBox.Error();
				value = string.Empty;
				return true;
			}
			else
			{
				textBox.ReturnDefault();
				value = textBox.afiledValue;
				return false;
			}
		}
		public static  bool CheckString(TextBoxWordLimit textBox, out string value)
		{
			if (string.IsNullOrEmpty(textBox.afiledValue))
			{
				textBox.Error();
				value = string.Empty;
				return true;
			}
			else
			{
				textBox.ReturnDefault();
				value = textBox.afiledValue;
				return false;
			}
		}
		public static bool CheckString(TextBoxMultiline textBox, out string value)
		{
			if (string.IsNullOrEmpty(textBox.afiledValue))
			{
				textBox.Error();
				value = string.Empty;
				return true;
			}
			else
			{
				textBox.ReturnDefault();
				value = textBox.afiledValue;
				return false;
			}
		}
	}
}
