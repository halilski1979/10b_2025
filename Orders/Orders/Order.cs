using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders
{
    public class Order
    {
        public Order(string clientName, string productName, int quantity, double price)
        {
            this.ClientName = clientName;
            this.ProductName = productName;
            this.Quantity = quantity;
            this.Price = price;
        }

        public string ClientName { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double TotalPrice()
        {
            return Quantity * Price;
        }
        public override string ToString()
        {
            return $"Client: {ClientName}, Product: {ProductName}, Price: {Price:f2}, Quantity:{Quantity}, Total price: {TotalPrice():f2}";
        }
    }
}
