﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SeleniumFirst
{
	public enum PropertyType
	{
		Id,
		Name,
		LinkText,
		CssName,
		ClassName
	}

	public class PropertiesCollection
	{
		//Auto-implement property

		public static IWebDriver driver { get; set; }
	}
}
