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
    public partial class FormSkuForCreateProduct : Form
    {
		private bool _isNew;

        public FormSkuForCreateProduct(bool isNew,string typeName, string stockNumber)
        {	//本視窗給新增商品視窗使用
			InitializeComponent();

            //新增sku情況下isNew為true，修改則為false
			buttonConfirm.Text = isNew ? "新增" : "確認";

			//將資料放入文字框
			if (isNew == false)
			{
				textBoxTypeName.afiledValue = typeName;
				textBoxStockNumber.afiledValue = stockNumber;
			}

			_isNew = isNew;
		}


        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAddSku_Click(object sender, EventArgs e)
        {

            //取值
            string typeName = textBoxTypeName.afiledValue;
            int stockNumber = 0;
            if(int.TryParse(textBoxStockNumber.afiledValue,out int num))
            {
                stockNumber = num;
            }

			if (_isNew)
			{
				//發動父視窗的事件，讓父視窗的listView增加sku
				FormProductCreate frm = (FormProductCreate)this.Owner;
				frm.AddSku(typeName, stockNumber);
				this.Close();
			}
			else
			{
				//發動父視窗的事件，修改父視窗listView的該項目
				FormProductCreate frm = (FormProductCreate)this.Owner;
				frm.EditSku(typeName, stockNumber);
				this.Close();
			}


		}




	}
}
