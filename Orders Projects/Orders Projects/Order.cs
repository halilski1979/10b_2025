using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders_Projects
{
    public class Order
    {
		private string clientName;
		private string productName;
		private int quantity;
		private double price;
		public double CatculateTotal()
		{
			return Price*Quantity;
		}
        public Order(string clientName, string productName, int quantity, double price)
        {
            this.ClientName = clientName;
            this.ProductName = productName;
            this.Quantity = quantity;
            this.Price = price;
        }
        public double Price
		{
			get { return price; }
			set 
			{
				if (value<0)
				{
					throw new ArgumentException("Price can not be 0 or negative");
				}
				price = value; 
			}
		}
		public int Quantity
		{
			get { return quantity; }
			set { quantity = value; }
		}
		public string ProductName
		{
			get { return productName; }
			set 
			{
				if (string.IsNullOrEmpty(value))
				{
					throw new ArgumentException("Name of the product can not be empty");
				}
				productName = value; }
		}
		public string ClientName
		{
			get { return clientName; }
			set 
			{
				if (string.IsNullOrEmpty(value))
				{
					throw new ArgumentException("Name client can not be empty string!");
				}
				clientName = value; 
			}
		}
        public override string ToString()
        {
            return $"{ClientName} {ProductName} {Quantity} - {Price:f2}. Total: {CatculateTotal():f2} ";
        }

    }
}
