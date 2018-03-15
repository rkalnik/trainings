using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsTraining
{
	public partial class _Default : Page
	{
		//protected override void OnInit(EventArgs e)
		//{
		//	base.OnInit(e);
		//}

		//protected override void OnLoad(EventArgs e)
		//{
		//	base.OnLoad(e);
		//}

		protected void Page_Load(object sender, EventArgs e)
		{
			CheckBox1.Checked = true;
		}
	}

}