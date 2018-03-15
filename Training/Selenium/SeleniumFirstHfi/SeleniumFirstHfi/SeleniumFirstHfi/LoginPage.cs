using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SeleniumFirstHfi
{
	public class LoginPage
	{
		private string EmailField { get { return "//input[contains(@type, 'email')]"; } }
		private string PasswordField { get { return "//input[contains(@type, 'password')]"; } }

		public HomePage LoginSuccessfully(string username, string password)
		{
			WebConfiguration.driver.FindElement(By.XPath(EmailField)).SendKeys(username);
			WebConfiguration.driver.FindElement(By.XPath(PasswordField)).SendKeys(password);

			return new HomePage();
		}


	}
}
