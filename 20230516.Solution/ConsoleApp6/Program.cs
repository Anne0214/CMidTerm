using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string value = "22";
			(bool isSuccess, string errorMessage) result = Validate(value);

            Console.WriteLine(result.isSuccess);
            Console.WriteLine(result.errorMessage);
        }

		/// <summary>
		/// 驗證是否為正整數
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		static (bool , string ) Validate(string value)
		{
			if(string.IsNullOrEmpty(value)) { return (false, "不能是null"); }

			bool isInt = int.TryParse(value, out int num);
			if(isInt == false ) { return (false, "必需是整數"); }

			if(num <= 0) { return (false, "必需是正整數"); }

			return (true, string.Empty);
		}
	}
}
