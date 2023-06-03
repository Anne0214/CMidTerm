using ISpan2023.UCook.BackEnd;
using ISpan2023.UCook.BackEnd.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
		private string CoverFilePath { get; set; }
		private string FullDescriptionFilePath { get; set; }

		public FormProductEdit(string spu)
		{
			InitializeComponent();
			this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(230)))));

            _spu = spu;

            string[] targets = new string[] {"生活","咖啡","食器","乾貨","調味品","餐廚"};
            comboBoxCategory.Items.AddRange(targets);


        }

        private void FormProductEdit_Load(object sender, EventArgs e)
        { //取得單筆資料
			var repo = new ProductRepositories();
			var (skuDtos, productDetailDto) = repo.GetBySpu(_spu);
			textBoxSPU.afiledValue = productDetailDto.Spu;

			if (productDetailDto.Cover.Contains("http"))
			{
				this.pictureBoxCover.Image = Image.FromStream(System.Net.WebRequest.Create(productDetailDto.Cover).GetResponse().GetResponseStream());
			}
			else
			{
				string currentDir = Environment.CurrentDirectory;
				string absolutePath = Path.Combine(currentDir, productDetailDto.Cover);

				this.pictureBoxCover.Image = Image.FromFile(absolutePath);
			}
            
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

			CoverFilePath = productDetailDto.Cover;
			FullDescriptionFilePath= productDetailDto.FullProductDescription;

		}

        private void buttonSave_Click(object sender, EventArgs e)
		{
			try
			{

				//取值，第一步型別檢查及是否有輸入
				List<bool> errors = new List<bool>();
				bool hasError = false;

				//取值: 1.檢查是否都有填 2. 檢查型別是否正確
				string prodName = string.Empty;
				hasError = CheckInput.CheckString(textBoxProdName, out prodName);
				errors.Add(hasError);

				//檢查產品名稱是否重複
				var repo = new ProductRepositories();
				var dto = repo.GetByName(prodName);
				if (dto.Spu != _spu && dto != null) //當我找到同名字的商品，且spu不相同，表示我取到跟其他商品一樣的名字，因此不可改成這個名字
				{
					textBoxProdName.Error("產品名稱重複，請重新取名");
					errors.Add(false);
				}


				var imgSave = new ImageUpload();

				//完整描述沒放圖
				hasError = string.IsNullOrEmpty(FullDescriptionFilePath);
				errorFullDescriptionFilePath.Visible = hasError;
				errors.Add(hasError);

				//完整描述使用非網址圖片
				if (!FullDescriptionFilePath.Contains("http"))
				{
					FullDescriptionFilePath = imgSave.SaveImage(FullDescriptionFilePath);
				}

				//沒放封面圖
				hasError = string.IsNullOrEmpty(CoverFilePath);
				errorCover.Visible = hasError;
				errors.Add(hasError);

				//封面圖使用非網址的圖片
				if (!CoverFilePath.Contains("http"))
				{
					CoverFilePath = imgSave.SaveImage(CoverFilePath);
				}



				string shortIntro = string.Empty;
				errors.Add(CheckInput.CheckString(textBoxProdDescription, out shortIntro));


				string onShelf = String.Empty;
				if (radioButtonOn.Checked)
				{
					onShelf = "1";
				}
				if (radioButtonOff.Checked)
				{
					onShelf = "0";
				}
				if (radioButtonUnavailable.Checked)
				{
					onShelf = "2";
				}
				hasError = string.IsNullOrEmpty(onShelf);
				errorOnShelf.Visible = hasError;
				errors.Add(hasError);

				string category = comboBoxCategory.SelectedItem.ToString();
				hasError = string.IsNullOrEmpty(category);
				errorCategory.Visible = hasError;
				errors.Add(hasError);

				int purchasePrice = 0;
				errors.Add(CheckInput.CheckPrice(textBoxPurchasePrice, out purchasePrice));

				int tagPrice = 0;
				errors.Add(CheckInput.CheckPrice(textBoxTagPrice, out tagPrice));

				int salePrice = 0;
				errors.Add(CheckInput.CheckPrice(textBoxSalePrice, out salePrice));

				//檢查: tagPrice>salePrice>purchasePrice
				if (tagPrice != 0 && salePrice != 0) //標籤價、銷售價
				{
					if (tagPrice >= salePrice && salePrice >= purchasePrice)
					{
						errors.Add(false);
						textBoxSalePrice.ReturnDefault();
						textBoxTagPrice.ReturnDefault();

					}
					else
					{
						textBoxPurchasePrice.Error("銷售價應大於進貨價，小於標籤價");
						textBoxTagPrice.Error("標籤價應大於進貨價、銷售價");
						textBoxSalePrice.Error("銷售價應小於進貨價、標籤價");
					}
				}


				//以上驗證條件有一項未通過，不可以開始創建程序
				if (errors.Any(x => x = true)) return;


				//建prductDto
				var productDto = new ProductDetailDto()
				{
					Spu = _spu,
					ProductName = prodName,
					Cover = CoverFilePath,
					FullProductDescription = FullDescriptionFilePath,
					OnShelf = onShelf,
					ProductDescription = shortIntro,
					Category = category,
					PurchasePrice = purchasePrice,
					TagPrice = tagPrice,
					SalePrice = salePrice,
				};

				//建skuDtos，存成list

				List<SkuDto> skuDtos = new List<SkuDto>();
				foreach (ListViewItem i in listViewSku.Items)
				{	
					string typeName = i.SubItems[2].Text;
					int stockNumber = int.Parse(i.SubItems[3].Text);
					int soldNumber = int.Parse(i.SubItems[4].Text);

					var skuDto = new SkuDto()
					{
						TypeName = typeName,
						StockNumber = stockNumber,
						SoldNumber = soldNumber
					};
					skuDtos.Add(skuDto);
				}


				//呼叫修改的方法
				repo = new ProductRepositories();
				repo.Update(productDto, skuDtos);
			}
			catch (Exception ex)
			{  //儲存失敗的狀況
				MessageBox.Show($"儲存失敗，請稍後再試。失敗原因:{ex.Message}");
				return;
			}

			//通知(儲存成功的狀況)
			INotify frm = this.Owner as INotify;
			frm.Success("修改成功");

			//關閉本視窗
			this.Close();
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void buttonEdit_Click(object sender, EventArgs e)
		{	
			
			string sku = listViewSku.SelectedItems[0].SubItems[1].Text;
			string typeName = listViewSku.SelectedItems[0].SubItems[2].Text;
			string stockNumber = listViewSku.SelectedItems[0].SubItems[3].Text;
			string soldNumber = listViewSku.SelectedItems[0].SubItems[4].Text;

			FormSkuForEditProduct frm = new FormSkuForEditProduct(false,sku,typeName,stockNumber,soldNumber );
			frm.Owner = this;
			frm.ShowDialog(this);
		}

		/// <summary>
		/// 給sku子視窗呼叫，用於修改sku，以更改本視窗的listView
		/// </summary>
		/// <param name="sku"></param>
		/// <param name="typeName"></param>
		/// <param name="stockNumber"></param>
		/// <param name="soldNumber"></param>
		public void EditSku(string sku,string typeName, int stockNumber,int soldNumber)
		{
			
			listViewSku.SelectedItems[0].SubItems[1].Text = sku;
			listViewSku.SelectedItems[0].SubItems[2].Text = typeName;
			listViewSku.SelectedItems[0].SubItems[3].Text = stockNumber.ToString();
			listViewSku.SelectedItems[0].SubItems[4].Text = soldNumber.ToString();

		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			if (listViewSku.Items.Count <= 1)
			{
				MessageBox.Show("無法刪除，因為每個商品必須至少一個型號");
				return;
			}
			ListViewItem item = listViewSku.SelectedItems[0];
			listViewSku.Items.Remove(item);
		}

		private void listViewSku_Click(object sender, EventArgs e)
		{
			if (listViewSku.FocusedItem == null) return;

			buttonEdit.Enabled = true;
			buttonDelete.Enabled = true;
		}

		private void buttonAddSku_Click(object sender, EventArgs e)
		{	
			
			string sku = textBoxSPU.afiledValue+"-" +(listViewSku.Items.Count + 1).ToString();
			FormSkuForEditProduct frm = new FormSkuForEditProduct(true,sku, "", "", "");
			frm.Owner = this;
			frm.ShowDialog(this);
		}
		public void AddSku(string sku,string typeName,int stockNumber)
		{
			//接收sku子視窗傳回來的值，更新本視窗的listViewSku

			ListViewItem item = new ListViewItem();
			item.SubItems.Add(sku);
			item.SubItems.Add(typeName);
			item.SubItems.Add(stockNumber.ToString());
			item.SubItems.Add("0");
			listViewSku.Items.Add(item);
		}


        private void buttonUpload_Click(object sender, EventArgs e)
		{
			var imgUpload = new ImageUpload();
			string path = imgUpload.UploadIMG();
			FullDescriptionFilePath = path;
			textBoxFullProdDescription.afiledValue = path;
		}
		
		private void buttonUploadCover_Click(object sender, EventArgs e)
		{
			var imgUpload = new ImageUpload();
			string path = imgUpload.UploadIMG();
			CoverFilePath = path;
			var MyImage = new Bitmap(path);
			pictureBoxCover.Image = (System.Drawing.Image)MyImage;
		}

	}
}
