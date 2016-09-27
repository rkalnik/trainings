using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanistaPrzyjec
{
	//static class Test
	//{
	//	static public void TestMethod1()
	//	{

	//	}
	//}

	public class DinnerParty
	{
	
		public const int costOfFoodPerPerson = 25;
		public int numberOfPeople;
		public decimal costOfBeveragesPerPerson;
		public decimal costOfDecorations = 0;

		//static public void TestMethod1()
		//{

		//}

		//DinnerParty dinner = new DinnerParty() { numberOfPeople = 8 };

		public void SetHealthyOption(bool healthyOption)
		{
			if (healthyOption)
			{
				//przypisanie do zmiennej wartosci z M spowoduje wyswitlenie waluty w postaci np.: zł w zaleznosci od ustwionego jezyka M=Money
				costOfBeveragesPerPerson = 5.00M;
			}
			else
			{
				costOfBeveragesPerPerson = 20.00M;
			}
		}

		public void CalculateCostOfDecorations(bool fancy)
		{
			//if(fancy) jest równoznaczne z if(fancy==true), poniewaz instrukcja if zawsze sprawdza, czy warunek jest prawdziwy.
			if (fancy)
			{
				costOfDecorations = (numberOfPeople * 15.00M) + 50M;
			}
			else
			{
				costOfDecorations = (numberOfPeople * 7.50M) + 30M;
			}
		}

		public decimal CalculateCost(bool healthyOption)
		{
			decimal totalCost = costOfDecorations + ((costOfBeveragesPerPerson + costOfFoodPerPerson) * numberOfPeople);

			if (healthyOption)
			{
				return totalCost * .95M;
			}
			else
			{
				return totalCost;
			}
		}

	}
}
