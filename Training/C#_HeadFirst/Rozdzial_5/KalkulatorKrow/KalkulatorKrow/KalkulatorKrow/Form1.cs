﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalkulatorKrow
{
	public partial class Form1 : Form
	{
		Farmer farmer;

		public Form1()
		{
			InitializeComponent();
			//stworzenie konstruktora z logika w ciele powoduje
			//wymuszenie jego zastosowania podczas tworzenia obiektu
			farmer = new Farmer(15, 30);
		}

		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{
			farmer.NumberOfCows = (int)numericUpDown1.Value;
		}

		private void calculateBt_Click(object sender, EventArgs e)
		{
			Console.WriteLine("Potrzebuję {0} worków paszy do wykarmienia {1} krów,", farmer.BagsOfFeed, farmer.NumberOfCows);
		}

	}
}
