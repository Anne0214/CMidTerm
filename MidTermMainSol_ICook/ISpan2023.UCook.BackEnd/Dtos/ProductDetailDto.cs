using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan2023.UCook.BackEnd.Dtos
{
    public class ProductDetailDto
    {

        public string Cover { get; set; }
        public string Category { get; set; }
        public string Spu { get; set; }
        public string ProductName { get; set; }

        //0:待上架,1:上架中,2:封存
        public string OnShelf { get; set; }

        public int PurchasePrice { get; set; }
        public int TagPrice { get; set; }
        public int SalePrice { get; set; }
        public string ProductDescription { get; set; }
        public string FullProductDescription { get; set; }
    }
}
