namespace TextBoxAndTable
{
	partial class TextBoxEditable
	{
		/// <summary> 
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region 元件設計工具產生的程式碼

		/// <summary> 
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.labelErrorMessage = new System.Windows.Forms.Label();
			this.panelError = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.textBox1.Location = new System.Drawing.Point(145, 3);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(300, 29);
			this.textBox1.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(2, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(137, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "我可以塞最多這些";
			// 
			// labelErrorMessage
			// 
			this.labelErrorMessage.AutoSize = true;
			this.labelErrorMessage.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.labelErrorMessage.ForeColor = System.Drawing.Color.Red;
			this.labelErrorMessage.Location = new System.Drawing.Point(458, 7);
			this.labelErrorMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelErrorMessage.Name = "labelErrorMessage";
			this.labelErrorMessage.Size = new System.Drawing.Size(105, 20);
			this.labelErrorMessage.TabIndex = 4;
			this.labelErrorMessage.Text = "請輸入正確的";
			this.labelErrorMessage.Visible = false;
			// 
			// panelError
			// 
			this.panelError.BackColor = System.Drawing.Color.Red;
			this.panelError.Location = new System.Drawing.Point(143, 0);
			this.panelError.Name = "panelError";
			this.panelError.Size = new System.Drawing.Size(305, 34);
			this.panelError.TabIndex = 8;
			this.panelError.Visible = false;
			// 
			// TextBoxEditable
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.labelErrorMessage);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panelError);
			this.Name = "TextBoxEditable";
			this.Size = new System.Drawing.Size(857, 40);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelErrorMessage;
        private System.Windows.Forms.Panel panelError;
    }
}
