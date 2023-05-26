using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//2020年2月,一共有幾天
			int days = DateTime.DaysInMonth(2020, 2);

			// 本月的一日是哪一天
			DateTime today = DateTime.Today;
			DateTime firstDay = new DateTime(today.Year, today.Month, 1);

			// 本月的最後一日是哪一天
			DateTime lastDay = firstDay.AddMonths(1).AddDays(-1);

			TimeSpan ts9 = TimeSpan.FromHours(9);
			DateTime dt2 = today.AddHours(9);

		}
	}
}
