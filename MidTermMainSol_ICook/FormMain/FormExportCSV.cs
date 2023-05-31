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
	public partial class FormExportCSV<T> : Form
	{
		/// <summary>
		/// 欄位名稱(中文)跟屬性名稱的配對。這樣才能知道用戶選的欄位對應到哪些屬性。
		/// </summary>
		private Dictionary<string, string> _columnPropertyPair;

		/// <summary>
		/// 用戶選中的資料的dto
		/// </summary>
		private List<T> _SelectedData { get; set; }
 

        public FormExportCSV(Dictionary<string,string> ColumnPropertyPair, List<T> selectedData)
		{
			InitializeComponent();
			_columnPropertyPair = ColumnPropertyPair;
			_SelectedData = selectedData;
		}

		private void FormExportCSV_Load(object sender, EventArgs e)
		{
			var columnName = _columnPropertyPair.Keys.ToArray<String>();
			listBoxOption.Items.AddRange(columnName);
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



		public void ExportCsv(string filePath)
		{
			List<string> properties = new List<string>();
			//整理出被選中的Property
			foreach (var i in listBoxSelected.SelectedItems)
			{
				properties.Add(_columnPropertyPair[i.ToString()]);
			}
			//得到該dto所有屬性
			Type t = typeof(T);
			PropertyInfo[] propInfos = t.GetProperties(BindingFlags.Public);

			//只留下有選中的property
			
			//取交集
			var intersection = propInfos.Select(x => x.ToString()).ToList().Intersect(properties);
			//取交集項目的位置
			var indexs = intersection.Select(x => Array.IndexOf(propInfos,x));
			//篩選propInfos
			propInfos = propInfos.Where((x, i) => indexs.Contains(i)).ToArray();

			using (var file = new StreamWriter(filePath))
			{
				//輸出屬性名稱，作為欄位
				file.WriteLineAsync(string.Join(",", properties));

				foreach (var item in _SelectedData)
				{
					file.WriteLineAsync(string.Join(",", propInfos.Select(i => i.GetValue(item)))); //組成csv文字
				}
			};
		}



		private void buttonExport_Click_1(object sender, EventArgs e)
		{ 
			SaveFileDialog dialog = new SaveFileDialog();
			string filePath = dialog.FileName;

			try
			{
				ExportCsv(filePath);
			}
			catch { 
				MessageBox.Show("輸出失敗，請稍後再試"); 
			}

			//輸出儲存完畢後通知
			IExportCSV frm = this.Owner as IExportCSV;
			frm.success();

		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
