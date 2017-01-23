﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumFirst
{
	class LoginPageObject
	{
		public LoginPageObject()
		{
			PageFactory.InitElements(PropertiesCollection.driver, this);
		}

		[FindsBy(How = How.Name, Using = "UserName")]

		public IWebElement txtUserName { get; set; }

		[FindsBy(How = How.Name, Using = "Password")]

		public IWebElement txtPassword { get; set; }

		[FindsBy(How = How.Name, Using = "Login")]

		public IWebElement btnLogin { get; set; }


		public EAPageObject Login(string userName, string password)
		{
			//UserNAme
			txtUserName.EnterText(userName);
			//txtUserName.SendKeys(userName);
			
			//password
			txtPassword.EnterText(password);
			//txtPassword.SendKeys(password);

			//Click button login
			btnLogin.Clicks();
			//btnLogin.Submit();

			return new EAPageObject();
		}

	}
}
