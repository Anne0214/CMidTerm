﻿using ISpan2023.EStore.SqlDataLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdFakeDataMaker
{
    public class LogRepository { 
        /// <summary>
        /// 用於創建log假資料
        /// </summary>
        /// <param name="minInterval">最短間隔多久會產生一次log</param>
        /// <param name="maxInterval">最長間隔多久會產生一次log</param>
        /// <returns></returns>
        public List<LogDto> CreateLogDto(int minInterval,int maxInterval)
        {
            //IP範圍[(1.160.0.0),(1.175.255.255)]，有100多萬個

            if (minInterval < 0 || maxInterval < 0) throw new ArgumentException("輸入的參數應大於0");
            if (minInterval > maxInterval) throw new ArgumentException("maxInterval參數不得小於minInterval參數");
        
            List<LogDto> fakeData = new List<LogDto>();
            //每個版面建立
            for (int i = 1; i <= 7; i++)
            {
                DateTime progress = DateTime.Now.AddDays(-14);
                while (progress < DateTime.Now)
                {
                    Random rd = new Random(Guid.NewGuid().GetHashCode()); //not allow repeated
                    Random rd2 = new Random(); //allow repeated
                    fakeData.Add(new LogDto()
                    {
                        AdSpacePk = i,
                        IP = "1." + rd.Next(160, 175+1).ToString() + "." + rd.Next(0, 255+1).ToString() + "." + rd.Next(0, 255+1).ToString(),
                        Time = progress
                    });
                    progress = progress.AddSeconds(rd.Next(minInterval, maxInterval));

                }
            }
            return fakeData;
        }

		public void CreateImpression(LogDto dto)
		{
			Func<SqlConnection> conn = SqlDb.GetConnection;
			string sql = @"Insert [AD_SPACE_IMPRESSION_LOG_廣告版面曝光紀錄] 
Values(@ad_space,@time,@ip) ";
			SqlParameter[] sp = new SqlParameterBuilder()
                                    .AddInt("@ad_space",dto.AdSpacePk)
                                    .AddDateTime("@time",dto.Time)
                                    .AddNVarchar("@ip",100,dto.IP)
									.Build();

			SqlDb2.CreateNoIdentityData(conn, sql, sp);
		}

		public void CreateClick(LogDto dto)
		{
			Func<SqlConnection> conn = SqlDb.GetConnection;
			string sql = @"Insert [AD_SPACE_CLICK_LOG_廣告版面點擊紀錄] 
Values(@ad_space,@time,@ip) ";
			SqlParameter[] sp = new SqlParameterBuilder()
									.AddInt("@ad_space", dto.AdSpacePk)
									.AddDateTime("@time", dto.Time)
									.AddNVarchar("@ip", 100, dto.IP)
									.Build();

			SqlDb2.CreateNoIdentityData(conn, sql, sp);
		}
	}
}
