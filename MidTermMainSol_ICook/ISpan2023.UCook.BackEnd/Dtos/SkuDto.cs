using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan2023.UCook.BackEnd.Dtos
{
    public class SkuDto:IDto
    {
        public string Sku { get; set; }
        public string TypeName { get; set; }
        public int StockNumber { get; set; }
        public int SoldNumber { get; set; }
    }
}
