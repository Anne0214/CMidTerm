using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ISpan2023.UCook.BackEnd.Dtos
{
    public class OrderDto
    {
        public string orderId { get; set; }

        //0:待出貨, 1:待收貨, 2:已完成, 3:退貨/退款 
        public string orderStatus { get; set; }

        public int memberId { get; set; }

        public string totalPrice { get; set; }

        public string purchasedItems { get; set; }

        public string dateOfEstablishment { get; set; }

        public string deliveryMethod { get; set; }

        public string paymentMethod { get; set; }

        public string modify { get; set; }

        public string dateOfPayment { get; set; }

        public string dateOfDelivery { get; set; }

        public string dateOfReceive { get; set; }

        public string dateOfRefund { get; set; }

        public string nickname { get; set; }

        public int deliveryId { get; set; }

        public int sku { get; set; }

        public int amount { get; set; }

        public string receiverName { get; set; }

        public string receiverAddress { get; set; }

        public string tel { get; set; }

    }
}
