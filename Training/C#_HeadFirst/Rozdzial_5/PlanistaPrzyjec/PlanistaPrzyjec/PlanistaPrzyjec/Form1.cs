using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlanistaPrzyjec
{
	public partial class Form1 : Form
	{
		DinnerParty dinnerParty;

		public Form1()
		{
			InitializeComponent();

			dinnerParty = new DinnerParty()
			{ numberOfPeople = 5 };
			//dinnerParty.numberOfPeople = 5;
			dinnerParty.CalculateCostOfDecorations(fancyBox.Checked);
			dinnerParty.SetHealthyOption(healthyBox.Checked);
			DisplayDinnerPartyCost();

		}

		private void fancyBox_CheckedChanged(object sender, EventArgs e)
		{
			dinnerParty.CalculateCostOfDecorations(fancyBox.Checked);
			DisplayDinnerPartyCost();
		}

		private void healthyBox_CheckedChanged(object sender, EventArgs e)
		{
			dinnerParty.SetHealthyOption(healthyBox.Checked);
			DisplayDinnerPartyCost();
		}

		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{
			dinnerParty.numberOfPeople = (int)numericUpDown1.Value;
			DisplayDinnerPartyCost();
		}

		private void DisplayDinnerPartyCost()
		{
			decimal cost = dinnerParty.CalculateCost(healthyBox.Checked);
			costLabel2.Text = cost.ToString("c");
			//jeżeli do metody kowertujacej obiekt na ciąg znaków przekażesz parametr:
			//c -wartosc zostanie zamieniona na kwote w lokalnej walucie
			//f3 -tekstowa liczba z trzema miejscami po przecinku
			//0 -zamieni wartosc na liczbe calkowita
			//0% -zamieni wartosc na liczbę w postaci procentowej
			//n -wyświetli wartość, wstawiajac separatory dla poszczegolnych rzędów wielkosci
		}

	}
}
