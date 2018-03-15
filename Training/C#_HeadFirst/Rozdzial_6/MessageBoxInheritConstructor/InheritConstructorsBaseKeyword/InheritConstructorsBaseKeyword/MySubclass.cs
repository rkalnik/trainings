using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InheritConstructorsBaseKeyword
{
	public class MySubclass : MyBaseClass
	{
		public MySubclass(string baseClassNeedsthis, int anotherValue) : base(baseClassNeedsthis)
		{
			MessageBox.Show("To jest klasa pochodna " + baseClassNeedsthis + " i " + anotherValue);
		}
	}
}
