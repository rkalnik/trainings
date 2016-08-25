namespace QuestionReviewer
{
	partial class EditCategories
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
			this.lbCategoryName = new System.Windows.Forms.Label();
			this.tbQuestion = new System.Windows.Forms.TextBox();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btCancel = new System.Windows.Forms.Button();
			this.btSave = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbCategoryName
			// 
			this.lbCategoryName.AutoSize = true;
			this.lbCategoryName.Location = new System.Drawing.Point(12, 9);
			this.lbCategoryName.Name = "lbCategoryName";
			this.lbCategoryName.Size = new System.Drawing.Size(81, 13);
			this.lbCategoryName.TabIndex = 15;
			this.lbCategoryName.Text = "Category name:";
			// 
			// tbQuestion
			// 
			this.tbQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbQuestion.Location = new System.Drawing.Point(15, 35);
			this.tbQuestion.Multiline = true;
			this.tbQuestion.Name = "tbQuestion";
			this.tbQuestion.Size = new System.Drawing.Size(486, 29);
			this.tbQuestion.TabIndex = 16;
			// 
			// btnDelete
			// 
			this.btnDelete.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnDelete.Location = new System.Drawing.Point(93, 108);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 23);
			this.btnDelete.TabIndex = 26;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			// 
			// btCancel
			// 
			this.btCancel.Location = new System.Drawing.Point(174, 109);
			this.btCancel.Name = "btCancel";
			this.btCancel.Size = new System.Drawing.Size(75, 24);
			this.btCancel.TabIndex = 25;
			this.btCancel.Text = "Cancel";
			this.btCancel.UseVisualStyleBackColor = true;
			// 
			// btSave
			// 
			this.btSave.Location = new System.Drawing.Point(12, 109);
			this.btSave.Name = "btSave";
			this.btSave.Size = new System.Drawing.Size(75, 23);
			this.btSave.TabIndex = 24;
			this.btSave.Text = "Save";
			this.btSave.UseVisualStyleBackColor = true;
			// 
			// EditCategories
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(513, 154);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btCancel);
			this.Controls.Add(this.btSave);
			this.Controls.Add(this.tbQuestion);
			this.Controls.Add(this.lbCategoryName);
			this.Name = "EditCategories";
			this.Text = "EditCategories";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbCategoryName;
		private System.Windows.Forms.TextBox tbQuestion;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btCancel;
		private System.Windows.Forms.Button btSave;
	}
}