using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
	public class Configuration
	{
		public static int ImplicitlyWait
		{
			get { return int.Parse("10"); }
		}

		public static string Url = "http://executeautomation.com/demosite/Login.html";
		//public static string Url = "http://executeautomation.com/demosite/index.html?UserName=&Password=&Login=Login";

			//public static string Url
			//{
			//	get { return Url ; }
			//	set { Url = value ; }
			//}

		}
}
