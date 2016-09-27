﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanistaPrzyjecPoprawiony
{
	class BirthdayParty
	{
		public const int CostOfFoodPerPerson = 25;
		public int NumberOfPeople { get; set; }
		public bool FancyDecorations { get; set; }
		public string CakeWriting { get; set; }

		public BirthdayParty(int numberOfPeople, bool fancyDecorations, string cakeWriting)
		{
			this.NumberOfPeople = numberOfPeople;
			this.FancyDecorations = fancyDecorations;
			this.CakeWriting = cakeWriting;
		}

		private int ActualLenght
		{
			get
			{
				if (CakeWriting.Length > MaxWritingLenght())
					return CakeWriting.Length;
				else
					return CakeWriting.Length;
			}
		}

		public int CakeSize()
		{
			if (NumberOfPeople <= 4)
				return 20;
			else
				return 40;
		} 
		
		private int MaxWritingLenght()
		{
			if (CakeSize() == 8)
				return 16;
			else
				return 40;
		}

		public bool CakeWritingTooLong
		{
			get
			{
				if (CakeWriting.Length > MaxWritingLenght())
					return true;
				else
					return false;
			}
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

		public decimal Cost
		{
			get
			{
				decimal totalCost = CalculateCostOfDecorations();
				totalCost += CostOfFoodPerPerson * NumberOfPeople;

				if (NumberOfPeople > 12)
					return totalCost + 100M; 
				else
					return totalCost;


				decimal cakeCost;
				if (CakeSize() == 20)
					cakeCost = 40M + ActualLenght * .25M;
				else
					cakeCost = 75M + ActualLenght * .25M;
				return totalCost + cakeCost;
			}
		}

	}
}
