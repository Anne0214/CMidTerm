using FormMain.EF_Models;
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
	public partial class FormRecipeSearch : Form
	{
		public FormRecipeSearch()
		{
			InitializeComponent();
			this.AutoScroll = true;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(213)))), ((int)(((byte)(230)))));
			dataGridView1.BackgroundColor = Color.FromArgb(255, 255, 253); //背景色
			dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(237, 243, 255); //雙行色

			dataGridView1.RowsAdded += DataGridView1_RowsAdded;
			dataGridView1.RowsAdded += DataGridView1_RowsAdded;

		}

        private void Display()
        {
            //拿搜尋條件
            string authorName = textBoxAuthorName.Text;
            string authorPk = textBoxAuthorPk.Text;
            string recipeName = textBoxRecipeName.Text;

			int recipePK = 0;
            if(int.TryParse(textBoxRecipePk.Text,out int num))
			{
				recipePK = num;
			}
			else
			{
				MessageBox.Show("食譜PK請輸入6位數字");
				return;
			}

            DateTime start = dateTimePickerStart.Value;
            DateTime end = dateTimePickerEnd.Value;

			//拿取資料
			var members = new AppDbContext().MEMBER_會員;
			var data = new AppDbContext().RECIPE_食譜
										.OrderByDescending(x => x.PUBLISHED_TIME發表時間)
										.Join(members, r => r.AUTHOR_作者, m => m.MEMBER_ID會員_PK, (r, m) => m.NICK_NAME暱稱);

			if (!string.IsNullOrEmpty(authorName))
			{
				//待處理
			}

			if(!string.IsNullOrEmpty(authorPk))
			{
				data.Where(x => x.AUTHOR_作者 == authorPk);
			}

			if (!string.IsNullOrEmpty(recipeName))
			{
				data.Where(x => x.RECIPE_NAME食譜名稱 == recipeName);
			}

			if(recipePK != 0)
			{
				data.Where(x => x.RECIPE食譜_PK.Equals(recipePK));
			}
			if(start != null)
			{
				data.Where(x => x.PUBLISHED_TIME發表時間 > start);
			}
			if(end != null)
			{
                data.Where(x => x.PUBLISHED_TIME發表時間 < end);
            }

            //最後整理
    
            dataGridView1.DataSource = data.ToList();

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

        private void buttonClear_Click(object sender, EventArgs e)
        {
			textBoxAuthorName.Text = String.Empty;
			textBoxAuthorPk.Text= String.Empty;
			textBoxRecipeName.Text= String.Empty;
			textBoxRecipePk.Text = String.Empty;
			dateTimePickerStart.Value = DateTime.Now;

			Display();
        }


        private void buttonSearch_Click(object sender, EventArgs e)
        {
			Display();
        }
    }
}
