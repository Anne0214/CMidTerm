using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.SizeMode = TabSizeMode.Fixed;

        }

        private void button1_Click(object sender, EventArgs e)
		{

			tableLayoutPanel1.RowCount += 1; //增加一個row
            //this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40));
            int rowsCount = tableLayoutPanel1.RowCount;
			TextBox textBoxLeft = new TextBox();
			textBoxLeft.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			textBoxLeft.Size = new System.Drawing.Size(172, 29);

			TextBox textBoxRight = new TextBox();
			textBoxRight.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			textBoxRight.Size = new System.Drawing.Size(172, 29);

            Button buttonDelete = new Button();
            buttonDelete.Dock = System.Windows.Forms.DockStyle.Bottom;
            buttonDelete.Size = new System.Drawing.Size(111, 23);
            buttonDelete.Text = "刪除";
            buttonDelete.Click += buttonDelete_Click;

            Button buttonInsert = new Button();
            buttonInsert.Dock = System.Windows.Forms.DockStyle.Bottom;
            buttonInsert.Size = new System.Drawing.Size(111, 23);
            buttonInsert.Text = "插入";
            buttonInsert.Click += buttonInsert_Click;

            this.tableLayoutPanel1.Controls.Add(textBoxLeft,0,rowsCount);
			this.tableLayoutPanel1.Controls.Add(textBoxRight, 1, rowsCount);
            this.tableLayoutPanel1.Controls.Add(buttonDelete, 2, rowsCount);
            this.tableLayoutPanel1.Controls.Add(buttonInsert, 3, rowsCount);

            this.button1.Location = new System.Drawing.Point(button1.Location.X, button1.Location.Y+40);
			
		}

        private void button3_Click(object sender, EventArgs e)
        {
            int index = this.tabControl1.SelectedIndex;
            if (index > 0)
                this.tabControl1.SelectedIndex = index - 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index = this.tabControl1.SelectedIndex;
            if (index < this.tabControl1.TabPages.Count)
                this.tabControl1.SelectedIndex = index + 1;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            StringBuilder strBuilder =  new StringBuilder();
            foreach(Control i in tableLayoutPanel1.Controls)
            {
                strBuilder.Append(i.Text);
                
            }
            MessageBox.Show(strBuilder.ToString());
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(tableLayoutPanel1.RowStyles.Count.ToString());
            //取得列
            Button buttonClicked = (Button)sender;
            int row=tableLayoutPanel1.GetRow(buttonClicked);

            
            int column = tableLayoutPanel1.ColumnCount;

            // 先刪除該行的控件
            Control control;
            for (int j = 0; j < column; j++)
            {
                control = tableLayoutPanel1.GetControlFromPosition(j, row);
                tableLayoutPanel1.Controls.Remove(control);
            }

            //將下方的控件提上來
            for(int k = row; k < tableLayoutPanel1.RowCount; k++)
            {
                Control ctlNext1 = tableLayoutPanel1.GetControlFromPosition(0, k + 1);
                tableLayoutPanel1.SetCellPosition(ctlNext1, new TableLayoutPanelCellPosition(0, k));

                Control ctlNext2 = tableLayoutPanel1.GetControlFromPosition(1, k + 1);
                tableLayoutPanel1.SetCellPosition(ctlNext2, new TableLayoutPanelCellPosition(1, k));

                Control ctlNext3 = tableLayoutPanel1.GetControlFromPosition(2, k + 1);
                tableLayoutPanel1.SetCellPosition(ctlNext3, new TableLayoutPanelCellPosition(2, k));

                Control ctlNext4 = tableLayoutPanel1.GetControlFromPosition(3, k + 1);
                tableLayoutPanel1.SetCellPosition(ctlNext4, new TableLayoutPanelCellPosition(3, k));
            }
           
            //// 删除該行樣式
            //tableLayoutPanel1.RowStyles.RemoveAt(row);
            // 行數 -1
            tableLayoutPanel1.RowCount = tableLayoutPanel1.RowCount - 1;
            
            //按鈕回上面
            this.button1.Location = new System.Drawing.Point(button1.Location.X, button1.Location.Y - 40);

        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            //增加列數
            tableLayoutPanel1.RowCount++; //增加一個row

            //取得要插入的列數
            Control insertSender = (Control)sender;
            int insertRowNum = tableLayoutPanel1.GetRow(insertSender)+1;//假設按index=3

            //將已存在的往下移
            foreach (Control ExistControl in tableLayoutPanel1.Controls)
            {
                if (tableLayoutPanel1.GetRow(ExistControl) >= insertRowNum) //是要插入到3的下面，所以>3
                {
                    tableLayoutPanel1.SetRow(ExistControl,
                                            tableLayoutPanel1.GetRow(ExistControl) + 1); //往下移一個
                }
            }


            //增加新的row
           
            TextBox textBoxLeft = new TextBox();
            textBoxLeft.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            textBoxLeft.Size = new System.Drawing.Size(172, 29);

            TextBox textBoxRight = new TextBox();
            textBoxRight.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            textBoxRight.Size = new System.Drawing.Size(172, 29);

            Button buttonDelete = new Button();
            buttonDelete.Dock = System.Windows.Forms.DockStyle.Bottom;
            buttonDelete.Size = new System.Drawing.Size(111, 23);
            buttonDelete.Text = "刪除";
            buttonDelete.Click += buttonDelete_Click;

            Button buttonInsert = new Button();
            buttonInsert.Dock = System.Windows.Forms.DockStyle.Bottom;
            buttonInsert.Size = new System.Drawing.Size(111, 23);
            buttonInsert.Text = "插入";
            buttonInsert.Click += buttonInsert_Click;

            this.tableLayoutPanel1.Controls.Add(textBoxLeft, 0, insertRowNum);
            this.tableLayoutPanel1.Controls.Add(textBoxRight, 1, insertRowNum);
            this.tableLayoutPanel1.Controls.Add(buttonDelete, 2, insertRowNum);
            this.tableLayoutPanel1.Controls.Add(buttonInsert, 3, insertRowNum);

            this.button1.Location = new System.Drawing.Point(button1.Location.X, button1.Location.Y + 40);
        }
    }
}
