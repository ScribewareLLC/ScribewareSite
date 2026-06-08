using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScribewareSite.Lib.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public Customer? CustomerData { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
