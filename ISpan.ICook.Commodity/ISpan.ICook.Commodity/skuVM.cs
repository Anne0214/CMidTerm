using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.ICook.Commodity
{
	public class skuVM
	{
		[Display(Name = "sku")]
		[Required(ErrorMessage = "{0}為必填")]
		public string sku { get; set; }

		[Display(Name = "型號名稱")]
		[Required(ErrorMessage ="{0}為必填")]
		public string typeName { get; set; }

		[Display(Name ="庫存數量")]
		[Required(ErrorMessage = "{0}為必填")]
		public int stockNumber { get; set; }
	}
}
