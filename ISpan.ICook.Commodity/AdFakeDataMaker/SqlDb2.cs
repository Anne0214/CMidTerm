using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdFakeDataMaker
{
	public class SqlDb2
	{
		public static void CreateNoIdentityData(Func<SqlConnection> connGetter, string sql, params SqlParameter[] parameters)
		{
			using (var conn = connGetter())
			{
				conn.Open();

				using (SqlCommand cmd = conn.CreateCommand())
				{
					cmd.CommandText = sql;
					if (parameters.Length > 0)
					{
						cmd.Parameters.AddRange(parameters);
					}
					cmd.ExecuteNonQuery();

				}


			}

		}
	}
}
