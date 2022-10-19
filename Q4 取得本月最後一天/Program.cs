using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4_取得本月最後一天
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DateTime today = DateTime.Today;
			string value1 = today.ToString();

			int year = today.Year;
			int month = today.Month;
			DateTime value2 = new DateTime(year, month, 01);
			var addMonth = value2.AddMonths(1);
			var lastday = addMonth.AddDays(-1);
			Console.WriteLine(lastday.ToString ("yyyy//MM//dd"));
		}
	}
}
