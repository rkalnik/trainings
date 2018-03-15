using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SeleniumFirstHfi
{
	public class WebConfiguration
	{
		public static IWebDriver driver { get; set; }

		public static string Url = "http://hfi.athena05.global.root";
	}

	
}
