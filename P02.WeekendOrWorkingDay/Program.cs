﻿using System;

namespace P02.WeekendOrWorkingDay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string workingDay = Console.ReadLine();

            switch (workingDay) 
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    Console.WriteLine("Working day");
                        break;
                case "Saturday":
                case "Sunday":
                    Console.WriteLine("Weekend");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
        }
    }
}