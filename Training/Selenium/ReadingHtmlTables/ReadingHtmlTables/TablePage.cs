using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ReadingHtmlTables
{
	class TablePage : Base
	{
		public TablePage()
		{
			PageFactory.InitElements(driver.SwitchTo().Frame(0), this);
		}

		[FindsBy(How = How.XPath, Using = "//table/tbody")]
		public IWebElement table { get; set; }

	}
}
