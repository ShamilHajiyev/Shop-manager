using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Interfaces
{
    interface IManagementServices
    {
        List<Product> Products { get; }

        void RegisterProduct(string productName, double productPrice, int productCount);

        void ShowAllProducts();

        Product FindProduct(string name);
    }
}
