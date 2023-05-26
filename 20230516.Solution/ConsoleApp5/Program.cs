using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] nums = { 1,4,2,6,22,17,89,88,90,22};
			foreach( var num in GetEvenItems2(nums))
			{
                Console.WriteLine(num);
            }
		}

		/// <summary>
		/// 傳回偶數
		/// </summary>
		/// <param name="numbers"></param>
		/// <returns></returns>
		static List<int> GetEvenItems(int[] numbers)
		{
			List<int> result = new List<int>();
			foreach (int num in numbers)
			{
				if(num %2 == 0)
				{
					result.Add(num);
				}
			}

			return result;
		}
		static IEnumerable<int> GetEvenItems2(int[] numbers)
		{
			foreach (int num in numbers)
			{
				if (num % 2 == 0)
				{
					yield return num;
				}
			}

			
		}
	}
}
