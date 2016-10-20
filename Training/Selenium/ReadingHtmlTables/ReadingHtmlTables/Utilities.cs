using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace ReadingHtmlTables
{
	public class Utilities
	{

		static List<TableDatacollection> _tableDatacollection = new List<TableDatacollection>();

		public static void ReadTable(IWebElement table)
		{
			//Get all the rows
			var rows = table.FindElements(By.TagName("tr"));

			//Get all columns from the table
			var columns = table.FindElements(By.TagName("th"));
					

			//Create row index
			int rowIndex = 0;

			foreach (var row in rows)
			{
				int colIndex = 0;

				var colData = row.FindElements(By.TagName("td"));

				foreach(var colValue in colData)
				{
					_tableDatacollection.Add(new TableDatacollection()
					{
						RowNumber = rowIndex,
						ColumnName = columns[colIndex].Text,
						ColumnValue = colValue.Text
					});

					//Move to next column
					colIndex++;
				}
				rowIndex++;
			}

		}

		public static string ReadCell(string columnName, int rowNumber)
		{
			var data = (from e in _tableDatacollection
						where e.ColumnName == columnName && e.RowNumber == rowNumber
						select e.ColumnValue).SingleOrDefault();

			return data;
		}

	}

	public class TableDatacollection
	{
		public int RowNumber { get; set; }
		public string ColumnName { get; set; }
		public string ColumnValue { get; set; }
	}

}
