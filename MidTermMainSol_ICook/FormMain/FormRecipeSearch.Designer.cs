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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
			this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
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
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonCSV
			// 
			this.buttonCSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
			this.buttonCSV.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonCSV.ForeColor = System.Drawing.Color.Black;
			this.buttonCSV.Location = new System.Drawing.Point(45, 101);
			this.buttonCSV.Name = "buttonCSV";
			this.buttonCSV.Size = new System.Drawing.Size(105, 31);
			this.buttonCSV.TabIndex = 16;
			this.buttonCSV.Text = "輸出成CSV";
			this.buttonCSV.UseVisualStyleBackColor = false;
			// 
			// toast
			// 
			this.toast.AMessage = "儲存成功";
			this.toast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.toast.Location = new System.Drawing.Point(26, 340);
			this.toast.Margin = new System.Windows.Forms.Padding(4);
			this.toast.Name = "toast";
			this.toast.Size = new System.Drawing.Size(203, 55);
			this.toast.TabIndex = 12;
			this.toast.Visible = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(43, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(61, 20);
			this.label1.TabIndex = 17;
			this.label1.Text = "食譜PK";
			// 
			// textBoxRecipePk
			// 
			this.textBoxRecipePk.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.textBoxRecipePk.Location = new System.Drawing.Point(123, 12);
			this.textBoxRecipePk.Name = "textBoxRecipePk";
			this.textBoxRecipePk.Size = new System.Drawing.Size(189, 29);
			this.textBoxRecipePk.TabIndex = 18;
			// 
			// textBoxRecipeName
			// 
			this.textBoxRecipeName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.textBoxRecipeName.Location = new System.Drawing.Point(439, 12);
			this.textBoxRecipeName.Name = "textBoxRecipeName";
			this.textBoxRecipeName.Size = new System.Drawing.Size(189, 29);
			this.textBoxRecipeName.TabIndex = 20;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(359, 18);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 20);
			this.label2.TabIndex = 19;
			this.label2.Text = "食譜標題";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label3.Location = new System.Drawing.Point(687, 15);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(61, 20);
			this.label3.TabIndex = 19;
			this.label3.Text = "作者PK";
			// 
			// textBoxAuthorPk
			// 
			this.textBoxAuthorPk.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.textBoxAuthorPk.Location = new System.Drawing.Point(767, 9);
			this.textBoxAuthorPk.Name = "textBoxAuthorPk";
			this.textBoxAuthorPk.Size = new System.Drawing.Size(189, 29);
			this.textBoxAuthorPk.TabIndex = 20;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label4.Location = new System.Drawing.Point(43, 62);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(73, 20);
			this.label4.TabIndex = 19;
			this.label4.Text = "作者暱稱";
			// 
			// textBoxAuthorName
			// 
			this.textBoxAuthorName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.textBoxAuthorName.Location = new System.Drawing.Point(123, 56);
			this.textBoxAuthorName.Name = "textBoxAuthorName";
			this.textBoxAuthorName.Size = new System.Drawing.Size(189, 29);
			this.textBoxAuthorName.TabIndex = 20;
			// 
			// dateTimePicker
			// 
			this.dateTimePicker.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.dateTimePicker.Location = new System.Drawing.Point(439, 58);
			this.dateTimePicker.MaxDate = new System.DateTime(2023, 6, 1, 15, 20, 9, 86);
			this.dateTimePicker.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
			this.dateTimePicker.Name = "dateTimePicker";
			this.dateTimePicker.Size = new System.Drawing.Size(200, 29);
			this.dateTimePicker.TabIndex = 21;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label5.Location = new System.Drawing.Point(359, 62);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(73, 20);
			this.label5.TabIndex = 19;
			this.label5.Text = "發表日期";
			// 
			// Operation
			// 
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.NullValue = "修改";
			this.Operation.DefaultCellStyle = dataGridViewCellStyle3;
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
			this.dataGridView1.Location = new System.Drawing.Point(45, 138);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 62;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(948, 271);
			this.dataGridView1.TabIndex = 13;
			// 
			// LabelRowCount
			// 
			this.LabelRowCount.AutoSize = true;
			this.LabelRowCount.Location = new System.Drawing.Point(959, 119);
			this.LabelRowCount.Name = "LabelRowCount";
			this.LabelRowCount.Size = new System.Drawing.Size(33, 12);
			this.LabelRowCount.TabIndex = 22;
			this.LabelRowCount.Text = "label6";
			// 
			// buttonClear
			// 
			this.buttonClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
			this.buttonClear.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonClear.ForeColor = System.Drawing.Color.Black;
			this.buttonClear.Location = new System.Drawing.Point(777, 62);
			this.buttonClear.Name = "buttonClear";
			this.buttonClear.Size = new System.Drawing.Size(105, 31);
			this.buttonClear.TabIndex = 23;
			this.buttonClear.Text = "清除";
			this.buttonClear.UseVisualStyleBackColor = false;
			// 
			// buttonSearch
			// 
			this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(116)))), ((int)(((byte)(198)))));
			this.buttonSearch.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
			this.buttonSearch.Location = new System.Drawing.Point(888, 62);
			this.buttonSearch.Name = "buttonSearch";
			this.buttonSearch.Size = new System.Drawing.Size(105, 31);
			this.buttonSearch.TabIndex = 24;
			this.buttonSearch.Text = "搜尋";
			this.buttonSearch.UseVisualStyleBackColor = false;
			// 
			// FormRecipeSearch
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1207, 645);
			this.Controls.Add(this.buttonClear);
			this.Controls.Add(this.buttonSearch);
			this.Controls.Add(this.LabelRowCount);
			this.Controls.Add(this.dateTimePicker);
			this.Controls.Add(this.textBoxAuthorName);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBoxAuthorPk);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBoxRecipeName);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxRecipePk);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonCSV);
			this.Controls.Add(this.toast);
			this.Controls.Add(this.dataGridView1);
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
		private System.Windows.Forms.DateTimePicker dateTimePicker;
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
	}
}