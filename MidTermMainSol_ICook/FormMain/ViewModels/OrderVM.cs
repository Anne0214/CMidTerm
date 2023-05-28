using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FormMain.ViewModels
{
    public class OrderVM
    {
        //0:信用卡一次付清, 1:ATM轉帳
        [Display(Name = "支付方式")]
        [Required(ErrorMessage = "{0}必填")]
        public string paymentMethod { get; set; }

        //0:宅配到府, 1:711取貨
        [Display(Name = "運送方式")]
        [Required(ErrorMessage = "{0}必填")]
        public string deliveryMethod { get; set; }

        [Display(Name = "收件人姓名")]
        [Required(ErrorMessage = "{0}必填")]
        public string receiverName { get; set; }

        [Display(Name = "收件人地址")]
        [Required(ErrorMessage = "{0}必填")]
        public string receiverAddress { get; set; }

        [Display(Name = "收件人電話")]
        [Required(ErrorMessage = "{0}必填")]
        public string tel { get; set; }

    }
}
