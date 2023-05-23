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

		 
		[Display(Name ="首圖")]
		[Required(ErrorMessage ="{0}必填")]
		public string Cover { get; set; }

		[Display(Name = "商品分類")]
		[Required(ErrorMessage = "{0}必填")]
		public string Category { get; set; }

		[Display(Name = "SPU")]
		public string Spu { get; set; }

		[Display(Name = "商品名稱")]
		[Required(ErrorMessage = "{0}必填")]
		[MaxLength(20,ErrorMessage ="字數需在20字內")]
		public string ProductName { get; set; }


		//0:待上架,1:上架中,2:封存
		[Display(Name = "上架狀態")]
		[Required(ErrorMessage = "{0}必填")]
		public int OnShelf { get; set; }

		[Display(Name = "商品規格")]
		[Required(ErrorMessage = "{0}必填")]
		public List<skuDto> SkuList { get; set; }

		[Display(Name = "採購價")]
		[Required(ErrorMessage = "{0}必填")]
		public int PurchasePrice { get; set; }

		[Display(Name = "吊牌價")]
		[Required(ErrorMessage = "{0}必填")]
		public int TagPrice { get; set; }

		[Display(Name = "銷售價")]
		[Required(ErrorMessage = "{0}必填")]
		public int SalePrice { get; set; }

		[Display(Name = "簡短說明")]
		[Required(ErrorMessage = "{0}必填")]
		[MaxLength(200,ErrorMessage ="{0}長度需在200以下")]
		public string ProductDescription { get; set; }

		[Display(Name = "完整說明")]
		[Required(ErrorMessage = "{0}必填")]
		public string FullProductDescription { get; set; }
	}
}
