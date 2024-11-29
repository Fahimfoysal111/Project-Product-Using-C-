using Project_Product.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Product.Factories
{
    public  interface IProductFactory
    {
        Product CreateProduct(int id, string productname, decimal price, string description, int quantity, string category, int rating);
        Product UpdateProduct(int id, string productname, decimal price, string description, int quantity, string category, int rating);
    }
}
