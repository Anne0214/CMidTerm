using ISpan2023.EStore.SqlDataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var parameters = new SqlParameterBuilder()
						.AddInt("id", 1)
						.AddInt("height", 2)
						.AddInt("Weight", 3)
						.AddDateTime("birthday", DateTime.Today)
						.AddNVarchar("firstName", 30, "Allen")
						.AddNVarchar("lastName", 30, "Kuo")
						.AddNVarchar("email", 100, "allen@gmail.com")
						.Build();

		}
	}
}
