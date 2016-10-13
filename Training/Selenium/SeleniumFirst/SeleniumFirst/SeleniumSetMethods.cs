using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumFirst
{
	class SeleniumSetMethods
	{
		/// <summary>
		/// Extended method for entering text in control
		/// </summary>
		public static void EnterText(IWebElement element, string value)
		{

			element.SendKeys(value);

			//if (elementType == PropertyType.Id)
			//	driver.FindElement(By.Id(element)).SendKeys(value);
			//if (elementType == PropertyType.Name)
			//	driver.FindElement(By.Name(element)).SendKeys(value);
		}


		/// <summary>
		////Click into a button, checkbox, option etc.
		/// </summary>
		/// <param name="element"></param>
		public static void Click(IWebElement element)
		{
			element.Click();
			
			//if (elementType == PropertyType.Id)
			//	driver.FindElement(By.Id(element)).Click();
			//if (elementType == PropertyType.Name)
			//	driver.FindElement(By.Name(element)).Click();
		}


		/// <summary>
		/// Selecting a drop down control
		/// </summary>
		public static void SelectDropDown(IWebElement element, string value)
		{
			//if (elementType == PropertyType.Id)
			//	new SelectElement(driver.FindElement(By.Id(element))).SelectByText(value);
			//if (elementType == PropertyType.Name)
			//	driver.FindElement(By.Name(element)).Click();
			//new SelectElement(driver.FindElement(By.Id(element))).SelectByText(value);

			new SelectElement(element).SelectByText(value);
		}

	}
}
