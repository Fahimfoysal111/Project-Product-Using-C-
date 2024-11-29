using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Product.Models
{
    public  class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public string Category { get; set; }
        public int Rating { get; set; }

        public Product(int id, string productname, decimal price, string description, int quantity, string category, int rating)
        {
            ProductId = id;
            ProductName = productname;
            Price = price;
            Description = description;
            Quantity = quantity;
            Category = category;
            Rating = rating;
        }
    }
}
