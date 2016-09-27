using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirdsInherit
{
	class Penguin : Bird
	{

		public void Swim()
		{

		}

		public override void Fly()
		{
			MessageBox.Show("Pingwiny nie potrafią latać");
			base.Fly();
		}
	}
}
