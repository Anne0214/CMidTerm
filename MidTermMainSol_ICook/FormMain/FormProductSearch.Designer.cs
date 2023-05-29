namespace FormMain
{
	partial class FormProductSearch
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Checkbox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.col_SPU = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.col_ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.col_OnShelf = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.col_CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.col_SalePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.col_Skus = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.col_SoldNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.col_StockNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Operation = new System.Windows.Forms.DataGridViewButtonColumn();
			this.LabelRowCount = new System.Windows.Forms.Label();
			this.textBoxSearch = new System.Windows.Forms.TextBox();
			this.comboBoxTarget = new System.Windows.Forms.ComboBox();
			this.buttonClear = new System.Windows.Forms.Button();
			this.buttonSearch = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.toast = new FormItem.Toast();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
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
            this.col_StockNumber,
            this.Operation});
			this.dataGridView1.Location = new System.Drawing.Point(78, -50);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 62;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(800, 176);
			this.dataGridView1.TabIndex = 4;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// Checkbox
			// 
			this.Checkbox.HeaderText = "請選取";
			this.Checkbox.MinimumWidth = 8;
			this.Checkbox.Name = "Checkbox";
			this.Checkbox.Width = 150;
			// 
			// col_SPU
			// 
			this.col_SPU.DataPropertyName = "Spu";
			this.col_SPU.HeaderText = "SPU";
			this.col_SPU.MinimumWidth = 8;
			this.col_SPU.Name = "col_SPU";
			this.col_SPU.Width = 150;
			// 
			// col_ProductName
			// 
			this.col_ProductName.DataPropertyName = "ProductName";
			this.col_ProductName.HeaderText = "產品名稱";
			this.col_ProductName.MinimumWidth = 8;
			this.col_ProductName.Name = "col_ProductName";
			this.col_ProductName.Width = 150;
			// 
			// col_OnShelf
			// 
			this.col_OnShelf.DataPropertyName = "OnShelf";
			this.col_OnShelf.HeaderText = "上架狀態";
			this.col_OnShelf.MinimumWidth = 8;
			this.col_OnShelf.Name = "col_OnShelf";
			this.col_OnShelf.Width = 150;
			// 
			// col_CategoryName
			// 
			this.col_CategoryName.DataPropertyName = "Category";
			this.col_CategoryName.HeaderText = "分類";
			this.col_CategoryName.MinimumWidth = 8;
			this.col_CategoryName.Name = "col_CategoryName";
			this.col_CategoryName.Width = 150;
			// 
			// col_SalePrice
			// 
			this.col_SalePrice.DataPropertyName = "SalePrice";
			this.col_SalePrice.HeaderText = "銷售價";
			this.col_SalePrice.MinimumWidth = 8;
			this.col_SalePrice.Name = "col_SalePrice";
			this.col_SalePrice.Width = 150;
			// 
			// col_Skus
			// 
			this.col_Skus.DataPropertyName = "AllSku";
			this.col_Skus.HeaderText = "SKU";
			this.col_Skus.MinimumWidth = 8;
			this.col_Skus.Name = "col_Skus";
			this.col_Skus.Width = 150;
			// 
			// col_SoldNumber
			// 
			this.col_SoldNumber.DataPropertyName = "SoldNumber";
			this.col_SoldNumber.HeaderText = "銷售數量";
			this.col_SoldNumber.MinimumWidth = 8;
			this.col_SoldNumber.Name = "col_SoldNumber";
			this.col_SoldNumber.Width = 150;
			// 
			// col_StockNumber
			// 
			this.col_StockNumber.DataPropertyName = "StockNumber";
			this.col_StockNumber.HeaderText = "庫存數量";
			this.col_StockNumber.MinimumWidth = 8;
			this.col_StockNumber.Name = "col_StockNumber";
			this.col_StockNumber.Width = 150;
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
			// LabelRowCount
			// 
			this.LabelRowCount.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.LabelRowCount.AutoSize = true;
			this.LabelRowCount.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.LabelRowCount.Location = new System.Drawing.Point(358, -139);
			this.LabelRowCount.Name = "LabelRowCount";
			this.LabelRowCount.Size = new System.Drawing.Size(83, 20);
			this.LabelRowCount.TabIndex = 5;
			this.LabelRowCount.Text = "總共OO筆";
			// 
			// textBoxSearch
			// 
			this.textBoxSearch.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.textBoxSearch.Location = new System.Drawing.Point(168, 39);
			this.textBoxSearch.Margin = new System.Windows.Forms.Padding(2);
			this.textBoxSearch.Name = "textBoxSearch";
			this.textBoxSearch.Size = new System.Drawing.Size(505, 29);
			this.textBoxSearch.TabIndex = 6;
			this.textBoxSearch.Click += new System.EventHandler(this.textBoxSearch_Click);
			// 
			// comboBoxTarget
			// 
			this.comboBoxTarget.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.comboBoxTarget.FormattingEnabled = true;
			this.comboBoxTarget.Location = new System.Drawing.Point(32, 39);
			this.comboBoxTarget.Margin = new System.Windows.Forms.Padding(2);
			this.comboBoxTarget.Name = "comboBoxTarget";
			this.comboBoxTarget.Size = new System.Drawing.Size(122, 28);
			this.comboBoxTarget.TabIndex = 7;
			this.comboBoxTarget.Text = "商品名稱";
			// 
			// buttonClear
			// 
			this.buttonClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
			this.buttonClear.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonClear.ForeColor = System.Drawing.Color.Black;
			this.buttonClear.Location = new System.Drawing.Point(801, 39);
			this.buttonClear.Name = "buttonClear";
			this.buttonClear.Size = new System.Drawing.Size(105, 31);
			this.buttonClear.TabIndex = 8;
			this.buttonClear.Text = "清除";
			this.buttonClear.UseVisualStyleBackColor = false;
			this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
			// 
			// buttonSearch
			// 
			this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(116)))), ((int)(((byte)(198)))));
			this.buttonSearch.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
			this.buttonSearch.Location = new System.Drawing.Point(691, 39);
			this.buttonSearch.Name = "buttonSearch";
			this.buttonSearch.Size = new System.Drawing.Size(105, 31);
			this.buttonSearch.TabIndex = 9;
			this.buttonSearch.Text = "搜尋";
			this.buttonSearch.UseVisualStyleBackColor = false;
			this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(731, 8);
			this.button1.Margin = new System.Windows.Forms.Padding(2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(50, 15);
			this.button1.TabIndex = 10;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// toast
			// 
			this.toast.AMessage = "儲存成功";
			this.toast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.toast.Location = new System.Drawing.Point(17, 163);
			this.toast.Margin = new System.Windows.Forms.Padding(4);
			this.toast.Name = "toast";
			this.toast.Size = new System.Drawing.Size(203, 55);
			this.toast.TabIndex = 1;
			this.toast.Visible = false;
			// 
			// FormProductSearch
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(903, 741);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.buttonClear);
			this.Controls.Add(this.buttonSearch);
			this.Controls.Add(this.comboBoxTarget);
			this.Controls.Add(this.textBoxSearch);
			this.Controls.Add(this.LabelRowCount);
			this.Controls.Add(this.toast);
			this.Controls.Add(this.dataGridView1);
			this.Name = "FormProductSearch";
			this.Text = "FormSearch";
			this.Load += new System.EventHandler(this.FormSearch_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private FormItem.Toast toast;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label LabelRowCount;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.ComboBox comboBoxTarget;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Checkbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SPU;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_OnShelf;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_CategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SalePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Skus;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SoldNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_StockNumber;
        private System.Windows.Forms.DataGridViewButtonColumn Operation;
    }
}