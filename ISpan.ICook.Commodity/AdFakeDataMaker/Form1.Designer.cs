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
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShowCampaign
            // 
            this.btnShowCampaign.Location = new System.Drawing.Point(52, 52);
            this.btnShowCampaign.Name = "btnShowCampaign";
            this.btnShowCampaign.Size = new System.Drawing.Size(117, 23);
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
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(190, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(1029, 386);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnShowImpression
            // 
            this.btnShowImpression.Location = new System.Drawing.Point(52, 105);
            this.btnShowImpression.Name = "btnShowImpression";
            this.btnShowImpression.Size = new System.Drawing.Size(117, 23);
            this.btnShowImpression.TabIndex = 0;
            this.btnShowImpression.Text = "曝光";
            this.btnShowImpression.UseVisualStyleBackColor = true;
            this.btnShowImpression.Click += new System.EventHandler(this.btnShowImpression_Click);
            // 
            // btnShowClick
            // 
            this.btnShowClick.Location = new System.Drawing.Point(52, 160);
            this.btnShowClick.Name = "btnShowClick";
            this.btnShowClick.Size = new System.Drawing.Size(117, 23);
            this.btnShowClick.TabIndex = 0;
            this.btnShowClick.Text = "點擊";
            this.btnShowClick.UseVisualStyleBackColor = true;
            this.btnShowClick.Click += new System.EventHandler(this.btnShowClick_Click);
            // 
            // btnDb
            // 
            this.btnDb.Location = new System.Drawing.Point(1144, 432);
            this.btnDb.Name = "btnDb";
            this.btnDb.Size = new System.Drawing.Size(75, 23);
            this.btnDb.TabIndex = 0;
            this.btnDb.Text = "寫進資料庫";
            this.btnDb.UseVisualStyleBackColor = true;
            this.btnDb.Click += new System.EventHandler(this.btnDb_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "AdSpacePk";
            this.Column1.HeaderText = "版位";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "IP";
            this.Column2.HeaderText = "IP";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Time";
            this.Column3.HeaderText = "時間";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 300;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 487);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDb);
            this.Controls.Add(this.btnShowClick);
            this.Controls.Add(this.btnShowImpression);
            this.Controls.Add(this.btnShowCampaign);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowCampaign;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnShowImpression;
        private System.Windows.Forms.Button btnShowClick;
        private System.Windows.Forms.Button btnDb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}

