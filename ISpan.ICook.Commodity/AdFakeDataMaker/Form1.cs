using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AdFakeDataMaker
{
    public partial class FormMain : Form
    {
        private List<CampaignDto> data { get; set; }
        private List<string> tables =
            new List<string>{
                "AD_SPACE_CLICK_LOG_廣告版面點擊紀錄",
                "AD_SPACE_IMPRESSION_LOG_廣告版面曝光紀錄",
                "CAMPAIGN_廣告活動"};

        public FormMain()
        {
            InitializeComponent();
        }

        private void btnShowCampaign_Click(object sender, EventArgs e)
        {
            //用方法產出假資料 var data
            try
            {
                data = new CampaignDtoRepository().BuildFakeData();
                dataGridView1.DataSource = data;
            }
            catch(Exception ex)
            {
                MessageBox.Show($"無法成功產生資料，原因:{ex.Message}");
            }
            //資料作為dataGridView的資料來源


        }

        private void btnDb_Click(object sender, EventArgs e)
        {
            try
            {
                //執行寫入
                //ISpan2023.EStore.SqlDataLayer.SqlDb.Create();
                var repo = new CampaignDtoRepository();
                int rows = 0;
                foreach (var dto in data)
                {
                    int row = repo.Create(dto);
                    rows += row;
                }

                MessageBox.Show($"成功輸入{rows}");
            }catch(Exception ex){
                MessageBox.Show($"輸入資料庫失敗，因為{ex.Message}");
            }
            
        }

        private void btnShowImpression_Click(object sender, EventArgs e)
        {//近一個月的，每60~300秒一次觀看，每300秒~2000秒一個點擊
            var data = new LogRepository().CreateLogDto(60,300);

            dataGridView1.DataSource = data;
        }

        private void btnShowClick_Click(object sender, EventArgs e)
        {
            //近一個月的，每60~300秒一次觀看，每300秒~2000秒一個點擊
            var data = new LogRepository().CreateLogDto(300,2000);

            dataGridView1.DataSource = data;
        }
    }
}
