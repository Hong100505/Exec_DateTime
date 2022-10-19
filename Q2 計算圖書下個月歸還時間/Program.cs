using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2_計算圖書下個月歸還時間
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DateTime today = DateTime.Today;
			string value1 = today.ToString();

			DateTime deadlineMonth = today.AddMonths(1);
			Console.WriteLine("下個月歸還時間" + deadlineMonth);
		}
	}
}
