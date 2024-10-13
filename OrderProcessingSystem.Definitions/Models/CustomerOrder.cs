using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingSystem.Definitions.Models
{
    public class CustomerOrder
    {
        public Guid OrderId { get; set; }
        public int CarId { get; set; }
        public int Quantity { get; set; }
    }
}
