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


	}
}
