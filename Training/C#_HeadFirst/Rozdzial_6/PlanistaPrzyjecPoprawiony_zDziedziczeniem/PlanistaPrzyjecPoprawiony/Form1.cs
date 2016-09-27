using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlanistaPrzyjecPoprawiony
{
	public partial class Form1 : Form
	{
		DinnerParty dinnerParty;
		BirthdayParty birthdayParty;

		public Form1()
		{
			InitializeComponent();
			dinnerParty = new DinnerParty((int)numericUpDown1.Value, healthyBox.Checked, fancyBox.Checked);
			DisplayDinnerPartyCost();

			birthdayParty = new BirthdayParty((int)numericUpDown2.Value, fancyBox2.Checked, cakeWritingTextBox.Text);
			DisplayBirthdayPartyCost();

		}

		private void fancyBox_CheckedChanged(object sender, EventArgs e)
		{
			dinnerParty.FancyDecorations = fancyBox.Checked;
			DisplayDinnerPartyCost();
		}

		private void healthyBox_CheckedChanged(object sender, EventArgs e)
		{
			dinnerParty.HealthyOption = healthyBox.Checked;
			DisplayDinnerPartyCost();
		}

		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{
			dinnerParty.NumberOfPeople = (int)numericUpDown1.Value;
			DisplayDinnerPartyCost();
		}

		private void DisplayDinnerPartyCost()
		{
			decimal Cost = dinnerParty.Cost;
			costLabel2.Text = Cost.ToString("c");
		}

		private void numericUpDown2_ValueChanged(object sender, EventArgs e)
		{
			birthdayParty.NumberOfPeople = (int)numericUpDown2.Value;
			DisplayBirthdayPartyCost();
		}

		private void fancyBox2_CheckedChanged(object sender, EventArgs e)
		{
			birthdayParty.FancyDecorations = fancyBox2.Checked;
			DisplayBirthdayPartyCost();
		}

		private void cakeWritingTextBox_TextChanged(object sender, EventArgs e)
		{
			birthdayParty.CakeWriting = cakeWritingTextBox.Text;
			DisplayBirthdayPartyCost();
		}

		private void DisplayBirthdayPartyCost()
		{
			tooLongLabel.Visible = birthdayParty.CakeWritingTooLong;
			decimal cost = birthdayParty.Cost;
			birthdayCost.Text = cost.ToString("c");
		}
	}
}
