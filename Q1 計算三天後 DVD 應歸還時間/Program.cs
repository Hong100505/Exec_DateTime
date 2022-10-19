using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1_計算三天後_DVD_應歸還時間
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DateTime today = DateTime.Today;
			string value1 = today.ToString();

			
			DateTime deadlinedays = today.AddDays(3);
			Console.WriteLine("三天後歸回期限" + deadlinedays);
		}
	}
}
