using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string value = "xxx";
			value = "abc\" fd";

			value = "line 1\r\nline2";

			value = @"SELECT *
FROM Categories
INNER JOIN Products ON Categories.Id=Products.CategoryId
WHERE Id=5
";
            Console.WriteLine(value);

        }
	}
}
