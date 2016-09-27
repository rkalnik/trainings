﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanistaPrzyjecPoprawiony
{
	class DinnerParty : Party
	{
		
		public bool HealthyOption { get; set; }
		
		public DinnerParty(int numberOfPeople, bool healthyOption, bool fancyDecorations)
		{
			this.NumberOfPeople = numberOfPeople;
			this.HealthyOption = healthyOption;
			this.FancyDecorations = fancyDecorations;
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

		override public decimal Cost
		{
			get
			{
				decimal totalCost = base.Cost;
				totalCost += ((CalculateCostOfBeveragesPerPerson() + costOfFoodPerPerson) * NumberOfPeople);
				
				if (HealthyOption)
				{
					totalCost *= .95M;
				}
				return totalCost;
			}
		}

	}
}
