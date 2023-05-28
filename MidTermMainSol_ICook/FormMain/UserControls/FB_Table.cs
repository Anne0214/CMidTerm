using ISpan2023.UCook.BackEnd;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary1
{
    public partial class FB_Table : UserControl
    {

        private DataGridView DataGridView1 = new DataGridView();

        public FB_Table()
        {
            InitializeComponent();

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
            label1.Text = "總共 " + dataGridView1.Rows.Count.ToString() + " 筆";
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

                    }
                    return;

                }
            }
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
                    MessageBox.Show("已複製");
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
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
        }
        
        public string afiled1First
        {
            get { return CheckBox.HeaderText; }
            set { CheckBox.HeaderText = value; }
        }
        public string afiled2Second
        {
            get { return MemberPK.HeaderText; }
            set { MemberPK.HeaderText = value; }
        }
        public string afiled3Third
        {
            get { return MemberName.HeaderText; }
            set { MemberName.HeaderText = value; }
        }
        public string afiled4Fourth
        {
            get { return MemberEmail.HeaderText; }
            set { MemberEmail.HeaderText = value; }
        }
        public string afiled5Fifth
        {
            get { return MemberPhone.HeaderText; }
            set { MemberPhone.HeaderText = value; }
        }
        public string afiled6Sixed
        {
            get { return LastLogin.HeaderText; }
            set { LastLogin.HeaderText = value; }
        }
        public string afiled7Sevened
        {
            get { return RegistrationTime.HeaderText; }
            set { RegistrationTime.HeaderText = value; }
        }
        public string afiled8Eighth
        {
            get { return Operation.HeaderText; }
            set { Operation.HeaderText = value; }
        }

        public string afiledAmount
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }


        public List<IDto> afiledDtoSources
        {
            set { this.dataGridView1.DataSource = value; }
        }



    }
}
