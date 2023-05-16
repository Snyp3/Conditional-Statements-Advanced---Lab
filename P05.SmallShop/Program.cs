using System;

namespace P05.SmallShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string produckt = Console.ReadLine();
            string town = Console.ReadLine();  
            double quantity = double.Parse(Console.ReadLine());

            double productPrice = 0;

            if (town == "Sofia") 
            {
                if (produckt == "coffee")
                {
                    productPrice = 0.5;
                }
                else if (produckt == "water")
                {
                    productPrice = 0.8;
                }
                else if (produckt == "beer")
                {
                    productPrice = 1.2;
                }
                else if (produckt == "sweets")
                {
                    productPrice = 1.45;
                }
                else if (produckt == "peanuts")
                {
                    productPrice = 1.60;
                }

                
            }
            else if (town == "Plovdiv")
            {
                if (produckt == "coffee")
                {
                    productPrice = 0.4;
                }
                else if (produckt == "water")
                {
                    productPrice = 0.7;
                }
                else if (produckt == "beer")
                {
                    productPrice = 1.15;
                }
                else if (produckt == "sweets")
                {
                    productPrice = 1.3;
                }
                else if (produckt == "peanuts")
                {
                    productPrice = 1.5;
                }
            }
            else if (town == "Varna")
            {
                if (produckt == "coffee")
                {
                    productPrice = 0.45;
                }
                else if (produckt == "water")
                {
                    productPrice = 0.7;
                }
                else if (produckt == "beer")
                {
                    productPrice = 1.1;
                }
                else if (produckt == "sweets")
                {
                    productPrice = 1.35;
                }
                else if (produckt == "peanuts")
                {
                    productPrice = 1.55;
                }
            }

            double totalPrice = productPrice * quantity;
            Console.WriteLine(totalPrice);
            
        }
    }
}
