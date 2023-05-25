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
        public List<LogDto> logDtos;
        public List<CampaignDto> campaignDtos;
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
                campaignDtos = new CampaignDtoRepository().BuildFakeData();
                dataGridView1.DataSource = campaignDtos;
            }
            catch(Exception ex)
            {
                MessageBox.Show($"無法成功產生資料，原因:{ex.Message}");
            }
            //資料作為dataGridView的資料來源


        }

        private void btnDb_Click(object sender, EventArgs e)
        {
            //var conn=ISpan2023.EStore.SqlDataLayer.SqlDb.GetConnection();
            //if (conn != null) MessageBox.Show("成功連線資料庫");
            //try
            //{
            //    //執行寫入

                var repo = new CampaignDtoRepository();

                foreach (var dto in campaignDtos)
                {
                    repo.Create(dto);
                    
                }

                MessageBox.Show("成功輸入");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"輸入資料庫失敗，因為{ex.Message}");
            //}

        }

        private void btnShowImpression_Click(object sender, EventArgs e)
        {//近一個月的，每60~300秒一次觀看，每300秒~2000秒一個點擊
			logDtos = new LogRepository().CreateLogDto(60,300);

            dataGridView2.DataSource = logDtos;
        }

        private void btnShowClick_Click(object sender, EventArgs e)
        {
			//近一個月的，每60~300秒一次觀看，每300秒~2000秒一個點擊
			logDtos = new LogRepository().CreateLogDto(300,2000);

            dataGridView3.DataSource = logDtos;
        }

		private void button1_Click(object sender, EventArgs e)
		{
			var repo = new LogRepository();

			foreach (var dto in logDtos)
			{
				repo.CreateImpression(dto);

			}

			MessageBox.Show("成功輸入");
		}

		private void button2_Click(object sender, EventArgs e)
		{
			var repo = new LogRepository();

			foreach (var dto in logDtos)
			{
				repo.CreateClick(dto);

			}

			MessageBox.Show("成功輸入");
		}
	}
}
