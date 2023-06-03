using ISpan2023.UCook.BackEnd.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormMain
{
	public partial class FormRecipeEdit : Form
	{
        private int _recipePk { get; set; }
        private string _coverFilePath { get; set; }

        public FormRecipeEdit()
		{
			InitializeComponent();

			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(213)))), ((int)(((byte)(230)))));

            //comboBox內容物填裝
            string[] costMinutes = new string[] { "5", "10", "15", "20", "30", "45", "60", "90", "120", "180+"};
            string[] amount = new string[] { "1", "2", "3", "4","5", "6", "7", "8", "9", "10+"};
            comboBoxCostMinutes.Items.AddRange(costMinutes);
            comboBoxAmount.Items.AddRange(amount);
        }

		private void AddNewIngredient()
		{
            int rowsCount = tableIngredient.RowCount;
            tableIngredient.RowCount += 1; //增加一個row
            TextBox textBoxLeft = new TextBox();
            textBoxLeft.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            textBoxLeft.Size = new System.Drawing.Size(260, 39);

            TextBox textBoxRight = new TextBox();
            textBoxRight.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            textBoxRight.Size = new System.Drawing.Size(260, 39);

            Button buttonDelete = new Button();
            buttonDelete.Size = new System.Drawing.Size(108, 29);
            buttonDelete.Text = "刪除";
            buttonDelete.Click += DeleteIngredient;

            Button buttonInsert = new Button();
            buttonInsert.Size = new System.Drawing.Size(110, 29);
            buttonInsert.Text = "插入";
            buttonInsert.Click += InsertIngredient;

            this.tableIngredient.Controls.Add(textBoxLeft, 0, rowsCount);
            this.tableIngredient.Controls.Add(textBoxRight, 1, rowsCount);
            this.tableIngredient.Controls.Add(buttonDelete, 2, rowsCount);
            this.tableIngredient.Controls.Add(buttonInsert, 3, rowsCount);
            
            tableIngredient.Height += 40;

            this.buttonIngredientAdd.Location = new System.Drawing.Point(buttonIngredientAdd.Location.X, buttonIngredientAdd.Location.Y + 40);

        }
		private void InsertIngredient(object sender, EventArgs e)
		{
            tableIngredient.Visible = false;
            tableIngredient.RowCount++; //增加一個row
            tableIngredient.Height += 40;
            //取得要插入的列數
            Control insertSender = (Control)sender;
            int insertRowNum = tableIngredient.GetRow(insertSender) + 1;//假設按index=3

            //將已存在的往下移
            foreach (Control ExistControl in tableIngredient.Controls)
            {
                if (tableIngredient.GetRow(ExistControl) >= insertRowNum) //是要插入到3的下面，所以>3
                {
                    tableIngredient.SetRow(ExistControl,
                                            tableIngredient.GetRow(ExistControl) + 1); //往下移一個
                }
            }


            //增加新的row
            TextBox textBoxLeft = new TextBox();
            textBoxLeft.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            textBoxLeft.Size = new System.Drawing.Size(260, 39);

            TextBox textBoxRight = new TextBox();
            textBoxRight.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            textBoxRight.Size = new System.Drawing.Size(260, 39);

            Button buttonDelete = new Button();
            buttonDelete.Size = new System.Drawing.Size(108, 29);
            buttonDelete.Text = "刪除";
            buttonDelete.Click += DeleteIngredient;

            Button buttonInsert = new Button();
            buttonInsert.Size = new System.Drawing.Size(110, 29);
            buttonInsert.Text = "插入";
            buttonInsert.Click += InsertIngredient;

            this.tableIngredient.Controls.Add(textBoxLeft, 0, insertRowNum);
            this.tableIngredient.Controls.Add(textBoxRight, 1, insertRowNum);
            this.tableIngredient.Controls.Add(buttonDelete, 2, insertRowNum);
            this.tableIngredient.Controls.Add(buttonInsert, 3, insertRowNum);


            this.buttonIngredientAdd.Location = new System.Drawing.Point(buttonIngredientAdd.Location.X, buttonIngredientAdd.Location.Y + 40);
            tableIngredient.Visible = true;
        }
		private void DeleteIngredient(object sender, EventArgs e)
		{
            tableIngredient.Visible = false;
            Button buttonClicked = (Button)sender;
            int row = tableIngredient.GetRow(buttonClicked);

            int column = tableIngredient.ColumnCount;

            // 先刪除該行的控件
            Control control;
            for (int j = 0; j < column; j++)
            {
                control = tableIngredient.GetControlFromPosition(j, row);
                tableIngredient.Controls.Remove(control);
            }

            //將下方的控件提上來
            for (int k = row; k < tableIngredient.RowCount-1; k++)
            {
                Control ctlNext1 = tableIngredient.GetControlFromPosition(0, k + 1);
                tableIngredient.SetCellPosition(ctlNext1, new TableLayoutPanelCellPosition(0, k));

                Control ctlNext2 = tableIngredient.GetControlFromPosition(1, k + 1);
                tableIngredient.SetCellPosition(ctlNext2, new TableLayoutPanelCellPosition(1, k));

                Control ctlNext3 = tableIngredient.GetControlFromPosition(2, k + 1);
                tableIngredient.SetCellPosition(ctlNext3, new TableLayoutPanelCellPosition(2, k));

                Control ctlNext4 = tableIngredient.GetControlFromPosition(3, k + 1);
                tableIngredient.SetCellPosition(ctlNext4, new TableLayoutPanelCellPosition(3, k));
            }

            //// 删除該行樣式
            //tableIngredient.RowStyles.RemoveAt(row);
            // 行數 -1
            tableIngredient.RowCount = tableIngredient.RowCount - 1;

            //高度減
            tableIngredient.Height = tableIngredient.Height - 40;

            //按鈕回上面
            this.buttonIngredientAdd.Location = new System.Drawing.Point(buttonIngredientAdd.Location.X, buttonIngredientAdd.Location.Y - 40);

            tableIngredient.Visible = true;
        }
		private void AddNewStep()
		{
            int rowsCount = tableSteps.RowCount;

            Label labelStep = new Label();
            labelStep.AutoSize = true;
            labelStep.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            labelStep.Size = new System.Drawing.Size(36, 40);
            labelStep.Text = (rowsCount+1).ToString();

            PictureBox pictureBoxStep = new PictureBox();
            pictureBoxStep.Size = new System.Drawing.Size(258, 194);
            pictureBoxStep.TabStop = false;

            TextBox textBoxStep = new TextBox();
            textBoxStep.Multiline = true;
            textBoxStep.Size = new System.Drawing.Size(390, 180);

            Button buttonDeleteStep = new Button();
            buttonDeleteStep.Dock = System.Windows.Forms.DockStyle.Bottom;
            buttonDeleteStep.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            buttonDeleteStep.Size = new System.Drawing.Size(93, 37);
            buttonDeleteStep.Text = "刪除";
            buttonDeleteStep.UseVisualStyleBackColor = true;
            buttonDeleteStep.Click += DeleteStep;


            Button buttonInsertStep = new Button();
            buttonInsertStep.Dock = System.Windows.Forms.DockStyle.Bottom;
            buttonInsertStep.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            buttonInsertStep.Size = new System.Drawing.Size(95, 37);
            buttonInsertStep.Text = "插入";
            buttonInsertStep.UseVisualStyleBackColor = true;
            buttonInsertStep.Click += InsertStep;


            this.tableSteps.Controls.Add(labelStep, 0, rowsCount);
            this.tableSteps.Controls.Add(pictureBoxStep, 1, rowsCount);
            this.tableSteps.Controls.Add(textBoxStep, 2, rowsCount);
            this.tableSteps.Controls.Add(buttonDeleteStep, 3, rowsCount);
            this.tableSteps.Controls.Add(buttonInsertStep, 4, rowsCount);
            tableSteps.RowCount += 1; //增加一個row
            tableSteps.Height += 210;


            this.buttonStepAdd.Location = new System.Drawing.Point(buttonStepAdd.Location.X, buttonStepAdd.Location.Y + 220);

        }
		private void DeleteStep(object sender, EventArgs e)
		{
            tableSteps.Visible = false;
            Button buttonClicked = (Button)sender;
            int row = tableSteps.GetRow(buttonClicked);

            int column = tableSteps.ColumnCount;

            // 先刪除該行的控件
            Control control;
            for (int j = 0; j < column; j++)
            {
                control = tableSteps.GetControlFromPosition(j, row);
                tableSteps.Controls.Remove(control);
            }

            //將下方的控件提上來
            for (int k = row; k < tableSteps.RowCount - 1; k++)
            {
                Control ctlNext1 = tableSteps.GetControlFromPosition(0, k + 1);
                tableSteps.SetCellPosition(ctlNext1, new TableLayoutPanelCellPosition(0, k));

                Control ctlNext2 = tableSteps.GetControlFromPosition(1, k + 1);
                tableSteps.SetCellPosition(ctlNext2, new TableLayoutPanelCellPosition(1, k));

                Control ctlNext3 = tableSteps.GetControlFromPosition(2, k + 1);
                tableSteps.SetCellPosition(ctlNext3, new TableLayoutPanelCellPosition(2, k));

                Control ctlNext4 = tableSteps.GetControlFromPosition(3, k + 1);
                tableSteps.SetCellPosition(ctlNext4, new TableLayoutPanelCellPosition(3, k));

                Control ctlNext5 = tableSteps.GetControlFromPosition(4, k + 1);
                tableSteps.SetCellPosition(ctlNext5, new TableLayoutPanelCellPosition(4, k));
            }

            //// 删除該行樣式
            //tableIngredient.RowStyles.RemoveAt(row);
            // 行數 -1
            tableSteps.RowCount = tableSteps.RowCount - 1;

            //高度減
            tableSteps.Height = tableSteps.Height - 210;

            //按鈕回上面
            this.buttonStepAdd.Location = new System.Drawing.Point(buttonStepAdd.Location.X, buttonStepAdd.Location.Y - 210);

            tableSteps.Visible = true;

        }
		private void InsertStep(object sender, EventArgs e)
		{
            tableSteps.Visible = false;
            tableSteps.RowCount++; //增加一個row
            tableSteps.Height += 210;
            //取得要插入的列數
            Control insertSender = (Control)sender;
            int insertRowNum = tableSteps.GetRow(insertSender) + 1;//假設按index=3

            //將已存在的往下移
            foreach (Control ExistControl in tableSteps.Controls)
            {
                if (tableSteps.GetRow(ExistControl) >= insertRowNum) //是要插入到3的下面，所以>3
                {
                    tableSteps.SetRow(ExistControl,
                                            tableSteps.GetRow(ExistControl) + 1); //往下移一個
                }
            }


            //增加新的row
            Label labelStep = new Label();
            labelStep.AutoSize = true;
            labelStep.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            labelStep.Size = new System.Drawing.Size(36, 40);
            labelStep.Text = (insertRowNum + 1).ToString();

            PictureBox pictureBoxStep = new PictureBox();
            pictureBoxStep.Size = new System.Drawing.Size(258, 194);
            pictureBoxStep.TabStop = false;

            TextBox textBoxStep = new TextBox();
            textBoxStep.Multiline = true;
            textBoxStep.Size = new System.Drawing.Size(390, 180);

            Button buttonDeleteStep = new Button();
            buttonDeleteStep.Dock = System.Windows.Forms.DockStyle.Bottom;
            buttonDeleteStep.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            buttonDeleteStep.Size = new System.Drawing.Size(93, 37);
            buttonDeleteStep.Text = "刪除";
            buttonDeleteStep.UseVisualStyleBackColor = true;
            buttonDeleteStep.Click += DeleteStep;

            Button buttonInsertStep = new Button();
            buttonInsertStep.Dock = System.Windows.Forms.DockStyle.Bottom;
            buttonInsertStep.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            buttonInsertStep.Size = new System.Drawing.Size(95, 37);
            buttonInsertStep.Text = "插入";
            buttonInsertStep.UseVisualStyleBackColor = true;
            buttonInsertStep.Click += InsertStep;


            this.tableSteps.Controls.Add(labelStep, 0, insertRowNum);
            this.tableSteps.Controls.Add(pictureBoxStep, 1, insertRowNum);
            this.tableSteps.Controls.Add(textBoxStep, 2, insertRowNum);
            this.tableSteps.Controls.Add(buttonDeleteStep, 3, insertRowNum);
            this.tableSteps.Controls.Add(buttonInsertStep, 4, insertRowNum);


            this.buttonStepAdd.Location = new System.Drawing.Point(buttonStepAdd.Location.X, buttonStepAdd.Location.Y + 210);
            tableSteps.Visible = true;

        }

        private void buttonIngredientAdd_Click(object sender, EventArgs e)
        {
            AddNewIngredient();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var controls = tableIngredient.Controls;
            MessageBox.Show(controls.Count.ToString());
        }

        private void FormRecipeEdit_Load(object sender, EventArgs e)
        {
        }

        private void buttonStepAdd_Click(object sender, EventArgs e)
        {
            AddNewStep();
        }

        private void buttonUpload_Click(object sender, EventArgs e)
        {
            try
            {
                var imgService = new ImageUpload();
                _coverFilePath = imgService.UploadIMG();
                var MyImage = new Bitmap(_coverFilePath);
                pictureBoxCover.Image = (System.Drawing.Image)MyImage;
            }
            catch
            {
                return;
            }
        }
    }
}
