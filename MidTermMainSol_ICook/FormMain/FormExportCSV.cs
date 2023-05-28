using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormMain
{
	public partial class FormExportCSV : Form
	{
        private String[] _Options { get; set; }



        /// <summary>
        /// 需定義可選欄位包含哪些，將會在視窗載入時成為可選欄位的內容
        /// </summary>
        /// <param name="columns">中文欄位名稱組成的Array</param>
        public FormExportCSV(string[] columns)
		{
			InitializeComponent();
			_Options = columns;
		}

		private void FormExportCSV_Load(object sender, EventArgs e)
		{
			listBoxOption.Items.AddRange(_Options);
		}

		private void buttonToRight_Click(object sender, EventArgs e)
		{
			if (listBoxOption.SelectedItem != null)        //判斷listbox內是否選取項目
			{
				string SelectedItem = listBoxOption.SelectedItem.ToString();   //設定回傳所選項目字串给 SelectedItem
				listBoxSelected.Items.Add(SelectedItem);  //增加項目至listBoxOutput輸出                    
				listBoxOption.Items.Remove(SelectedItem);  //移除listBoxInput輸入所選項目
			}
		}

		private void buttonToLeft_Click(object sender, EventArgs e)
		{
			if (listBoxSelected.SelectedItem != null)
			{
				string SelectedItem = listBoxSelected.SelectedItem.ToString();
				listBoxOption.Items.Add(SelectedItem);
				listBoxSelected.Items.Remove(SelectedItem);
			}
		}

		private void buttonUp_Click(object sender, EventArgs e)
		{
			if (listBoxSelected.SelectedItem != null)
			{
				int SelectedIndex = listBoxSelected.SelectedIndex;  //設定回傳索引給變量
				object selectedItem = listBoxSelected.SelectedItem;  //將選取項目儲存給變量
				listBoxSelected.Items.RemoveAt(SelectedIndex);        //移除所選索引
				listBoxSelected.Items.Insert(SelectedIndex - 1, selectedItem); //將所選插入前一個位置
				listBoxSelected.SelectedIndex = SelectedIndex - 1;   //將插入項設為選中狀態
			}
		}

		private void buttonDown_Click(object sender, EventArgs e)
		{
			if (listBoxSelected.SelectedItem != null)
			{
				int SelectedIndex = listBoxSelected.SelectedIndex;
				object selectedItem = listBoxSelected.SelectedItem;
				listBoxSelected.Items.RemoveAt(SelectedIndex);
				listBoxSelected.Items.Insert(SelectedIndex + 1, selectedItem);
				listBoxSelected.SelectedIndex = SelectedIndex + 1;
			}
		}



		public void ExportCsv<T>(string filePath,List<T> dtos)
		{
			using (var file = new StreamWriter(filePath))
			{
				Type t = typeof(T);
				PropertyInfo[] propInfos = t.GetProperties(BindingFlags.Public | BindingFlags.Instance); //得到該dto的所有屬性
				//輸出屬性名稱
				file.WriteLineAsync(string.Join(",", propInfos.Select(i => i.Name)));

				foreach (var item in dtos)
				{
					file.WriteLineAsync(string.Join(",", propInfos.Select(i => i.GetValue(item)))); //組成csv文字
				}
			}
		}



		private void buttonExport_Click_1(object sender, EventArgs e)
		{ //todo等之後再寫完
			SaveFileDialog dialog = new SaveFileDialog();
			string filePath = dialog.FileName;
			IExportCSV frm = this.Parent as IExportCSV;

		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
