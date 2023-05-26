namespace WindowsFormsApp1
{
    partial class Form1
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

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
			this.buttonConnect = new System.Windows.Forms.Button();
			this.buttonEditCategory = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// buttonConnect
			// 
			this.buttonConnect.Location = new System.Drawing.Point(36, 26);
			this.buttonConnect.Name = "buttonConnect";
			this.buttonConnect.Size = new System.Drawing.Size(142, 23);
			this.buttonConnect.TabIndex = 0;
			this.buttonConnect.Text = "Connect to Db";
			this.buttonConnect.UseVisualStyleBackColor = true;
			this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
			// 
			// buttonEditCategory
			// 
			this.buttonEditCategory.Location = new System.Drawing.Point(36, 66);
			this.buttonEditCategory.Name = "buttonEditCategory";
			this.buttonEditCategory.Size = new System.Drawing.Size(142, 23);
			this.buttonEditCategory.TabIndex = 1;
			this.buttonEditCategory.Text = "Edit Category";
			this.buttonEditCategory.UseVisualStyleBackColor = true;
			this.buttonEditCategory.Click += new System.EventHandler(this.buttonEditCategory_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(345, 177);
			this.Controls.Add(this.buttonEditCategory);
			this.Controls.Add(this.buttonConnect);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonConnect;
		private System.Windows.Forms.Button buttonEditCategory;
	}
}

