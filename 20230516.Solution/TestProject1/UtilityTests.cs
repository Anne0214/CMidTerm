using ConsoleApp7;

namespace TestProject1
{
	public class UtilityTests
	{
		[SetUp]
		public void Setup()
		{
		}


		[Test]
		public void IsTaiwanStocksWorkingDay_若是假日_傳回false()
		{
			var today = new DateTime(2023, 5, 21, 10, 0, 0);
			
			bool actual = Utility.IsTaiwanStocksWorkingDay(today);

			Assert.IsFalse(actual);
		}

		[TestCase("2023/5/22 8:59:59")]
		[TestCase("2023/5/22 13:30:01")]
		public void IsTaiwanStocksWorkingDay_若是平日但非交易時間_傳回false(DateTime dt)
		{
			//var today = new DateTime(2023, 5, 22, 8, 59, 59);

			bool actual = Utility.IsTaiwanStocksWorkingDay(dt);

			Assert.IsFalse(actual);
		}

		[TestCase("2023/5/22 9:00:00")]
		[TestCase("2023/5/22 13:30:00")]
		public void IsTaiwanStocksWorkingDay_若是平日且交易時間_傳回true(DateTime dt)
		{
			//var today = new DateTime(2023, 5, 22, 8, 59, 59);

			bool actual = Utility.IsTaiwanStocksWorkingDay(dt);

			Assert.IsTrue(actual);
		}
	}
}