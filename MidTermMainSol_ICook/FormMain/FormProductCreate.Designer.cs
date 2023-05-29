namespace FormMain
{
    partial class FormProductCreate
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
			System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            "單一型號",
            "100"}, -1);
			this.pictureBoxCover = new System.Windows.Forms.PictureBox();
			this.label3 = new System.Windows.Forms.Label();
			this.comboBoxCategory = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panelOnShelf = new System.Windows.Forms.Panel();
			this.radioButtonUnavailable = new System.Windows.Forms.RadioButton();
			this.radioButtonOff = new System.Windows.Forms.RadioButton();
			this.radioButtonOn = new System.Windows.Forms.RadioButton();
			this.buttonUpload = new System.Windows.Forms.Button();
			this.listViewSku = new System.Windows.Forms.ListView();
			this.col_blacnk = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.col_TypeName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.col_StockNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.label4 = new System.Windows.Forms.Label();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonAddSku = new System.Windows.Forms.Button();
			this.buttonSave = new System.Windows.Forms.Button();
			this.buttonImg = new System.Windows.Forms.Button();
			this.buttonEdit = new System.Windows.Forms.Button();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.textBoxFullProdDescription = new TextBoxAndTable.TextBoxCannotBeChanged();
			this.textBoxProdDescription = new TextBoxAndTable.TextBoxMultiline();
			this.textBoxTagPrice = new TextBoxAndTable.TextBoxEditable();
			this.textBoxSalePrice = new TextBoxAndTable.TextBoxEditable();
			this.textBoxPurchasePrice = new TextBoxAndTable.TextBoxEditable();
			this.textBoxProdName = new TextBoxAndTable.TextBoxWordLimit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).BeginInit();
			this.panelOnShelf.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBoxCover
			// 
			this.pictureBoxCover.Location = new System.Drawing.Point(88, 36);
			this.pictureBoxCover.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBoxCover.Name = "pictureBoxCover";
			this.pictureBoxCover.Size = new System.Drawing.Size(233, 233);
			this.pictureBoxCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxCover.TabIndex = 22;
			this.pictureBoxCover.TabStop = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label3.Location = new System.Drawing.Point(35, 334);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(73, 20);
			this.label3.TabIndex = 17;
			this.label3.Text = "上架狀態";
			// 
			// comboBoxCategory
			// 
			this.comboBoxCategory.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.comboBoxCategory.FormattingEnabled = true;
			this.comboBoxCategory.Location = new System.Drawing.Point(88, 293);
			this.comboBoxCategory.Margin = new System.Windows.Forms.Padding(2);
			this.comboBoxCategory.Name = "comboBoxCategory";
			this.comboBoxCategory.Size = new System.Drawing.Size(189, 28);
			this.comboBoxCategory.TabIndex = 19;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(35, 298);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 20);
			this.label2.TabIndex = 18;
			this.label2.Text = "分類";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(35, 36);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 20);
			this.label1.TabIndex = 16;
			this.label1.Text = "圖片";
			// 
			// panelOnShelf
			// 
			this.panelOnShelf.Controls.Add(this.radioButtonUnavailable);
			this.panelOnShelf.Controls.Add(this.radioButtonOff);
			this.panelOnShelf.Controls.Add(this.radioButtonOn);
			this.panelOnShelf.Location = new System.Drawing.Point(119, 326);
			this.panelOnShelf.Margin = new System.Windows.Forms.Padding(2);
			this.panelOnShelf.Name = "panelOnShelf";
			this.panelOnShelf.Size = new System.Drawing.Size(278, 37);
			this.panelOnShelf.TabIndex = 20;
			// 
			// radioButtonUnavailable
			// 
			this.radioButtonUnavailable.AutoSize = true;
			this.radioButtonUnavailable.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.radioButtonUnavailable.Location = new System.Drawing.Point(210, 9);
			this.radioButtonUnavailable.Margin = new System.Windows.Forms.Padding(2);
			this.radioButtonUnavailable.Name = "radioButtonUnavailable";
			this.radioButtonUnavailable.Size = new System.Drawing.Size(59, 24);
			this.radioButtonUnavailable.TabIndex = 6;
			this.radioButtonUnavailable.TabStop = true;
			this.radioButtonUnavailable.Text = "封存";
			this.radioButtonUnavailable.UseVisualStyleBackColor = true;
			// 
			// radioButtonOff
			// 
			this.radioButtonOff.AutoSize = true;
			this.radioButtonOff.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.radioButtonOff.Location = new System.Drawing.Point(113, 11);
			this.radioButtonOff.Margin = new System.Windows.Forms.Padding(2);
			this.radioButtonOff.Name = "radioButtonOff";
			this.radioButtonOff.Size = new System.Drawing.Size(59, 24);
			this.radioButtonOff.TabIndex = 6;
			this.radioButtonOff.TabStop = true;
			this.radioButtonOff.Text = "下架";
			this.radioButtonOff.UseVisualStyleBackColor = true;
			// 
			// radioButtonOn
			// 
			this.radioButtonOn.AutoSize = true;
			this.radioButtonOn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.radioButtonOn.Location = new System.Drawing.Point(13, 9);
			this.radioButtonOn.Margin = new System.Windows.Forms.Padding(2);
			this.radioButtonOn.Name = "radioButtonOn";
			this.radioButtonOn.Size = new System.Drawing.Size(75, 24);
			this.radioButtonOn.TabIndex = 6;
			this.radioButtonOn.TabStop = true;
			this.radioButtonOn.Text = "上架中";
			this.radioButtonOn.UseVisualStyleBackColor = true;
			// 
			// buttonUpload
			// 
			this.buttonUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(116)))), ((int)(((byte)(198)))));
			this.buttonUpload.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonUpload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
			this.buttonUpload.Location = new System.Drawing.Point(503, 956);
			this.buttonUpload.Name = "buttonUpload";
			this.buttonUpload.Size = new System.Drawing.Size(105, 31);
			this.buttonUpload.TabIndex = 23;
			this.buttonUpload.Text = "上傳";
			this.buttonUpload.UseVisualStyleBackColor = false;
			this.buttonUpload.Click += new System.EventHandler(this.buttonUpload_Click);
			// 
			// listViewSku
			// 
			this.listViewSku.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_blacnk,
            this.col_TypeName,
            this.col_StockNumber});
			this.listViewSku.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.listViewSku.FullRowSelect = true;
			this.listViewSku.HideSelection = false;
			this.listViewSku.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
			this.listViewSku.Location = new System.Drawing.Point(39, 461);
			this.listViewSku.Margin = new System.Windows.Forms.Padding(2);
			this.listViewSku.Name = "listViewSku";
			this.listViewSku.Size = new System.Drawing.Size(439, 141);
			this.listViewSku.TabIndex = 28;
			this.listViewSku.UseCompatibleStateImageBehavior = false;
			this.listViewSku.View = System.Windows.Forms.View.Details;
			this.listViewSku.Click += new System.EventHandler(this.listViewSku_Click);
			// 
			// col_TypeName
			// 
			this.col_TypeName.Text = "型號名稱";
			this.col_TypeName.Width = 100;
			// 
			// col_StockNumber
			// 
			this.col_StockNumber.Text = "庫存數量";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label4.Location = new System.Drawing.Point(35, 431);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(40, 20);
			this.label4.TabIndex = 27;
			this.label4.Text = "SKU";
			// 
			// buttonCancel
			// 
			this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
			this.buttonCancel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonCancel.ForeColor = System.Drawing.Color.Black;
			this.buttonCancel.Location = new System.Drawing.Point(170, 1058);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(105, 31);
			this.buttonCancel.TabIndex = 24;
			this.buttonCancel.Text = "取消";
			this.buttonCancel.UseVisualStyleBackColor = false;
			// 
			// buttonAddSku
			// 
			this.buttonAddSku.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(116)))), ((int)(((byte)(198)))));
			this.buttonAddSku.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonAddSku.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
			this.buttonAddSku.Location = new System.Drawing.Point(377, 426);
			this.buttonAddSku.Name = "buttonAddSku";
			this.buttonAddSku.Size = new System.Drawing.Size(105, 31);
			this.buttonAddSku.TabIndex = 25;
			this.buttonAddSku.Text = "新增";
			this.buttonAddSku.UseVisualStyleBackColor = false;
			this.buttonAddSku.Click += new System.EventHandler(this.buttonAddSku_Click);
			// 
			// buttonSave
			// 
			this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(116)))), ((int)(((byte)(198)))));
			this.buttonSave.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
			this.buttonSave.Location = new System.Drawing.Point(37, 1058);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(105, 31);
			this.buttonSave.TabIndex = 26;
			this.buttonSave.Text = "新增";
			this.buttonSave.UseVisualStyleBackColor = false;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// buttonImg
			// 
			this.buttonImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(116)))), ((int)(((byte)(198)))));
			this.buttonImg.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonImg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
			this.buttonImg.Location = new System.Drawing.Point(345, 239);
			this.buttonImg.Name = "buttonImg";
			this.buttonImg.Size = new System.Drawing.Size(105, 31);
			this.buttonImg.TabIndex = 34;
			this.buttonImg.Text = "上傳";
			this.buttonImg.UseVisualStyleBackColor = false;
			this.buttonImg.Click += new System.EventHandler(this.buttonImg_Click);
			// 
			// buttonEdit
			// 
			this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
			this.buttonEdit.Enabled = false;
			this.buttonEdit.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonEdit.ForeColor = System.Drawing.Color.Black;
			this.buttonEdit.Location = new System.Drawing.Point(503, 461);
			this.buttonEdit.Name = "buttonEdit";
			this.buttonEdit.Size = new System.Drawing.Size(105, 31);
			this.buttonEdit.TabIndex = 24;
			this.buttonEdit.Text = "編輯";
			this.buttonEdit.UseVisualStyleBackColor = false;
			this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
			// 
			// buttonDelete
			// 
			this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
			this.buttonDelete.Enabled = false;
			this.buttonDelete.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonDelete.ForeColor = System.Drawing.Color.Black;
			this.buttonDelete.Location = new System.Drawing.Point(503, 511);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(105, 31);
			this.buttonDelete.TabIndex = 24;
			this.buttonDelete.Text = "刪除";
			this.buttonDelete.UseVisualStyleBackColor = false;
			this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
			// 
			// textBoxFullProdDescription
			// 
			this.textBoxFullProdDescription.afiledName = "長說明(圖片)";
			this.textBoxFullProdDescription.afiledValue = "";
			this.textBoxFullProdDescription.Location = new System.Drawing.Point(39, 956);
			this.textBoxFullProdDescription.Name = "textBoxFullProdDescription";
			this.textBoxFullProdDescription.Size = new System.Drawing.Size(650, 40);
			this.textBoxFullProdDescription.TabIndex = 33;
			// 
			// textBoxProdDescription
			// 
			this.textBoxProdDescription.afiledMaxCount = 200;
			this.textBoxProdDescription.afiledName = "簡短說明";
			this.textBoxProdDescription.afiledValue = "rgrgrgrgdcdgrgrgr";
			this.textBoxProdDescription.Location = new System.Drawing.Point(35, 736);
			this.textBoxProdDescription.Name = "textBoxProdDescription";
			this.textBoxProdDescription.Size = new System.Drawing.Size(680, 215);
			this.textBoxProdDescription.TabIndex = 32;
			// 
			// textBoxTagPrice
			// 
			this.textBoxTagPrice.afiledName = "標籤價";
			this.textBoxTagPrice.afiledValue = "56";
			this.textBoxTagPrice.Location = new System.Drawing.Point(35, 658);
			this.textBoxTagPrice.Name = "textBoxTagPrice";
			this.textBoxTagPrice.Size = new System.Drawing.Size(650, 40);
			this.textBoxTagPrice.TabIndex = 31;
			// 
			// textBoxSalePrice
			// 
			this.textBoxSalePrice.afiledName = "銷售價";
			this.textBoxSalePrice.afiledValue = "56";
			this.textBoxSalePrice.Location = new System.Drawing.Point(35, 698);
			this.textBoxSalePrice.Name = "textBoxSalePrice";
			this.textBoxSalePrice.Size = new System.Drawing.Size(650, 40);
			this.textBoxSalePrice.TabIndex = 29;
			// 
			// textBoxPurchasePrice
			// 
			this.textBoxPurchasePrice.afiledName = "採購價";
			this.textBoxPurchasePrice.afiledValue = "56";
			this.textBoxPurchasePrice.Location = new System.Drawing.Point(35, 619);
			this.textBoxPurchasePrice.Name = "textBoxPurchasePrice";
			this.textBoxPurchasePrice.Size = new System.Drawing.Size(650, 40);
			this.textBoxPurchasePrice.TabIndex = 30;
			// 
			// textBoxProdName
			// 
			this.textBoxProdName.afiledMaxCount = 30;
			this.textBoxProdName.afiledName = "商品名稱";
			this.textBoxProdName.afiledValue = "電風扇";
			this.textBoxProdName.Location = new System.Drawing.Point(35, 372);
			this.textBoxProdName.Name = "textBoxProdName";
			this.textBoxProdName.Size = new System.Drawing.Size(650, 40);
			this.textBoxProdName.TabIndex = 21;
			// 
			// FormProductCreate
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(1289, 700);
			this.Controls.Add(this.buttonImg);
			this.Controls.Add(this.buttonUpload);
			this.Controls.Add(this.textBoxFullProdDescription);
			this.Controls.Add(this.textBoxProdDescription);
			this.Controls.Add(this.textBoxTagPrice);
			this.Controls.Add(this.textBoxSalePrice);
			this.Controls.Add(this.textBoxPurchasePrice);
			this.Controls.Add(this.listViewSku);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.buttonEdit);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonAddSku);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.pictureBoxCover);
			this.Controls.Add(this.textBoxProdName);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.comboBoxCategory);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panelOnShelf);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "FormProductCreate";
			this.Text = "FormProductCreate";
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).EndInit();
			this.panelOnShelf.ResumeLayout(false);
			this.panelOnShelf.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCover;
        private TextBoxAndTable.TextBoxWordLimit textBoxProdName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelOnShelf;
        private System.Windows.Forms.RadioButton radioButtonUnavailable;
        private System.Windows.Forms.RadioButton radioButtonOff;
        private System.Windows.Forms.RadioButton radioButtonOn;
        private System.Windows.Forms.Button buttonUpload;
        private TextBoxAndTable.TextBoxCannotBeChanged textBoxFullProdDescription;
        private TextBoxAndTable.TextBoxMultiline textBoxProdDescription;
        private TextBoxAndTable.TextBoxEditable textBoxTagPrice;
        private TextBoxAndTable.TextBoxEditable textBoxSalePrice;
        private TextBoxAndTable.TextBoxEditable textBoxPurchasePrice;
        private System.Windows.Forms.ListView listViewSku;
        private System.Windows.Forms.ColumnHeader col_TypeName;
        private System.Windows.Forms.ColumnHeader col_StockNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAddSku;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonImg;
        private System.Windows.Forms.ColumnHeader col_blacnk;
		private System.Windows.Forms.Button buttonEdit;
		private System.Windows.Forms.Button buttonDelete;
	}
}