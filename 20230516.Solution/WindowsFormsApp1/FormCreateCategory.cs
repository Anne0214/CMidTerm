using ISpan2023.EStore.SqlDataLayer.Dtos;
using ISpan2023.EStore.SqlDataLayer.Repositories;
using ISpan2023.EStore.SqlDataLayer.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.interfaces;
using WindowsFormsApp1.ViewModels;

namespace WindowsFormsApp1
{
	public partial class FormCreateCategory : Form
	{
		public FormCreateCategory()
		{
			InitializeComponent();
		}

		private (bool isValid, List<ValidationResult> errors) Validate(CategoryCreateVM vm)
		{
			// 得知要驗證規則
			ValidationContext context = new ValidationContext(vm, null, null);

			// 用來存放錯誤的集合,因為可能有零到多個錯誤
			List<ValidationResult> errors = new List<ValidationResult>();

			// 驗證 model
			bool validateAllProperties = true; // 是否驗證所有規則,而非只驗證Required規則
			bool isValid = Validator.TryValidateObject(vm, context, errors, validateAllProperties);

			return (isValid, errors);
		}

		private void DisplayErrors(List<ValidationResult> errors)
		{
			// 大小寫不同仍視為相同的key
			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{"Name", textBoxName},
				{"DisplayOrder", textBoxDisplayOrder}
			};

			this.errorProvider1.Clear();

			foreach (ValidationResult error in errors)
			{
				string propName = error.MemberNames.FirstOrDefault();
				if (map.TryGetValue(propName, out Control ctrl))
				{
					this.errorProvider1.SetError(ctrl, error.ErrorMessage);
				}
			}
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			// 收集表單欄位值,建立CategoryCreateVM物件
			string name = textBoxName.Text;
			int displayOrder = int.Parse(textBoxDisplayOrder.Text);
			var vm = new CategoryCreateVM { Name=name, DisplayOrder=displayOrder};

			// 驗證vm是否通過欄位驗證規則
			(bool isValid, List<ValidationResult> errors) validationResult = Validate(vm);

			//如果有錯, 就顯示它
			if (validationResult.isValid == false)
			{
				this.errorProvider1.Clear();
				DisplayErrors(validationResult.errors);
				return;
			}

			// 如果通過, 將vm轉型為CategoryDto
			CategoryDto dto = new CategoryDto {Id=vm.Id, Name=vm.Name, DisplayOrder=vm.DisplayOrder };

			//以下,就全部接軌了
			try
			{
				var service = new CategoryService();
				int newId = service.Create(dto);
				MessageBox.Show($"新增成功,新的編號為{newId}");
			}
			catch (Exception ex)
			{
				MessageBox.Show("新增失敗, 原因: " + ex.Message);
				return;
			}


			// 關閉表單
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

		private void button1_Click(object sender, EventArgs e)
		{
			errorProvider1.SetError(this.textBoxName, "我是error message");
			errorProvider1.SetError(this.textBoxDisplayOrder, "順序要輸入數字哦");
		}

		private void button2_Click(object sender, EventArgs e)
		{
			errorProvider1.Clear();
		}
	}
}
