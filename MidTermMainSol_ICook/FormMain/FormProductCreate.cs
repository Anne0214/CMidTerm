using ISpan2023.UCook.BackEnd;
using ISpan2023.UCook.BackEnd.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextBoxAndTable;
using static System.Net.Mime.MediaTypeNames;

namespace FormMain
{
    public partial class FormProductCreate : Form
    {
        
        public FormProductCreate()
        {
            InitializeComponent();

            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(230)))));

            //category combobox的前置作業
            string[] targets = new string[] { "生活", "咖啡", "食器", "乾貨", "調味品", "餐廚" };
            comboBoxCategory.Items.AddRange(targets);
            comboBoxCategory.SelectedIndex = 0;

            //商品圖片放預設
            this.pictureBoxCover.Image= System.Drawing.Image.FromStream(System.Net.WebRequest.Create("https://i.imgur.com/CVST7tT.png").GetResponse().GetResponseStream());

		}

        /// <summary>
        /// 檢查價格是否整數且不為0，若違反則會讓文字框顯示錯誤
        /// </summary>
        /// <param name="textBox"></param>
        /// <param name="price"></param>
        /// <returns></returns>
        public bool CheckPrice(TextBoxEditable textBox, out int price)
        {
            if (!(int.TryParse(textBox.afiledValue, out int num)) || num==0)
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
        public bool CheckString(TextBoxEditable textBox,out string value)
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
                value=textBox.afiledValue;
                return false;
            }
        }
        public bool CheckString(TextBoxWordLimit textBox, out string value)
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
        public bool CheckString(TextBoxMultiline textBox, out string value)
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
        private void buttonSave_Click(object sender, EventArgs e)
        {
            //存放各項是否有錯，最後檢查
            List<bool> errors = new List<bool>();


            //取值: 1.檢查是否都有填 2. 檢查型別是否正確
            string prodName = string.Empty;
            errors.Add(CheckString(textBoxProdName, out prodName));
            
            var imgSave = new ImageUpload();

            errorFullDescription.Visible = string.IsNullOrEmpty(FullDescriptionFilePath);
            errors.Add(string.IsNullOrEmpty(FullDescriptionFilePath));

            FullDescriptionFilePath = string.IsNullOrEmpty(FullDescriptionFilePath) ?
                                            FullDescriptionFilePath : imgSave.SaveImage(FullDescriptionFilePath);


            ErrorCover.Visible = string.IsNullOrEmpty(CoverFilePath);
            errors.Add(string.IsNullOrEmpty(CoverFilePath));

            CoverFilePath = string.IsNullOrEmpty(CoverFilePath) ?
                                CoverFilePath : imgSave.SaveImage(CoverFilePath);


            string shortIntro = string.Empty;
            errors.Add(CheckString(textBoxProdDescription, out shortIntro));
          
            
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
            errorOnShelf.Visible = string.IsNullOrEmpty(onShelf);
            errors.Add(string.IsNullOrEmpty(onShelf));


            string category = comboBoxCategory.SelectedItem.ToString();
            errorCategory.Visible = string.IsNullOrEmpty(category);
            errors.Add(string.IsNullOrEmpty(category));


            int purchasePrice = 0;
            errors.Add(CheckPrice(textBoxPurchasePrice,out purchasePrice));

            int tagPrice = 0;
            errors.Add(CheckPrice(textBoxTagPrice, out tagPrice));

            int salePrice = 0;
            errors.Add(CheckPrice(textBoxSalePrice, out salePrice));

            //檢查: tagPrice>salePrice>purchasePrice
            if(tagPrice != 0 && salePrice != 0) //標籤價、銷售價
            {
                if(tagPrice>salePrice && salePrice >purchasePrice)
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
            if (errors.Any(x => x=true)) return;

            //建prductDto
            var productDto = new ProductDetailDto()
            {
                ProductName = prodName,
                Cover = CoverFilePath,
                FullProductDescription = FullDescriptionFilePath,
                OnShelf = onShelf,
                ProductDescription = shortIntro,
                Category=category,
                PurchasePrice=purchasePrice,
                TagPrice=tagPrice,
                SalePrice=salePrice,
            };

            //建skuDtos，存成list

            List<SkuDto> skuDtos=  new List<SkuDto>();
            foreach (ListViewItem i in listViewSku.Items)
            {
                string typeName = i.SubItems[1].Text;
                int stockNumber = int.Parse(i.SubItems[2].Text);
                var dto = new SkuDto()
                {
                    TypeName = typeName,
                    StockNumber = stockNumber,
                    SoldNumber = 0
                };
                skuDtos.Add(dto);
            }
            try
            {
                //存到資料庫
                var repo = new ProductRepositories();
                repo.Create(productDto, skuDtos);
                INotify frm = this.Owner as INotify;
                frm.Success("新增成功");
                this.Close();
            }
            catch { MessageBox.Show("儲存失敗，請稍後再試"); }

        }
        private string CoverFilePath { get; set; }
        private void buttonImg_Click(object sender, EventArgs e)
        {
            var imgUpload = new ImageUpload();
            string path = imgUpload.UploadIMG();
            if (path == string.Empty) return; //使用者沒有選擇圖片的狀況
            CoverFilePath = path;
            var MyImage = new Bitmap(path);
            pictureBoxCover.Image = (System.Drawing.Image)MyImage;
        }

        public string FullDescriptionFilePath { get; set; }
        private void buttonUpload_Click(object sender, EventArgs e)
        {
            var imgUpload = new ImageUpload();
            string path = imgUpload.UploadIMG();
            if (path == string.Empty) return; //使用者沒有選擇圖片的狀況
            FullDescriptionFilePath = path;
            var MyImage = new Bitmap(path);
        }

        private void buttonAddSku_Click(object sender, EventArgs e)
        {
            FormSkuForCreateProduct frm = new FormSkuForCreateProduct(true,"","");
            frm.Owner = this;
            frm.ShowDialog();

        }
        public void AddSku(string typeName, int stockNumber)
        { //給sku子視窗呼叫，用於新增sku，以更改本視窗的listView
            ListViewItem item = new ListViewItem();
            item.SubItems.Add(typeName);
            item.SubItems.Add(stockNumber.ToString());
            listViewSku.Items.Add(item);

            //         skuDtos.Add(new SkuDto()
            //         {
            //	SoldNumber = 0,
            //	StockNumber = stockNumber,
            //	TypeName = typeName,
            //});
        }

        public void EditSku(string typeName, int stockNumber)
		{//給sku子視窗呼叫，用於修改sku，以更改本視窗的listView
			listViewSku.SelectedItems[0].SubItems[1].Text = typeName;
            listViewSku.SelectedItems[0].SubItems[2].Text = stockNumber.ToString();
		}

		private void listViewSku_Click(object sender, EventArgs e)
		{ //todo 找一個更好的時機
            if (listViewSku.FocusedItem == null) return;

            buttonEdit.Enabled = true;
            buttonDelete.Enabled = true;
		}

		private void buttonEdit_Click(object sender, EventArgs e)
		{
            
			string typeName = listViewSku.SelectedItems[0].SubItems[1].Text;
			string stockNumber = listViewSku.SelectedItems[0].SubItems[2].Text;
			FormSkuForCreateProduct frm = new FormSkuForCreateProduct(false,typeName,stockNumber);
            frm.Owner = this;
            frm.ShowDialog();
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
	}
}
