namespace ClassLibrary1
{
    partial class FB_Table
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.CheckBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MemberPK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegistrationTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Operation = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckBox,
            this.MemberPK,
            this.MemberName,
            this.MemberEmail,
            this.MemberPhone,
            this.LastLogin,
            this.RegistrationTime,
            this.Operation});
            this.dataGridView1.Location = new System.Drawing.Point(3, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1024, 472);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(936, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "總共OO筆";
            // 
            // CheckBox
            // 
            this.CheckBox.HeaderText = "請選取";
            this.CheckBox.MinimumWidth = 6;
            this.CheckBox.Name = "CheckBox";
            this.CheckBox.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CheckBox.Width = 80;
            // 
            // MemberPK
            // 
            this.MemberPK.HeaderText = "會員PK";
            this.MemberPK.MinimumWidth = 6;
            this.MemberPK.Name = "MemberPK";
            this.MemberPK.ReadOnly = true;
            this.MemberPK.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.MemberPK.Width = 125;
            // 
            // MemberName
            // 
            this.MemberName.HeaderText = "會員暱稱";
            this.MemberName.MinimumWidth = 6;
            this.MemberName.Name = "MemberName";
            this.MemberName.ReadOnly = true;
            this.MemberName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.MemberName.Width = 130;
            // 
            // MemberEmail
            // 
            this.MemberEmail.HeaderText = "會員信箱";
            this.MemberEmail.MinimumWidth = 6;
            this.MemberEmail.Name = "MemberEmail";
            this.MemberEmail.ReadOnly = true;
            this.MemberEmail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.MemberEmail.Width = 165;
            // 
            // MemberPhone
            // 
            this.MemberPhone.HeaderText = "會員電話";
            this.MemberPhone.MinimumWidth = 6;
            this.MemberPhone.Name = "MemberPhone";
            this.MemberPhone.ReadOnly = true;
            this.MemberPhone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.MemberPhone.Width = 140;
            // 
            // LastLogin
            // 
            this.LastLogin.HeaderText = "上次登入";
            this.LastLogin.MinimumWidth = 6;
            this.LastLogin.Name = "LastLogin";
            this.LastLogin.ReadOnly = true;
            this.LastLogin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.LastLogin.Width = 125;
            // 
            // RegistrationTime
            // 
            this.RegistrationTime.HeaderText = "註冊時間";
            this.RegistrationTime.MinimumWidth = 6;
            this.RegistrationTime.Name = "RegistrationTime";
            this.RegistrationTime.ReadOnly = true;
            this.RegistrationTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.RegistrationTime.Width = 125;
            // 
            // Operation
            // 
            this.Operation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Operation.HeaderText = "操作";
            this.Operation.MinimumWidth = 6;
            this.Operation.Name = "Operation";
            this.Operation.Text = "修改";
            this.Operation.ToolTipText = "修改";
            this.Operation.UseColumnTextForButtonValue = true;
            this.Operation.Width = 80;
            // 
            // FB_Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FB_Table";
            this.Size = new System.Drawing.Size(1032, 538);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberPK;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistrationTime;
        private System.Windows.Forms.DataGridViewButtonColumn Operation;
    }
}
