using ConsoleApp1.Interfaces;
using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Services
{
    class ManagementServices : IManagementServices
    {
        List<Product> _products;

        public List<Product> Products => _products;

        public ManagementServices()
        {
            _products = new List<Product>();
        }

        public void RegisterProduct(string productName, double productPrice, int productCount)
        {
            Product product = new Product(productName, productCount, productPrice);
            _products.Add(product);
            Console.WriteLine("Product created successfully");
        }

        public void ShowAllProducts()
        {
            if (_products.Count == 0)
            {
                Console.WriteLine("There is no product here yet");
            }
            else
            {
                foreach (Product product in _products)
                {
                    Console.WriteLine(product.ToString());
                }
            }
        }

        public Product FindProduct(string name)
        {
            foreach (Product product in _products)
            {
                if (name.ToUpper().Trim() == product.Name.ToUpper().Trim())
                {
                    return product;
                }
            }
            return null;
        }
    }
}
