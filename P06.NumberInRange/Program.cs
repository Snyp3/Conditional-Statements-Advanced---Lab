using System;

namespace P06.NumberInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());  // тая стана 
            if (num >= -100 && num != 0 && num <= 100)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}
