using Project_Product.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Product.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly List<Product> _products = new List<Product>();

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public Product GetById(int id)
        {
            return _products.FirstOrDefault(p => p.ProductId == id);
        }

        public IEnumerable<Product> GetAll()
        {
            return _products;
        }

        public void Update(Product product)
        {
            var _product = _products.FirstOrDefault(p => p.ProductId == product.ProductId);
            if (_product != null)
            {
                _product.ProductName = product.ProductName;
                _product.Price = product.Price;
                _product.Description = product.Description;
                _product.Category = product.Category;
                _product.Quantity = product.Quantity;
                _product.Rating = product.Rating;
            }
        }

        public void Remove(int id)
        {
            var product = _products.FirstOrDefault(p => p.ProductId == id);
            if (product != null)
            {
                _products.Remove(product);
            }
        }
      }
    }  
