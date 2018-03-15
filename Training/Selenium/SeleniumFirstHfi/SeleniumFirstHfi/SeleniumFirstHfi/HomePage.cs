using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SeleniumFirstHfi
{
	public class HomePage
	{
		public void CloseWelcomeMessage()
		{
			WebConfiguration.driver.FindElement(By.XPath("//button[text()='Close ✖']")).Click();
		}

		public LoginPage NavigateToLoginPage()
		{
			WebConfiguration.driver.FindElement(By.XPath("//nav/div[1]/ul/li[1]/a[text()='Log-in']")).Click();
			return new LoginPage();
		}

	}
}
