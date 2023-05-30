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
				string prodName = textBoxProdName.afiledValue;
				var imgSave = new ImageUpload();
				string fullDescription_newPath = String.Empty;
				string cover_newPath = String.Empty;
				if (!FullDescriptionFilePath.Contains("http"))
				{
					fullDescription_newPath = imgSave.SaveImage(FullDescriptionFilePath);
				}else{
					fullDescription_newPath = FullDescriptionFilePath;
				}
				if (!CoverFilePath.Contains("http"))
				{
					cover_newPath = imgSave.SaveImage(CoverFilePath);
				}
				else{
					cover_newPath = CoverFilePath;
				}
				
				
				string shortIntro = textBoxProdDescription.afiledValue;
				//string fullIntro = textBoxFullProdDescription.afiledValue;

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

				string category = comboBoxCategory.SelectedItem.ToString();

				int purchasePrice = 0;
				if (int.TryParse(textBoxPurchasePrice.afiledValue, out int number))
				{
					purchasePrice = number;
				}

				int tagPrice = 0;
				if (int.TryParse(textBoxTagPrice.afiledValue, out number))
				{

					tagPrice = number;
				}
				int salePrice = 0;
				if (int.TryParse(textBoxSalePrice.afiledValue, out number))
				{
					salePrice = number;
				}

			//建prductDto
				var productDto = new ProductDetailDto()
				{
					Spu = _spu,
					ProductName = prodName,
					Cover = cover_newPath,
					FullProductDescription = fullDescription_newPath,
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

					var dto = new SkuDto()
					{
						TypeName = typeName,
						StockNumber = stockNumber,
						SoldNumber = soldNumber
					};
					skuDtos.Add(dto);
				}


				//呼叫修改的方法
				var repo = new ProductRepositories();
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
				MessageBox.Show("無法刪除，因為每個商品都會有至少一個型號");
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
