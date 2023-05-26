using ConsoleApp9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject2
{
	public class UtilityTests
	{

		[Test]
		public void IsTaiwanStocksWorkingDay_是假日_傳回false() {
			var today = new DateTime(2023, 5, 21);

			bool actual = Utility.IsTaiwanStocksWorkingDay(today);

			Assert.IsFalse(actual);
		}

		[TestCase("2023/5/22 8:59:59")]
		[TestCase("2023/5/22 13:30:01")]
		public void IsTaiwanStocksWorkingDay_非假日但非交易時間_傳回false(DateTime dt)
		{
			bool actual = Utility.IsTaiwanStocksWorkingDay(dt);

			Assert.IsFalse(actual);
		}

		[TestCase("2023/5/22 9:00:00")]
		[TestCase("2023/5/22 13:30:00")]
		public void IsTaiwanStocksWorkingDay_平日且交易時間_傳回true(DateTime dt)
		{
			bool actual = Utility.IsTaiwanStocksWorkingDay(dt);

			Assert.IsTrue(actual);
		}
	}
}
