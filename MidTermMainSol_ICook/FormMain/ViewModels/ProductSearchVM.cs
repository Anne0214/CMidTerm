using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormMain.ViewModels
{
    public class ProductSearchVM
    { //todo待修正
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
