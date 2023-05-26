using ISpan2023.EStore.SqlDataLayer.ExtMethods;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan2023.EStore.SqlDataLayer.Dtos
{
	public static class Assembler
	{
		public static Func<SqlDataReader, CategoryDto> CategoryDtoAssembler
		{
			get {
				
				Func<SqlDataReader, CategoryDto> func = (reader) =>
				{
					int id = reader.GetInt("id");
					string name = reader.GetString("name");
					int displayOrder = reader.GetInt("displayOrder");

					return new CategoryDto
					{
						Id = id,
						Name = name,
						DisplayOrder = displayOrder
					};
				};

				return func;
			}
		}
	}
}
