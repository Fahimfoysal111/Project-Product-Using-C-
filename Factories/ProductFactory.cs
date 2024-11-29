using Project_Product.Models;
using Project_Product.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Product.Factories
{
    public class ProductFactory : IProductFactory
    {
        public Product CreateProduct(int id, string productname, decimal price, string description, int quantity, string category, int rating)
        {
            return new Product(id, productname, price, description, quantity, category, rating);
        }
        public Product UpdateProduct(int id, string productname, decimal price, string description, int quantity, string category, int rating)
        {
            return new Product(id, productname, price, description, quantity, category, rating);
        }
    }
}
