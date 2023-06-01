using ISpan2023.UCook.BackEnd;
using ISpan2023.UCook.BackEnd.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace FormMain
{
	public partial class FormProductSearch : Form,INotify
	{
		
		public FormProductSearch()
		{
			InitializeComponent();
			this.AutoScroll = true;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(213)))), ((int)(((byte)(230)))));
			dataGridView1.BackgroundColor = Color.FromArgb(255, 255, 253); //背景色
			dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(237, 243, 255); //雙行色

			dataGridView1.RowsAdded += DataGridView1_RowsAdded;
			dataGridView1.RowsAdded += DataGridView1_RowsAdded;

            string[] targets = new string[] { "SKU", "商品名稱", "SPU" };
            comboBoxTarget.Items.AddRange(targets);
			comboBoxTarget.SelectedItem = "SKU";
        }
		private void DataGridView1_RowsAdded(object sender, EventArgs e)
		{
			UpdateRowCount();
		}

		private void DataGridView1_RowsRemoved(object sender, EventArgs e)
		{
			UpdateRowCount();
		}
		private void UpdateRowCount()
		{
			LabelRowCount.Text = "總共 " + dataGridView1.Rows.Count.ToString() + " 筆";
		}

		public void Success(string message)
		{
			toast.AMessage = message; 
			toast.ShowUp();
			Display(); //用來刷新表格資料
		}

		/// <summary>
		/// 顯示資料的方法
		/// </summary>
		private void Display()
		{
			string searchText = textBoxSearch.Text;

			List<ProductSearchDto> data = new List<ProductSearchDto>();
            var repo = new ProductRepositories();

			switch (comboBoxTarget.SelectedItem)
			{
				case "SKU":
					data = repo.Search("", "", searchText);
					break;
				case "商品名稱":
					data = repo.Search(searchText, "", "");
					break;
				case "SPU":
					data = repo.Search("", searchText, "");
					break;
			}
			//如果沒有一筆資料符合，要說沒有資料符合(messageBox.show)
			if (data.Count == 0 || data == null) //todo 搞懂差異
			{
				MessageBox.Show("查無符合的資料");
				return;
			}

			foreach(var item in data)
			{
				//0:待上架,1:上架中,2:封存
				switch (item.OnShelf)
				{
					case "0":
						item.OnShelf = "待上架";
						break;
					case "1":
						item.OnShelf = "上架中";
						break;
					case "2":
						item.OnShelf = "封存";
						break;
				}
				item.AllSku = item.AllSku.Substring(1);
			}


			dataGridView1.DataSource = data;
		}



        private void FormSearch_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
			textBoxSearch.Text = string.Empty;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
			
            if (textBoxSearch.Text == string.Empty)
            {
                textBoxSearch.ForeColor = Color.Red;
                textBoxSearch.Text = "請輸入搜尋內容";
                return;
            }
			Display();


		}

        private void textBoxSearch_Click(object sender, EventArgs e)
        {
			if(textBoxSearch.ForeColor == Color.Red)
			{ //如果搜尋時無輸入內容，會讓搜尋框文字變紅色及提醒用戶，故此時再點擊要變回正常狀態
				textBoxSearch.ForeColor = Color.Black;
				textBoxSearch.Text = string.Empty;
			}
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { 
            if (dataGridView1.Columns[e.ColumnIndex].Name =="Operation" && e.RowIndex > 0) //只有對資料點擊修改時會發動
            {
                string spu = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

                FormProductEdit frm = new FormProductEdit(spu);
                frm.Owner = this;
                frm.Show();
            }

            bool isAnyRowChecked = false;
            
            // 檢查是否第一欄是CheckBox列
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                // 取得選取的CheckBox單元格
                DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)dataGridView1.Rows[e.RowIndex].Cells[0];

                // 切換CheckBox的值
                checkBoxCell.Value = !(checkBoxCell.Value == null || !(bool)checkBoxCell.Value);

                // 判斷CheckBox是否被勾選

                if ((bool)checkBoxCell.Value)
                {
                    // CheckBox未勾選，取消選取整列
                    dataGridView1.Rows[e.RowIndex].Selected = false;
                    checkBoxCell.Value = false;
                }
                else
                {
                    // CheckBox已勾選，則選取整列
                    dataGridView1.Rows[e.RowIndex].Selected = true;
                    checkBoxCell.Value = true;
                }
            }
            // 檢查是否有任何資料列被勾選
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)row.Cells[0];

                if (checkBoxCell.Value != null && (bool)checkBoxCell.Value)
                {
                    isAnyRowChecked = true;
                    break;
                }
            }

            // 根據是否有資料列被勾選來設定Button的Enable屬性
            buttonCSV.Enabled = isAnyRowChecked;

        }

		private void buttonAddNewProduct_Click(object sender, EventArgs e)
		{
			FormProductCreate frm = new FormProductCreate();
			frm.Owner = this;
			frm.Show();
		}

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left) // 只處理滑鼠左键點擊事件
            {
                if (e.RowIndex == -1) // 確保點擊標題
                {
                    DataGridViewColumn clickedColumn = dataGridView1.Columns[e.ColumnIndex];

                    StringBuilder rowValues = new StringBuilder();

                    // 獲取每格的值
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        DataGridViewCell cell = row.Cells[e.ColumnIndex];

                        //如果value!=null,用ToString();如為null,用string.Empty
                        string cellValue = cell.Value?.ToString() ?? string.Empty;
                        rowValues.AppendLine(cellValue);
                    }

                    // 將值複製到剪貼版
                    Clipboard.SetText(rowValues.ToString());
                    Success("複製成功");
                }
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // 只處理滑鼠左键點擊事件
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // 確認不是點擊標題行
                {
                    DataGridViewCell clickedCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];

                    //如果value!=null,用ToString();如為null,用string.Empty
                    string cellValue = clickedCell.Value?.ToString() ?? string.Empty;

                    if (!string.IsNullOrEmpty(cellValue)) //不是null或空字串才複製
                    {
                        // 將值複製到剪貼版
                        Clipboard.SetText(cellValue);
						Success("複製成功");

					}
                    return;

                }
            }
        }

        private void buttonCSV_Click(object sender, EventArgs e)
        {
            //找到被勾選的列，存spu
            List<string> spus = new List<string>(); 
            int count = dataGridView1.RowCount;

            for(int i =0; i < count; i++)
            {
                DataGridViewCell selectedRow = dataGridView1.Rows[i].Cells[0];
                bool flag = Convert.ToBoolean(selectedRow.Value);
                if(flag)
                {
                    spus.Add(dataGridView1.Rows[i].Cells[2].Value.ToString());

                }
            }

            //取得資料
            List<ProductCSVDto> dtos = new List<ProductCSVDto>();
            var repo = new ProductRepositories();
            dtos = repo.GetDetailBySpu(spus).ToList();

            //產出我的dict
            Dictionary<string, string> pairs = new Dictionary<string, string>()
            {
                { "產品圖片","Cover"},
                {"產品分類","Category"},
                { "SPU","Spu"},
                { "產品名稱","ProductName"},
                { "上架狀態","OnShelf"},
                { "進貨價","PurchasePrice"},
                { "標籤價","TagPrice"},
                { "銷售價","SalePrice"},
                { "商品描述","ProductDescription"},
                { "商品完整描述","FullProductDescription"},
                { "SKU","Sku"},
                { "型號名稱","TypeName"},
                { "庫存數量","StockNumber"},
                { "售出數量","SoldNumber"},

            };

            //開啟FormCSV，指定為owner
            FormExportCSV<ProductCSVDto> frm = new FormExportCSV<ProductCSVDto>(pairs, dtos);
            frm.Owner = this;
            frm.ShowDialog();

        }
    }
}
