using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulatorKrow
{
	public class Farmer
	{
		public int BagsOfFeed { get; private set; }
		private int feedMultiplier;
		public int FeedMultiplier { get { return feedMultiplier; } }
		public int Rafal { get; set; }

		private int numberOfCows;
		public int NumberOfCows
		{
			get
			{
				return numberOfCows;
			}
			set
			{
				numberOfCows = value;
				BagsOfFeed = numberOfCows * FeedMultiplier;
			}
		}

		//konstruktor w ktorym jego parametry przypisane sa do wlasciwosci klasy Farmer, stworzenie konstruktora z logika w ciele powoduje
		//wymuszenie jego zastosowania podczas tworzenia obiektu w klasie Form1
		public Farmer(int numberOfCows, int feedMultiplier)
		{
			this.feedMultiplier = feedMultiplier;
			this.NumberOfCows = numberOfCows;
		}

	}
}
