namespace WindowsFormsApp1
{
	partial class FormMain
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
			this.buttonCategories = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.維護商品分類ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.維護商品分類ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonCategories
			// 
			this.buttonCategories.Location = new System.Drawing.Point(65, 91);
			this.buttonCategories.Name = "buttonCategories";
			this.buttonCategories.Size = new System.Drawing.Size(114, 37);
			this.buttonCategories.TabIndex = 0;
			this.buttonCategories.Text = "維護商品分類";
			this.buttonCategories.UseVisualStyleBackColor = true;
			this.buttonCategories.Click += new System.EventHandler(this.buttonCategories_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.維護商品分類ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(369, 27);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// 維護商品分類ToolStripMenuItem
			// 
			this.維護商品分類ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.維護商品分類ToolStripMenuItem1});
			this.維護商品分類ToolStripMenuItem.Name = "維護商品分類ToolStripMenuItem";
			this.維護商品分類ToolStripMenuItem.Size = new System.Drawing.Size(113, 23);
			this.維護商品分類ToolStripMenuItem.Text = "維護基本資料";
			// 
			// 維護商品分類ToolStripMenuItem1
			// 
			this.維護商品分類ToolStripMenuItem1.Name = "維護商品分類ToolStripMenuItem1";
			this.維護商品分類ToolStripMenuItem1.Size = new System.Drawing.Size(182, 26);
			this.維護商品分類ToolStripMenuItem1.Text = "維護商品分類";
			this.維護商品分類ToolStripMenuItem1.Click += new System.EventHandler(this.維護商品分類ToolStripMenuItem1_Click);
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(369, 243);
			this.Controls.Add(this.buttonCategories);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "FormMain";
			this.Text = "FormMain";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonCategories;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 維護商品分類ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 維護商品分類ToolStripMenuItem1;
	}
}