using ISpan2023.UCook.BackEnd;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FormMain
{
	public partial class FormProductEdit : Form
	{
		private string _spu;
        public FormProductEdit(string spu)
		{
			InitializeComponent();
			this.AutoScroll = true;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(213)))), ((int)(((byte)(230)))));

			_spu = spu;

            string[] targets = new string[] {"生活","咖啡","食器","乾貨","調味品","餐廚"};
            comboBoxCategory.Items.AddRange(targets);
        }

        private void FormProductEdit_Load(object sender, EventArgs e)
        { //取得單筆資料
			var repo = new ProductRepositories();
			var (skuDtos, productDetailDto) = repo.GetBySpu(_spu);
			textBoxSPU.afiledValue = productDetailDto.Spu;
            this.pictureBoxCover.Image = Image.FromStream(System.Net.WebRequest.Create(productDetailDto.Cover).GetResponse().GetResponseStream());
            comboBoxCategory.SelectedItem = productDetailDto.Category;
			switch (int.Parse(productDetailDto.OnShelf))
			{
				case 0: //待上架
					radioButtonOff.Checked = true;
					break;
				case 1: //上架中
                    radioButtonOn.Checked = true;
                    break;
				case 2: //封存
                    radioButtonUnavailable.Checked = true;
                    break;
			}
            textBoxProdName.afiledValue = productDetailDto.ProductName;

			foreach(var i in skuDtos)
			{
				ListViewItem skuItem = new ListViewItem();
				skuItem.SubItems.Add(i.Sku);
                skuItem.SubItems.Add(i.TypeName);
                skuItem.SubItems.Add(i.StockNumber.ToString());
                skuItem.SubItems.Add(i.SoldNumber.ToString());
				listViewSku.Items.Add(skuItem);
            }

			textBoxPurchasePrice.afiledValue = productDetailDto.PurchasePrice.ToString();
			textBoxTagPrice.afiledValue = productDetailDto.TagPrice.ToString();
			textBoxSalePrice.afiledValue= productDetailDto.SalePrice.ToString();
			textBoxProdDescription.afiledValue  = productDetailDto.ProductDescription;
			textBoxFullProdDescription.afiledValue = productDetailDto.FullProductDescription;
        }

        private void buttonSave_Click(object sender, EventArgs e)
		{
			try
			{
				//儲存程序寫這裡
			}
			catch
			{  //儲存失敗的狀況
				MessageBox.Show("儲存失敗，請稍後再試");
				return;
			}

			//通知(儲存成功的狀況)
			INotify frm = this.Owner as INotify;
			frm.Success();

			//關閉本視窗
			this.Close();
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}


    }
}
