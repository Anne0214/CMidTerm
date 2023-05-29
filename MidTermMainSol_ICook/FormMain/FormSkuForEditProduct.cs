using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormMain
{
	public partial class FormSkuForEditProduct : Form
	{
        private bool _isNew { get; set; }
        public FormSkuForEditProduct(bool isNew, string sku, string typeName, string stockNumber,string soldNumber)
		{
			
			InitializeComponent();

			//新增sku情況下isNew為true，修改則為false
			buttonConfirm.Text = isNew ? "新增" : "確認";

			//將資料放入文字框
			if (isNew == false)
			{
				textBoxTypeName.afiledValue = typeName;
				textBoxStockNumber.afiledValue = stockNumber;
				textBoxSku.afiledValue = sku;
				textBoxSoldNumber.afiledValue = soldNumber;
			}
			else
			{
				textBoxSku.afiledValue = sku;
				textBoxSoldNumber.afiledValue ="0";
			}

			_isNew = isNew;

		}

		private void buttonConfirm_Click(object sender, EventArgs e)
		{
			//取值
			string typeName = textBoxTypeName.afiledValue;
			int stockNumber = 0;
			if (int.TryParse(textBoxStockNumber.afiledValue, out int num))
			{
				stockNumber = num;
			}
			string sku = textBoxSku.afiledValue;
			int soldNumber = 0;
			if (int.TryParse(textBoxStockNumber.afiledValue, out int num2))
			{
				soldNumber = num;
			}

			if (_isNew)
			{
				//發動父視窗的事件，讓父視窗的listView增加sku
				FormProductEdit frm = (FormProductEdit)this.Owner;
				frm.AddSku(sku,typeName, stockNumber);
				this.Close();
			}
			else
			{
				//發動父視窗的事件，修改父視窗listView的該項目
				FormProductEdit frm = (FormProductEdit)this.Owner;
				frm.EditSku(sku,typeName,stockNumber,0);
				this.Close();
			}

		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
