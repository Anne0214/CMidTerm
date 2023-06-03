namespace FormMain
{
	partial class FormRecipeSearch
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonCSV = new System.Windows.Forms.Button();
            this.toast = new FormItem.Toast();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRecipePk = new System.Windows.Forms.TextBox();
            this.textBoxRecipeName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAuthorPk = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAuthorName = new System.Windows.Forms.TextBox();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.Operation = new System.Windows.Forms.DataGridViewButtonColumn();
            this.col_SoldNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Skus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SalePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_OnShelf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SPU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Checkbox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LabelRowCount = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCSV
            // 
            this.buttonCSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.buttonCSV.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonCSV.ForeColor = System.Drawing.Color.Black;
            this.buttonCSV.Location = new System.Drawing.Point(68, 152);
            this.buttonCSV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCSV.Name = "buttonCSV";
            this.buttonCSV.Size = new System.Drawing.Size(158, 46);
            this.buttonCSV.TabIndex = 16;
            this.buttonCSV.Text = "輸出成CSV";
            this.buttonCSV.UseVisualStyleBackColor = false;
            // 
            // toast
            // 
            this.toast.AMessage = "儲存成功";
            this.toast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.toast.Location = new System.Drawing.Point(39, 510);
            this.toast.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.toast.Name = "toast";
            this.toast.Size = new System.Drawing.Size(304, 82);
            this.toast.TabIndex = 12;
            this.toast.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(64, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 30);
            this.label1.TabIndex = 17;
            this.label1.Text = "食譜PK";
            // 
            // textBoxRecipePk
            // 
            this.textBoxRecipePk.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxRecipePk.Location = new System.Drawing.Point(184, 18);
            this.textBoxRecipePk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxRecipePk.Name = "textBoxRecipePk";
            this.textBoxRecipePk.Size = new System.Drawing.Size(282, 39);
            this.textBoxRecipePk.TabIndex = 18;
            // 
            // textBoxRecipeName
            // 
            this.textBoxRecipeName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxRecipeName.Location = new System.Drawing.Point(658, 18);
            this.textBoxRecipeName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxRecipeName.Name = "textBoxRecipeName";
            this.textBoxRecipeName.Size = new System.Drawing.Size(282, 39);
            this.textBoxRecipeName.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(538, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 30);
            this.label2.TabIndex = 19;
            this.label2.Text = "食譜標題";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(1030, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 30);
            this.label3.TabIndex = 19;
            this.label3.Text = "作者PK";
            // 
            // textBoxAuthorPk
            // 
            this.textBoxAuthorPk.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxAuthorPk.Location = new System.Drawing.Point(1150, 14);
            this.textBoxAuthorPk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxAuthorPk.Name = "textBoxAuthorPk";
            this.textBoxAuthorPk.Size = new System.Drawing.Size(282, 39);
            this.textBoxAuthorPk.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(64, 93);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 30);
            this.label4.TabIndex = 19;
            this.label4.Text = "作者暱稱";
            // 
            // textBoxAuthorName
            // 
            this.textBoxAuthorName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxAuthorName.Location = new System.Drawing.Point(184, 84);
            this.textBoxAuthorName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxAuthorName.Name = "textBoxAuthorName";
            this.textBoxAuthorName.Size = new System.Drawing.Size(282, 39);
            this.textBoxAuthorName.TabIndex = 20;
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateTimePickerStart.Location = new System.Drawing.Point(658, 87);
            this.dateTimePickerStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePickerStart.MaxDate = new System.DateTime(2023, 6, 1, 15, 20, 9, 86);
            this.dateTimePickerStart.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(216, 39);
            this.dateTimePickerStart.TabIndex = 21;
            this.dateTimePickerStart.Value = new System.DateTime(2023, 6, 1, 15, 20, 9, 86);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(538, 93);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 30);
            this.label5.TabIndex = 19;
            this.label5.Text = "發表日期";
            // 
            // Operation
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "修改";
            this.Operation.DefaultCellStyle = dataGridViewCellStyle1;
            this.Operation.HeaderText = "操作";
            this.Operation.MinimumWidth = 8;
            this.Operation.Name = "Operation";
            this.Operation.Text = "修改";
            this.Operation.Width = 150;
            // 
            // col_SoldNumber
            // 
            this.col_SoldNumber.DataPropertyName = "SoldNumber";
            this.col_SoldNumber.HeaderText = "上次更新時間";
            this.col_SoldNumber.MinimumWidth = 8;
            this.col_SoldNumber.Name = "col_SoldNumber";
            this.col_SoldNumber.Width = 150;
            // 
            // col_Skus
            // 
            this.col_Skus.DataPropertyName = "AllSku";
            this.col_Skus.HeaderText = "發表時間";
            this.col_Skus.MinimumWidth = 8;
            this.col_Skus.Name = "col_Skus";
            this.col_Skus.Width = 150;
            // 
            // col_SalePrice
            // 
            this.col_SalePrice.DataPropertyName = "SalePrice";
            this.col_SalePrice.HeaderText = "精選分類";
            this.col_SalePrice.MinimumWidth = 8;
            this.col_SalePrice.Name = "col_SalePrice";
            this.col_SalePrice.Width = 150;
            // 
            // col_CategoryName
            // 
            this.col_CategoryName.DataPropertyName = "Category";
            this.col_CategoryName.HeaderText = "會員暱稱";
            this.col_CategoryName.MinimumWidth = 8;
            this.col_CategoryName.Name = "col_CategoryName";
            this.col_CategoryName.Width = 150;
            // 
            // col_OnShelf
            // 
            this.col_OnShelf.DataPropertyName = "OnShelf";
            this.col_OnShelf.HeaderText = "會員PK";
            this.col_OnShelf.MinimumWidth = 8;
            this.col_OnShelf.Name = "col_OnShelf";
            this.col_OnShelf.Width = 150;
            // 
            // col_ProductName
            // 
            this.col_ProductName.DataPropertyName = "ProductName";
            this.col_ProductName.HeaderText = "標題";
            this.col_ProductName.MinimumWidth = 8;
            this.col_ProductName.Name = "col_ProductName";
            this.col_ProductName.Width = 150;
            // 
            // col_SPU
            // 
            this.col_SPU.DataPropertyName = "Spu";
            this.col_SPU.HeaderText = "食譜PK";
            this.col_SPU.MinimumWidth = 8;
            this.col_SPU.Name = "col_SPU";
            this.col_SPU.Width = 150;
            // 
            // Checkbox
            // 
            this.Checkbox.HeaderText = "請選取";
            this.Checkbox.MinimumWidth = 8;
            this.Checkbox.Name = "Checkbox";
            this.Checkbox.Width = 150;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Checkbox,
            this.col_SPU,
            this.col_ProductName,
            this.col_OnShelf,
            this.col_CategoryName,
            this.col_SalePrice,
            this.col_Skus,
            this.col_SoldNumber,
            this.Operation});
            this.dataGridView1.Location = new System.Drawing.Point(68, 207);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1422, 406);
            this.dataGridView1.TabIndex = 13;
            // 
            // LabelRowCount
            // 
            this.LabelRowCount.AutoSize = true;
            this.LabelRowCount.Location = new System.Drawing.Point(1438, 178);
            this.LabelRowCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelRowCount.Name = "LabelRowCount";
            this.LabelRowCount.Size = new System.Drawing.Size(50, 18);
            this.LabelRowCount.TabIndex = 22;
            this.LabelRowCount.Text = "label6";
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.buttonClear.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonClear.ForeColor = System.Drawing.Color.Black;
            this.buttonClear.Location = new System.Drawing.Point(1166, 93);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(158, 46);
            this.buttonClear.TabIndex = 23;
            this.buttonClear.Text = "清除";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(116)))), ((int)(((byte)(198)))));
            this.buttonSearch.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.buttonSearch.Location = new System.Drawing.Point(1332, 93);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(158, 46);
            this.buttonSearch.TabIndex = 24;
            this.buttonSearch.Text = "搜尋";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateTimePickerEnd.Location = new System.Drawing.Point(915, 87);
            this.dateTimePickerEnd.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerEnd.MaxDate = new System.DateTime(2023, 6, 1, 15, 20, 9, 86);
            this.dateTimePickerEnd.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(216, 39);
            this.dateTimePickerEnd.TabIndex = 21;
            this.dateTimePickerEnd.Value = new System.DateTime(2023, 6, 1, 15, 20, 9, 86);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(882, 93);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 30);
            this.label6.TabIndex = 19;
            this.label6.Text = "~";
            // 
            // FormRecipeSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1810, 968);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.LabelRowCount);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.textBoxAuthorName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxAuthorPk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxRecipeName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxRecipePk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCSV);
            this.Controls.Add(this.toast);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormRecipeSearch";
            this.Text = "FormRecipeSearch";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonCSV;
		private FormItem.Toast toast;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxRecipePk;
		private System.Windows.Forms.TextBox textBoxRecipeName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxAuthorPk;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxAuthorName;
		private System.Windows.Forms.DateTimePicker dateTimePickerStart;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DataGridViewButtonColumn Operation;
		private System.Windows.Forms.DataGridViewTextBoxColumn col_SoldNumber;
		private System.Windows.Forms.DataGridViewTextBoxColumn col_Skus;
		private System.Windows.Forms.DataGridViewTextBoxColumn col_SalePrice;
		private System.Windows.Forms.DataGridViewTextBoxColumn col_CategoryName;
		private System.Windows.Forms.DataGridViewTextBoxColumn col_OnShelf;
		private System.Windows.Forms.DataGridViewTextBoxColumn col_ProductName;
		private System.Windows.Forms.DataGridViewTextBoxColumn col_SPU;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Checkbox;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label LabelRowCount;
		private System.Windows.Forms.Button buttonClear;
		private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Label label6;
    }
}