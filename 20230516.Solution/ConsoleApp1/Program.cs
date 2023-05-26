using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var allen = new Member();
            allen.Name = "Allen";
            allen.Email = "allen@gmail.com";

            string title = "A";
            string sql = "SELECT * FROM News WHERE Title = '" + title + "'";
        }
    }
    class Member
    {
        public string Name; // Field,欄位

        private string _Email;
        
        // property,屬性
        public string Email
        {
            get { return _Email; }
            set {
                if (value!= null && value.Length > 5) throw new Exception("不可以超過五個字");

                _Email = value;
            }
        }

        public DateTime DateOfBirth { get; set; }

        public int Age
        {
            get
            {
                return DateTime.Today.Year - this.DateOfBirth.Year;
            }
        }


    }
}
