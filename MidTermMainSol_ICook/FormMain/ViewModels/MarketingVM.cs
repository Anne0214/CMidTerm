using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FormMain.ViewModels
{
	public class MarketingVM
	{

		[Display(Name = "期間")]
		[Required(ErrorMessage = "{0}必填")]
		public DateTime datetime { get; set; }


		[Display(Name = "標題")]
		[Required(ErrorMessage = "{0}必填")]
		[MaxLength(20, ErrorMessage = "{0}長度不可大於{1}")]
		public string Title { get; set; }


		[Display(Name = "超連結")]
		[Required(ErrorMessage = "{0}必填")]
		[RegularExpression(@"^(http|https)://([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?$", ErrorMessage = "Invalid URL format")]
		public string URL { get; set; }


		[Display(Name = "曝光數")]
		public int Impression { get; set; }


		[Display(Name = "點擊數")]
		public int Click { get; set; }


		[Display(Name = "點擊率")]
		public int CTR { get; set; }
	}
}
