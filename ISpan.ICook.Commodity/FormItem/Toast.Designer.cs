namespace FormItem
{
	partial class Toast
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
			this.toastBackground = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// toastBackground
			// 
			this.toastBackground.Enabled = false;
			this.toastBackground.Location = new System.Drawing.Point(2, 3);
			this.toastBackground.Name = "toastBackground";
			this.toastBackground.Size = new System.Drawing.Size(75, 23);
			this.toastBackground.TabIndex = 0;
			this.toastBackground.Text = "button1";
			this.toastBackground.UseVisualStyleBackColor = true;
			// 
			// Toast
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.toastBackground);
			this.Name = "Toast";
			this.Size = new System.Drawing.Size(80, 29);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button toastBackground;
	}
}
