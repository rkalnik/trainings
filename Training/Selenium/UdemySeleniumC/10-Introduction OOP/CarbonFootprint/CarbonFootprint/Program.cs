using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarbonFootprint
{
	class Program
	{
		static void Main(string[] args)
		{
			ICarbonFootprint[] list = new ICarbonFootprint[3];

			list[0] = new Bicycle();
			list[1] = new Building(2500);
			list[2] = new Car(15);

			foreach(ICarbonFootprint element in list)
			{
				element.CalcCarbonFootprint();
			}

			Console.ReadKey();
		}
	}
}
