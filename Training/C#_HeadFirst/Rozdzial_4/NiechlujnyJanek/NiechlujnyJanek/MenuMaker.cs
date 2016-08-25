using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiechlujnyJanek
{
	class MenuMaker
	{
		public Random randomizer;

		string[] meats = { "Pieczona wołowina", "Salami", "Indyk", "Szynka", "Karkówka" };
		string[] condiments = { "żółta musztarda", "brązowa musztarda", "musztarda miodowa", "majonez", "przyprawa", "sos francuski" };
		string[] breads = { "chleb ryżowy", "chleb biały", "chleb zbożowy", "pumpernikiel", "chleb włoski", "bułka" };

		public string GetMenuItem()
		{
			string randomMeat = meats[randomizer.Next(meats.Length)];
			string randomCondiment = condiments[randomizer.Next(condiments.Length)];
			string randomBread = breads[0];

			return randomMeat + ", " + randomCondiment + ", " + randomBread;
		}

	}
}
