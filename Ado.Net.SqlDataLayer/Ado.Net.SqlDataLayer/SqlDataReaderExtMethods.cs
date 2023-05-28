using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado.Net.SqlDataLayer
{
    public static class SqlDataReaderExtMethods
    {
        /// <summary>
		/// 取得一個SqlDataReader欄位值,並轉型為int,若為DbNull,則傳回0
		/// </summary>
		/// <param name="reader"></param>
		/// <param name="columnName"></param>
		/// <returns></returns>
		public static int GetInt(this SqlDataReader reader, string columnName)
        {
            try
            {
                int columnIndex = reader.GetOrdinal(columnName);
                if (reader.IsDBNull(columnIndex))
                {
                    return 0;
                }
                else
                {
                    return reader.GetInt32(columnIndex);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("讀取資料庫欄位值時發生錯誤: " + ex.Message);
            }

        }

        /// <summary>
        /// 取得一個SqlDataReader欄位值,並轉型為string,若為DbNull,則傳回null
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="columnName"></param>
        /// <returns></returns>
        public static string GetString(this SqlDataReader reader, string columnName)
        {
            try
            {
                int columnIndex = reader.GetOrdinal(columnName);
                if (reader.IsDBNull(columnIndex))
                {
                    return null;
                }
                else
                {
                    return reader.GetString(columnIndex);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("讀取資料庫欄位值時發生錯誤: " + ex.Message);
            }
        }

        public static DateTime GetDateTime(this SqlDataReader reader, string columnName)
        {
            try
            {
                int columnIndex = reader.GetOrdinal(columnName);
                if (reader.IsDBNull(columnIndex))
                {
                    return DateTime.MinValue;
                }
                else
                {
                    return reader.GetDateTime(columnIndex);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("讀取資料庫欄位值時發生錯誤: " + ex.Message);
            }
        }
    }
}
