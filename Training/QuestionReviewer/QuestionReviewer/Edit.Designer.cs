namespace QuestionReviewer
{
	partial class Edit
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
			this.tbQuestion = new System.Windows.Forms.TextBox();
			this.tbAnswer1 = new System.Windows.Forms.TextBox();
			this.tbAnswer2 = new System.Windows.Forms.TextBox();
			this.tbAnswer3 = new System.Windows.Forms.TextBox();
			this.rb1 = new System.Windows.Forms.RadioButton();
			this.rb2 = new System.Windows.Forms.RadioButton();
			this.rb3 = new System.Windows.Forms.RadioButton();
			this.labelQuestion = new System.Windows.Forms.Label();
			this.labelAnswer1 = new System.Windows.Forms.Label();
			this.labelAnswer2 = new System.Windows.Forms.Label();
			this.labelAnswer3 = new System.Windows.Forms.Label();
			this.labelCorrectAnswer = new System.Windows.Forms.Label();
			this.labelCategory = new System.Windows.Forms.Label();
			this.btSave = new System.Windows.Forms.Button();
			this.btCancel = new System.Windows.Forms.Button();
			this.cbCategory = new System.Windows.Forms.ComboBox();
			this.btnDelete = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// tbQuestion
			// 
			this.tbQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbQuestion.Location = new System.Drawing.Point(12, 22);
			this.tbQuestion.Multiline = true;
			this.tbQuestion.Name = "tbQuestion";
			this.tbQuestion.Size = new System.Drawing.Size(667, 100);
			this.tbQuestion.TabIndex = 7;
			// 
			// tbAnswer1
			// 
			this.tbAnswer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbAnswer1.Location = new System.Drawing.Point(12, 142);
			this.tbAnswer1.Multiline = true;
			this.tbAnswer1.Name = "tbAnswer1";
			this.tbAnswer1.Size = new System.Drawing.Size(667, 100);
			this.tbAnswer1.TabIndex = 8;
			// 
			// tbAnswer2
			// 
			this.tbAnswer2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbAnswer2.Location = new System.Drawing.Point(13, 262);
			this.tbAnswer2.Multiline = true;
			this.tbAnswer2.Name = "tbAnswer2";
			this.tbAnswer2.Size = new System.Drawing.Size(666, 100);
			this.tbAnswer2.TabIndex = 9;
			// 
			// tbAnswer3
			// 
			this.tbAnswer3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbAnswer3.Location = new System.Drawing.Point(13, 381);
			this.tbAnswer3.Multiline = true;
			this.tbAnswer3.Name = "tbAnswer3";
			this.tbAnswer3.Size = new System.Drawing.Size(666, 100);
			this.tbAnswer3.TabIndex = 10;
			// 
			// rb1
			// 
			this.rb1.AccessibleName = "";
			this.rb1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
			this.rb1.AutoSize = true;
			this.rb1.Checked = true;
			this.rb1.Location = new System.Drawing.Point(13, 519);
			this.rb1.Name = "rb1";
			this.rb1.Size = new System.Drawing.Size(32, 17);
			this.rb1.TabIndex = 11;
			this.rb1.TabStop = true;
			this.rb1.Tag = "1";
			this.rb1.Text = "A";
			this.rb1.UseVisualStyleBackColor = true;
			// 
			// rb2
			// 
			this.rb2.AccessibleName = "";
			this.rb2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
			this.rb2.AutoSize = true;
			this.rb2.Location = new System.Drawing.Point(51, 519);
			this.rb2.Name = "rb2";
			this.rb2.Size = new System.Drawing.Size(32, 17);
			this.rb2.TabIndex = 12;
			this.rb2.Tag = "2";
			this.rb2.Text = "B";
			this.rb2.UseVisualStyleBackColor = true;
			// 
			// rb3
			// 
			this.rb3.AccessibleName = "";
			this.rb3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
			this.rb3.AutoSize = true;
			this.rb3.Location = new System.Drawing.Point(89, 519);
			this.rb3.Name = "rb3";
			this.rb3.Size = new System.Drawing.Size(32, 17);
			this.rb3.TabIndex = 13;
			this.rb3.Tag = "3";
			this.rb3.Text = "C";
			this.rb3.UseVisualStyleBackColor = true;
			// 
			// labelQuestion
			// 
			this.labelQuestion.AutoSize = true;
			this.labelQuestion.Location = new System.Drawing.Point(12, 6);
			this.labelQuestion.Name = "labelQuestion";
			this.labelQuestion.Size = new System.Drawing.Size(52, 13);
			this.labelQuestion.TabIndex = 14;
			this.labelQuestion.Text = "Question:";
			// 
			// labelAnswer1
			// 
			this.labelAnswer1.AutoSize = true;
			this.labelAnswer1.Location = new System.Drawing.Point(9, 126);
			this.labelAnswer1.Name = "labelAnswer1";
			this.labelAnswer1.Size = new System.Drawing.Size(54, 13);
			this.labelAnswer1.TabIndex = 15;
			this.labelAnswer1.Text = "Answer 1:";
			// 
			// labelAnswer2
			// 
			this.labelAnswer2.AutoSize = true;
			this.labelAnswer2.Location = new System.Drawing.Point(12, 245);
			this.labelAnswer2.Name = "labelAnswer2";
			this.labelAnswer2.Size = new System.Drawing.Size(54, 13);
			this.labelAnswer2.TabIndex = 16;
			this.labelAnswer2.Text = "Answer 2:";
			// 
			// labelAnswer3
			// 
			this.labelAnswer3.AutoSize = true;
			this.labelAnswer3.Location = new System.Drawing.Point(12, 365);
			this.labelAnswer3.Name = "labelAnswer3";
			this.labelAnswer3.Size = new System.Drawing.Size(54, 13);
			this.labelAnswer3.TabIndex = 17;
			this.labelAnswer3.Text = "Answer 3:";
			// 
			// labelCorrectAnswer
			// 
			this.labelCorrectAnswer.AutoSize = true;
			this.labelCorrectAnswer.Location = new System.Drawing.Point(10, 503);
			this.labelCorrectAnswer.Name = "labelCorrectAnswer";
			this.labelCorrectAnswer.Size = new System.Drawing.Size(81, 13);
			this.labelCorrectAnswer.TabIndex = 18;
			this.labelCorrectAnswer.Text = "Correct answer:";
			// 
			// labelCategory
			// 
			this.labelCategory.AutoSize = true;
			this.labelCategory.Location = new System.Drawing.Point(11, 541);
			this.labelCategory.Name = "labelCategory";
			this.labelCategory.Size = new System.Drawing.Size(52, 13);
			this.labelCategory.TabIndex = 19;
			this.labelCategory.Text = "Category:";
			// 
			// btSave
			// 
			this.btSave.Location = new System.Drawing.Point(8, 599);
			this.btSave.Name = "btSave";
			this.btSave.Size = new System.Drawing.Size(75, 23);
			this.btSave.TabIndex = 20;
			this.btSave.Text = "Save";
			this.btSave.UseVisualStyleBackColor = true;
			this.btSave.Click += new System.EventHandler(this.btSave_Click);
			// 
			// btCancel
			// 
			this.btCancel.Location = new System.Drawing.Point(170, 599);
			this.btCancel.Name = "btCancel";
			this.btCancel.Size = new System.Drawing.Size(75, 24);
			this.btCancel.TabIndex = 21;
			this.btCancel.Text = "Cancel";
			this.btCancel.UseVisualStyleBackColor = true;
			// 
			// cbCategory
			// 
			this.cbCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cbCategory.FormattingEnabled = true;
			this.cbCategory.Location = new System.Drawing.Point(13, 559);
			this.cbCategory.Name = "cbCategory";
			this.cbCategory.Size = new System.Drawing.Size(666, 21);
			this.cbCategory.TabIndex = 22;
			// 
			// btnDelete
			// 
			this.btnDelete.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnDelete.Location = new System.Drawing.Point(89, 598);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 23);
			this.btnDelete.TabIndex = 23;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// Edit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(691, 644);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.cbCategory);
			this.Controls.Add(this.btCancel);
			this.Controls.Add(this.btSave);
			this.Controls.Add(this.labelCategory);
			this.Controls.Add(this.labelCorrectAnswer);
			this.Controls.Add(this.labelAnswer3);
			this.Controls.Add(this.labelAnswer2);
			this.Controls.Add(this.labelAnswer1);
			this.Controls.Add(this.labelQuestion);
			this.Controls.Add(this.rb3);
			this.Controls.Add(this.rb2);
			this.Controls.Add(this.rb1);
			this.Controls.Add(this.tbAnswer3);
			this.Controls.Add(this.tbAnswer2);
			this.Controls.Add(this.tbAnswer1);
			this.Controls.Add(this.tbQuestion);
			this.Name = "Edit";
			this.Text = "Edit";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbQuestion;
		private System.Windows.Forms.TextBox tbAnswer1;
		private System.Windows.Forms.TextBox tbAnswer2;
		private System.Windows.Forms.TextBox tbAnswer3;
		private System.Windows.Forms.RadioButton rb1;
		private System.Windows.Forms.RadioButton rb2;
		private System.Windows.Forms.RadioButton rb3;
		private System.Windows.Forms.Label labelQuestion;
		private System.Windows.Forms.Label labelAnswer1;
		private System.Windows.Forms.Label labelAnswer2;
		private System.Windows.Forms.Label labelAnswer3;
		private System.Windows.Forms.Label labelCorrectAnswer;
		private System.Windows.Forms.Label labelCategory;
		private System.Windows.Forms.Button btSave;
		private System.Windows.Forms.Button btCancel;
		private System.Windows.Forms.ComboBox cbCategory;
		private System.Windows.Forms.Button btnDelete;
	}
}