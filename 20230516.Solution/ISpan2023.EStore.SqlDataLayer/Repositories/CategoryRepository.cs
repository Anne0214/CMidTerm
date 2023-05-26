using ISpan2023.EStore.SqlDataLayer.Dtos;
using ISpan2023.EStore.SqlDataLayer.ExtMethods;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ISpan2023.EStore.SqlDataLayer.Repositories
{
    public class CategoryRepository
    {
        /// <summary>
        /// 取得一筆商品分類記錄
        /// </summary>
        /// <param name="categoryId">商品分類編號</param>
        /// <returns></returns>
        public CategoryDto Get(int categoryId)
        {
            string sql = $"SELECT * FROM Categories WHERE Id={categoryId}";
            Func<SqlDataReader, CategoryDto> func = Assembler.CategoryDtoAssembler;
            SqlParameter[] parameters = new SqlParameter[0];
            Func<SqlConnection> connGetter = SqlDb.GetConnection;

            return SqlDb.Get(connGetter, sql, func);
            
        }
        
        public CategoryDto GetByName(string name) {
			string sql = $"SELECT * FROM Categories WHERE Name=@Name";
			Func<SqlDataReader, CategoryDto> func = Assembler.CategoryDtoAssembler;
			
            SqlParameter parameter = new SqlParameter("@Name", SqlDbType.NVarChar, 30) { Value=name};

			Func<SqlConnection> connGetter = SqlDb.GetConnection;

			return SqlDb.Get(connGetter, sql, func, parameter);
		}

        public List<CategoryDto> Search(int? categoryId, string s_name)
        {
			#region sql and SqlParameter[]
			string sql = $"SELECT * FROM Categories";

            #region 建立條件式
            var builder = new SqlParameterBuilder();

            string where = string.Empty;
            if (categoryId.HasValue)
            {
                where += $" AND Id=@Id";
                builder.AddInt("@Id", categoryId.Value);
            }

            if (string.IsNullOrEmpty(s_name) == false)
            {
                where += $" AND Name LIKE '%' + @Name + '%'";
                builder.AddNVarchar("@Name", 30, s_name);
            }

            if (string.IsNullOrEmpty(where) == false)
            {
                where = " WHERE " + where.Substring(5);
                sql += where;
            }

            var parameters = builder.Build().ToArray(); 
            #endregion

            sql += " ORDER BY DisplayOrder";
			#endregion
			Func<SqlConnection> connGetter = SqlDb.GetConnection;
			Func<SqlDataReader, CategoryDto> func = Assembler.CategoryDtoAssembler;

            return SqlDb.Search(connGetter, sql, func, parameters).ToList();

        }

        /// <summary>
        /// 更新 Categories table記錄
        /// </summary>
        /// <param name="dto"></param>
        /// <returns>傳回被異動總筆數</returns>
        public int Update(CategoryDto dto)
        {
            string sql = "UPDATE Categories SET Name=@Name, DisplayOrder = @DisplayOrder WHERE Id=@Id";

            var parameters = new SqlParameterBuilder()
                .AddInt("@Id", dto.Id)
                .AddNVarchar("@Name", 30, dto.Name)
                .AddInt("@DisplayOrder", dto.DisplayOrder)
                .Build();
            Func<SqlConnection> connGetter = SqlDb.GetConnection;

            return SqlDb.UpdateOrDelete(connGetter, sql, parameters);

        }

        public int Create(CategoryDto dto)
        {
            string sql = @"INSERT INTO Categories
(Name, DisplayOrder)
VALUES
(@Name, @DisplayOrder)"; 

            var parameters = new SqlParameterBuilder()
				.AddNVarchar("@Name", 30, dto.Name)
				.AddInt("@DisplayOrder", dto.DisplayOrder)
				.Build();

            return SqlDb.Create(SqlDb.GetConnection, sql, parameters);

		}

        public int Delete(int categoryId)
        {
            string sql = "DELETE FROM Categories WHERE Id=@Id";

            SqlParameter parameter = new SqlParameter("@Id", SqlDbType.Int) { Value = categoryId };
			Func<SqlConnection> connGetter = SqlDb.GetConnection;

            return SqlDb.UpdateOrDelete(connGetter, sql, parameter);

        }
    }
}
