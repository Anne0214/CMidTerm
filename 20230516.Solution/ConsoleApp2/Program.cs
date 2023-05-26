using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	internal class Program
	{
		static void Main(string[] args)
		{
		}
	}

	class Member
	{
		private readonly string name;
		private readonly string email;
		private readonly bool gender;

		public Member(string name, string email, bool gender)
        {
			this.name = name;
			this.email = email;
			this.gender = gender;
		}

		public Member(string name, string email):this(name,email,false)
		{}


	}
}
