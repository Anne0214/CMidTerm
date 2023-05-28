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
            this.textBoxProdName = new TextBoxAndTable.TextBoxWordLimit();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelOnShelf = new System.Windows.Forms.Panel();
            this.radioButtonUnavailable = new System.Windows.Forms.RadioButton();
            this.radioButtonOff = new System.Windows.Forms.RadioButton();
            this.radioButtonOn = new System.Windows.Forms.RadioButton();
            this.buttonUpload = new System.Windows.Forms.Button();
            this.textBoxFullProdDescription = new TextBoxAndTable.TextBoxCannotBeChanged();
            this.textBoxProdDescription = new TextBoxAndTable.TextBoxMultiline();
            this.textBoxTagPrice = new TextBoxAndTable.TextBoxEditable();
            this.textBoxSalePrice = new TextBoxAndTable.TextBoxEditable();
            this.textBoxPurchasePrice = new TextBoxAndTable.TextBoxEditable();
            this.listViewSku = new System.Windows.Forms.ListView();
            this.col_TypeName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_StockNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAddSku = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonImg = new System.Windows.Forms.Button();
            this.col_blacnk = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).BeginInit();
            this.panelOnShelf.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxCover
            // 
            this.pictureBoxCover.Location = new System.Drawing.Point(111, 44);
            this.pictureBoxCover.Name = "pictureBoxCover";
            this.pictureBoxCover.Size = new System.Drawing.Size(350, 350);
            this.pictureBoxCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCover.TabIndex = 22;
            this.pictureBoxCover.TabStop = false;
            // 
            // textBoxProdName
            // 
            this.textBoxProdName.afiledMaxCount = 30;
            this.textBoxProdName.afiledName = "商品名稱";
            this.textBoxProdName.afiledValue = "電風扇";
            this.textBoxProdName.Location = new System.Drawing.Point(32, 561);
            this.textBoxProdName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxProdName.Name = "textBoxProdName";
            this.textBoxProdName.Size = new System.Drawing.Size(975, 60);
            this.textBoxProdName.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(32, 504);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 30);
            this.label3.TabIndex = 17;
            this.label3.Text = "上架狀態";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(111, 442);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(281, 38);
            this.comboBoxCategory.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(32, 450);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 30);
            this.label2.TabIndex = 18;
            this.label2.Text = "分類";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(32, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 30);
            this.label1.TabIndex = 16;
            this.label1.Text = "圖片";
            // 
            // panelOnShelf
            // 
            this.panelOnShelf.Controls.Add(this.radioButtonUnavailable);
            this.panelOnShelf.Controls.Add(this.radioButtonOff);
            this.panelOnShelf.Controls.Add(this.radioButtonOn);
            this.panelOnShelf.Location = new System.Drawing.Point(158, 492);
            this.panelOnShelf.Name = "panelOnShelf";
            this.panelOnShelf.Size = new System.Drawing.Size(417, 55);
            this.panelOnShelf.TabIndex = 20;
            // 
            // radioButtonUnavailable
            // 
            this.radioButtonUnavailable.AutoSize = true;
            this.radioButtonUnavailable.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioButtonUnavailable.Location = new System.Drawing.Point(315, 14);
            this.radioButtonUnavailable.Name = "radioButtonUnavailable";
            this.radioButtonUnavailable.Size = new System.Drawing.Size(86, 34);
            this.radioButtonUnavailable.TabIndex = 6;
            this.radioButtonUnavailable.TabStop = true;
            this.radioButtonUnavailable.Text = "封存";
            this.radioButtonUnavailable.UseVisualStyleBackColor = true;
            // 
            // radioButtonOff
            // 
            this.radioButtonOff.AutoSize = true;
            this.radioButtonOff.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioButtonOff.Location = new System.Drawing.Point(170, 16);
            this.radioButtonOff.Name = "radioButtonOff";
            this.radioButtonOff.Size = new System.Drawing.Size(86, 34);
            this.radioButtonOff.TabIndex = 6;
            this.radioButtonOff.TabStop = true;
            this.radioButtonOff.Text = "下架";
            this.radioButtonOff.UseVisualStyleBackColor = true;
            // 
            // radioButtonOn
            // 
            this.radioButtonOn.AutoSize = true;
            this.radioButtonOn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioButtonOn.Location = new System.Drawing.Point(19, 14);
            this.radioButtonOn.Name = "radioButtonOn";
            this.radioButtonOn.Size = new System.Drawing.Size(110, 34);
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
            this.buttonUpload.Location = new System.Drawing.Point(733, 1457);
            this.buttonUpload.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(158, 46);
            this.buttonUpload.TabIndex = 23;
            this.buttonUpload.Text = "上傳";
            this.buttonUpload.UseVisualStyleBackColor = false;
            this.buttonUpload.Click += new System.EventHandler(this.buttonUpload_Click);
            // 
            // textBoxFullProdDescription
            // 
            this.textBoxFullProdDescription.afiledName = "長說明(圖片)";
            this.textBoxFullProdDescription.afiledValue = "";
            this.textBoxFullProdDescription.Location = new System.Drawing.Point(37, 1457);
            this.textBoxFullProdDescription.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFullProdDescription.Name = "textBoxFullProdDescription";
            this.textBoxFullProdDescription.Size = new System.Drawing.Size(975, 60);
            this.textBoxFullProdDescription.TabIndex = 33;
            // 
            // textBoxProdDescription
            // 
            this.textBoxProdDescription.afiledMaxCount = 200;
            this.textBoxProdDescription.afiledName = "簡短說明";
            this.textBoxProdDescription.afiledValue = "rgrgrgrgdcdgrgrgr";
            this.textBoxProdDescription.Location = new System.Drawing.Point(32, 1127);
            this.textBoxProdDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxProdDescription.Name = "textBoxProdDescription";
            this.textBoxProdDescription.Size = new System.Drawing.Size(1020, 322);
            this.textBoxProdDescription.TabIndex = 32;
            // 
            // textBoxTagPrice
            // 
            this.textBoxTagPrice.afiledName = "標籤價";
            this.textBoxTagPrice.afiledValue = "56";
            this.textBoxTagPrice.Location = new System.Drawing.Point(32, 1010);
            this.textBoxTagPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxTagPrice.Name = "textBoxTagPrice";
            this.textBoxTagPrice.Size = new System.Drawing.Size(975, 60);
            this.textBoxTagPrice.TabIndex = 31;
            // 
            // textBoxSalePrice
            // 
            this.textBoxSalePrice.afiledName = "銷售價";
            this.textBoxSalePrice.afiledValue = "56";
            this.textBoxSalePrice.Location = new System.Drawing.Point(32, 1069);
            this.textBoxSalePrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSalePrice.Name = "textBoxSalePrice";
            this.textBoxSalePrice.Size = new System.Drawing.Size(975, 60);
            this.textBoxSalePrice.TabIndex = 29;
            // 
            // textBoxPurchasePrice
            // 
            this.textBoxPurchasePrice.afiledName = "採購價";
            this.textBoxPurchasePrice.afiledValue = "56";
            this.textBoxPurchasePrice.Location = new System.Drawing.Point(32, 951);
            this.textBoxPurchasePrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPurchasePrice.Name = "textBoxPurchasePrice";
            this.textBoxPurchasePrice.Size = new System.Drawing.Size(975, 60);
            this.textBoxPurchasePrice.TabIndex = 30;
            // 
            // listViewSku
            // 
            this.listViewSku.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_blacnk,
            this.col_TypeName,
            this.col_StockNumber});
            this.listViewSku.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listViewSku.HideSelection = false;
            this.listViewSku.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listViewSku.Location = new System.Drawing.Point(37, 695);
            this.listViewSku.Name = "listViewSku";
            this.listViewSku.Size = new System.Drawing.Size(657, 210);
            this.listViewSku.TabIndex = 28;
            this.listViewSku.UseCompatibleStateImageBehavior = false;
            this.listViewSku.View = System.Windows.Forms.View.Details;
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
            this.label4.Location = new System.Drawing.Point(32, 650);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 30);
            this.label4.TabIndex = 27;
            this.label4.Text = "SKU";
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.buttonCancel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonCancel.ForeColor = System.Drawing.Color.Black;
            this.buttonCancel.Location = new System.Drawing.Point(256, 1593);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(158, 46);
            this.buttonCancel.TabIndex = 24;
            this.buttonCancel.Text = "取消";
            this.buttonCancel.UseVisualStyleBackColor = false;
            // 
            // buttonAddSku
            // 
            this.buttonAddSku.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(116)))), ((int)(((byte)(198)))));
            this.buttonAddSku.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonAddSku.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.buttonAddSku.Location = new System.Drawing.Point(545, 642);
            this.buttonAddSku.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddSku.Name = "buttonAddSku";
            this.buttonAddSku.Size = new System.Drawing.Size(158, 46);
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
            this.buttonSave.Location = new System.Drawing.Point(57, 1593);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(158, 46);
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
            this.buttonImg.Location = new System.Drawing.Point(497, 348);
            this.buttonImg.Margin = new System.Windows.Forms.Padding(4);
            this.buttonImg.Name = "buttonImg";
            this.buttonImg.Size = new System.Drawing.Size(158, 46);
            this.buttonImg.TabIndex = 34;
            this.buttonImg.Text = "上傳";
            this.buttonImg.UseVisualStyleBackColor = false;
            this.buttonImg.Click += new System.EventHandler(this.buttonImg_Click);
            // 
            // FormProductCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1009, 1050);
            this.Controls.Add(this.buttonImg);
            this.Controls.Add(this.buttonUpload);
            this.Controls.Add(this.textBoxFullProdDescription);
            this.Controls.Add(this.textBoxProdDescription);
            this.Controls.Add(this.textBoxTagPrice);
            this.Controls.Add(this.textBoxSalePrice);
            this.Controls.Add(this.textBoxPurchasePrice);
            this.Controls.Add(this.listViewSku);
            this.Controls.Add(this.label4);
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
    }
}