using System;
using System.ComponentModel.Design;

namespace P07.Working2Hours
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int time = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();


            if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday" || day == "Saturday")
            {
                if (time >= 10 && time <= 18)
                {
                    Console.WriteLine("open");
                }
                else if (day == "Sunday")
                {
                    Console.WriteLine("closed");
                }
                else
                {
                    Console.WriteLine("closed");
                }
            }
            else
            {
                Console.WriteLine("closed");
            }
        }
    }
}
