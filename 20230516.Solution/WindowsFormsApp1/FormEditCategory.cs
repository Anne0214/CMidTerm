using ISpan2023.EStore.SqlDataLayer.Dtos;
using ISpan2023.EStore.SqlDataLayer.Repositories;
using ISpan2023.EStore.SqlDataLayer.Services;
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
	public partial class FormEditCategory : Form
	{
		private readonly int _categoryId;

		public FormEditCategory(int categoryId)
		{
			_categoryId = categoryId;

			InitializeComponent();
		}

		private void FormEditCategory_Load(object sender, EventArgs e)
		{
			var repo = new CategoryRepository();
			CategoryDto dto = repo.Get(_categoryId);
			if(dto == null ) {
				MessageBox.Show("找不到符合的記錄");
				return;
			}

			textBoxId.Text = dto.Id.ToString();
			textBoxName.Text = dto.Name.ToString();
			textBoxDisplayOrder.Text = dto.DisplayOrder.ToString();
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			//收集表單欄位值到 dto
			bool isInt = int.TryParse(textBoxDisplayOrder.Text, out int displayOrder);
			displayOrder = isInt ? displayOrder : 0; //如果轉換失敗，就給 0

			CategoryDto dto = new CategoryDto { Id= this._categoryId, Name = textBoxName.Text, DisplayOrder = displayOrder};

			//叫用 CategoryRepository.Update
			//var repo = new CategoryRepository();
			//int rows = repo.Update(dto);
			//
			try
			{
				var service = new CategoryService();
				int rows = service.Update(dto);

				// 回到 FormCategories
				if (rows > 0)
				{
					MessageBox.Show("更新成功");
				}
				else
				{
					MessageBox.Show("更新失敗, 原因: 可能是沒有這筆記錄,例如已經被別人刪除");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("更新失敗, 原因:" + ex.Message);
			}

			IGrid parent = this.Owner as IGrid; // 將開啟我的那個視窗, 轉型成 IGrid, 如果轉型失敗,不會丟出例外, 而是傳回null
			if (parent == null) // 表示轉型失敗
			{
				MessageBox.Show("開啟我的表單, 它忘記實作 IGrid,所以無法通知它");
			}
			else
			{
				parent.Display(); // 呼叫它的 Display() 重新顯示資料
			}

			this.Close();
		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			var repo = new CategoryRepository();
			try
			{
				int rows = repo.Delete(_categoryId);

				// 回到 FormCategories
				if (rows > 0)
				{
					MessageBox.Show("刪除成功");
				}
				else
				{
					MessageBox.Show("刪除失敗");
				}

				IGrid parent = this.Owner as IGrid; // 將開啟我的那個視窗, 轉型成 IGrid, 如果轉型失敗,不會丟出例外, 而是傳回null
				if (parent == null) // 表示轉型失敗
				{
					MessageBox.Show("開啟我的表單, 它忘記實作 IGrid,所以無法通知它");
				}
				else
				{
					parent.Display(); // 呼叫它的 Display() 重新顯示資料
				}

				this.Close();

			}
			catch (Exception ex) {
				MessageBox.Show("刪除失敗, 原因: " + ex.Message);
			}
		}
	}
}
