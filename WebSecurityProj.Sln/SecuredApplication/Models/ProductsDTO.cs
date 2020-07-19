using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecuredApplication.Models
{
    public class ProductsDTO
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string ManufacturerName { get; set; }
        public string Price { get; set; }
        public bool IsAvailable { get; set; }
        public bool IsActive { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
