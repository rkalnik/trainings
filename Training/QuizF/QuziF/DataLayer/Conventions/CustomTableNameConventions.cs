using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataLayer.Conventions
{
	public class CustomTableNameConventions:Convention
	{
		public CustomTableNameConventions()
		{
			this.Types().Configure(t => t.ToTable($"MyCustom{t.ClrType.Name}Table"));
		}
	}
}
