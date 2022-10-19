using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6_根據日期__傳回今天是本月的上旬__中旬或下旬
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DateTime today = DateTime.Today;
			
			

			int day = today.Day;
			if (day <= 10)
			{
				Console.WriteLine(today.ToString("yyyy/MM/dd") + "是上旬");
			}
			else if (day <= 20)
			{
				Console.WriteLine(today.ToString("yyyy/MM/dd") + "是中旬");
			}
			else
			{
				Console.WriteLine(today.ToString("yyyy/MM/dd") + "是下旬");
			}

		}
	}
}
