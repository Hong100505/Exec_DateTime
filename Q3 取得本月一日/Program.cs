using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3_取得本月一日
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DateTime today = DateTime.Today;
			string value1 = today.ToString();


			value1 = today.ToString("yyyy/MM/01");
			Console.WriteLine(value1);
		}
	}
}
