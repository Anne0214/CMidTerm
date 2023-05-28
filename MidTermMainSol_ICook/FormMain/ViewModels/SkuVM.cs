using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FormMain.ViewModels
{
    public class SkuVM
    {
        [Display(Name = "sku")]
        public string Sku { get; set; }

        [Display(Name = "型號名稱")]
        [Required(ErrorMessage = "{0}為必填")]
        public string TypeName { get; set; }

        [Display(Name = "庫存數量")]
        [Required(ErrorMessage = "{0}為必填")]
        public int StockNumber { get; set; }

        [Display(Name = "售出數量")]
        public int SoldNumber { get; set; }
    }
}
