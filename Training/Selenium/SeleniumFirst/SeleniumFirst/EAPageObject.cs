﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumFirst
{
	class EAPageObject
	{
		public EAPageObject()
		{
			PageFactory.InitElements(PropertiesCollection.driver, this);
		}


		[FindsBy(How = How.Id, Using = "TitleId")]
		
		public IWebElement	ddlTitleID { get; set; }
		

		[FindsBy(How = How.Name, Using = "Initial")]

		public IWebElement txtInitial { get; set; }


		[FindsBy(How = How.Name, Using = "FirstName")]

		public IWebElement txtFirstName { get; set; }


		[FindsBy(How = How.Name, Using = "MiddleName")]

		public IWebElement txtMiddleName { get; set; }


		[FindsBy(How = How.Name, Using = "Save")]

		public IWebElement btnSave { get; set; }


		public void FillUserForm(string initial, string middleName, string fisrtName)
		{
			txtInitial.EnterText(initial);
			txtFirstName.EnterText(fisrtName);
			txtMiddleName.EnterText(middleName);
			btnSave.Clicks();

			//SeleniumSetMethods.EnterText(txtInitial, initial);
			//SeleniumSetMethods.EnterText(txtFirstName, fisrtName);
			//SeleniumSetMethods.EnterText(txtMiddleName, middleName);
			//SeleniumSetMethods.Click(btnSave);


			//txtInitial.SendKeys(initial);
			//txtFirstName.SendKeys(fisrtName);
			//txtMiddleName.SendKeys(middleName);
			//btnSave.Click();
		}

	}
}