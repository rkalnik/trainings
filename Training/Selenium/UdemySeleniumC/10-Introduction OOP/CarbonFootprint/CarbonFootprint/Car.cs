using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarbonFootprint
{
	class Car : ICarbonFootprint
	{
		public Car(double gals)
		{
			Gallons = gals;
		}
		private double gallons;
		public double Gallons
		{
			get
			{
				return gallons;
			}

			set
			{
				if(value >= 0)
				{
					gallons = value;
				}
			}
		}

		public void CalcCarbonFootprint()
		{
			Console.WriteLine("The carbon footprint for a car that has used {0} gallons is {1}", Gallons, Gallons * 20);
		}
	}
}
