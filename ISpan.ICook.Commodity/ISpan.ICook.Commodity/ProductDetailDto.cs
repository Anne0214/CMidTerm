using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.ICook.Commodity
{
	public class ProductDetailDto
	{
        //todo 商品圖還沒在資料庫
        public string cover { get; set; }
        public string category { get; set; }
		public string spu { get; set; }
		public string productName { get; set; }

		//0:待上架,1:上架中,2:封存
		public string onShelf { get; set; }
        
        public List<skuDto> skuList { get; set; }
		public int purchasePrice { get; set; }
		public int tagPrice { get; set; }
		public int salePrice { get; set; }
        public int stockNumber { get; set; }
        public int soldNumber { get; set; }
        public string ProductDescription { get; set; }
        public string fullProductDescription { get; set; }

    }
}
