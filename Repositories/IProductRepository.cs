using Project_Product.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Product.Repositories
{
    public interface IProductRepository
    {
        void Add(Product product);
        Product GetById(int id);
        IEnumerable<Product> GetAll();
        void Update(Product product);
        void Remove(int id);
    }
}
