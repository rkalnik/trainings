﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZamianaSloni
{
    public partial class Form1 : Form
    {
        Elephant lucinda;
        Elephant lloyd;
		Elephant[] elephants;

        public Form1()
        {
            InitializeComponent();
            lucinda = new Elephant() { Name = "Lucinda", EarSize = 33 };

			lloyd = new Elephant();
			lloyd.Name = "Lloyd";
			lloyd.EarSize = 40;
			

        }
        private void button1_Click(object sender, EventArgs e)
        {
            lloyd.WhoAmI();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            lucinda.WhoAmI();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Elephant holder;
            holder = lloyd;
            lloyd = lucinda;
            lucinda = holder;
            MessageBox.Show("Obiekty zamienione");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lloyd = lucinda;
            lloyd.EarSize = 4321;
            lloyd.WhoAmI();
        }

		private void button5_Click(object sender, EventArgs e)
		{
			elephants = new Elephant[7];
			elephants[0] = new Elephant() { Name = "Lloyd", EarSize = 40 };
			elephants[1] = new Elephant() { Name = "Lucinda", EarSize = 33 };
			elephants[2] = new Elephant() { Name = "Larry", EarSize = 42 };
			elephants[3] = new Elephant() { Name = "Lucille", EarSize = 32 };
			elephants[4] = new Elephant() { Name = "Lars", EarSize = 44 };
			elephants[5] = new Elephant() { Name = "Linda", EarSize = 37 };
			elephants[6] = new Elephant() { Name = "Humphrey", EarSize = 45 };

			Elephant biggestEars = elephants[0];
			for (int i=1; i < elephants.Length; i++)
			{
				if (elephants[i].EarSize > biggestEars.EarSize)
				{
					biggestEars = elephants[i];
				}
			}

			MessageBox.Show("Słoń z największymi uszami to: " + biggestEars.Name + "\nJego rozmiar uszu to: " + biggestEars.EarSize.ToString());

		}

	}

}
