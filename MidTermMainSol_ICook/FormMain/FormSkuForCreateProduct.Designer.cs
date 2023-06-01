namespace FormMain
{
    partial class FormSkuForCreateProduct
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
			this.textBoxStockNumber = new TextBoxAndTable.TextBoxEditable();
			this.buttonConfirm = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.textBoxTypeName = new TextBoxAndTable.TextBoxWordLimit();
			this.SuspendLayout();
			// 
			// textBoxStockNumber
			// 
			this.textBoxStockNumber.afiledName = "庫存數量";
			this.textBoxStockNumber.afiledValue = "";
			this.textBoxStockNumber.Location = new System.Drawing.Point(9, 137);
			this.textBoxStockNumber.Name = "textBoxStockNumber";
			this.textBoxStockNumber.Size = new System.Drawing.Size(650, 40);
			this.textBoxStockNumber.TabIndex = 2;
			// 
			// buttonConfirm
			// 
			this.buttonConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(116)))), ((int)(((byte)(198)))));
			this.buttonConfirm.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
			this.buttonConfirm.Location = new System.Drawing.Point(385, 229);
			this.buttonConfirm.Name = "buttonConfirm";
			this.buttonConfirm.Size = new System.Drawing.Size(105, 31);
			this.buttonConfirm.TabIndex = 3;
			this.buttonConfirm.Text = "新增";
			this.buttonConfirm.UseVisualStyleBackColor = false;
			this.buttonConfirm.Click += new System.EventHandler(this.buttonAddSku_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
			this.buttonCancel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonCancel.ForeColor = System.Drawing.Color.Black;
			this.buttonCancel.Location = new System.Drawing.Point(259, 229);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(105, 31);
			this.buttonCancel.TabIndex = 4;
			this.buttonCancel.Text = "取消";
			this.buttonCancel.UseVisualStyleBackColor = false;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// textBoxTypeName
			// 
			this.textBoxTypeName.afiledMaxCount = 20;
			this.textBoxTypeName.afiledName = "型號名稱";
			this.textBoxTypeName.afiledValue = "";
			this.textBoxTypeName.Location = new System.Drawing.Point(12, 53);
			this.textBoxTypeName.Name = "textBoxTypeName";
			this.textBoxTypeName.Size = new System.Drawing.Size(650, 40);
			this.textBoxTypeName.TabIndex = 5;
			// 
			// FormSkuForCreateProduct
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(515, 279);
			this.Controls.Add(this.textBoxTypeName);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonConfirm);
			this.Controls.Add(this.textBoxStockNumber);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "FormSkuForCreateProduct";
			this.Text = "SKU";
			this.ResumeLayout(false);

        }

        #endregion
        private TextBoxAndTable.TextBoxEditable textBoxStockNumber;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button buttonCancel;
        private TextBoxAndTable.TextBoxWordLimit textBoxTypeName;
	}
}