using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueDemo.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int OrderQUantity { get; set; }

        // constructors
        public Order(int orderId, int orderQuantity)
        {
            this.OrderId = orderId;
            this.OrderQUantity = orderQuantity;
        }

        // methods
        public void ProcessOrder()
        {
            Console.WriteLine($"Order #{OrderId} processed.");
        }
    }
}
