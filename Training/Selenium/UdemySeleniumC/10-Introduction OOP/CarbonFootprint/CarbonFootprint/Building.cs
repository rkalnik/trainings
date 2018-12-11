using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarbonFootprint
{
	class Building : ICarbonFootprint
	{
		public Building(int squareFeet)
		{
			SquareFeet = squareFeet;
		}

		private int sqft;
		public int SquareFeet
		{
			get
			{
				return sqft;
			}

			set
			{
				if (value >= 0)
				{
					sqft = value;
				}
			}
		}

		public void CalcCarbonFootprint()
		{
			Console.WriteLine("Carbon footprint for a building of {0} square feet is: {1}", SquareFeet, SquareFeet * 134);
		}

	}
}
