using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.ICook.Commodity
{
	public class ProductSearchVM
	{ 
        public string Spu { get; set; }
        public string ProductName { get; set; }
        public int OnShelf { get; set; }
        public int SalePrice { get; set; }
        public string Category { get; set; }
        public string SkuString { get; set; } //從sku資料拼出的string
        public int StockNumber { get; set; } //從sku資料算的庫存數
        public int SoldNumber { get; set; }//從sku資料算的售出數
    }
}
