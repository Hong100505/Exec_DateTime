using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5_列出指定年份的每一個星期日
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int year2 = 2022;

			var dt = new DateTime(year2, 01, 1);
			DayOfWeek weekday = dt.DayOfWeek;
			int value5 = (int)weekday;
			if (value5 == 0)
			{
				value5 = 0;
			}
			else
			{
				value5 = 7 - value5; //與禮拜天相差幾天
			}
			var dt2 = new DateTime(year2, 01, 1 + (value5)); //第一個禮拜天
			Console.WriteLine(dt2.ToString("yyyy/MM/dd")); 

			for (int i = 7; i < 365 - value5; i += 7)
			{
				dt2 = dt2.AddDays(7);
				Console.WriteLine(dt2.ToString("yyyy/MM/dd"));
			}
		}
	}
}
