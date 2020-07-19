using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSecurityProj.Models
{
    public class DeliveriesDTO
    {
        public string DeliveryId { get; set; }
        public int WayBillNo { get; set; }

        public string ProductId { get; set; }
        public string FromAddress { get; set; }
        public string ToAddress { get; set; }
        public string ReceiverName { get; set; }
        public string Phone { get; set; }
        public string PinCode { get; set; }
        public string PanCardNo { get; set; }
        public bool IsDelivered { get; set; }
        public bool IsActive { get; set; }
        public string CreatedDate { get; set; }
        public string CurrentLocation { get; set; }
    }
}
