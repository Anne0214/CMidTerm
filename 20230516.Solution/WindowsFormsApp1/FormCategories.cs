using ISpan2023.EStore.SqlDataLayer.Dtos;
using ISpan2023.EStore.SqlDataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.interfaces;

namespace WindowsFormsApp1
{
	public partial class FormCategories : Form , IGrid
	{
		List<CategoryDto> data;

		public FormCategories()
		{
			InitializeComponent();
		}

		private void FormCategories_Load(object sender, EventArgs e)
		{
			Display();
		}
		
		private void buttonSearch_Click(object sender, EventArgs e)
		{
			Display();			
		}

		public void Display() {
			// 取得篩選條件的值
			bool isInt = int.TryParse(this.textBoxCategoryId.Text, out int categoryId);
			int? sId = isInt ? categoryId : (int?)null;

			string sName = this.textBoxName.Text;

			// 叫用Search(),取得符合的記錄
			var repo = new CategoryRepository();
			data = repo.Search(sId, sName);

			// 繫結到DataGridView
			this.dataGridView1.DataSource = data;
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return; // 按到了header,不處理

			int id = this.data[e.RowIndex].Id;

			var frm = new FormEditCategory(id);
			frm.Owner = this;
			frm.ShowDialog();
		}

		private void buttonAddNew_Click(object sender, EventArgs e)
		{
			var frm = new FormCreateCategory();
			frm.Owner = this;
			frm.ShowDialog();
		}
	}
}
