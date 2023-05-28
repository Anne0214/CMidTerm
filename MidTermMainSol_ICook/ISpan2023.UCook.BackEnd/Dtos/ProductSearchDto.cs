using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan2023.UCook.BackEnd.Dtos
{
    public class ProductSearchDto
    {
        //從資料庫拿的資料，用於查詢介面
        public string Spu { get; set; }
        public string ProductName { get; set; }
        public string OnShelf { get; set; }
        public int SalePrice { get; set; }
        public string Category { get; set; }
        public string AllSku { get; set; }
        public int StockNumber { get; set; } //從sku資料算的庫存數
        public int SoldNumber { get; set; }//從sku資料算的售出數

    }
}
