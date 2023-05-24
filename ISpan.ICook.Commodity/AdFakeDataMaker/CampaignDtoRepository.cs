using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISpan2023.EStore.SqlDataLayer;

namespace AdFakeDataMaker
{
    internal class CampaignDtoRepository
    {
        public int Create(CampaignDto dto)
        {
            Func<SqlConnection> conn = SqlDb.GetConnection;
            string sql = @"Insert [CAMPAIGN_廣告活動]
                            Values(@cp_pk,@cp_name,@url,@ad_img,@ad_space,@start_time,@end_time) ";
            SqlParameter[] sp = new SqlParameterBuilder()
                                    .AddNVarchar("@cp_pk", 20, dto.CampaignPk)
                                    .AddNVarchar("@cp_name", 100, dto.CampaignName)
                                    .AddNVarchar("@url", 100, dto.URL)
                                    .AddNVarchar("@ad_img", 100, dto.AdImg)
                                    .AddInt("@ad_space", dto.AdSpacePk)
                                    .AddDateTime("@start_time", dto.StartTime)
                                    .AddDateTime("@end_time", dto.EndTime)
                                    .Build();

            return SqlDb.Create(conn, sql, sp);
        }
        public List<CampaignDto> BuildFakeData()
        {

            #region 名稱與日期組合

            int month = 1;
            List<NameAndDate> AllNameAndDate = new List<NameAndDate>()
            {new NameAndDate(){ CName="元旦推薦菜單",S_Time=new DateTime(DateTime.Now.Year,month,1),E_Time=new DateTime(DateTime.Now.Year,month,3)},
                new NameAndDate(){ CName="年貨推薦",S_Time=new DateTime(DateTime.Now.Year,month,4),E_Time=new DateTime(DateTime.Now.Year,month,10)},
                new NameAndDate(){ CName="除夕年菜套組",S_Time=new DateTime(DateTime.Now.Year,month,16),E_Time=new DateTime(DateTime.Now.Year,month,20)},
            };

            month = 2;
            AllNameAndDate.Add(new NameAndDate() { CName = "情人節推薦菜單", S_Time = new DateTime(DateTime.Now.Year, month, 1), E_Time = new DateTime(DateTime.Now.Year, month, 3) });
            AllNameAndDate.Add(new NameAndDate() { CName = "228連假推薦菜單", S_Time = new DateTime(DateTime.Now.Year, month, 4), E_Time = new DateTime(DateTime.Now.Year, month, 10) });
            AllNameAndDate.Add(new NameAndDate() { CName = "2月家電促銷", S_Time = new DateTime(DateTime.Now.Year, month, 16), E_Time = new DateTime(DateTime.Now.Year, month, 20) });

            month = 3;
            AllNameAndDate.Add(new NameAndDate() { CName = "郊遊便當菜單推薦", S_Time = new DateTime(DateTime.Now.Year, month, 1), E_Time = new DateTime(DateTime.Now.Year, month, 3) });
            AllNameAndDate.Add(new NameAndDate() { CName = "婦女節鍋具促銷", S_Time = new DateTime(DateTime.Now.Year, month, 4), E_Time = new DateTime(DateTime.Now.Year, month, 10) });
            AllNameAndDate.Add(new NameAndDate() { CName = "婦女節家電促銷", S_Time = new DateTime(DateTime.Now.Year, month, 16), E_Time = new DateTime(DateTime.Now.Year, month, 20) });
            AllNameAndDate.Add(new NameAndDate() { CName = "婦女節餐廚促銷", S_Time = new DateTime(DateTime.Now.Year, month, 22), E_Time = new DateTime(DateTime.Now.Year, month, 23) });

            month = 4;
            AllNameAndDate.Add(new NameAndDate() { CName = "愚人節推薦菜單", S_Time = new DateTime(DateTime.Now.Year, month, 1), E_Time = new DateTime(DateTime.Now.Year, month, 3) });
            AllNameAndDate.Add(new NameAndDate() { CName = "兒童節餐廚推薦", S_Time = new DateTime(DateTime.Now.Year, month, 4), E_Time = new DateTime(DateTime.Now.Year, month, 10) });
            AllNameAndDate.Add(new NameAndDate() { CName = "兒童節推薦菜單", S_Time = new DateTime(DateTime.Now.Year, month, 16), E_Time = new DateTime(DateTime.Now.Year, month, 20) });
            AllNameAndDate.Add(new NameAndDate() { CName = "清明節推薦菜單", S_Time = new DateTime(DateTime.Now.Year, month, 22), E_Time = new DateTime(DateTime.Now.Year, month, 23) });

            month = 5;
            AllNameAndDate.Add(new NameAndDate() { CName = "母親節推薦菜單", S_Time = new DateTime(DateTime.Now.Year, month, 1), E_Time = new DateTime(DateTime.Now.Year, month, 3) });
            AllNameAndDate.Add(new NameAndDate() { CName = "母親節鍋具促銷", S_Time = new DateTime(DateTime.Now.Year, month, 4), E_Time = new DateTime(DateTime.Now.Year, month, 10) });
            AllNameAndDate.Add(new NameAndDate() { CName = "母親節家電促銷", S_Time = new DateTime(DateTime.Now.Year, month, 16), E_Time = new DateTime(DateTime.Now.Year, month, 20) });
            AllNameAndDate.Add(new NameAndDate() { CName = "母親節餐廚促銷", S_Time = new DateTime(DateTime.Now.Year, month, 22), E_Time = new DateTime(DateTime.Now.Year, month, 23) });

            month = 6;
            AllNameAndDate.Add(new NameAndDate() { CName = "端午節推薦菜單", S_Time = new DateTime(DateTime.Now.Year, month, 1), E_Time = new DateTime(DateTime.Now.Year, month, 3) });
            AllNameAndDate.Add(new NameAndDate() { CName = "端午節推薦菜單2", S_Time = new DateTime(DateTime.Now.Year, month, 4), E_Time = new DateTime(DateTime.Now.Year, month, 10) });
            AllNameAndDate.Add(new NameAndDate() { CName = "六月家電促銷", S_Time = new DateTime(DateTime.Now.Year, month, 16), E_Time = new DateTime(DateTime.Now.Year, month, 20) });


            month = 7;
            AllNameAndDate.Add(new NameAndDate() { CName = "暑假推薦菜單_冰品", S_Time = new DateTime(DateTime.Now.Year, month, 1), E_Time = new DateTime(DateTime.Now.Year, month, 3) });
            AllNameAndDate.Add(new NameAndDate() { CName = "暑假推薦菜單_涼麵", S_Time = new DateTime(DateTime.Now.Year, month, 4), E_Time = new DateTime(DateTime.Now.Year, month, 10) });
            AllNameAndDate.Add(new NameAndDate() { CName = "暑假推薦菜單_飲料", S_Time = new DateTime(DateTime.Now.Year, month, 16), E_Time = new DateTime(DateTime.Now.Year, month, 20) });
            AllNameAndDate.Add(new NameAndDate() { CName = "暑假推薦菜單_涼拌菜", S_Time = new DateTime(DateTime.Now.Year, month, 22), E_Time = new DateTime(DateTime.Now.Year, month, 23) });

            month = 8;
            AllNameAndDate.Add(new NameAndDate() { CName = "父親節推薦菜單", S_Time = new DateTime(DateTime.Now.Year, month, 1), E_Time = new DateTime(DateTime.Now.Year, month, 3) });
            AllNameAndDate.Add(new NameAndDate() { CName = "七夕推薦菜單", S_Time = new DateTime(DateTime.Now.Year, month, 4), E_Time = new DateTime(DateTime.Now.Year, month, 10) });
            AllNameAndDate.Add(new NameAndDate() { CName = "八月家電促銷", S_Time = new DateTime(DateTime.Now.Year, month, 16), E_Time = new DateTime(DateTime.Now.Year, month, 20) });

            month = 9;
            AllNameAndDate.Add(new NameAndDate() { CName = "中秋節推薦菜單", S_Time = new DateTime(DateTime.Now.Year, month, 1), E_Time = new DateTime(DateTime.Now.Year, month, 3) });
            AllNameAndDate.Add(new NameAndDate() { CName = "九月家電促銷", S_Time = new DateTime(DateTime.Now.Year, month, 4), E_Time = new DateTime(DateTime.Now.Year, month, 10) });

            month = 10;
            AllNameAndDate.Add(new NameAndDate() { CName = "萬聖節推薦菜單_南瓜料理", S_Time = new DateTime(DateTime.Now.Year, month, 1), E_Time = new DateTime(DateTime.Now.Year, month, 3) });
            AllNameAndDate.Add(new NameAndDate() { CName = "萬聖節推薦菜單_甜點", S_Time = new DateTime(DateTime.Now.Year, month, 4), E_Time = new DateTime(DateTime.Now.Year, month, 10) });
            AllNameAndDate.Add(new NameAndDate() { CName = "八月家電促銷", S_Time = new DateTime(DateTime.Now.Year, month, 16), E_Time = new DateTime(DateTime.Now.Year, month, 20) });

            month = 11;
            AllNameAndDate.Add(new NameAndDate() { CName = "雙11鍋具促銷", S_Time = new DateTime(DateTime.Now.Year, month, 1), E_Time = new DateTime(DateTime.Now.Year, month, 3) });
            AllNameAndDate.Add(new NameAndDate() { CName = "雙11家電促銷", S_Time = new DateTime(DateTime.Now.Year, month, 4), E_Time = new DateTime(DateTime.Now.Year, month, 10) });
            AllNameAndDate.Add(new NameAndDate() { CName = "雙11餐廚促銷", S_Time = new DateTime(DateTime.Now.Year, month, 16), E_Time = new DateTime(DateTime.Now.Year, month, 20) });
            AllNameAndDate.Add(new NameAndDate() { CName = "雙11食器推薦", S_Time = new DateTime(DateTime.Now.Year, month, 22), E_Time = new DateTime(DateTime.Now.Year, month, 23) });

            month = 12;
            AllNameAndDate.Add(new NameAndDate() { CName = "聖誕節推薦菜單\r\n", S_Time = new DateTime(DateTime.Now.Year, month, 1), E_Time = new DateTime(DateTime.Now.Year, month, 3) });
            AllNameAndDate.Add(new NameAndDate() { CName = "聖誕節咖啡推薦", S_Time = new DateTime(DateTime.Now.Year, month, 4), E_Time = new DateTime(DateTime.Now.Year, month, 10) });
            AllNameAndDate.Add(new NameAndDate() { CName = "跨年推薦菜單", S_Time = new DateTime(DateTime.Now.Year, month, 16), E_Time = new DateTime(DateTime.Now.Year, month, 20) });

            #endregion

            
            List<CampaignDto> fakeData = new List<CampaignDto>();
            Random rand = new Random(Guid.NewGuid().GetHashCode());



            //用for迴圈產生dto
            for (int i=1; i <= 7; i++)
            { //第一層哪個版
                //第二層年
                for (int g = -3; g < 0; g++)
                {
                    var data = AllNameAndDate.Select(x => new CampaignDto()
                    {
                        CampaignName = x.CName,
                        CampaignPk = "C"+rand.Next(100001,999999).ToString(),
                        AdImg = "https://i.imgur.com/tnlH7su.jpg",
                        AdSpacePk = i,
                        StartTime = x.S_Time.AddYears(g).ToString(),
                        EndTime = x.E_Time.AddYears(g).ToString(),
                        URL = "https://google.com",
                    });
                    fakeData.AddRange(data);

                }
            }

            return fakeData;
            
        }
        public class NameAndDate
        {
            public string CName { get; set; }
            public DateTime S_Time { get; set; }
            public DateTime E_Time { get; set; }

        }

    }
}
