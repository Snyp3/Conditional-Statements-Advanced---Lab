using System;

namespace P12.TradeCommissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sells = double.Parse(Console.ReadLine());

            double comm = -1.0;

            if (city == "Sofia")
            {
                if (sells >= 0 && sells <= 500)
                {
                    comm = 0.05;
                }
                else if (sells >= 500 && sells <= 1000)
                {
                    comm = 0.07;
                }
                else if (sells >= 1000 && sells <= 10000)
                {
                    comm = 0.08;
                }
                else if (sells > 10000)
                {
                    comm = 0.12;
                }
            }

            else if (city == "Varna")
            {
                if (sells >= 0 && sells <= 500)
                {
                    comm = 0.045;
                }
                else if (sells >= 500 && sells <= 1000)
                {
                    comm = 0.075;
                }
                else if (sells >= 1000 && sells <= 10000)
                {
                    comm = 0.1;
                }
                else if (sells > 10000)
                {
                    comm = 0.13;
                }

            }
            else if (city == "Plovdiv")
            {
                if (sells >= 0 && sells <= 500)
                {
                    comm = 0.055;
                }
                else if (sells >= 500 && sells <= 1000)
                {
                    comm = 0.08;
                }
                else if (sells >= 1000 && sells <= 10000)
                {
                    comm = 0.12;
                }
                else if (sells > 10000)
                {
                    comm = 0.145; ;
                }

            }
                if (comm >= 0)
                {
                    Console.WriteLine("{0:f2}", sells * comm);
                }
                else
                {
                    Console.WriteLine("error");

                }
            
            

        }
    }
}
