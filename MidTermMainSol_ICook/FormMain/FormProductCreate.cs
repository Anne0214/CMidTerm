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
using static System.Net.Mime.MediaTypeNames;

namespace FormMain
{
    public partial class FormProductCreate : Form
    {
        
        public FormProductCreate()
        {
            InitializeComponent();

            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(213)))), ((int)(((byte)(230)))));

            
            //category combobox的前置作業
            string[] targets = new string[] { "生活", "咖啡", "食器", "乾貨", "調味品", "餐廚" };
            comboBoxCategory.Items.AddRange(targets);
            comboBoxCategory.SelectedIndex = 0;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //todo 預檢查

            //取值
            string prodName = textBoxProdName.afiledValue;
            var imgSave = new ImageUpload();
            string fullDescription_newPath = imgSave.SaveImage(FullDescriptionFilePath);
            string cover_newPath = imgSave.SaveImage(CoverFilePath);
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
            if(int.TryParse(textBoxPurchasePrice.afiledValue, out int number))
            {
                purchasePrice = number;
            }

            int tagPrice = 0;
            if(int.TryParse(textBoxTagPrice.afiledValue,out number)){

                tagPrice = number;
            }
            int salePrice = 0;
            if(int.TryParse(textBoxSalePrice.afiledValue,out number))
            {
                salePrice = number;
            }

            //建prductDto
            var productDto = new ProductDetailDto()
            {
                ProductName = prodName,
                Cover = cover_newPath,
                FullProductDescription = fullDescription_newPath,
                OnShelf = onShelf,
                ProductDescription = shortIntro,
                Category=category,
                PurchasePrice=purchasePrice,
                TagPrice=tagPrice,
                SalePrice=salePrice,
            };

            //建skuDtos，存成list
            List<SkuDto> skuDtos = new List<SkuDto>();

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

            //存到資料庫
            var repo = new ProductRepositories();
            repo.Create(productDto, skuDtos);

            //todo 完成儲存後的通知(儲存失敗，該視窗不關閉。儲存成功，關閉並跳視窗)
        }
        private string CoverFilePath { get; set; }
        private void buttonImg_Click(object sender, EventArgs e)
        {
            var imgUpload = new ImageUpload();
            string path = imgUpload.UploadIMG();
            CoverFilePath = path;
            var MyImage = new Bitmap(path);
            pictureBoxCover.Image = (System.Drawing.Image)MyImage;
        }

        public string FullDescriptionFilePath { get; set; }
        private void buttonUpload_Click(object sender, EventArgs e)
        {
            var imgUpload = new ImageUpload();
            string path = imgUpload.UploadIMG();
            FullDescriptionFilePath = path;
            var MyImage = new Bitmap(path);
            //pictureBoxCover.Image = (System.Drawing.Image)MyImage;
        }

        private void buttonAddSku_Click(object sender, EventArgs e)
        {
            FormSku frm = new FormSku(true);
            frm.Owner = this;
            frm.ShowDialog();

        }
        public void AddSku(string typeName, int stockNumber)
        {
            ListViewItem item = new ListViewItem();
            item.SubItems.Add(typeName);
            item.SubItems.Add(stockNumber.ToString());
            listViewSku.Items.Add(item);
        }
    }
}
