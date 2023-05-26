using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// IMemberRepository repo = new MemberRepository();
			IMemberRepository repo = new DapperMemberRepo();
			
			var service = new MemberService(repo);
			service.Delete(1);
		}
	}

	public class MemberService {

		private IMemberRepository _repo;
		public MemberService(IMemberRepository repo)
		{
			this._repo = repo;
		}

		public void Delete(int id) {
			// MemberRepository _repo = new MemberRepository();
			_repo.Delete(id);
		}
	}

	public interface IMemberRepository
	{
		void Delete(int id);
	}

	public class MemberRepository:IMemberRepository {
		public void Delete(int id) { }
	}

	public class DapperMemberRepo :IMemberRepository
	{
		public void Delete(int id)
		{
			//我這裡改用Dapper 套件來達到刪記錄的功能
		}
	}
}
