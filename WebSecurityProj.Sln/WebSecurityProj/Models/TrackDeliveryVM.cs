using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSecurityProj.Models
{
    public class TrackDeliveryVM
    {
        public string WayBillNo { get; set; }
        public string SQLQuery { get; set; }

        public List<DeliveriesDTO> DeliveriesList { get; set; }

    }
}
