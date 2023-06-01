namespace FormMain
{
	partial class FormExportCSV<T>
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
			this.listBoxOption = new System.Windows.Forms.ListBox();
			this.listBoxSelected = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.buttonToRight = new System.Windows.Forms.Button();
			this.buttonToLeft = new System.Windows.Forms.Button();
			this.buttonUp = new System.Windows.Forms.Button();
			this.buttonDown = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonExport = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// listBoxOption
			// 
			this.listBoxOption.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.listBoxOption.FormattingEnabled = true;
			this.listBoxOption.ItemHeight = 20;
			this.listBoxOption.Location = new System.Drawing.Point(54, 46);
			this.listBoxOption.Name = "listBoxOption";
			this.listBoxOption.Size = new System.Drawing.Size(200, 304);
			this.listBoxOption.TabIndex = 0;
			// 
			// listBoxSelected
			// 
			this.listBoxSelected.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.listBoxSelected.FormattingEnabled = true;
			this.listBoxSelected.ItemHeight = 20;
			this.listBoxSelected.Location = new System.Drawing.Point(353, 46);
			this.listBoxSelected.Name = "listBoxSelected";
			this.listBoxSelected.Size = new System.Drawing.Size(200, 304);
			this.listBoxSelected.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(50, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(73, 20);
			this.label1.TabIndex = 3;
			this.label1.Text = "可選欄位";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(349, 20);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "輸出欄位";
			// 
			// buttonToRight
			// 
			this.buttonToRight.BackColor = System.Drawing.Color.White;
			this.buttonToRight.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonToRight.Location = new System.Drawing.Point(284, 122);
			this.buttonToRight.Name = "buttonToRight";
			this.buttonToRight.Size = new System.Drawing.Size(35, 35);
			this.buttonToRight.TabIndex = 4;
			this.buttonToRight.Text = "▶";
			this.buttonToRight.UseVisualStyleBackColor = false;
			this.buttonToRight.Click += new System.EventHandler(this.buttonToRight_Click);
			// 
			// buttonToLeft
			// 
			this.buttonToLeft.BackColor = System.Drawing.Color.White;
			this.buttonToLeft.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonToLeft.Location = new System.Drawing.Point(284, 179);
			this.buttonToLeft.Name = "buttonToLeft";
			this.buttonToLeft.Size = new System.Drawing.Size(35, 35);
			this.buttonToLeft.TabIndex = 4;
			this.buttonToLeft.Text = "◀";
			this.buttonToLeft.UseVisualStyleBackColor = false;
			this.buttonToLeft.Click += new System.EventHandler(this.buttonToLeft_Click);
			// 
			// buttonUp
			// 
			this.buttonUp.BackColor = System.Drawing.Color.White;
			this.buttonUp.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonUp.Location = new System.Drawing.Point(559, 46);
			this.buttonUp.Name = "buttonUp";
			this.buttonUp.Size = new System.Drawing.Size(35, 35);
			this.buttonUp.TabIndex = 4;
			this.buttonUp.Text = "▲";
			this.buttonUp.UseVisualStyleBackColor = false;
			this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
			// 
			// buttonDown
			// 
			this.buttonDown.BackColor = System.Drawing.Color.White;
			this.buttonDown.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonDown.Location = new System.Drawing.Point(559, 103);
			this.buttonDown.Name = "buttonDown";
			this.buttonDown.Size = new System.Drawing.Size(35, 35);
			this.buttonDown.TabIndex = 4;
			this.buttonDown.Text = "▼";
			this.buttonDown.UseVisualStyleBackColor = false;
			this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
			this.buttonCancel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonCancel.ForeColor = System.Drawing.Color.Black;
			this.buttonCancel.Location = new System.Drawing.Point(377, 414);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(105, 31);
			this.buttonCancel.TabIndex = 5;
			this.buttonCancel.Text = "取消";
			this.buttonCancel.UseVisualStyleBackColor = false;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// buttonExport
			// 
			this.buttonExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(116)))), ((int)(((byte)(198)))));
			this.buttonExport.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonExport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
			this.buttonExport.Location = new System.Drawing.Point(506, 414);
			this.buttonExport.Name = "buttonExport";
			this.buttonExport.Size = new System.Drawing.Size(105, 31);
			this.buttonExport.TabIndex = 6;
			this.buttonExport.Text = "輸出CSV";
			this.buttonExport.UseVisualStyleBackColor = false;
			this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click_1);
			// 
			// FormExportCSV
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(230)))));
			this.ClientSize = new System.Drawing.Size(642, 471);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonExport);
			this.Controls.Add(this.buttonDown);
			this.Controls.Add(this.buttonToLeft);
			this.Controls.Add(this.buttonUp);
			this.Controls.Add(this.buttonToRight);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.listBoxSelected);
			this.Controls.Add(this.listBoxOption);
			this.Name = "FormExportCSV";
			this.Text = "輸出CSV檔案";
			this.Load += new System.EventHandler(this.FormExportCSV_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox listBoxOption;
		private System.Windows.Forms.ListBox listBoxSelected;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button buttonToRight;
		private System.Windows.Forms.Button buttonToLeft;
		private System.Windows.Forms.Button buttonUp;
		private System.Windows.Forms.Button buttonDown;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonExport;
	}
}