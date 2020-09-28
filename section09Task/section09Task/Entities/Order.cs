using System;
using section09Task.Entities.Enums;
using System.Collections.Generic;
using System.Text;


namespace section09Task.Entities
{
    class Order
    {
        public DateTime Date { get; set; } = DateTime.Now;
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        
        public Order()
        {

        }

        public Order(OrderStatus status)
        {
            Status = status;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);   
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double sum = 0;
            foreach(OrderItem item in Items)
            {
                sum += item.SubTotal();
            }

            return sum;
        }
    }
}
