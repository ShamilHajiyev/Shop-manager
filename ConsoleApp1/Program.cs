using ConsoleApp1.Enums;
using ConsoleApp1.Services;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the program");
            bool exit = false;
            bool result;
            byte selection;

            do
            {
                MenuServices.ShowMenu();
            Input:
                Console.WriteLine("");
                result = byte.TryParse(Console.ReadLine(), out selection);
                Console.Clear();

                if (!result)
                {
                    MenuServices.ErrorMessage();
                    MenuServices.ShowMenu();
                    goto Input;
                }

                switch (selection)
                {
                    case (byte)Actions.Register:
                        MenuServices.RegisterMenu();
                        break;
                    case (byte)Actions.Sell:
                        MenuServices.SellMenu();
                        break;
                    case (byte)Actions.Account:
                        MenuServices.AccountMenu();
                        break;
                    case (byte)Actions.Exit:
                        exit = MenuServices.ExitMenu();
                        break;
                    default:
                        MenuServices.ErrorMessage();
                        break;
                }
            } while (!exit);
        }
    }
}
