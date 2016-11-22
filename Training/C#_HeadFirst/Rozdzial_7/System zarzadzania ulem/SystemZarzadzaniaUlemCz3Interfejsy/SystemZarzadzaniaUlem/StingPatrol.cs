﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemZarzadzaniaUlem
{
	class StingPatrol : Worker
	{
		public StingPatrol(string[] jobsICanDo, double weightMg) : base(jobsICanDo, weightMg)
		{
		}

		public int AlertLevel { get; private set; }
		public int StingerLength { get; set; }

		public bool SharpenStinger(int Lenght)
		{
			return false;
		}

		public bool LookForEnemies()
		{
			return false;
		}

		public void Sting(string Enemy)
		{

		}
	}
}
