using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanistaPrzyjecPoprawiony
{
	class Party
	{
		public const int costOfFoodPerPerson = 25;
		public int NumberOfPeople { get; set; }
		public bool FancyDecorations { get; set; }


		private decimal CalculateCostOfDecorations()
		{
			decimal costOfDecorations;
			if (FancyDecorations)
			{
				costOfDecorations = (NumberOfPeople * 15.00M) + 50M;
			}
			else
			{
				costOfDecorations = (NumberOfPeople * 7.50M) + 30M;
			}
			return costOfDecorations;
		}

		virtual public decimal Cost
		{
			get
			{
				decimal totalCost = CalculateCostOfDecorations();
				totalCost += costOfFoodPerPerson * NumberOfPeople;

				if (NumberOfPeople > 12)
					return totalCost + 100M;
				else
					return totalCost;

			}
		}
	}
}
