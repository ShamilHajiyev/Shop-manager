using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Services
{
    static class MenuServices
    {
        public static ManagementServices Manager;

        static MenuServices()
        {
            Manager = new ManagementServices();
        }

        public static void ShowMenu()
        {
            Console.WriteLine("\n1 - Register products");
            Console.WriteLine("2 - Sell products");
            Console.WriteLine("3 - Account");
            Console.WriteLine("0 - Exit");
        }
        public static void ErrorMessage()
        {
            Console.WriteLine("Something went wrong:(");
        }

        public static void RegisterMenu()
        {
        NameInput:
            Console.WriteLine("Enter product name:\n");
            string productName = Console.ReadLine();
            if (!NameCondition(productName))
            {
                goto NameInput;
            }
            Console.Clear();
        PriceInput:
            Console.WriteLine("Enter price:\n");
            double productPrice;
            bool priceResult = double.TryParse(Console.ReadLine(), out productPrice);
            if (!priceResult)
            {
                goto PriceInput;
            }
            Console.Clear();
        CountInput:
            Console.WriteLine("Enter count:\n");
            int productCount;
            bool countResult = int.TryParse(Console.ReadLine(), out productCount);
            if (!countResult)
            {
                goto CountInput;
            }
            Console.Clear();

            Manager.RegisterProduct(Capitalize(productName), productPrice, productCount);
        }

        public static void SellMenu()
        {
            Console.WriteLine("Not ready");
        }

        public static void AccountMenu()
        {
            Manager.ShowAllProducts();
        }

        public static bool ExitMenu()
        {
            Console.WriteLine("Press 0 again to quit program\n");
            string confirmation = Console.ReadLine();
            Console.Clear();
            if (confirmation == "0")
            {
                Console.WriteLine("Bye:)");
                return true;
            }
            else
            {
                Console.WriteLine("Welcome back:)");
                return false;
            }
        }

        public static string Capitalize(string word)
        {
            word = word.ToLower().Trim();
            if (word.Length > 1)
            {
                return char.ToUpper(word[0]) + word.Substring(1);
            }
            else
            {
                return Convert.ToString(char.ToUpper(word[0]));
            }
        }

        public static bool NameCondition(string name)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name))
            {
                return false;
            }

            foreach (char item in name)
            {
                if (!char.IsLetter(item))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
