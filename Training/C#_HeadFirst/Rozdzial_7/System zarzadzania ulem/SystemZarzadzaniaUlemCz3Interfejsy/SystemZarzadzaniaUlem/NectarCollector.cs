using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemZarzadzaniaUlem
{
	class NectarCollector : Worker
	{
		public NectarCollector(string[] jobsICanDo, double weightMg) : base(jobsICanDo, weightMg)
		{
		}

		public int Nectar { get; set; }
		public void FindFlowers()
		{

		}

		public void GatherNectar()
		{

		}

		public void ReturnToHive()
		{

		}
	}
}
