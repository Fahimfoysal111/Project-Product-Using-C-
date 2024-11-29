using Project_Product.Factories;
using Project_Product.Models;
using Project_Product.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Product.Services
{
    public class ProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IProductFactory _productFactory;

        public ProductService(IProductRepository productRepository, IProductFactory productFactory)
        {
            _productRepository = productRepository;
            _productFactory = productFactory;
        }

        public void AddProduct(int id, string productname, decimal price, string description, int quantity, string category, int rating)
        {
            var product = _productFactory.CreateProduct(id, productname, price, description, quantity, category, rating);
            _productRepository.Add(product);
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _productRepository.GetAll();
        }

        public Product GetById(int id)
        {
            return _productRepository.GetById(id);
        }

        public void UpdateProduct(int id, string productname, decimal price, string description, int quantity, string category, int rating)
        {
            var product = _productFactory.UpdateProduct(id, productname, price, description, quantity, category, rating);
            _productRepository.Update(product);
        }

        public void DeleteProduct(int id)
        {
            _productRepository.Remove(id);
        }
    }
}
