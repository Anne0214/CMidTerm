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

		public void Success()
		{
			toast.ShowUp();
			Display(); //用來刷新表格資料
		}

		private void Display()
		{ 
            List<ProductSearchDto> data = new List<ProductSearchDto>();
            var repo = new ProductRepositories();
            data =repo.Search("", "", "");

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
            string searchText = textBoxSearch.Text;
            if (searchText == string.Empty)
            {
                textBoxSearch.ForeColor = Color.Red;
                textBoxSearch.Text = "請輸入搜尋內容";
                return;
            }

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
            //更新資料來源
            dataGridView1.DataSource = data;

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
        }

		private void buttonAddNewProduct_Click(object sender, EventArgs e)
		{
			FormProductCreate frm = new FormProductCreate();
			frm.Owner = this;
			frm.Show();
		}
	}
}
