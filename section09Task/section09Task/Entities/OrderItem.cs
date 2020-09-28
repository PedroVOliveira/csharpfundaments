using System;
using System.Collections.Generic;
using System.Text;

namespace section09Task.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public int Price { get; set; }

        public double SubTotal()
        {
            return Quantity * Price;
        }
    }
}
