using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.ViewModels
{
    public class CategoryCreateVM
    {
        [Display(Name = "編號")]

        public int Id { get; set; }

        [Display(Name = "分類名稱")]
        [Required(ErrorMessage = "{0}必填")]
        [MaxLength(30, ErrorMessage = "{0}長度不可大於{1}")]
        public string Name { get; set; }

        [Display(Name = "顯示順序")]
        [Required(ErrorMessage = "顯示順序必填")]
        [Range(10, 1000, ErrorMessage ="{0} 的值, 必需介於{1} ~ {2} 之間")]
		public int DisplayOrder { get; set; }
    }
}
