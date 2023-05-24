using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdFakeDataMaker
{
    public class CampaignDto
    {
        public  string CampaignPk { get; set; }

        public string CampaignName { get; set; }
        
        public string URL { get; set; }

        public string AdImg { get; set; }

        public int AdSpacePk { get; set; }

        public string StartTime { get; set; }

        public string EndTime { get; set; }
    }
}
