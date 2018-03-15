using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClass
{
	class Report
	{
		private string name;
		private string date;

		public string Name
		{
			get
			{
				return name;
			}

			set
			{
				name = value;
			}
		}

		public string Date
		{
			get
			{
				return date;
			}

			set
			{
				if(value == "July")
				{
					date = value;
				}
			}
		}

		public string Type { get; set; }

	}
}
