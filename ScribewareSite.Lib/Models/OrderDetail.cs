using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScribewareSite.Lib.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public Order? OrderData { get; set; }
        public int ProductId { get; set; }
        public Product? ProductData { get; set; }
        public int Quantity { get; set; }
        public decimal? FinalPrice { get; set; }
    }
}
