﻿using System;

namespace P._01._Day_of_Week
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            if (n >= 1 && n <= 7)
            {
                Console.WriteLine(days[n-1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }

        }
    }
}
