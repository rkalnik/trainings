namespace SystemZarzadzaniaUlem
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
			this.shifts = new System.Windows.Forms.NumericUpDown();
			this.workerBeeJobCB = new System.Windows.Forms.ComboBox();
			this.nextShiftBt = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.reportTb = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.assignJobBt = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.shifts)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// shifts
			// 
			this.shifts.Location = new System.Drawing.Point(178, 33);
			this.shifts.Name = "shifts";
			this.shifts.Size = new System.Drawing.Size(120, 20);
			this.shifts.TabIndex = 0;
			this.shifts.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
			// 
			// workerBeeJobCB
			// 
			this.workerBeeJobCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.workerBeeJobCB.FormattingEnabled = true;
			this.workerBeeJobCB.Items.AddRange(new object[] {
            "Zbieranie nektaru",
            "Pielęgnacja jaj",
            "Utrzymanie ula",
            "Wytwarzanie miodu",
            "Nauczanie pszczółek",
            "Patrol z żądłami"});
			this.workerBeeJobCB.Location = new System.Drawing.Point(6, 33);
			this.workerBeeJobCB.Name = "workerBeeJobCB";
			this.workerBeeJobCB.Size = new System.Drawing.Size(153, 21);
			this.workerBeeJobCB.TabIndex = 1;
			// 
			// nextShiftBt
			// 
			this.nextShiftBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nextShiftBt.Location = new System.Drawing.Point(342, 30);
			this.nextShiftBt.Name = "nextShiftBt";
			this.nextShiftBt.Size = new System.Drawing.Size(98, 97);
			this.nextShiftBt.TabIndex = 2;
			this.nextShiftBt.Text = "Przepracuj następną zmianę";
			this.nextShiftBt.UseVisualStyleBackColor = true;
			this.nextShiftBt.Click += new System.EventHandler(this.nextShiftBt_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(92, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Zadanie robotnicy";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(175, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(41, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Zmiany";
			// 
			// reportTb
			// 
			this.reportTb.Location = new System.Drawing.Point(15, 148);
			this.reportTb.Multiline = true;
			this.reportTb.Name = "reportTb";
			this.reportTb.Size = new System.Drawing.Size(425, 253);
			this.reportTb.TabIndex = 6;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.assignJobBt);
			this.groupBox1.Controls.Add(this.workerBeeJobCB);
			this.groupBox1.Controls.Add(this.shifts);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Location = new System.Drawing.Point(15, 25);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(321, 102);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Przydział prac robotnicom";
			// 
			// assignJobBt
			// 
			this.assignJobBt.Location = new System.Drawing.Point(7, 70);
			this.assignJobBt.Name = "assignJobBt";
			this.assignJobBt.Size = new System.Drawing.Size(291, 23);
			this.assignJobBt.TabIndex = 6;
			this.assignJobBt.Text = "Przypisz tę pracę pszczole";
			this.assignJobBt.UseVisualStyleBackColor = true;
			this.assignJobBt.Click += new System.EventHandler(this.assignJobBt_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(458, 413);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.reportTb);
			this.Controls.Add(this.nextShiftBt);
			this.Name = "Form1";
			this.Text = "System zarządzania ulem";
			((System.ComponentModel.ISupportInitialize)(this.shifts)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.NumericUpDown shifts;
		private System.Windows.Forms.ComboBox workerBeeJobCB;
		private System.Windows.Forms.Button nextShiftBt;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox reportTb;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button assignJobBt;
	}
}

