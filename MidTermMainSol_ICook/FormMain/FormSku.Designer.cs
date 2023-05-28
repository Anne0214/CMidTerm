namespace FormMain
{
    partial class FormSku
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
            this.textBoxSku = new TextBoxAndTable.TextBoxCannotBeChanged();
            this.textBoxStockNumber = new TextBoxAndTable.TextBoxEditable();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxTypeName = new TextBoxAndTable.TextBoxWordLimit();
            this.SuspendLayout();
            // 
            // textBoxSku
            // 
            this.textBoxSku.afiledName = "SKU";
            this.textBoxSku.afiledValue = "";
            this.textBoxSku.Location = new System.Drawing.Point(13, 69);
            this.textBoxSku.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSku.Name = "textBoxSku";
            this.textBoxSku.Size = new System.Drawing.Size(975, 60);
            this.textBoxSku.TabIndex = 0;
            // 
            // textBoxStockNumber
            // 
            this.textBoxStockNumber.afiledName = "庫存數量";
            this.textBoxStockNumber.afiledValue = "";
            this.textBoxStockNumber.Location = new System.Drawing.Point(13, 205);
            this.textBoxStockNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxStockNumber.Name = "textBoxStockNumber";
            this.textBoxStockNumber.Size = new System.Drawing.Size(975, 60);
            this.textBoxStockNumber.TabIndex = 2;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(116)))), ((int)(((byte)(198)))));
            this.buttonConfirm.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.buttonConfirm.Location = new System.Drawing.Point(578, 323);
            this.buttonConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(158, 46);
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
            this.buttonCancel.Location = new System.Drawing.Point(389, 323);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(158, 46);
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
            this.textBoxTypeName.Location = new System.Drawing.Point(13, 137);
            this.textBoxTypeName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxTypeName.Name = "textBoxTypeName";
            this.textBoxTypeName.Size = new System.Drawing.Size(975, 60);
            this.textBoxTypeName.TabIndex = 5;
            // 
            // FormSku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 418);
            this.Controls.Add(this.textBoxTypeName);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.textBoxStockNumber);
            this.Controls.Add(this.textBoxSku);
            this.Name = "FormSku";
            this.Text = "FormSku";
            this.ResumeLayout(false);

        }

        #endregion

        private TextBoxAndTable.TextBoxCannotBeChanged textBoxSku;
        private TextBoxAndTable.TextBoxEditable textBoxStockNumber;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button buttonCancel;
        private TextBoxAndTable.TextBoxWordLimit textBoxTypeName;
    }
}