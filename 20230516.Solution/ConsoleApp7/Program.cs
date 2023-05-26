using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
	internal class Program
	{
		static void Main(string[] args)
		{
		}
	}

	public static class Utility
	{
		public static bool IsTaiwanStocksWorkingDay(DateTime today)
			=> today.BetweenDayOfWeek(1, 5) && today.BetweenHours(9, 13.5);			
		

		
	}
	public static class DateTimeExts
	{
		public static bool BetweenDayOfWeek(this DateTime value, int start, int end)
		{
			int weekday = (int)value.DayOfWeek;
			return weekday>= start && weekday <= end;
		}

		public static bool BetweenHours(this DateTime value, double startHour, double endHour)
		{
			DateTime start = value.Date.AddHours(startHour); // 找出value 那一天的早上九點
			DateTime end = value.Date.AddHours(endHour); // 找出value 那一天的13.5點

			return value>= start && value<= end;

		}
	}
}
