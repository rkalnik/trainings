﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InheritConstructorsBaseKeyword
{
	public class MyBaseClass
	{
		public MyBaseClass(string baseClassNeedsThis)
		{
			MessageBox.Show("To jest klasa bazowa ", baseClassNeedsThis);
		}

	}
}
