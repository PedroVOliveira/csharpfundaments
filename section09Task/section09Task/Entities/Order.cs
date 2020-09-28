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
        public void AddItem(OrderItem item)
        {
            Items.Add(item);   
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }
    }
}
