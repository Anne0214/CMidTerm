using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan2023.UCook.BackEnd.Dtos
{
	public class MarketingDto
	{
		public int DateTime //日期區間
		{
			get; set;
		}

		public string Title //標題
		{
			get; set;
		}

		public string URL //超連結
		{
			get; set;
		}
		public int Impression //曝光數
		{
			get; set;
		}
		public int Click //點擊數
		{
			get; set;
		}
		public int CTR //點擊率
		{
			get; set;
		}
	}
}
