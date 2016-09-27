using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanistaPrzyjecPoprawiony
{
	class DinnerParty
	{
		public const int costOfFoodPerPerson = 25;
		public int NumberOfPeople { get; set; }
		public bool FancyDecorations { get; set; }
		public bool HealthyOption { get; set; }
		//public decimal Cost { get; set; }


		public DinnerParty(int numberOfPeople, bool healthyOption, bool fancyDecorations)
		{
			this.NumberOfPeople = numberOfPeople;
			this.HealthyOption = healthyOption;
			this.FancyDecorations = fancyDecorations;
		}


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

		private decimal CalculateCostOfBeveragesPerPerson()
		{
			decimal costOfBeveragesPerPerson;

			if (HealthyOption)
			{
				costOfBeveragesPerPerson = 5.00M;
			}
			else
			{
				costOfBeveragesPerPerson = 20.00M;
			}
			return costOfBeveragesPerPerson;
		}

		public decimal Cost
		{
			get
			{
				decimal totalCost = CalculateCostOfDecorations();
				totalCost += ((CalculateCostOfBeveragesPerPerson() + costOfFoodPerPerson) * NumberOfPeople);

				if (NumberOfPeople > 12)
					return totalCost + 100M;
				else
					return totalCost;

				if (HealthyOption)
				{
					totalCost *= .95M;
				}
				return totalCost;
			}
		}

	}
}
