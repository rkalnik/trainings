using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Conventions
{
	public class CustomTableNameConvention : Convention
	{
		public CustomTableNameConvention()
		{
			this.Types().Configure(t => t.ToTable(GetTableName(t.ClrType.Name)));
		}

		private string GetTableName(string className)
		{
			return className.EndsWith("s") ? $"Ultimate{className}es" : $"Ultimate{className}s";
		}
	}
}
