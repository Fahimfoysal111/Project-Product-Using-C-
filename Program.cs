using Project_Product.Factories;
using Project_Product.Repositories;
using Project_Product.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Product
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IProductRepository productRepository = new ProductRepository();
            IProductFactory productFactory = new ProductFactory();
            ProductService productService = new ProductService(productRepository, productFactory);

            AddCommands();
            bool isRunning = true;
            while (isRunning)
            {
                try
                {
                    var command = Console.ReadLine().ToLower();
                    if (command == "5")
                    {
                        Console.Clear();
                        AddCommands();
                    }
                    else if (command == "6")
                    {
                        isRunning = false;
                    }
                    else if (command == "2")
                    {
                        Console.WriteLine("Type 'a' to read one product or type 'all' to read all products");
                        command = Console.ReadLine();
                        if (command == "a")
                        {
                            Console.WriteLine("Type a product id");
                            var id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"Product Id is= {id}");
                            var product = productService.GetById(id);
                            if (product != null)
                            {
                                Console.WriteLine($"Product Name: {product.ProductName}\n Product Price: {product.Price}\nProduct Category: {product.Category}\n Product Description: {product.Description}\nProduct Quantity: {product.Quantity}\nProduct Rating: {product.Rating}");
                            }
                            else
                            {
                                Console.WriteLine("Product not found.");
                            }
                        }
                        else if (command == "all")
                        {
                           
                            Console.WriteLine("Reading all products");
                            foreach (var product in productService.GetAllProducts())
                            {
                                Console.WriteLine($"Product Name: {product.ProductName} Product Price: {product.Price}Product Category: {product.Category} Product Description: {product.Description}Product Quantity: {product.Quantity}Product Rating: {product.Rating}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("'" + command + "'" + " is not a valid command.");
                        }
                    }
                    else if (command == "1")
                    {
                        Console.WriteLine("Type a product id:");
                        var id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Product Id is: " + id);
                        Console.WriteLine("Type a product name:");
                        var name = Console.ReadLine();
                        Console.WriteLine("Product Name is: " + name);
                        Console.WriteLine("Type a product price:");
                        var price = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("Product Price is: " + price);
                        Console.WriteLine("Type a ProductCategory:");
                        var category = Console.ReadLine();
                        Console.WriteLine("ProductCategory is: " + category);
                        Console.WriteLine("Give Any Description:");
                        var description = Console.ReadLine();
                        Console.WriteLine("Description: " + description);
                        Console.WriteLine("Type Product Quantity:");
                        int quantity = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Product Quantity: " + quantity);
                        Console.WriteLine("Type Product Rating:");
                        int rating = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Rating is: " + rating);

                      
                        productService.AddProduct(id, name, price, description, quantity, category, rating);
                        Console.WriteLine("'" + name + "' as product, created successfully.");

                    }
                    else if (command == "3")
                    {
                        Console.WriteLine("Type a product id");
                        var id = Convert.ToInt32(Console.ReadLine());
                        var product = productService.GetById(id);
                        if (product != null)
                        {
                            Console.WriteLine("Reading a product");
                            Console.WriteLine($"Product Name: {product.ProductName} Product Price: {product.Price}Product Category: {product.Category} Product Description: {product.Description}Product Quantity: {product.Quantity}Product Rating: {product.Rating}");

                            Console.WriteLine("Type a product name");
                            var name = Console.ReadLine();
                            Console.WriteLine("Product Name is: " + name);
                            Console.WriteLine("Type a product price");
                            var price = Convert.ToDecimal(Console.ReadLine());
                            Console.WriteLine("Product Price is: " + price);
                            Console.WriteLine("Type a ProductCategory");
                            var category = Console.ReadLine();
                            Console.WriteLine("ProductCategory is: " + category);
                            Console.WriteLine("Give Any Description");
                            var description = Console.ReadLine();
                            Console.WriteLine("Description: " + description);
                            Console.WriteLine("Type Product Quantity");
                            int quantity = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Product Quantity: " + quantity);
                            Console.WriteLine("Type Product Rating:");
                            int rating = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Rating is: " + rating);
                           
                            productService.UpdateProduct(id, name, price, description, quantity, category, rating);
                            Console.WriteLine("'" + name + "' as product, updated successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Product not found.");
                        }
                    }
                    else if (command == "4")
                    {
                        Console.WriteLine("Type a product id");
                        var id = Convert.ToInt32(Console.ReadLine());
                        var product = productService.GetById(id);
                        if (product != null)
                        {
                            Console.WriteLine("Reading a product");
                            Console.WriteLine($"Product Name: {product.ProductName} Product Price: {product.Price}Product Category: {product.Category} Product Description: {product.Description}Product Quantity: {product.Quantity}Product Rating: {product.Rating}");

                           
                            productService.DeleteProduct(id);
                            Console.WriteLine("'" + product.ProductName + "' as product, deletd successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Product not found.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("'" + command + "'" + " is not a valid command.");
                    }
                }
                catch { }
            }
        }
        static void AddCommands()
        {
            Console.WriteLine("Press '1' for creation of product");
            Console.WriteLine("Press '2' for read a product");
            Console.WriteLine("Press '3' for update of product");
            Console.WriteLine("Press '4' for deletion of product");
            Console.WriteLine("Press '5' for clear window and '6' for exit");
            Console.WriteLine("-------------------------------------------");
        }
    }
}
