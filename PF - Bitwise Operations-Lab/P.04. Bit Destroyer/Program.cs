﻿using System;

namespace P._04._Bit_Destroyer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());

            int mask = ~(1 << position);
            int result = (number & mask);
            Console.WriteLine(result);
        }
    }
}
