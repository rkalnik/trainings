namespace PlanistaPrzyjec
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
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.fancyBox = new System.Windows.Forms.CheckBox();
			this.healthyBox = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.costLabel = new System.Windows.Forms.Label();
			this.costLabel2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(12, 36);
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
			this.numericUpDown1.TabIndex = 0;
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
			this.fancyBox.Location = new System.Drawing.Point(12, 80);
			this.fancyBox.Name = "fancyBox";
			this.fancyBox.Size = new System.Drawing.Size(126, 17);
			this.fancyBox.TabIndex = 1;
			this.fancyBox.Text = "Dekoracje fantazyjne";
			this.fancyBox.UseVisualStyleBackColor = true;
			this.fancyBox.CheckedChanged += new System.EventHandler(this.fancyBox_CheckedChanged);
			// 
			// healthyBox
			// 
			this.healthyBox.AutoSize = true;
			this.healthyBox.Location = new System.Drawing.Point(12, 117);
			this.healthyBox.Name = "healthyBox";
			this.healthyBox.Size = new System.Drawing.Size(91, 17);
			this.healthyBox.TabIndex = 2;
			this.healthyBox.Text = "Opcja zdrowa";
			this.healthyBox.UseVisualStyleBackColor = true;
			this.healthyBox.CheckedChanged += new System.EventHandler(this.healthyBox_CheckedChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Ilość osób";
			// 
			// costLabel
			// 
			this.costLabel.AutoSize = true;
			this.costLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.costLabel.Location = new System.Drawing.Point(12, 158);
			this.costLabel.Name = "costLabel";
			this.costLabel.Size = new System.Drawing.Size(59, 20);
			this.costLabel.TabIndex = 4;
			this.costLabel.Text = "Koszt:";
			// 
			// costLabel2
			// 
			this.costLabel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.costLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.costLabel2.Location = new System.Drawing.Point(77, 158);
			this.costLabel2.Name = "costLabel2";
			this.costLabel2.Size = new System.Drawing.Size(100, 22);
			this.costLabel2.TabIndex = 5;
			this.costLabel2.Tag = "";
			this.costLabel2.Text = " ";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(271, 213);
			this.Controls.Add(this.costLabel2);
			this.Controls.Add(this.costLabel);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.healthyBox);
			this.Controls.Add(this.fancyBox);
			this.Controls.Add(this.numericUpDown1);
			this.Name = "Form1";
			this.Text = "Planista Przyjęć";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.CheckBox fancyBox;
		private System.Windows.Forms.CheckBox healthyBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label costLabel;
		private System.Windows.Forms.Label costLabel2;
	}
}

