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
    public partial class FormSku : Form
    {
        public FormSku(bool isNew)
        {
            InitializeComponent();
            buttonConfirm.Text = isNew ? "新增" : "確認";
            textBoxSku.Visible = isNew ? false : true; //完全新增的情況不會知道spu(因為spu要新增到資料庫才知道)
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
            //發動父視窗的事件，讓父視窗的listView增加sku
            FormProductCreate  frm = (FormProductCreate)this.Owner;
            frm.AddSku(typeName, stockNumber);
            this.Close();

        }
    }
}
