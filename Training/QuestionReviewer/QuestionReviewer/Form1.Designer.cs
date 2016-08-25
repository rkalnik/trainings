namespace QuestionReviewer
{
	partial class Form1
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
			this.dgvQuestionCard = new System.Windows.Forms.DataGridView();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.dgvQuestion = new System.Windows.Forms.DataGridView();
			this.Categories = new System.Windows.Forms.TabPage();
			this.menuStrip2 = new System.Windows.Forms.MenuStrip();
			this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addQuestionCardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dgvCategories = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgvQuestionCard)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvQuestion)).BeginInit();
			this.Categories.SuspendLayout();
			this.menuStrip2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvQuestionCard
			// 
			this.dgvQuestionCard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvQuestionCard.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvQuestionCard.Location = new System.Drawing.Point(0, 48);
			this.dgvQuestionCard.Name = "dgvQuestionCard";
			this.dgvQuestionCard.Size = new System.Drawing.Size(648, 299);
			this.dgvQuestionCard.TabIndex = 0;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 24);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(648, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
			this.saveToolStripMenuItem.Text = "Save";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.Categories);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 48);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(648, 299);
			this.tabControl1.TabIndex = 2;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.dgvQuestion);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(640, 273);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Question";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// dgvQuestion
			// 
			this.dgvQuestion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvQuestion.Location = new System.Drawing.Point(3, 3);
			this.dgvQuestion.MultiSelect = false;
			this.dgvQuestion.Name = "dgvQuestion";
			this.dgvQuestion.ReadOnly = true;
			this.dgvQuestion.RowHeadersVisible = false;
			this.dgvQuestion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvQuestion.Size = new System.Drawing.Size(634, 267);
			this.dgvQuestion.TabIndex = 0;
			this.dgvQuestion.DoubleClick += new System.EventHandler(this.dgvQuestion_DoubleClick);
			// 
			// Categories
			// 
			this.Categories.Controls.Add(this.dgvCategories);
			this.Categories.Location = new System.Drawing.Point(4, 22);
			this.Categories.Name = "Categories";
			this.Categories.Padding = new System.Windows.Forms.Padding(3);
			this.Categories.Size = new System.Drawing.Size(640, 273);
			this.Categories.TabIndex = 1;
			this.Categories.Text = "Categories";
			this.Categories.UseVisualStyleBackColor = true;
			// 
			// menuStrip2
			// 
			this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem});
			this.menuStrip2.Location = new System.Drawing.Point(0, 0);
			this.menuStrip2.Name = "menuStrip2";
			this.menuStrip2.Size = new System.Drawing.Size(648, 24);
			this.menuStrip2.TabIndex = 3;
			this.menuStrip2.Text = "menuStrip2";
			// 
			// addToolStripMenuItem
			// 
			this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addQuestionCardToolStripMenuItem});
			this.addToolStripMenuItem.Name = "addToolStripMenuItem";
			this.addToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
			this.addToolStripMenuItem.Text = "Add";
			// 
			// addQuestionCardToolStripMenuItem
			// 
			this.addQuestionCardToolStripMenuItem.Name = "addQuestionCardToolStripMenuItem";
			this.addQuestionCardToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
			this.addQuestionCardToolStripMenuItem.Text = "Add QuestionCard";
			this.addQuestionCardToolStripMenuItem.Click += new System.EventHandler(this.addQuestionCardToolStripMenuItem_Click);
			// 
			// dgvCategories
			// 
			this.dgvCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCategories.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvCategories.Location = new System.Drawing.Point(3, 3);
			this.dgvCategories.MultiSelect = false;
			this.dgvCategories.Name = "dgvCategories";
			this.dgvCategories.ReadOnly = true;
			this.dgvCategories.RowHeadersVisible = false;
			this.dgvCategories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvCategories.Size = new System.Drawing.Size(634, 267);
			this.dgvCategories.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(648, 347);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.dgvQuestionCard);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.menuStrip2);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dgvQuestionCard)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvQuestion)).EndInit();
			this.Categories.ResumeLayout(false);
			this.menuStrip2.ResumeLayout(false);
			this.menuStrip2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvQuestionCard;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage Categories;
		private System.Windows.Forms.DataGridView dgvQuestion;
		private System.Windows.Forms.MenuStrip menuStrip2;
		private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addQuestionCardToolStripMenuItem;
		private System.Windows.Forms.DataGridView dgvCategories;
	}
}

