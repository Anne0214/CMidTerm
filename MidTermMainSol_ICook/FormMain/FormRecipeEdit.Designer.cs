namespace FormMain
{
	partial class FormRecipeEdit
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
			this.pictureBoxCover = new System.Windows.Forms.PictureBox();
			this.textBoxCover = new System.Windows.Forms.TextBox();
			this.buttonUpload = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBoxCategory1 = new System.Windows.Forms.ComboBox();
			this.comboBoxCategory2 = new System.Windows.Forms.ComboBox();
			this.comboBoxCategory3 = new System.Windows.Forms.ComboBox();
			this.textBoxRecipePk = new TextBoxAndTable.TextBoxCannotBeChanged();
			this.textBoxRecipeName = new TextBoxAndTable.TextBoxWordLimit();
			this.textBoxAuthor = new TextBoxAndTable.TextBoxCannotBeChanged();
			this.textBoxPublishedTime = new TextBoxAndTable.TextBoxCannotBeChanged();
			this.textBoxShortDescription = new TextBoxAndTable.TextBoxMultiline();
			this.comboBoxCostMinutes = new System.Windows.Forms.ComboBox();
			this.comboBoxAmount = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.buttonClear = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBoxCover
			// 
			this.pictureBoxCover.Location = new System.Drawing.Point(157, 31);
			this.pictureBoxCover.Name = "pictureBoxCover";
			this.pictureBoxCover.Size = new System.Drawing.Size(324, 207);
			this.pictureBoxCover.TabIndex = 0;
			this.pictureBoxCover.TabStop = false;
			// 
			// textBoxCover
			// 
			this.textBoxCover.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.textBoxCover.Location = new System.Drawing.Point(157, 259);
			this.textBoxCover.Name = "textBoxCover";
			this.textBoxCover.Size = new System.Drawing.Size(352, 29);
			this.textBoxCover.TabIndex = 1;
			// 
			// buttonUpload
			// 
			this.buttonUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(116)))), ((int)(((byte)(198)))));
			this.buttonUpload.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonUpload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
			this.buttonUpload.Location = new System.Drawing.Point(529, 259);
			this.buttonUpload.Name = "buttonUpload";
			this.buttonUpload.Size = new System.Drawing.Size(105, 31);
			this.buttonUpload.TabIndex = 11;
			this.buttonUpload.Text = "上傳";
			this.buttonUpload.UseVisualStyleBackColor = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(22, 327);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(73, 20);
			this.label1.TabIndex = 12;
			this.label1.Text = "精選分類";
			// 
			// comboBoxCategory1
			// 
			this.comboBoxCategory1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.comboBoxCategory1.FormattingEnabled = true;
			this.comboBoxCategory1.Location = new System.Drawing.Point(157, 324);
			this.comboBoxCategory1.Name = "comboBoxCategory1";
			this.comboBoxCategory1.Size = new System.Drawing.Size(121, 28);
			this.comboBoxCategory1.TabIndex = 13;
			// 
			// comboBoxCategory2
			// 
			this.comboBoxCategory2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.comboBoxCategory2.FormattingEnabled = true;
			this.comboBoxCategory2.Location = new System.Drawing.Point(295, 324);
			this.comboBoxCategory2.Name = "comboBoxCategory2";
			this.comboBoxCategory2.Size = new System.Drawing.Size(121, 28);
			this.comboBoxCategory2.TabIndex = 13;
			// 
			// comboBoxCategory3
			// 
			this.comboBoxCategory3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.comboBoxCategory3.FormattingEnabled = true;
			this.comboBoxCategory3.Location = new System.Drawing.Point(431, 324);
			this.comboBoxCategory3.Name = "comboBoxCategory3";
			this.comboBoxCategory3.Size = new System.Drawing.Size(121, 28);
			this.comboBoxCategory3.TabIndex = 13;
			// 
			// textBoxRecipePk
			// 
			this.textBoxRecipePk.afiledName = "食譜PK";
			this.textBoxRecipePk.afiledValue = "";
			this.textBoxRecipePk.Location = new System.Drawing.Point(12, 385);
			this.textBoxRecipePk.Name = "textBoxRecipePk";
			this.textBoxRecipePk.Size = new System.Drawing.Size(650, 40);
			this.textBoxRecipePk.TabIndex = 14;
			// 
			// textBoxRecipeName
			// 
			this.textBoxRecipeName.afiledMaxCount = 0;
			this.textBoxRecipeName.afiledName = "食品名稱";
			this.textBoxRecipeName.afiledValue = "";
			this.textBoxRecipeName.Location = new System.Drawing.Point(14, 440);
			this.textBoxRecipeName.Name = "textBoxRecipeName";
			this.textBoxRecipeName.Size = new System.Drawing.Size(720, 40);
			this.textBoxRecipeName.TabIndex = 15;
			// 
			// textBoxAuthor
			// 
			this.textBoxAuthor.afiledName = "作者PK";
			this.textBoxAuthor.afiledValue = "";
			this.textBoxAuthor.Location = new System.Drawing.Point(14, 497);
			this.textBoxAuthor.Name = "textBoxAuthor";
			this.textBoxAuthor.Size = new System.Drawing.Size(650, 40);
			this.textBoxAuthor.TabIndex = 16;
			// 
			// textBoxPublishedTime
			// 
			this.textBoxPublishedTime.afiledName = "發表時間";
			this.textBoxPublishedTime.afiledValue = "";
			this.textBoxPublishedTime.Location = new System.Drawing.Point(14, 553);
			this.textBoxPublishedTime.Name = "textBoxPublishedTime";
			this.textBoxPublishedTime.Size = new System.Drawing.Size(650, 40);
			this.textBoxPublishedTime.TabIndex = 16;
			// 
			// textBoxShortDescription
			// 
			this.textBoxShortDescription.afiledMaxCount = 0;
			this.textBoxShortDescription.afiledName = "簡短說明";
			this.textBoxShortDescription.afiledValue = "";
			this.textBoxShortDescription.Location = new System.Drawing.Point(14, 609);
			this.textBoxShortDescription.Name = "textBoxShortDescription";
			this.textBoxShortDescription.Size = new System.Drawing.Size(890, 215);
			this.textBoxShortDescription.TabIndex = 17;
			// 
			// comboBoxCostMinutes
			// 
			this.comboBoxCostMinutes.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.comboBoxCostMinutes.FormattingEnabled = true;
			this.comboBoxCostMinutes.Location = new System.Drawing.Point(157, 830);
			this.comboBoxCostMinutes.Name = "comboBoxCostMinutes";
			this.comboBoxCostMinutes.Size = new System.Drawing.Size(121, 28);
			this.comboBoxCostMinutes.TabIndex = 13;
			// 
			// comboBoxAmount
			// 
			this.comboBoxAmount.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.comboBoxAmount.FormattingEnabled = true;
			this.comboBoxAmount.Location = new System.Drawing.Point(157, 881);
			this.comboBoxAmount.Name = "comboBoxAmount";
			this.comboBoxAmount.Size = new System.Drawing.Size(121, 28);
			this.comboBoxAmount.TabIndex = 13;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(22, 31);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 20);
			this.label2.TabIndex = 12;
			this.label2.Text = "封面圖";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label3.Location = new System.Drawing.Point(22, 833);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(115, 20);
			this.label3.TabIndex = 12;
			this.label3.Text = "花費時間(分鐘)";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label4.Location = new System.Drawing.Point(22, 884);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(83, 20);
			this.label4.TabIndex = 12;
			this.label4.Text = "份量(人份)";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(116)))), ((int)(((byte)(198)))));
			this.button1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
			this.button1.Location = new System.Drawing.Point(26, 1018);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(105, 31);
			this.button1.TabIndex = 11;
			this.button1.Text = "儲存";
			this.button1.UseVisualStyleBackColor = false;
			// 
			// buttonClear
			// 
			this.buttonClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
			this.buttonClear.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonClear.ForeColor = System.Drawing.Color.Black;
			this.buttonClear.Location = new System.Drawing.Point(148, 1018);
			this.buttonClear.Name = "buttonClear";
			this.buttonClear.Size = new System.Drawing.Size(105, 31);
			this.buttonClear.TabIndex = 18;
			this.buttonClear.Text = "取消";
			this.buttonClear.UseVisualStyleBackColor = false;
			// 
			// FormRecipeEdit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 1061);
			this.Controls.Add(this.buttonClear);
			this.Controls.Add(this.textBoxShortDescription);
			this.Controls.Add(this.textBoxPublishedTime);
			this.Controls.Add(this.textBoxAuthor);
			this.Controls.Add(this.textBoxRecipeName);
			this.Controls.Add(this.textBoxRecipePk);
			this.Controls.Add(this.comboBoxCategory3);
			this.Controls.Add(this.comboBoxCategory2);
			this.Controls.Add(this.comboBoxAmount);
			this.Controls.Add(this.comboBoxCostMinutes);
			this.Controls.Add(this.comboBoxCategory1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.buttonUpload);
			this.Controls.Add(this.textBoxCover);
			this.Controls.Add(this.pictureBoxCover);
			this.Name = "FormRecipeEdit";
			this.Text = "FormRecipeEdit";
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBoxCover;
		private System.Windows.Forms.TextBox textBoxCover;
		private System.Windows.Forms.Button buttonUpload;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBoxCategory1;
		private System.Windows.Forms.ComboBox comboBoxCategory2;
		private System.Windows.Forms.ComboBox comboBoxCategory3;
		private TextBoxAndTable.TextBoxCannotBeChanged textBoxRecipePk;
		private TextBoxAndTable.TextBoxWordLimit textBoxRecipeName;
		private TextBoxAndTable.TextBoxCannotBeChanged textBoxAuthor;
		private TextBoxAndTable.TextBoxCannotBeChanged textBoxPublishedTime;
		private TextBoxAndTable.TextBoxMultiline textBoxShortDescription;
		private System.Windows.Forms.ComboBox comboBoxCostMinutes;
		private System.Windows.Forms.ComboBox comboBoxAmount;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button buttonClear;
	}
}