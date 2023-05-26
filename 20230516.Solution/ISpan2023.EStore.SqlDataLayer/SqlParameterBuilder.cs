using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan2023.EStore.SqlDataLayer
{
	public class SqlParameterBuilder
	{
		private List<SqlParameter> _parameters = new List<SqlParameter>();
		

		public SqlParameterBuilder AddInt(string parameterName, int value)
		{
			var parameter = new SqlParameter(parameterName, System.Data.SqlDbType.Int) { Value = value };
			_parameters.Add(parameter);

			return this;
		}

		public SqlParameterBuilder AddIntOut(string parameterName)
		{
			var parameter = new SqlParameter(parameterName, System.Data.SqlDbType.Int) { Direction = ParameterDirection.Output };
			_parameters.Add(parameter);

			return this;
		}

		public SqlParameterBuilder AddNullableInt(string parameterName, int? value)
		{
			var parameter = new SqlParameter(parameterName, System.Data.SqlDbType.Int);

			if (value.HasValue)
			{
				parameter.Value = value.Value;
			}
			else
			{
				parameter.Value = DBNull.Value;
			}

			_parameters.Add(parameter);

			return this;
		}

		public SqlParameterBuilder AddDateTime(string parameterName, DateTime value)
		{
			var parameter = new SqlParameter(parameterName, 
									System.Data.SqlDbType.DateTime) { Value = value };
			_parameters.Add(parameter);

			return this;
		}

		public SqlParameterBuilder AddNVarchar(string parameterName,int length, string value)
		{
			var parameter = new SqlParameter(parameterName,
									System.Data.SqlDbType.NVarChar,length )
			{ Value = value };

			_parameters.Add(parameter);

			return this;
		}

		public SqlParameter[] Build()
		{
			return _parameters.ToArray();
		}
	}
}
