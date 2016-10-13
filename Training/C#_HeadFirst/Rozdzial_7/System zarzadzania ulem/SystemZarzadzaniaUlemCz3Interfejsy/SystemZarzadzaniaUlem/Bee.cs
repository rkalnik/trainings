using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemZarzadzaniaUlem
{
	public class Bee
	{
		public const double HoneyUnitsConsumedPerMg = .25;
		public double WeightMg { get; private set; }
		public Bee(double weightMg)
		{
			this.WeightMg = weightMg;
		}
		public virtual double HoneyConsumptionRate()
		{
			return WeightMg * HoneyUnitsConsumedPerMg;
		}
	}
}
