using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.ICook.Commodity
{
	public class ProductSearchDto
	{
        public string spu { get; set; }
        public string productName { get; set; }
        public string onShelf { get; set; }
        public int salePrice { get; set; }
        public string category { get; set; }
        public string skuList { get; set; }
        public int stockNumber { get; set; }

    }
}
