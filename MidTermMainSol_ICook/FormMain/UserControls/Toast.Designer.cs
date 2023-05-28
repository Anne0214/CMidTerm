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
			this.components = new System.ComponentModel.Container();
			this.labToast = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// labToast
			// 
			this.labToast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(81)))), ((int)(((byte)(123)))));
			this.labToast.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.labToast.ForeColor = System.Drawing.Color.White;
			this.labToast.Location = new System.Drawing.Point(2, 0);
			this.labToast.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labToast.MinimumSize = new System.Drawing.Size(200, 53);
			this.labToast.Name = "labToast";
			this.labToast.Size = new System.Drawing.Size(200, 53);
			this.labToast.TabIndex = 0;
			this.labToast.Text = "label1";
			this.labToast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// timer1
			// 
			this.timer1.Interval = 20;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// Toast
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.labToast);
			this.Name = "Toast";
			this.Size = new System.Drawing.Size(203, 55);
			this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.Label labToast;
        private System.Windows.Forms.Timer timer1;
    }
}
