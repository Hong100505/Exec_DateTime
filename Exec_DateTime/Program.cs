using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_DateTime
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DateTime today = DateTime.Today;
			string value1 = today.ToString();

			

			

			

			

			

			//Q6 根據日期, 傳回今天是本月的上旬, 中旬或下旬
			int day = today.Day;
			if(day <=10)
			{
				Console.WriteLine("上旬");
			}
			else if(day <=20)
			{
				Console.WriteLine("中旬");
			}
			else
			{
				Console.WriteLine("下旬");
			}

			//Q7 根據不同時間, 傳回不同問安方式

			DateTime now = DateTime.Now; 
			int hour = now.Hour;
			Console.WriteLine(hour);

			if(hour <=11 )
			{
				Console.WriteLine("早安");
			}
			else if(hour <=18)
			{
				Console.WriteLine("早安");
			}
			else 
			{
				Console.WriteLine("晚安");
			}


			 
		}
	}
}
