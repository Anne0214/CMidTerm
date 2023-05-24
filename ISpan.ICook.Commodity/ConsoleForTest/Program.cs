using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleForTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var date = new DateTime(1998, 1, 1).ToString("MMM", CultureInfo.GetCultureInfo("en-Us"));
            Console.WriteLine(date);
        }
    }
}
