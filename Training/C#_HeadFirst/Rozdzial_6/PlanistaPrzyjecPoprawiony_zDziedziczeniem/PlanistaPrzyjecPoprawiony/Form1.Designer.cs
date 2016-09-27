namespace PlanistaPrzyjecPoprawiony
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
			this.label1 = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.fancyBox = new System.Windows.Forms.CheckBox();
			this.healthyBox = new System.Windows.Forms.CheckBox();
			this.costLabel = new System.Windows.Forms.Label();
			this.costLabel2 = new System.Windows.Forms.Label();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tooLongLabel = new System.Windows.Forms.Label();
			this.cakeWritingTextBox = new System.Windows.Forms.TextBox();
			this.cakeWritingLb = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.birthdayCost = new System.Windows.Forms.Label();
			this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.fancyBox2 = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Ilość osób";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(71, 18);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
			this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
			this.numericUpDown1.TabIndex = 5;
			this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
			// 
			// fancyBox
			// 
			this.fancyBox.AutoSize = true;
			this.fancyBox.Checked = true;
			this.fancyBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.fancyBox.Location = new System.Drawing.Point(71, 63);
			this.fancyBox.Name = "fancyBox";
			this.fancyBox.Size = new System.Drawing.Size(126, 17);
			this.fancyBox.TabIndex = 6;
			this.fancyBox.Text = "Dekoracje fantazyjne";
			this.fancyBox.UseVisualStyleBackColor = true;
			this.fancyBox.CheckedChanged += new System.EventHandler(this.fancyBox_CheckedChanged);
			// 
			// healthyBox
			// 
			this.healthyBox.AutoSize = true;
			this.healthyBox.Location = new System.Drawing.Point(71, 96);
			this.healthyBox.Name = "healthyBox";
			this.healthyBox.Size = new System.Drawing.Size(91, 17);
			this.healthyBox.TabIndex = 7;
			this.healthyBox.Text = "Opcja zdrowa";
			this.healthyBox.UseVisualStyleBackColor = true;
			this.healthyBox.CheckedChanged += new System.EventHandler(this.healthyBox_CheckedChanged);
			// 
			// costLabel
			// 
			this.costLabel.AutoSize = true;
			this.costLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.costLabel.Location = new System.Drawing.Point(7, 169);
			this.costLabel.Name = "costLabel";
			this.costLabel.Size = new System.Drawing.Size(59, 20);
			this.costLabel.TabIndex = 8;
			this.costLabel.Text = "Koszt:";
			// 
			// costLabel2
			// 
			this.costLabel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.costLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.costLabel2.Location = new System.Drawing.Point(72, 167);
			this.costLabel2.Name = "costLabel2";
			this.costLabel2.Size = new System.Drawing.Size(100, 22);
			this.costLabel2.TabIndex = 9;
			this.costLabel2.Tag = "";
			this.costLabel2.Text = " ";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(0, 4);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(276, 259);
			this.tabControl1.TabIndex = 10;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this.costLabel2);
			this.tabPage1.Controls.Add(this.numericUpDown1);
			this.tabPage1.Controls.Add(this.costLabel);
			this.tabPage1.Controls.Add(this.fancyBox);
			this.tabPage1.Controls.Add(this.healthyBox);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(268, 233);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Impreza okolicznościowa";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.tooLongLabel);
			this.tabPage2.Controls.Add(this.cakeWritingTextBox);
			this.tabPage2.Controls.Add(this.cakeWritingLb);
			this.tabPage2.Controls.Add(this.label2);
			this.tabPage2.Controls.Add(this.birthdayCost);
			this.tabPage2.Controls.Add(this.numericUpDown2);
			this.tabPage2.Controls.Add(this.label4);
			this.tabPage2.Controls.Add(this.fancyBox2);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(268, 233);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Przyjęcie urodzinowe";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// tooLongLabel
			// 
			this.tooLongLabel.AutoSize = true;
			this.tooLongLabel.BackColor = System.Drawing.Color.Red;
			this.tooLongLabel.ForeColor = System.Drawing.SystemColors.MenuText;
			this.tooLongLabel.Location = new System.Drawing.Point(125, 100);
			this.tooLongLabel.Name = "tooLongLabel";
			this.tooLongLabel.Size = new System.Drawing.Size(78, 13);
			this.tooLongLabel.TabIndex = 17;
			this.tooLongLabel.Text = "ZBYT DŁUGI !";
			// 
			// cakeWritingTextBox
			// 
			this.cakeWritingTextBox.Location = new System.Drawing.Point(43, 130);
			this.cakeWritingTextBox.Name = "cakeWritingTextBox";
			this.cakeWritingTextBox.Size = new System.Drawing.Size(100, 20);
			this.cakeWritingTextBox.TabIndex = 16;
			this.cakeWritingTextBox.Text = "Sto lat!";
			this.cakeWritingTextBox.TextChanged += new System.EventHandler(this.cakeWritingTextBox_TextChanged);
			// 
			// cakeWritingLb
			// 
			this.cakeWritingLb.AutoSize = true;
			this.cakeWritingLb.Location = new System.Drawing.Point(40, 101);
			this.cakeWritingLb.Name = "cakeWritingLb";
			this.cakeWritingLb.Size = new System.Drawing.Size(78, 13);
			this.cakeWritingLb.TabIndex = 15;
			this.cakeWritingLb.Text = "Napis na torcie";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(40, 15);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 13);
			this.label2.TabIndex = 10;
			this.label2.Text = "Ilość osób";
			// 
			// birthdayCost
			// 
			this.birthdayCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.birthdayCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.birthdayCost.Location = new System.Drawing.Point(104, 180);
			this.birthdayCost.Name = "birthdayCost";
			this.birthdayCost.Size = new System.Drawing.Size(100, 22);
			this.birthdayCost.TabIndex = 14;
			this.birthdayCost.Tag = "";
			this.birthdayCost.Text = " ";
			// 
			// numericUpDown2
			// 
			this.numericUpDown2.Location = new System.Drawing.Point(43, 31);
			this.numericUpDown2.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
			this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown2.Name = "numericUpDown2";
			this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
			this.numericUpDown2.TabIndex = 11;
			this.numericUpDown2.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(39, 182);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(59, 20);
			this.label4.TabIndex = 13;
			this.label4.Text = "Koszt:";
			// 
			// fancyBox2
			// 
			this.fancyBox2.AutoSize = true;
			this.fancyBox2.Checked = true;
			this.fancyBox2.CheckState = System.Windows.Forms.CheckState.Checked;
			this.fancyBox2.Location = new System.Drawing.Point(43, 66);
			this.fancyBox2.Name = "fancyBox2";
			this.fancyBox2.Size = new System.Drawing.Size(126, 17);
			this.fancyBox2.TabIndex = 12;
			this.fancyBox2.Text = "Dekoracje fantazyjne";
			this.fancyBox2.UseVisualStyleBackColor = true;
			this.fancyBox2.CheckedChanged += new System.EventHandler(this.fancyBox2_CheckedChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(275, 261);
			this.Controls.Add(this.tabControl1);
			this.Name = "Form1";
			this.Text = "Planista Przyjęć";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.CheckBox fancyBox;
		private System.Windows.Forms.CheckBox healthyBox;
		private System.Windows.Forms.Label costLabel;
		private System.Windows.Forms.Label costLabel2;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label birthdayCost;
		private System.Windows.Forms.NumericUpDown numericUpDown2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.CheckBox fancyBox2;
		private System.Windows.Forms.TextBox cakeWritingTextBox;
		private System.Windows.Forms.Label cakeWritingLb;
		private System.Windows.Forms.Label tooLongLabel;
	}
}

