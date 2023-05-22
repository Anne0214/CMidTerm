using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.ICook.Commodity
{
	public class ProductDetailVm
	{

		//todo 商品圖還沒在資料庫
		 
		[Display(Name ="首圖")]
		[Required(ErrorMessage ="{0}必填")]
		public string cover { get; set; }

		[Display(Name = "商品分類")]
		[Required(ErrorMessage = "{0}必填")]
		public string category { get; set; }

		[Display(Name = "SPU")]
		public string spu { get; set; }

		[Display(Name = "商品名稱")]
		[Required(ErrorMessage = "{0}必填")]
		[MaxLength(20,ErrorMessage ="字數需在20字內")]
		public string productName { get; set; }


		//0:待上架,1:上架中,2:封存
		[Display(Name = "上架狀態")]
		[Required(ErrorMessage = "{0}必填")]
		public string onShelf { get; set; }

		[Display(Name = "商品規格")]
		[Required(ErrorMessage = "{0}必填")]
		public List<skuDto> skuList { get; set; }

		[Display(Name = "採購價")]
		[Required(ErrorMessage = "{0}必填")]
		public int purchasePrice { get; set; }

		[Display(Name = "吊牌價")]
		[Required(ErrorMessage = "{0}必填")]
		public int tagPrice { get; set; }

		[Display(Name = "銷售價")]
		[Required(ErrorMessage = "{0}必填")]
		public int salePrice { get; set; }

		//[Display(Name = "庫存數量")]
		//public int stockNumber { get; set; }

		[Display(Name = "售出數量")]
		public int soldNumber { get; set; }

		[Display(Name = "簡短說明")]
		[Required(ErrorMessage = "{0}必填")]
		public string ProductDescription { get; set; }

		[Display(Name = "完整說明")]
		[Required(ErrorMessage = "{0}必填")]
		public string fullProductDescription { get; set; }
	}
}
