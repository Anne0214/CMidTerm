using FormMain.EF_Models;
using ISpan2023.UCook.BackEnd.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormMain
{
	public partial class FormRecipeEdit : Form
	{
        private string _recipePk { get; set; }
        private string _coverFilePath { get; set; }

        public FormRecipeEdit(string recipePk)
		{
			InitializeComponent();

            _recipePk = recipePk;

            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(230)))));

            //comboBox內容物填裝
            string[] costMinutes = new string[] { "5", "10", "15", "20", "30", "45", "60", "90", "120", "180+","--"};
            string[] amount = new string[] { "1", "2", "3", "4","5", "6", "7", "8", "9", "10+","--"};
            comboBoxCostMinutes.Items.AddRange(costMinutes);
            comboBoxAmount.Items.AddRange(amount);

            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.SizeMode = TabSizeMode.Fixed;
        }
        private void Get()
        {
            #region 取得資料
            var db = new AppDbContext();
            var recipeInfo = db.RECIPE_食譜.Where(x => x.RECIPE食譜_PK == _recipePk)
                                        .SingleOrDefault();

            var step = db.RECIPE_食譜.Where(x => x.RECIPE食譜_PK == _recipePk)
                                        .SelectMany(x => x.STEP_步驟列表)
                                        .ToList();

            var food = db.RECIPE_食譜.Where(x => x.RECIPE食譜_PK == _recipePk)
                                        .SelectMany(x => x.FOOD_食材)
                                        .ToList();

            var r_category3 = (from r in db.RECIPE_食譜
                               join c3 in db.CATEGORY_食譜分類_LEVEL_THREE on r.FEATURED_CATEGORY精選分類LEVEL_THREE equals c3.FEATURED_CATEGORY精選分類LEVEL_THREE_PK
                               where r.RECIPE食譜_PK == _recipePk
                               select new
                               {
                                   c3Name = c3.FEATURED_CATEGORY精選分類LEVEL_THREE_NAME名稱,
                                   c3Index = r.FEATURED_CATEGORY精選分類LEVEL_THREE
                               }).SingleOrDefault();

            var r_category2 = (from r in db.RECIPE_食譜
                               join c2 in db.CATEGORY_食譜分類_LEVEL_TWO on r.FEATURED_CATEGORY精選分類LEVEL_TWO equals c2.FEATURED_CATEGORY精選分類LEVEL_TWO_PK
                               where r.RECIPE食譜_PK == _recipePk
                               select new
                               {
                                   c2Name = c2.FEATURED_CATEGORY精選分類LEVEL_TWO_NAME名稱,
                                   c2Index = r.FEATURED_CATEGORY精選分類LEVEL_TWO,
                                   c1Index = c2.LEVEL_ONE_FK
                               }).SingleOrDefault();

            var r_category1 = db.CATEGORY_食譜分類_LEVEL_ONE.Where(x => x.FEATURED_CATEGORY精選分類LEVEL_ONE_PK == r_category2.c1Index)
                                                 .Select(x => x.FEATURED_CATEGORY精選分類LEVEL_ONE_NAME名稱)
                                                 .SingleOrDefault();

            var list_c1 = db.CATEGORY_食譜分類_LEVEL_ONE
                            .Select(x => x.FEATURED_CATEGORY精選分類LEVEL_ONE_NAME名稱)
                            .ToArray();


            var list_c2 = db.CATEGORY_食譜分類_LEVEL_TWO
                                .Where(x => x.LEVEL_ONE_FK == r_category2.c1Index)
                                .Select(x => x.FEATURED_CATEGORY精選分類LEVEL_TWO_NAME名稱)
                                .ToArray();

            var list_c3 = db.CATEGORY_食譜分類_LEVEL_THREE
                                .Where(x => x.LEVEL_TWO_FK == r_category2.c2Index)
                                .Select(x => x.FEATURED_CATEGORY精選分類LEVEL_THREE_NAME名稱)
                                .ToArray();
            #endregion

            #region 填資料進入
            
            //封面圖
            var img = new ImageUpload();
            img.ReadImage(pictureBoxCover,recipeInfo.RECIPE_COVER, @"https://i.imgur.com/Kq5dm0M.png");

            //分類
            comboBoxCategory1.Items.AddRange(list_c1);
            comboBoxCategory2.Items.AddRange(list_c2);
            
            if (list_c3 != null)
            {
                comboBoxCategory3.Items.AddRange(list_c3);
            }
            comboBoxCategory3.Items.Add("--");
            comboBoxCategory1.SelectedItem = r_category1;
            comboBoxCategory2.SelectedItem = r_category2.c2Name;
            if(r_category3 !=null)
            {
                comboBoxCategory3.SelectedItem = r_category3.c3Name;
            }
            else
            {
                comboBoxCategory3.SelectedItem = "--";
            }

            //各列文字
            textBoxRecipePk.afiledValue = _recipePk;
            textBoxRecipeName.afiledValue = recipeInfo.RECIPE_NAME食譜名稱;
            textBoxAuthor.afiledValue = recipeInfo.AUTHOR_作者;
            textBoxPublishedTime.afiledValue = recipeInfo.PUBLISHED_TIME發表時間.ToString();

            if(!string.IsNullOrEmpty(recipeInfo.AMOUNT_份量))
            {
                comboBoxAmount.SelectedItem = recipeInfo.AMOUNT_份量;
            }
            else
            {
                comboBoxAmount.SelectedItem = "--";
            }

            if (!string.IsNullOrEmpty(recipeInfo.COST_MINUTES花費時間))
            {
                comboBoxCostMinutes.SelectedItem = recipeInfo.COST_MINUTES花費時間;
            }
            else
            {
                comboBoxCostMinutes.SelectedItem = "--";
            }
            
            //描述
            textBoxShortDescription.afiledValue = recipeInfo.SHORT_DESCRIPTION簡短說明;

            //食材
            textBoxFood1.Text = food.First().FOOD_NAME食材名稱;
            textBoxFoodAmount1.Text = food.First().FOOD_AMOUNT食材數量;

            textBoxFood1.Text = food[0].FOOD_NAME食材名稱;
            textBoxFoodAmount1.Text = food[1].FOOD_AMOUNT食材數量;
        
            foreach(var f in food.GetRange(1,food.Count-1))
            {
                AddNewIngredient(f.FOOD_NAME食材名稱, f.FOOD_AMOUNT食材數量);
            }

            //步驟
            textBoxStep1.Text = step[0].STEP_DESCRIPTION步驟說明;
            img.ReadImage(pictureStep1, step[0].STEP_DESCRIPTION_PICTURE步驟附圖, @"https://i.imgur.com/Um6a2HT.png");

            foreach(var s in step.GetRange(1, step.Count - 1))
            {
                AddNewStep(s.STEP_DESCRIPTION_PICTURE步驟附圖, s.STEP_DESCRIPTION步驟說明);
            }
#endregion

        }

		private void AddNewIngredient(string food, string foodAmount)
		{
            int rowsCount = tableIngredient.RowCount;
            tableIngredient.RowCount += 1; //增加一個row
            TextBox textBoxLeft = new TextBox();
            textBoxLeft.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            textBoxLeft.Size = new System.Drawing.Size(260, 39);
            textBoxLeft.Text = food;

            TextBox textBoxRight = new TextBox();
            textBoxRight.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            textBoxRight.Size = new System.Drawing.Size(260, 39);
            textBoxRight.Text = foodAmount;

            Button buttonDelete = new Button();
            buttonDelete.Size = new System.Drawing.Size(108, 29);
            buttonDelete.Text = "刪除";
            buttonDelete.Click += DeleteIngredient;
            buttonDelete.UseVisualStyleBackColor = true;

            Button buttonInsert = new Button();
            buttonInsert.Size = new System.Drawing.Size(110, 29);
            buttonInsert.Text = "插入";
            buttonInsert.Click += InsertIngredient;
            buttonInsert.UseVisualStyleBackColor = true;

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
            buttonDelete.UseVisualStyleBackColor = true;

            Button buttonInsert = new Button();
            buttonInsert.Size = new System.Drawing.Size(110, 29);
            buttonInsert.Text = "插入";
            buttonInsert.Click += InsertIngredient;
            buttonInsert.UseVisualStyleBackColor = true;

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
		private void AddNewStep(string pic, string description)
		{
            var img = new ImageUpload();
            int rowsCount = tableSteps.RowCount;

            Label labelStep = new Label();
            labelStep.AutoSize = true;
            labelStep.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            labelStep.Size = new System.Drawing.Size(36, 40);
            labelStep.Text = (rowsCount+1).ToString();

            PictureBox pictureBoxStep = new PictureBox();
            pictureBoxStep.Size = new System.Drawing.Size(258, 194);
            pictureBoxStep.TabStop = false;
            pictureBoxStep.SizeMode = PictureBoxSizeMode.StretchImage;
            img.ReadImage(pictureBoxStep, pic, @"https://i.imgur.com/Um6a2HT.png");

            TextBox textBoxStep = new TextBox();
            textBoxStep.Multiline = true;
            textBoxStep.Size = new System.Drawing.Size(390, 180);
            textBoxStep.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            textBoxStep.Text = description;

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
            this.panel1.Location = new System.Drawing.Point(panel1.Location.X, panel1.Location.Y + 220);
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
            this.panel1.Location = new System.Drawing.Point(panel1.Location.X, panel1.Location.Y - 220);

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
            this.panel1.Location = new System.Drawing.Point(panel1.Location.X, panel1.Location.Y + 220);
            tableSteps.Visible = true;

        }

        private void buttonIngredientAdd_Click(object sender, EventArgs e)
        {
            AddNewIngredient("","");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var controls = tableIngredient.Controls;
            MessageBox.Show(controls.Count.ToString());
        }

        private void FormRecipeEdit_Load(object sender, EventArgs e)
        {
            Get();
        }

        private void buttonStepAdd_Click(object sender, EventArgs e)
        {
            AddNewStep("","");
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

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            int index = this.tabControl1.SelectedIndex;
            if (index > 0)
                this.tabControl1.SelectedIndex = index - 1;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            int index = this.tabControl1.SelectedIndex;
            if (index < this.tabControl1.TabPages.Count)
                this.tabControl1.SelectedIndex = index + 1;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //取值

            string c1_name = comboBoxCategory1.SelectedItem.ToString();
            string c2_name = comboBoxCategory2.SelectedItem.ToString();
            string c3_name = String.Empty;
            if (comboBoxCategory3.SelectedItem != null)
            {
                c3_name = comboBoxCategory3.SelectedItem.ToString();
            }

            string recipeName = textBoxRecipeName.afiledValue;
            string amount = comboBoxAmount.SelectedItem.ToString();
            string costTime = comboBoxCostMinutes.SelectedItem.ToString();
            string description = textBoxShortDescription.afiledValue;

            //食材
            int count = 0;
            List<string> food_names = new List<string>();
            List<string> food_amount = new List<string>();
            foreach (var i in tableIngredient.Controls)
            {
                if(i.GetType() == typeof(TextBox))
                {
                    TextBox name = (TextBox)i;
                    if (string.IsNullOrEmpty(name.Text))
                    {
                        count++;
                        continue;
                    }
                    if (count % 2 == 0 )
                    {
                        food_names.Add(name.Text.ToString());
                    }
                    else
                    {
                        food_amount.Add(name.Text.ToString());
                    }
                    count++;
                }
            }

            //步驟
            List<string> step_pics = new List<string>();
            List<string> step_intros = new List<string>();
            foreach (var i in tableSteps.Controls)
            {
                if (i.GetType() == typeof(TextBox))
                {
                    TextBox step_intro = (TextBox)i;
                    if (string.IsNullOrEmpty(step_intro.Text))
                    {
                        continue;
                    }

                    step_intros.Add(step_intro.Text.ToString());

                }
                if(i.GetType() == typeof(PictureBox))
                {
                    PictureBox step_pic  = (PictureBox)i;
                    if(string.IsNullOrEmpty(step_pic.ImageLocation))
                    {
                        continue;
                    }
                    step_pics.Add(step_pic.ImageLocation);
                }
            }


            //欄位檢查(待補)

            //儲存(待補TRY CATCH)
            var db = new AppDbContext();
            var recipe = db.RECIPE_食譜.Find(_recipePk);
            var c1_Pk = db.CATEGORY_食譜分類_LEVEL_ONE
                          .AsNoTracking()
                          .Where(x => x.FEATURED_CATEGORY精選分類LEVEL_ONE_NAME名稱 == c1_name)
                          .Select(x => x.FEATURED_CATEGORY精選分類LEVEL_ONE_PK)
                          .SingleOrDefault();

            var c2_Pk = db.CATEGORY_食譜分類_LEVEL_TWO
                          .AsNoTracking()
                          .Where(x => x.FEATURED_CATEGORY精選分類LEVEL_TWO_NAME名稱 == c2_name)
                          .Select(x => x.FEATURED_CATEGORY精選分類LEVEL_TWO_PK)
                          .SingleOrDefault();

            var c3_Pk = db.CATEGORY_食譜分類_LEVEL_THREE
                          .AsNoTracking()
                          .Where(x => x.FEATURED_CATEGORY精選分類LEVEL_THREE_NAME名稱 == c3_name)
                          .Select(x => x.FEATURED_CATEGORY精選分類LEVEL_THREE_PK)
                          .SingleOrDefault();

            recipe.RECIPE_COVER = _coverFilePath;
            recipe.RECIPE_NAME食譜名稱 = recipeName;
            recipe.AMOUNT_份量 = amount;
            recipe.COST_MINUTES花費時間 = costTime;
            recipe.SHORT_DESCRIPTION簡短說明 = description;
            recipe.FEATURED_CATEGORY精選分類LEVEL_ONE = c1_Pk;
            recipe.FEATURED_CATEGORY精選分類LEVEL_TWO = c2_Pk;

            if(c3_Pk == 0)
            {
                recipe.FEATURED_CATEGORY精選分類LEVEL_THREE = null;
            }
            else
            {
                recipe.FEATURED_CATEGORY精選分類LEVEL_THREE = c3_Pk;
            }
           


            //找到該筆食譜的步驟跟食材編號
            int[] step_pks = recipe.STEP_步驟列表.Select(x => x.STEP_步驟_PK).ToArray();
            int[] food_pks = recipe.FOOD_食材.Select(x => x.FOOD_食材_PK).ToArray();

            //該筆食譜的步驟、食材改成新的
            List<FOOD_食材> food_list = new List<FOOD_食材>();
            for (int f = 0; f < food_names.Count; f++)
            {
                var food = new FOOD_食材
                {
                    FOOD_AMOUNT食材數量 = food_amount[f],
                    FOOD_NAME食材名稱 = food_names[f],
                    RECIPE_FOOD_食譜_FK = _recipePk
                };
                food_list.Add(food);
            };

            recipe.FOOD_食材 = food_list;

            List<STEP_步驟列表> step_list = new List<STEP_步驟列表>();
            for (int s = 0; s < step_pics.Count; s++)
            {
                var step = new STEP_步驟列表
                {
                    RECIPE_STEP_食譜_FK = _recipePk,
                    STEP_DESCRIPTION_PICTURE步驟附圖 = step_pics[s],
                    STEP_DESCRIPTION步驟說明 = step_intros[s],
                };
                step_list.Add(step);
            };
            recipe.STEP_步驟列表 = step_list;


            db.SaveChanges();

            INotify owner = this.Owner as INotify;
            owner.Success("修改成功");
            this.Close();
        }

        private void comboBoxCategory1_SelectedValueChanged(object sender, EventArgs e)
        {
            //當分類1選中的項目改變時，第二層選擇要改變
            comboBoxCategory2.Items.Clear();
            string c1_name = comboBoxCategory1.SelectedItem.ToString();

            var category1 = new AppDbContext().CATEGORY_食譜分類_LEVEL_ONE
                            .AsNoTracking()        
                            .Where(x => x.FEATURED_CATEGORY精選分類LEVEL_ONE_NAME名稱 == c1_name)
                            .Select(x =>x.FEATURED_CATEGORY精選分類LEVEL_ONE_PK)
                            .SingleOrDefault();

            var category2 = new AppDbContext().CATEGORY_食譜分類_LEVEL_TWO
                                    .AsNoTracking()
                                    .Where(x => x.LEVEL_ONE_FK == category1)
                                    .Select(x => x.FEATURED_CATEGORY精選分類LEVEL_TWO_NAME名稱)
                                    .ToArray();

            comboBoxCategory2.Items.AddRange(category2);
            comboBoxCategory2.SelectedItem = category2[0];


        }

        private void comboBoxCategory2_SelectedValueChanged(object sender, EventArgs e)
        {
            comboBoxCategory3.Items.Clear();
            string c2_name = comboBoxCategory2.SelectedItem.ToString();
            var category2 = new AppDbContext().CATEGORY_食譜分類_LEVEL_TWO
                              .AsNoTracking()
                              .Where(x => x.FEATURED_CATEGORY精選分類LEVEL_TWO_NAME名稱 == c2_name)
                              .Select(x => x.FEATURED_CATEGORY精選分類LEVEL_TWO_PK)
                              .SingleOrDefault();
            var category3 = new AppDbContext().CATEGORY_食譜分類_LEVEL_THREE
                             .AsNoTracking()
                             .Where(x => x.LEVEL_TWO_FK == category2)
                             .Select(x => x.FEATURED_CATEGORY精選分類LEVEL_THREE_NAME名稱)
                             .ToArray();
            if(category3 == null)
            {
                comboBoxCategory3.Items.Add("--");
            }
            else
            {
                comboBoxCategory3.Items.AddRange(category3);
            }
        }

 
    }
}
