namespace AdFakeDataMaker
{
    partial class FormMain
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
            this.btnShowCampaign = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnShowImpression = new System.Windows.Forms.Button();
            this.btnShowClick = new System.Windows.Forms.Button();
            this.btnDb = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShowCampaign
            // 
            this.btnShowCampaign.Location = new System.Drawing.Point(52, 32);
            this.btnShowCampaign.Name = "btnShowCampaign";
            this.btnShowCampaign.Size = new System.Drawing.Size(117, 44);
            this.btnShowCampaign.TabIndex = 0;
            this.btnShowCampaign.Text = "廣告活動";
            this.btnShowCampaign.UseVisualStyleBackColor = true;
            this.btnShowCampaign.Click += new System.EventHandler(this.btnShowCampaign_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(218, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(1029, 324);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnShowImpression
            // 
            this.btnShowImpression.Location = new System.Drawing.Point(52, 406);
            this.btnShowImpression.Name = "btnShowImpression";
            this.btnShowImpression.Size = new System.Drawing.Size(117, 45);
            this.btnShowImpression.TabIndex = 0;
            this.btnShowImpression.Text = "曝光";
            this.btnShowImpression.UseVisualStyleBackColor = true;
            this.btnShowImpression.Click += new System.EventHandler(this.btnShowImpression_Click);
            // 
            // btnShowClick
            // 
            this.btnShowClick.Location = new System.Drawing.Point(52, 774);
            this.btnShowClick.Name = "btnShowClick";
            this.btnShowClick.Size = new System.Drawing.Size(117, 40);
            this.btnShowClick.TabIndex = 0;
            this.btnShowClick.Text = "點擊";
            this.btnShowClick.UseVisualStyleBackColor = true;
            this.btnShowClick.Click += new System.EventHandler(this.btnShowClick_Click);
            // 
            // btnDb
            // 
            this.btnDb.Location = new System.Drawing.Point(1044, 378);
            this.btnDb.Name = "btnDb";
            this.btnDb.Size = new System.Drawing.Size(202, 39);
            this.btnDb.TabIndex = 0;
            this.btnDb.Text = "廣告活動寫進資料庫";
            this.btnDb.UseVisualStyleBackColor = true;
            this.btnDb.Click += new System.EventHandler(this.btnDb_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(924, 658);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(322, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "曝光Log寫進資料庫";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(924, 1005);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(322, 39);
            this.button2.TabIndex = 3;
            this.button2.Text = "點擊Log寫進資料庫";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(218, 424);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1029, 225);
            this.dataGridView2.TabIndex = 4;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(218, 750);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 62;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(1029, 225);
            this.dataGridView3.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(52, 992);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1806, 1050);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDb);
            this.Controls.Add(this.btnShowClick);
            this.Controls.Add(this.btnShowImpression);
            this.Controls.Add(this.btnShowCampaign);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowCampaign;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnShowImpression;
        private System.Windows.Forms.Button btnShowClick;
        private System.Windows.Forms.Button btnDb;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button button3;
    }
}

