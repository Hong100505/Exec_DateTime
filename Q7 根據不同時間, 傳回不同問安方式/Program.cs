using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7_根據不同時間__傳回不同問安方式
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DateTime now = DateTime.Now;
			int hour = now.Hour;
			

			if (hour <= 11)
			{
				Console.WriteLine("早安");
			}
			else if (hour <= 18)
			{
				Console.WriteLine("午安");
			}
			else
			{
				Console.WriteLine("晚安");
			}
		}
	}
}
